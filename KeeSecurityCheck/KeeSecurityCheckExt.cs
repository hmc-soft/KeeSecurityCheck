﻿using KeePass.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeeSecurityCheck
{
    public sealed class KeeSecurityCheckExt : Plugin
    {
        private IPluginHost m_host = null;
        private ToolStripSeparator m_sep = null;
        private ToolStripMenuItem m_menuItem = null;

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

            return true;
        }

        public void showSecurityCheckDialog(object sender, EventArgs e)
        {
            return;
        }

        public override void Terminate()
        {
            ToolStripItemCollection tsmenu = m_host.MainWindow.ToolsMenu.DropDownItems;
            m_menuItem.Click -= this.showSecurityCheckDialog;
            tsmenu.Remove(m_sep);
            tsmenu.Remove(m_menuItem);
            return;
        }
    }
}
