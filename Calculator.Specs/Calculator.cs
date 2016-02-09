using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Specs
{
    public class Calculator
    {
        private readonly Stack<int> operands = new Stack<int>();

        public int Result
        {
            get { return operands.Peek(); }
        }

        public void Enter(int operand)
        {
            operands.Push(operand);
        }

        public void Add()
        {
            operands.Push(operands.Pop() + operands.Pop());
        }
    }
}
