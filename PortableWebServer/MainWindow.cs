using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.ServiceProcess;
using System.Windows.Forms;

namespace PortableWebServer
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        bool isInstall = false;
        bool CheckServiceisRunning(string ServiceName)
        {
            try
            {
                ServiceController Service = new ServiceController(ServiceName);
                if (Service.Status == ServiceControllerStatus.Running)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        void WriteFile(string Path, string Text)
        {
            File.WriteAllText(Path, string.Join("\n", Text));
        }

        string ReadFile(string FilePath)
        {
            string[] TargetFile = File.ReadAllLines(FilePath);
            return String.Join(Environment.NewLine, TargetFile);
        }

        string App = "PortableWebServer";
        void RegeditCreate(string name, string data)
        {
            Registry.CurrentUser.CreateSubKey(App);
            RegistryKey regedit = Registry.CurrentUser.OpenSubKey(App, true);
            regedit.SetValue(name, data);
        }

        string RegeditRead(string name)
        {
            RegistryKey regedit = Registry.CurrentUser.OpenSubKey(App, true);
            if (regedit != null)
            {
                object data = regedit.GetValue(name);
                if (data != null)
                {
                    return data.ToString();
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        void ClearRegedit()
        {
            try
            {
                using (RegistryKey Key = Registry.CurrentUser.OpenSubKey(App, true))
                {
                    if (Key != null)
                    {
                        Key.DeleteValue("Path");

                    }
                }
            }
            catch { }
        }

        void Command(string command)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo = new System.Diagnostics.ProcessStartInfo()
            {
                UseShellExecute = false,
                CreateNoWindow = true,
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                Arguments = "/C " + command
            };
            process.Start();
            process.WaitForExit();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            if (RegeditRead("Path") != null)
            {
                Page1_Button.Text = "Uninstall";
                Page1.Text = "Uninstall";
                TabControl.SelectedTab = Page2;
                Page1_FolderPath.Text = RegeditRead("Path");
                isInstall = true;
            }
        }

        private void Page1_FolderSelect_Click(object sender, EventArgs e)
        {
            using (var FolderBrowser = new FolderBrowserDialog())
            {
                DialogResult Result = FolderBrowser.ShowDialog();
                if (Result == DialogResult.OK && !string.IsNullOrWhiteSpace(FolderBrowser.SelectedPath))
                {
                    Page1_FolderPath.Text = FolderBrowser.SelectedPath;
                }
            }
        }

        private void CheckServices_Tick(object sender, EventArgs e)
        {
            if(CheckServiceisRunning("Apache2.4") == true)
            {
                Page2_ApacheStatus.ForeColor = Color.Green;
                Page2_ApacheStatus.Text = "Online";
            }
            else
            {
                Page2_ApacheStatus.ForeColor = Color.Red;
                Page2_ApacheStatus.Text = "Offline";
            }

            if (CheckServiceisRunning("mysql") == true)
            {
                Page2_MySQLStatus.ForeColor = Color.Green;
                Page2_MySQLStatus.Text = "Online";
            }
            else
            {
                Page2_MySQLStatus.ForeColor = Color.Red;
                Page2_MySQLStatus.Text = "Offline";
            }
        }

        private void Page1_Button_Click(object sender, EventArgs e)
        {
            if(Page1_FolderPath.Text == "")
            {
                MessageBox.Show("Please select a location first!", "Stop!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(isInstall == false)
            {
                string FileName = "localhost.zip";
                string Path = Page1_FolderPath.Text + @"\" + FileName;
                byte[] Zip = Properties.Resources.localhost;
                File.WriteAllBytes(Path, Zip);

                if (!File.Exists(Path))
                {
                    MessageBox.Show("Error extracting file!", "Stop!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ZipFile.ExtractToDirectory(Path, Path.Replace(@"\" + FileName, ""));
                File.Delete(Path);
                string ApacheFile1 = ReadFile(Path.Replace(@"\" + FileName, "") + @"\apache\conf\httpd.conf");
                string ApacheFile2 = ReadFile(Path.Replace(@"\" + FileName, "") + @"\apache\conf\extra\httpd-multilang-errordoc.conf");
                string ApacheFile3 = ReadFile(Path.Replace(@"\" + FileName, "") + @"\apache\conf\extra\httpd-ssl.conf");
                string ApacheFile4 = ReadFile(Path.Replace(@"\" + FileName, "") + @"\apache\conf\extra\httpd-vhosts.conf");
                string ApacheFile5 = ReadFile(Path.Replace(@"\" + FileName, "") + @"\apache\conf\extra\httpd-xampp.conf");
                string ApacheFile6 = ReadFile(Path.Replace(@"\" + FileName, "") + @"\apache\conf\extra\httpd-autoindex.conf");
                string ApacheFile7 = ReadFile(Path.Replace(@"\" + FileName, "") + @"\apache\conf\extra\httpd-dav.conf");
                string ApacheFile8 = ReadFile(Path.Replace(@"\" + FileName, "") + @"\apache\conf\extra\httpd-manual.conf");
                string MysqlFile1 = ReadFile(Path.Replace(@"\" + FileName, "") + @"\mysql\data\my.ini");
                string MysqlFile2 = ReadFile(Path.Replace(@"\" + FileName, "") + @"\mysql\bin\my.ini");
                string PhpFile1 = ReadFile(Path.Replace(@"\" + FileName, "") + @"\php\pci");
                string PhpFile2 = ReadFile(Path.Replace(@"\" + FileName, "") + @"\php\pci.bat");
                string PhpFile3 = ReadFile(Path.Replace(@"\" + FileName, "") + @"\php\pciconf");
                string PhpFile4 = ReadFile(Path.Replace(@"\" + FileName, "") + @"\php\pciconf.bat");
                string PhpFile5 = ReadFile(Path.Replace(@"\" + FileName, "") + @"\php\pear.bat");
                string PhpFile6 = ReadFile(Path.Replace(@"\" + FileName, "") + @"\php\peardev.bat");
                string PhpFile7 = ReadFile(Path.Replace(@"\" + FileName, "") + @"\php\pecl.bat");
                string PhpFile8 = ReadFile(Path.Replace(@"\" + FileName, "") + @"\php\php.ini");
                string PhpFile9 = ReadFile(Path.Replace(@"\" + FileName, "") + @"\php\phpunit");
                string PhpFile10 = ReadFile(Path.Replace(@"\" + FileName, "") + @"\php\phpunit.bat");

                string Type1 = @"C:\localhost\";
                string NewType1 = Page1_FolderPath.Text + @"\";

                string Type2 = @"C:/localhost/";
                string NewType2 = Page1_FolderPath.Text.Replace(@"\",@"/") + @"/";

                string Type3 = @"c:\localhost\";
                string NewType3 = Page1_FolderPath.Text + @"\";

                string Type4 = @"c:/localhost/";
                string NewType4 = Page1_FolderPath.Text.Replace(@"\", @"/").Replace("C", "c") + @"/";

                ApacheFile1 = ApacheFile1.Replace(Type1, NewType1).Replace(Type2, NewType2).Replace(Type3, NewType3).Replace(Type4, NewType4);
                ApacheFile2 = ApacheFile2.Replace(Type1, NewType1).Replace(Type2, NewType2).Replace(Type3, NewType3).Replace(Type4, NewType4);
                ApacheFile3 = ApacheFile3.Replace(Type1, NewType1).Replace(Type2, NewType2).Replace(Type3, NewType3).Replace(Type4, NewType4);
                ApacheFile4 = ApacheFile4.Replace(Type1, NewType1).Replace(Type2, NewType2).Replace(Type3, NewType3).Replace(Type4, NewType4);
                ApacheFile5 = ApacheFile5.Replace(Type1, NewType1).Replace(Type2, NewType2).Replace(Type3, NewType3).Replace(Type4, NewType4);
                ApacheFile6 = ApacheFile6.Replace(Type1, NewType1).Replace(Type2, NewType2).Replace(Type3, NewType3).Replace(Type4, NewType4);
                ApacheFile7 = ApacheFile7.Replace(Type1, NewType1).Replace(Type2, NewType2).Replace(Type3, NewType3).Replace(Type4, NewType4);
                ApacheFile8 = ApacheFile8.Replace(Type1, NewType1).Replace(Type2, NewType2).Replace(Type3, NewType3).Replace(Type4, NewType4);
                MysqlFile1 = MysqlFile1.Replace(Type1, NewType1).Replace(Type2, NewType2).Replace(Type3, NewType3).Replace(Type4, NewType4);
                MysqlFile2 = MysqlFile2.Replace(Type1, NewType1).Replace(Type2, NewType2).Replace(Type3, NewType3).Replace(Type4, NewType4);
                PhpFile1 = PhpFile1.Replace(Type1, NewType1).Replace(Type2, NewType2).Replace(Type3, NewType3).Replace(Type4, NewType4);
                PhpFile2 = PhpFile2.Replace(Type1, NewType1).Replace(Type2, NewType2).Replace(Type3, NewType3).Replace(Type4, NewType4);
                PhpFile3 = PhpFile3.Replace(Type1, NewType1).Replace(Type2, NewType2).Replace(Type3, NewType3).Replace(Type4, NewType4);
                PhpFile4 = PhpFile4.Replace(Type1, NewType1).Replace(Type2, NewType2).Replace(Type3, NewType3).Replace(Type4, NewType4);
                PhpFile5 = PhpFile5.Replace(Type1, NewType1).Replace(Type2, NewType2).Replace(Type3, NewType3).Replace(Type4, NewType4);
                PhpFile6 = PhpFile6.Replace(Type1, NewType1).Replace(Type2, NewType2).Replace(Type3, NewType3).Replace(Type4, NewType4);
                PhpFile7 = PhpFile7.Replace(Type1, NewType1).Replace(Type2, NewType2).Replace(Type3, NewType3).Replace(Type4, NewType4);
                PhpFile8 = PhpFile8.Replace(Type1, NewType1).Replace(Type2, NewType2).Replace(Type3, NewType3).Replace(Type4, NewType4);
                PhpFile9 = PhpFile9.Replace(Type1, NewType1).Replace(Type2, NewType2).Replace(Type3, NewType3).Replace(Type4, NewType4);
                PhpFile10 = PhpFile10.Replace(Type1, NewType1).Replace(Type2, NewType2).Replace(Type3, NewType3).Replace(Type4, NewType4);

                WriteFile(Path.Replace(@"\" + FileName, "") + @"\apache\conf\httpd.conf", ApacheFile1);
                WriteFile(Path.Replace(@"\" + FileName, "") + @"\apache\conf\extra\httpd-multilang-errordoc.conf", ApacheFile2);
                WriteFile(Path.Replace(@"\" + FileName, "") + @"\apache\conf\extra\httpd-ssl.conf", ApacheFile3);
                WriteFile(Path.Replace(@"\" + FileName, "") + @"\apache\conf\extra\httpd-vhosts.conf", ApacheFile4);
                WriteFile(Path.Replace(@"\" + FileName, "") + @"\apache\conf\extra\httpd-xampp.conf", ApacheFile5);
                WriteFile(Path.Replace(@"\" + FileName, "") + @"\apache\conf\extra\httpd-autoindex.conf", ApacheFile6);
                WriteFile(Path.Replace(@"\" + FileName, "") + @"\apache\conf\extra\httpd-dav.conf", ApacheFile7);
                WriteFile(Path.Replace(@"\" + FileName, "") + @"\apache\conf\extra\httpd-manual.conf", ApacheFile8);
                WriteFile(Path.Replace(@"\" + FileName, "") + @"\mysql\data\my.ini", MysqlFile1);
                WriteFile(Path.Replace(@"\" + FileName, "") + @"\mysql\bin\my.ini", MysqlFile2);
                WriteFile(Path.Replace(@"\" + FileName, "") + @"\php\pci", PhpFile1);
                WriteFile(Path.Replace(@"\" + FileName, "") + @"\php\pci.bat", PhpFile2);
                WriteFile(Path.Replace(@"\" + FileName, "") + @"\php\pciconf", PhpFile3);
                WriteFile(Path.Replace(@"\" + FileName, "") + @"\php\pciconf.bat", PhpFile4);
                WriteFile(Path.Replace(@"\" + FileName, "") + @"\php\pear.bat", PhpFile5);
                WriteFile(Path.Replace(@"\" + FileName, "") + @"\php\peardev.bat", PhpFile6);
                WriteFile(Path.Replace(@"\" + FileName, "") + @"\php\pecl.bat", PhpFile7);
                WriteFile(Path.Replace(@"\" + FileName, "") + @"\php\php.ini", PhpFile8);
                WriteFile(Path.Replace(@"\" + FileName, "") + @"\php\phpunit", PhpFile9);
                WriteFile(Path.Replace(@"\" + FileName, "") + @"\php\phpunit.bat", PhpFile10);
                RegeditCreate("Path", Page1_FolderPath.Text + @"\");
                isInstall = true;
                MessageBox.Show("Installation Successful!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Page1_Button.Text = "Uninstall";
                Page1.Text = "Uninstall";
                TabControl.SelectedTab = Page2;
            }
            else
            {
                Command(@"cd " + RegeditRead("Path") + "apache && apache_uninstallservice.bat && exit");
                Command(@"cd " + RegeditRead("Path") + "mysql && mysql_uninstallservice.bat && exit");
                Directory.Delete(RegeditRead("Path"), true);
                ClearRegedit();
                MessageBox.Show("Deletion Successful!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }

        }

        private void Page2_ApacheStart_Click(object sender, EventArgs e)
        {
            Command(@"cd " + RegeditRead("Path") + "apache && apache_installservice.bat && exit");
        }

        private void Page2_ApacheStop_Click(object sender, EventArgs e)
        {
            Command(@"cd " + RegeditRead("Path") + "apache && apache_uninstallservice.bat && exit");
        }

        private void Page2_MySQLStart_Click(object sender, EventArgs e)
        {
            Command(@"cd " + RegeditRead("Path") + "mysql && mysql_installservice.bat && exit");
        }

        private void Page2_MySQLStop_Click(object sender, EventArgs e)
        {
            Command(@"cd " + RegeditRead("Path") + "mysql && mysql_uninstallservice.bat && exit");
        }

        private void Page2_MySQLAdmin_Click(object sender, EventArgs e)
        {
            Process.Start("http://localhost/phpmyadmin/");
        }
    }
}
