using myTournamentExtensionInterfaces.SportExtension;
using System;
using System.IO;
using System.Reflection;

namespace Korfbal
{
    class KorfbalExtensionInformation : ISportExtensionInformation
    {
        public string extensionName
        {
            get
            {
                return Localisation.strings.extensionName;
            }
        }

        public Version extensionVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version;
            }
        }

        public string extensionDevelopers
        {
            get
            {
                // Get the developers from the Contributors file and return it
                return readEmbeddedFile("CONTRIBUTORS");
            }
        }

        public string appropriateLicenseShort
        {
            get
            {
                return "MIT License";
            }
        }

        public string appropriateLicenseLong
        {
            get
            {
                // Get the developers from the Contributors file and return it
                return readEmbeddedFile("LICENSE");
            }
        }

        private string readEmbeddedFile(string filename)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "Korfbal." + filename;
            string result;

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                result = reader.ReadToEnd();
            }
            return result;
        }
    }
}
