using ownTournamentExtensionInterfaces.Sport.SportExtension;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Korfball
{
    class KorfballExtensionInformation : ISportExtensionInformation
    {
        public string Sport
        {
            get
            {
                return Localisation.strings.sport;
            }
        }

        public string extensionName
        {
            get
            {
                //Console.WriteLine($"(LOCAL: extensionName = {Localisation.strings.extensionName} in {Thread.CurrentThread.CurrentUICulture.Name})");
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

        public string linkToLicense
        {
            get
            {
                return "https://opensource.org/licenses/MIT";
            }
        }

        private string readEmbeddedFile(string filename)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "Korfball." + filename;
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
