using SyntaxAnalyzer.Models;
using SyntaxAnalyzer.Models.SyntaxItems;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SyntaxAnalyzer
{
    public abstract class SyntaxAnalyzerBase
    {
        protected class SyntaxAnalyzerTable : Dictionary<NonTerminalSyntaxItem, IDictionary<TerminalSyntaxItem, IList<SyntaxItemBase>>>
        {
            public void Add(NonTerminalSyntaxItem row, TerminalSyntaxItem column, params SyntaxItemBase[] replacedWith)
            {
                if (!this.ContainsKey(row))
                {
                    this.Add(row, new Dictionary<TerminalSyntaxItem, IList<SyntaxItemBase>>());
                }

                this[row].Add(column, replacedWith);
            }
        }

        public List<string> Parse(IList<LexemBase> lexems)
        {
            var log = new List<string>();

            var syntaxItemStack = new Stack<SyntaxItemBase>();
            syntaxItemStack.Push(FinalSyntaxItem);
            syntaxItemStack.Push(RootSyntaxItem);

            int codePointer = 0;

            while (syntaxItemStack.Count != 0)
            {
                var currentSyntaxItem = syntaxItemStack.Peek();

                if (codePointer == lexems.Count && currentSyntaxItem.IsEnd)
                {
                    break;
                }

                if (currentSyntaxItem.IsTerminal)
                {
                    if (currentSyntaxItem.Lexem.Token == lexems[codePointer].Token)
                    {
                        syntaxItemStack.Pop();
                        ++codePointer;
                    }
                    else
                    {
                        throw new Exception($"Incorrect syntax near {currentSyntaxItem.Name} at {codePointer}");
                    }

                    log.Add($"stack: {string.Join(", ", syntaxItemStack)}");
                }
                else
                {
                    var currentNonTerminal = currentSyntaxItem as NonTerminalSyntaxItem;
                    if (Table.TryGetValue(currentNonTerminal, out var possibleChildren))
                    {
                        IList<SyntaxItemBase> children = null;

                        if (codePointer == lexems.Count)
                        {
                            children = possibleChildren[FinalSyntaxItem];
                        }
                        else
                        {
                            var predictedChild = possibleChildren.FirstOrDefault(child => child.Key.Lexem.Token == lexems[codePointer].Token);

                            if (predictedChild.Key == null)
                            {
                                throw new Exception($"Incorrect syntax near {currentSyntaxItem.Name} at {codePointer}");
                            }

                            children = predictedChild.Value;
                        }

                        syntaxItemStack.Pop();
                        foreach (var syntaxItem in children.Reverse())
                        {
                            syntaxItemStack.Push(syntaxItem);
                        }

                        log.Add($"stack: {string.Join(", ", syntaxItemStack)}");
                    }
                }
            }

            return log;
        }

        protected abstract SyntaxItemBase RootSyntaxItem { get; }
        protected abstract TerminalSyntaxItem FinalSyntaxItem { get; }
        protected abstract SyntaxAnalyzerTable Table { get; }
    }
}
