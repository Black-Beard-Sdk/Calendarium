using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Schema.Generation;
using System;
using System.Text;

namespace Bb.Calendarium.Configuration
{

    internal static class SchemaHelper
    {

        /// <summary>
        /// Generates JSON schema for a given C# class using Newtonsoft.Json.Schema library.
        /// </summary>
        /// <param name="myType">class type</param>
        /// <returns>a string containing JSON schema for a given class type</returns>
        public static StringBuilder GenerateSchemaForClass(Type myType)
        {
            JSchemaGenerator generator = new JSchemaGenerator()
            {
                SchemaIdGenerationHandling = SchemaIdGenerationHandling.AssemblyQualifiedName,
                SchemaLocationHandling = SchemaLocationHandling.Definitions,
                DefaultRequired = Newtonsoft.Json.Required.Default,
            };

            generator.GenerationProviders.Add(new StringEnumGenerationProvider());
            
            JSchema schema = generator.Generate(myType, false);
            schema.SchemaVersion = new Uri("http://json-schema.org/draft-04/schema");
            return new StringBuilder(schema.ToString());
        }

    }
}
