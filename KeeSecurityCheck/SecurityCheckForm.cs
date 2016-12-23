using KeePass.Plugins;
using KeePassLib;
using KeePassLib.Collections;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace KeeSecurityCheck
{
    public partial class SecurityCheckForm : Form
    {
        private IPluginHost m_host = null;

        public SecurityCheckForm(IPluginHost host)
        {
            InitializeComponent();
            m_host = host;
        }

        private void runCheckButton_Click(object sender, EventArgs e)
        {
            var checkDups = checkDuplicates.Checked;
            var checkLen = checkLength.Checked;
            var lenToCheck = Convert.ToInt32(lengthToCheckInput.Value);
            var checkComp = checkComplexity.Checked;
            var comp = (PasswordScore)complexitySlider.Value;

            if (!checkDups && !checkLen && !checkComp)
            {
                MessageBox.Show("You must select at least one criteria to check.", "Error");
                return;
            }

            runCheckButton.Enabled = false;
            checkDuplicates.Enabled = false;
            checkLength.Enabled = false;
            lengthToCheckInput.Enabled = false;
            checkComplexity.Enabled = false;
            complexitySlider.Enabled = false;

            try
            {
                this.statusLabel.Text = "Starting Check...";
                PwDatabase pwdb = m_host.Database;

                if (!pwdb.IsOpen)
                {
                    statusLabel.Text = "Please open database first...";
                    return;
                }

                PwObjectList<PwEntry> entries = pwdb.RootGroup.GetEntries(true);

                if (entries != null)
                {
                    statusLabel.Text = "Database opened, " + entries.UCount + " entries to check...";
                }
                else
                {
                    statusLabel.Text = "No entries in Database.";
                    return;
                }

                //Used to check for Duplicate Passwords
                Dictionary<string, List<string>> results = new Dictionary<string, List<string>>(entries.Count<PwEntry>());
                //Used to check password length
                List<string> shortPasses = new List<string>();
                //Used to check password complexity
                List<string> simplePasses = new List<string>();

                foreach (var entry in entries)
                {
                    string pass = entry.Strings.Get(PwDefs.PasswordField).ReadString();
                    if (pass.Equals(""))
                    {
                        continue;
                    }
                    if (checkDups)
                    {
                        if (results.ContainsKey(pass))
                        {
                            results[pass].Add(entry.Strings.Get(PwDefs.TitleField).ReadString());
                        }
                        else
                        {
                            List<string> list = new List<string>();
                            var xx = entry.Strings.Get(PwDefs.TitleField);
                            if (xx != null)
                            {
                                list.Add(xx.ReadString());
                            }
                            else
                            {
                                var urlxx = entry.Strings.Get(PwDefs.UrlField);
                                if (urlxx != null)
                                {
                                    list.Add(urlxx.ReadString());
                                }
                                else
                                {
                                    list.Add(entry.ToString());
                                }
                            }
                            results.Add(pass, list);
                        }
                    }
                    if (checkLen)
                    {
                        if (pass.Length < lenToCheck)
                        {
                            shortPasses.Add(entry.Strings.Get(PwDefs.TitleField).ReadString() + " (" + pass.Length + ")");
                        }
                    }

                    if (checkComp)
                    {
                        var tcomp = PasswordAdvisor.CheckStrength(pass);
                        if (tcomp < comp)
                        {
                            simplePasses.Add(entry.Strings.Get(PwDefs.TitleField).ReadString() + " (" + Enum.GetName(typeof(PasswordScore), tcomp) + ")");
                        }
                    }
                }

                checkResultsView.BeginUpdate();

                TreeNodeCollection nodes = checkResultsView.Nodes;

                checkResultsView.Nodes.Clear();

                if (checkDups)
                {
                    int dupPass = 1;
                    foreach (KeyValuePair<string, List<string>> result in results)
                    {
                        if (result.Value.Count > 1)
                        {
                            List<TreeNode> children = new List<TreeNode>();
                            foreach (var title in result.Value)
                            {
                                children.Add(new TreeNode(title));
                            }
                            TreeNode node = new TreeNode(string.Format("Duplicated Password [{0}] ({1})", result.Key, children.Count), children.ToArray());
                            nodes.Add(node);
                            dupPass++;
                        }
                    }
                }

                if (checkLen)
                {
                    if (shortPasses.Count > 0)
                    {
                        List<TreeNode> children = new List<TreeNode>();
                        foreach (var title in shortPasses)
                        {
                            children.Add(new TreeNode(title));
                        }
                        TreeNode node = new TreeNode("Short Passwords", children.ToArray());
                        nodes.Add(node);
                    }
                }

                if (checkComp)
                {
                    if (simplePasses.Count > 0)
                    {
                        List<TreeNode> children = new List<TreeNode>();
                        foreach (var title in simplePasses)
                        {
                            children.Add(new TreeNode(title));
                        }
                        TreeNode node = new TreeNode("Simple Passwords", children.ToArray());
                        nodes.Add(node);
                    }
                }

                checkResultsView.EndUpdate();

                statusLabel.Text = "Check complete.";
            }
            catch (NullReferenceException nre)
            {
                MessageBox.Show(string.Format("I tried to read a null value.\n{0}", nre.StackTrace));
                throw;
            }
            runCheckButton.Enabled = true;
            checkDuplicates.Enabled = true;
            checkLength.Enabled = true;
            lengthToCheckInput.Enabled = true;
            checkComplexity.Enabled = true;
            complexitySlider.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var about = new AboutBox();
            about.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var check = new ComplexityForm();
            check.ShowDialog();
        }
    }
}