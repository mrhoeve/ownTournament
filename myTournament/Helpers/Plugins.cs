using myTournament.Generic;
using myTournamentExtensionInterfaces.Sport;
using myTournamentExtensionInterfaces.Sport.SportExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTournament.Helpers
{
    public static class Plugins
    {
        private static bool pluginsLoaded = false;

        public static void LoadAllPlugins()
        {
            if (pluginsLoaded == false)
            {
                // Load the plugins
                loadSportExtensionInformation();

                // Set pluginsLoaded to true to prevent reloading
                pluginsLoaded = true;
            }
        }

        private static void loadSportExtensionInformation()
        {
            SportExtension<ISportExtensionInformation>.loadType();
        }
    }
}
