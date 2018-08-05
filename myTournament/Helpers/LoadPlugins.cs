using myTournamentExtensionInterfaces.SportExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTournament.Helpers
{
    class LoadPlugins
    {
        public LoadPlugins()
        {
            ICollection<ISportExtensionInformation> _sportExtensionInformation = GenericPluginLoader<ISportExtensionInformation>.LoadPlugins("Plugins");
            if (_sportExtensionInformation != null)
            {
                foreach (var item in _sportExtensionInformation)
                {
                    Console.WriteLine($"Plugin loaded!\n\n{Localisation.strings.extensionName}: {item.extensionName}\n{Localisation.strings.extensionVersion}: {item.extensionVersion.ToString()}\n{Localisation.strings.extensionDeveloper}: {item.extensionDevelopers}\n{Localisation.strings.extensionAppropriateLicenseShort}: {item.appropriateLicenseShort}\n\n{item.appropriateLicenseLong}");
                }
            }
        }
    }
}
