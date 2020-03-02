using System;
using System.Collections.Generic;
using System.Text;

namespace Dataworks.Model
{
    class balanced
    {
        Stack<char> stack = new Stack<char>();
        bool structureWrong = false;
        public void CheckBracket(string s)
        {
            foreach (char bracket in s)
            {
                if (bracket == '(' || bracket == '{' || bracket == '[')
                    stack.Push(bracket);
                switch (bracket)
                {
                    case ')':
                        CheckBackBracket('(');
                        break;
                    case '}':
                        CheckBackBracket('{');
                        break;
                    case ']':
                        CheckBackBracket('[');
                        break;
                }
                   
            }
            if (structureWrong || !stack.IsEmpty)
            {
                Console.WriteLine("Скобочная структура неверна");
            }
            else Console.WriteLine("Скобочная структура верна");
        }
        private void CheckBackBracket(char c)
        {
            if (!stack.IsEmpty)
                if (stack.Peek() == c)
                    stack.Pop();
                else structureWrong = true;
            else structureWrong = true;
        }
    }
}
