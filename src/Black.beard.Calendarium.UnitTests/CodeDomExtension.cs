using Microsoft.CSharp;
using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.IO;
using System.Text;

namespace Bb.Calendarium.UnitTests
{
    public static class CodeDomExtension
    {


        public static CodeSnippetExpression AsSnippet(this object self)
        {
            var v = self.ToString();

            if (self.GetType().IsEnum)
                v = self.GetType().Name + "." + v;

            return new CodeSnippetExpression(v);
        }

        public static CodePrimitiveExpression AsPrimitive(this bool self)
        {
            return new CodePrimitiveExpression(self);
        }

        public static CodePrimitiveExpression AsPrimitive(this object self)
        {
            return new CodePrimitiveExpression(self);
        }

        public static CodeVariableDeclarationStatement Declare(this CodeTypeReference self, string name, CodeExpression initExpression = null)
        {
            if (initExpression == null)
                return new CodeVariableDeclarationStatement(self, name);
            return new CodeVariableDeclarationStatement(self, name, initExpression);
        }

        public static CodeObjectCreateExpression New(this CodeTypeReference self, params CodeExpression[] parameters)
        {
            return new CodeObjectCreateExpression(self, parameters);
        }

        public static CodeTypeReference Type(this Type self)
        {
            return new CodeTypeReference(self);
        }

        public static CodeMemberMethod Return(this CodeMemberMethod self, CodeExpression value)
        {
            self.Statements.Add(new CodeMethodReturnStatement(value));
            return self;
        }

        public static CodeMethodReferenceExpression Method(this CodeExpression instance, string methodName)
        {
            var method = new CodeMethodReferenceExpression(instance, methodName);
            return method;
        }

        public static CodeMethodInvokeExpression Call(this CodeMethodReferenceExpression self, params CodeExpression[] args)
        {
            var r = new CodeMethodInvokeExpression(self, args);
            return r;
        }

        public static CodeVariableReferenceExpression VariableRef(this string self)
        {
            return new CodeVariableReferenceExpression(self);
        }

        public static CodePropertyReferenceExpression Property(this CodeExpression instance, string propertyName)
        {
            return new CodePropertyReferenceExpression(instance, propertyName);
        }

        public static CodeMemberMethod SetProperty(this CodeMemberMethod self, CodeExpression instance, string propertyName, CodeExpression value)
        {

            self.Statements.Add(new CodeAssignStatement(new CodePropertyReferenceExpression(instance, propertyName), value));

            return self;
        }


        public static void Save(this StringBuilder self, string filename)
        {

            if (File.Exists(filename))
                File.Delete(filename);

            File.AppendAllText(filename, self.ToString());

        }

        public static StringBuilder GenerateCode(this CodeNamespace self)
        {
            CodeCompileUnit unit = new CodeCompileUnit();
            unit.Namespaces.Add(self);

            CSharpCodeProvider provider = new CSharpCodeProvider();

            MemoryStream mem = new MemoryStream();

            using (StreamWriter sw = new StreamWriter(mem, System.Text.Encoding.UTF8))
            {
                IndentedTextWriter tw = new IndentedTextWriter(sw, "    ");

                // Generate source code using the code provider.
                provider.GenerateCodeFromCompileUnit(unit, tw, new CodeGeneratorOptions());

                // Close the output file.
                tw.Close();
            }

            var sb = new StringBuilder(System.Text.Encoding.UTF8.GetString(mem.ToArray()));

            return sb;

        }


    }
}
