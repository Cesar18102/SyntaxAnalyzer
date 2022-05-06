using SyntaxAnalyzer.LexicalAnalysis.Exceptions;
using SyntaxAnalyzer.LexicalAnalysis.Scanners;
using SyntaxAnalyzer.Models;
using System.Collections.Generic;
using System.Linq;

namespace SyntaxAnalyzer.LexicalAnalysis
{
    public abstract class LexicalAnalyzerBase
    {
        protected abstract IList<ScannerBase> Scanners { get; }

        public IList<LexemBase> ParseToLexems(string text)
        {
            var lexems = new List<LexemBase>();
            var textPointer = 0;

            while(textPointer < text.Length)
            {
                bool someMatchFound = false;

                foreach (var scanner in Scanners)
                {
                    var match = scanner.Specification.Match(text, textPointer);
                    
                    if(match.Success && match.Index == textPointer)
                    {
                        var lexem = scanner.MatchHandler(match);

                        if(lexem == null)
                        {
                            continue;
                        }

                        lexems.Add(lexem);
                        textPointer += match.Length;
                        someMatchFound = true;

                        break;
                    }
                }

                if(!someMatchFound)
                {
                    var analyzedText = text.Substring(0, textPointer + 1);
                    var line = analyzedText.Count(symbol => symbol == '\n');
                    var col = textPointer - analyzedText.LastIndexOf('\n');
                    throw new LexicalAnalysisException(line, col);
                }
            }

            return lexems;
        }
    }
}
