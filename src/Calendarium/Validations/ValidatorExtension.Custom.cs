using Bb.Helpers;
using Microsoft.Extensions.CommandLineUtils;
using System.Linq;

namespace Bb.Validations
{
    public static partial class ValidatorExtension
    {


        public static int EvaluateCountryName(CommandArgument command)
        {

            if (string.IsNullOrWhiteSpace(command.Value))
                return 0;

            var country = command.Value.ToLower();
            var _country = Helper.Parameters.Countries.FirstOrDefault(c => c.Name.ToLower() == country);

            if (_country == null)
                return Error(string.Format("country {0} is missing in package nuget on '{1}'", command.Value, Constants.urlNuget));

            return 0;

        }

       

    }


}
