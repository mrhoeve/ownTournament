using ownTournament.Generic;
using ownTournament.Helpers.AboutFormHelper;
using ownTournamentExtensionInterfaces.Sport.SportExtension;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ownTournament.AboutForm
{
    partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            this.Text = String.Format("About {0}", AssemblyTitle);
            this.labelProductName.Text = AssemblyProduct;
            this.labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
            this.labelCopyright.Text = AssemblyCopyright;
            this.labelCompanyName.Text = AssemblyCompany;

            this.tableLayoutSoftware.Controls.Add(new AboutFormHelper("Generic plugin loader", "Copyright 2013 Christoph Gattnar", "Apache 2.0", "http://www.apache.org/licenses/LICENSE-2.0"));
            this.tableLayoutSoftware.Controls.Add(new AboutFormHelper("Generic plugin loader", "Copyright 2013 Christoph Gattnar", "Apache 2.0", "http://www.apache.org/licenses/LICENSE-2.0"));
            this.tableLayoutSoftware.Controls.Add(new AboutFormHelper("Generic plugin loader", "Copyright 2013 Christoph Gattnar", "Apache 2.0", "http://www.apache.org/licenses/LICENSE-2.0"));

            ISportExtensionInformation item;
            foreach (var _item in SportExtension<ISportExtensionInformation>._plugins)
            {
                item = (ISportExtensionInformation)_item.Value;
                this.tableLayoutSoftware.Controls.Add(new AboutFormHelper(item.extensionName, item.extensionDevelopers, item.appropriateLicenseShort, item.linkToLicense));
                //Console.WriteLine($"Plugin loaded!\n\n{Localisation.strings.extensionName}: {item.extensionName}\n{Localisation.strings.extensionVersion}: {item.extensionVersion.ToString()}\n{Localisation.strings.extensionDeveloper}: {item.extensionDevelopers}\n{Localisation.strings.extensionAppropriateLicenseShort}: {item.appropriateLicenseShort}\n\n{item.appropriateLicenseLong}");
            }


        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion
    }
}
