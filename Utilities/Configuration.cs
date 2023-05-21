using Microsoft.Extensions.Configuration;

namespace DummyWebSiteTests.Utilities
{
    /// <summary>
    /// Configuration class to get information  from appsettings.json
    /// </summary>
    public static class Configuration
    {
        public static IConfigurationRoot? ConfigurationSettings { get; set; }
        public static string Url => ConfigurationSettings.GetConnectionString($"url");
        public static string User => ConfigurationSettings.GetConnectionString($"user");
        public static string Password => ConfigurationSettings.GetConnectionString($"password");
        public static string Browser => ConfigurationSettings.GetConnectionString($"browser");


        /// <summary>
        /// Setup the configuration to  get the app settings from appsettings.json
        /// </summary>
        public static void SetupConfigFile()
        {
            // Build and combine the configuration file
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", true, true);
            ConfigurationSettings = builder.Build();

        }
    }
}
