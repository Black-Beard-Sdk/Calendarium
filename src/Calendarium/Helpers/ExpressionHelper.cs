using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

namespace Bb.Helpers
{

    internal static class ExpressionHelper
    {

        public static MemberExpression Member(this Expression self, PropertyInfo property)
        {
            return Expression.Property(self, property);
        }

        public static BinaryExpression CreateObject(this Expression self)
        {
            return self.SettedBy(Expression.New(self.Type));
        }

        public static UnaryExpression As(this Expression self, Type type)
        {
            return Expression.ConvertChecked(self, type);
        }

        public static BinaryExpression SettedBy(this Expression self, Expression right)
        {
            return Expression.Assign(self, right);
        }

        public static MethodCallExpression Invoke(this Expression self, MethodInfo method, params Expression[] args)
        {

            if (args.Length == 0)
                return Expression.Call(self, method);
            else
                return Expression.Call(self, method, args);

        }

    }

}
