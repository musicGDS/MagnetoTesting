using System.IO;
using Microsoft.Extensions.Configuration;

namespace MagnetoTesting
{
    public static class ConfigurationReader
    {
        public static IConfiguration Configuration;
        

        static ConfigurationReader()
        {
            
            var configurationBuilder = new ConfigurationBuilder()
    .AddJsonFile(Path.Combine("appsettings.json"))
    .AddEnvironmentVariables();
            Configuration = configurationBuilder.Build();
        }

        public static string GetValue(string section, string key)
        {
            var config = Configuration.GetSection("Config");
            string result = config.GetSection(section).GetSection(key).Value;
            return result;
        }
        
    }
}


