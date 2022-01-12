using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Advanced_Combat_Tracker;

namespace appplbot_EventTracker
{
    public partial class eventtracker : UserControl, IActPluginV1
    {
		Label lblStatus;
		public ui eventTrackerForm;

		public eventtracker()
        {
            InitializeComponent();
        }
		public void InitPlugin(TabPage pluginScreenSpace, Label pluginStatusText)
		{
			lblStatus = pluginStatusText;   // Hand the status label's reference to our local var
			pluginScreenSpace.Controls.Add(this);   // Add this UserControl to the tab ACT provides
			this.Dock = DockStyle.Fill; // Expand the UserControl to fill the tab's client space

			ActGlobals.oFormActMain.OnCombatStart += new CombatToggleEventDelegate(oFormActMain_OnCombatStart);
			//ActGlobals.oFormActMain.OnCombatEnd += new CombatToggleEventDelegate(oFormActMain_OnCombatEnd);

			eventTrackerForm = new ui();
			eventTrackerForm.Show();
			lblStatus.Text = "Plugin Started";
		}
		public void DeInitPlugin()
		{
			try
			{
				ActGlobals.oFormActMain.OnCombatStart -= oFormActMain_OnCombatStart;
			}
			catch (Exception ex)
			{
				lblStatus.Text = ex.Message;
			}
			eventTrackerForm.Close();
			lblStatus.Text = "Plugin Exited";
		}
		void oFormActMain_OnCombatStart(bool isImport, CombatToggleEventArgs encounterInfo)
		{
			//reset the form
			return;
		}
	}
}
