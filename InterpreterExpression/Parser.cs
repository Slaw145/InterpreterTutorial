using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    class Parser
    {
        private List<Expression> parseTree = new List<Expression>();

        public Parser(string s)
        {
            foreach (string token in s.Split(' '))
            {
                if (token.Equals("+"))
                {
                    parseTree.Add(new TerminalExpression_Plus());
                }
                else if (token.Equals("-"))
                {
                    parseTree.Add(new TerminalExpression_Minus());
                }
                else
                {
                    parseTree.Add(new TerminalExpression_Number(Int32.Parse(token)));
                }
            }
        }

        public int evaluate()
        {
            Stack<int> context = new Stack<int>();

            foreach (Expression e in parseTree)
            {
                e.interpret(context);
            }

            return context.Pop();
        }
    }
}
