using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ownTournament.AboutForm;
using ownTournament.Generic;
using ownTournament.Helpers;
using ownTournamentExtensionInterfaces.Sport.SportExtension;

namespace ownTournament
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Plugins.LoadAllPlugins();
            ISportExtensionInformation item;
            foreach (var _item in SportExtension<ISportExtensionInformation>._plugins)
            {
                item = (ISportExtensionInformation)_item.Value;
                Console.WriteLine($"Plugin loaded!\n\n{Localisation.strings.extensionName}: {item.extensionName}\n{Localisation.strings.extensionVersion}: {item.extensionVersion.ToString()}\n{Localisation.strings.extensionDeveloper}: {item.extensionDevelopers}\n{Localisation.strings.extensionAppropriateLicenseShort}: {item.appropriateLicenseShort}\n\n{item.appropriateLicenseLong}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
    }
}
