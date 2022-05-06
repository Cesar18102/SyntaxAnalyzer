using SyntaxAnalyzer.LexicalAnalysis;
using SyntaxAnalyzer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SyntaxAnalyzer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            IList<LexemBase> lexems = null;

            Log.AppendText("Lexical analysis:\n");
            try
            {
                var lexicalAnalyzer = new LexicalAnalyzer();
                lexems = lexicalAnalyzer.ParseToLexems(CodeInput.Text);
                Log.AppendText(string.Join("; ", lexems.Select(l => l.Token)) + ";\n");
            }
            catch(Exception ex)
            {
                Log.AppendText($"{ex.Message}\n");
            }

            Log.AppendText("Syntax analysis:\n");
            try
            {
                var syntaxAnalyzer = new SyntaxAnalysis.SyntaxAnalyzer();
                var log = syntaxAnalyzer.Parse(lexems);
                Log.AppendText(string.Join("\n", log) + "\n");
            }
            catch (Exception ex)
            {
                Log.AppendText($"{ex.Message}\n");
            }
        }
    }
}
