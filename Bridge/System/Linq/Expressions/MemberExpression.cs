using Bridge;
using System.Reflection;

namespace System.Linq.Expressions
{
    [External]
    [Name("Object")]
    [Cast("{this}.ntype === 23")]
    public sealed class MemberExpression : Expression
    {
        [FieldProperty]
        public extern MemberInfo Member { get; private set; }

        [FieldProperty]
        public extern Expression Expression { get; private set; }

        internal extern MemberExpression();
    }
}