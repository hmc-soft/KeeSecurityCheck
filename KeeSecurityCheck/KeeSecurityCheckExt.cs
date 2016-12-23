using KeePass.Plugins;
using KeePassLib;
using KeePassLib.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeeSecurityCheck
{
    public sealed class KeeSecurityCheckExt : Plugin, IDisposable
    {
        private IPluginHost m_host = null;
        private ToolStripSeparator m_sep = null;
        private ToolStripMenuItem m_menuItem = null;
        private SecurityCheckForm m_form = null;
        private ToolStripMenuItem m_integ = null;

        public override bool Initialize(IPluginHost host)
        {
            m_host = host;
            ToolStripItemCollection tsmenu = m_host.MainWindow.ToolsMenu.DropDownItems;

            m_sep = new ToolStripSeparator();
            tsmenu.Add(m_sep);

            //Add our menu item
            m_menuItem = new ToolStripMenuItem("Security Check...");
            m_menuItem.Click += this.showSecurityCheckDialog;
            tsmenu.Add(m_menuItem);

            m_integ = new ToolStripMenuItem("Integrity Check");
            m_integ.Click += this.IntegrityCheck;
            tsmenu.Add(m_integ);

            return true;
        }

        public void IntegrityCheck(object sender, EventArgs e)
        {
            PwDatabase pwdb = m_host.Database;
            PwObjectList<PwEntry> entries = pwdb.RootGroup.GetEntries(true);
            List<PwUuid> existing = new List<PwUuid>();
            List<PwEntry> duplicates = new List<PwEntry>();
            foreach (PwEntry item in entries)
            {
                if (existing.Contains(item.Uuid))
                {
                    duplicates.Add(item);
                }
                else
                {
                    existing.Add(item.Uuid);
                }
            }
            m_host.MainWindow.SetStatusEx(string.Format("Found {0} duplicate ids", duplicates.Count));
        }

        public void showSecurityCheckDialog(object sender, EventArgs e)
        {
            if (m_form == null)
            {
                m_form = new SecurityCheckForm(m_host);
            }
            m_form.Show();
            return;
        }

        public override void Terminate()
        {
            ToolStripItemCollection tsmenu = m_host.MainWindow.ToolsMenu.DropDownItems;
            m_menuItem.Click -= this.showSecurityCheckDialog;
            tsmenu.Remove(m_sep);
            tsmenu.Remove(m_menuItem);
            tsmenu.Remove(m_integ);
            return;
        }

        public void Dispose()
        {
            m_form.Dispose();
            m_menuItem.Dispose();
            m_sep.Dispose();
            m_integ.Dispose();
        }
    }
}