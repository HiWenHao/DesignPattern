using System;

namespace DesignPattern.InterpreterPattern
{
    public interface IExpression
    {
        bool Interpret(string context);
    }

    public class TerminalExpression : IExpression
    {
        private string _data;

        public TerminalExpression(string data)
        {
            this._data = data;
        }

        public bool Interpret(string context)
        {
            if (context.Contains(_data))
            {
                return true;
            }
            return false;
        }
    }

    public class OrExpression : IExpression
    {
        private IExpression _expr1 = null;
        private IExpression _expr2 = null;

        public OrExpression(IExpression expression1, IExpression expression2)
        {
            this._expr1 = expression1;
            this._expr2 = expression2;
        }

        public bool Interpret(string context)
        {
            return _expr1.Interpret(context) || _expr2.Interpret(context);
        }
    }

    public class AndExpression : IExpression
    {
        private IExpression _expr1 = null;
        private IExpression _expr2 = null;

        public AndExpression(IExpression expression1, IExpression expression2)
        {
            this._expr1 = expression1;
            this._expr2 = expression2;
        }

        public bool Interpret(string context)
        {
            return _expr1.Interpret(context) && _expr2.Interpret(context);
        }
    }

    public class InterpreterPatternDemo
    {
        public static IExpression GetMaleExpression()
        {
            IExpression robert = new TerminalExpression("Robert");
            IExpression john = new TerminalExpression("John");
            return new OrExpression(robert, john);
        }

        public static IExpression GetMarriedWomanExpression()
        {
            IExpression julie = new TerminalExpression("Julie");
            IExpression married = new TerminalExpression("Married");
            return new AndExpression(julie, married);
        }

        public static void Execute()
        {
            IExpression isMale = GetMaleExpression();
            Console.WriteLine($"John is male? {isMale.Interpret("John")}");

            IExpression isMarriedWoman = GetMarriedWomanExpression();
            Console.WriteLine($"Julie is a married women? {isMarriedWoman.Interpret("Married Julie")}");
        }
    }
}
