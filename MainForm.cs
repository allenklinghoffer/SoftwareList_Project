using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class MainForm : Form
    {
        Dictionary<string, string> All = new Dictionary<string, string>();
        Dictionary<string, string> DicDB = new Dictionary<string, string>();
        string hostname = Environment.MachineName;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> File32 = new Dictionary<string, string>();
            Dictionary<string, string> File64 = new Dictionary<string, string>();
            Dictionary<string, string> DN32 = new Dictionary<string, string>();
            Dictionary<string, string> DN64 = new Dictionary<string, string>();

            object line1;
            object line2;
            object line3;
            object line4;

            try
            {
                string registry_key = @"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall";
                using (var baseKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32))
                {
                    using (var key = baseKey.OpenSubKey(registry_key))
                    {
                        foreach (string subkey_name in key.GetSubKeyNames())
                        {
                            using (var subKey = key.OpenSubKey(subkey_name))
                            {
                                line1 = subKey.GetValue("DisplayName");
                                line2 = subKey.GetValue("DisplayVersion");
                                try
                                {
                                    if (line1 != null && line2 != null)
                                    {
                                        if (!File32.ContainsKey(line1.ToString()))
                                            File32.Add(line1.ToString(), line2.ToString());
                                    }
                                }
                                catch (Exception)
                                {

                                }
                            }
                        }
                    }
                }
                string uninstallkey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
                using (var baseKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
                {
                    using (var key = baseKey.OpenSubKey(uninstallkey))
                    {
                        foreach (string subkey_name in key.GetSubKeyNames())
                        {
                            using (var subKey = key.OpenSubKey(subkey_name))
                            {
                                line3 = subKey.GetValue("DisplayName");
                                line4 = subKey.GetValue("DisplayVersion");

                                try
                                {
                                    if (line3 != null && line4 != null)
                                    {
                                        if (!File64.ContainsKey(line3.ToString()))
                                            File64.Add(line3.ToString(), line4.ToString());
                                    }
                                }
                                catch (Exception)
                                {

                                }
                            }
                        }
                    }
                }
                //3264-bit合併至fall(有重複)
                Dictionary<string, string> fall = new Dictionary<string, string>();
                fall = fall.Union(File32).ToDictionary(i => i.Key, i => i.Value);
                foreach (KeyValuePair<string, string> kvp in File64)
                {
                    string value;
                    if (!fall.TryGetValue(kvp.Key, out value))
                    {
                        fall.Add(kvp.Key, kvp.Value);
                    }
                    else
                        fall[kvp.Key] = kvp.Value;

                }

                //32對64-bit做資料比對 無重複儲存至 DN32
                var diff1 = File32.Except(File64);
                foreach (var i in diff1)
                {
                    DN32.Add(i.Key, i.Value);
                }
                //64對32-bit做資料比對 無重複儲存至 DN64
                var diff2 = File64.Except(File32);
                foreach (var i in diff2)
                {
                    DN64.Add(i.Key, i.Value);
                }

                //合併無重複DN3264-bit，並在判斷key值有無重複資料 若無儲存至 All                
                All = All.Union(DN32).ToDictionary(i => i.Key, i => i.Value);
                foreach (KeyValuePair<string, string> kvp in DN64)
                {
                    string value;
                    if (!All.TryGetValue(kvp.Key, out value))
                    {
                        All.Add(kvp.Key, kvp.Value);
                    }
                    else
                        All[kvp.Key] = kvp.Value;
                }

                ListViewItem item;
                var items = from pair in All orderby pair.Key ascending select pair;
                foreach (var i in items)
                {
                    item = new ListViewItem(new string[] { i.Key, i.Value });
                    listView1.Items.Add(item);
                }
                total.Text += "("+ listView1.Items.Count.ToString() +")";
            }           
            catch (Exception)
            {

            }

        }
    }
}
