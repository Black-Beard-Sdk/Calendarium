using Bb.Helpers;
using Microsoft.Extensions.CommandLineUtils;
using System;
using System.IO;

namespace Bb.Validations
{
    public static partial class ValidatorExtension
    {

        public static int EvaluateFileExist(CommandOption option)
        {

            if (option.HasValue())
            {
                FileInfo file = new FileInfo(option.Value());
                if (!file.Exists)
                    return Error($"file '{file.FullName}' not found");
            }

            return 0;

        }

        public static int EvaluateFileExist(CommandArgument option)
        {

            if (!string.IsNullOrEmpty(option.Value))
            {
                var file = option.Value.GetFilename();
                if (!file.Exists)
                    return Error($"file '{file.FullName}' not found");
            }

            return Error($"Missing filename");

        }

        private static FileInfo GetFilename(this string self)
        {
            FileInfo file = new FileInfo(self);
            return file;
        }

        //public static int EvaluateName(CommandArgument command)
        //{

        //    if (command.Value.Contains('.'))
        //        return Error("name {0} can't contains '.' character", command);

        //    return 0;

        //}

        public static int EvaluateRequired(CommandArgument command)
        {

            if (string.IsNullOrWhiteSpace(command.Value))
                return Error("{0} must be specified", command);

            return 0;

        }

        public static int EvaluateInteger(CommandArgument command)
        {

            var value = command.Value;

            if (!int.TryParse(value, out int result))
                return 1;

            return 0;

        }

        public static int EvaluateLong(CommandArgument command)
        {

            var value = command.Value;

            if (!long.TryParse(value, out long result))
                return 1;

            return 0;

        }

        public static int EvaluateShort(CommandArgument command)
        {

            var value = command.Value;

            if (!short.TryParse(value, out short result))
                return 1;

            return 0;

        }

        public static void Stop()
        {
            System.Diagnostics.Debugger.Launch();
            System.Diagnostics.Debugger.Break();
        }

        public static int Error(string message)
        {
            Output.ErrorWriteLine();
            Output.ErrorWriteLine(message);
            return 1;
        }

        public static int Error(string message, CommandArgument arg)
        {
            Output.ErrorWriteLine();
            Output.ErrorWriteLine(message, arg.Name);
            return 1;
        }

        public static int Error(string message, CommandOption arg)
        {
            Output.ErrorWriteLine();
            Output.ErrorWriteLine(message, arg.Template);



            return 1;
        }

        internal static bool CheckToken()
        {

            if (string.IsNullOrEmpty(Helper.Parameters.Token))
                return false;

            return DateTime.Now < Helper.Parameters.TokenExpiration;

        }

    }

}
