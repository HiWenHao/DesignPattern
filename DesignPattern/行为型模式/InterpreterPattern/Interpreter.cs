namespace DesignPattern.InterpreterPattern
{
    /// <summary>
    /// 解释器接口
    /// </summary>
    public interface Interpreter
    {
        /// <summary>
        /// 解释器
        /// </summary>
        /// <param name="context">具体内容</param>
        /// <returns></returns>
        bool Interpret(string context);
    }

    /// <summary>
    /// 解释具体内容是否存在该元素中
    /// </summary>
    public class CheckContentsExistence : Interpreter
    {
        private string m_data;

        public CheckContentsExistence(string data)
        {
            this.m_data = data;
        }

        public bool Interpret(string context)
        {
            if (context.Contains(m_data))
            {
                return true;
            }
            return false;
        }
    }

    /// <summary>
    /// 或运算
    /// </summary>
    public class OrExpression : Interpreter
    {
        private Interpreter m_expr1 = null;
        private Interpreter m_expr2 = null;

        public OrExpression(Interpreter expression1, Interpreter expression2)
        {
            this.m_expr1 = expression1;
            this.m_expr2 = expression2;
        }

        public bool Interpret(string context)
        {
            return m_expr1.Interpret(context) || m_expr2.Interpret(context);
        }
    }

    /// <summary>
    /// 和运算
    /// </summary>
    public class AndExpression : Interpreter
    {
        private Interpreter m_expr1 = null;
        private Interpreter m_expr2 = null;

        public AndExpression(Interpreter expression1, Interpreter expression2)
        {
            this.m_expr1 = expression1;
            this.m_expr2 = expression2;
        }

        public bool Interpret(string context)
        {
            return m_expr1.Interpret(context) && m_expr2.Interpret(context);
        }
    }
}
