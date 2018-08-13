using ownTournament.Helpers;
using ownTournamentExtensionInterfaces.Sport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ownTournament.Generic
{
    class SportExtension<T> where T : ISport
    {
        public static Dictionary<string, T> _plugins = new Dictionary<string, T>();

        public static void loadType()
        {
            ICollection<T> _sportExtensionInformation = GenericPluginLoader<T>.LoadPlugins("Plugins");
            // Did we get any results?
            if (_sportExtensionInformation != null)
            {
                foreach (T _isei in _sportExtensionInformation)
                {
                    if (!_plugins.ContainsKey(_isei.Sport))
                    {
                        _plugins.Add(_isei.Sport, _isei);
                    }
                }
            }
        }
    }
}
