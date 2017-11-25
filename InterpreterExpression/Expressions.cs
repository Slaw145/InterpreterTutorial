using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    interface Expression
    {
        void interpret(Stack<int> s);
    }

    class TerminalExpression_Number : Expression
    {
        private int number;

        public TerminalExpression_Number(int number)
        {
            this.number = number;

        }
        public void interpret(Stack<int> s)
        {
            s.Push(number);
        }
    }

    class TerminalExpression_Plus : Expression
    {
        public void interpret(Stack<int> s)
        {
            s.Push(s.Pop() + s.Pop());
        }
    }
 
    class TerminalExpression_Minus : Expression
    {
        public void interpret(Stack<int> s)
        {
            s.Push(-s.Pop() + s.Pop());
        }
    }
}

    

