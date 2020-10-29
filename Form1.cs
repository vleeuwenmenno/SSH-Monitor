using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using Renci.SshNet.Common;
using System.IO;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System.Text;
using QRCoder;
using System.Diagnostics;

namespace SSHMonitor
{
    public partial class Form1 : Form
    {
        Thread testThread;
        public List<ConnectionInfo> connections;
        ConnectionInfo activeConnection;

        public Form1()
        {
            InitializeComponent();

            if (File.Exists(Environment.CurrentDirectory + "/connections.json"))
                connections = JsonConvert.DeserializeObject<List<ConnectionInfo>>(File.ReadAllText(Environment.CurrentDirectory + "/connections.json"));
            
            else
                connections = new List<ConnectionInfo>();
            
            vpnSettingsList.Items.Add(new ListViewItem("Loading ..."));

            FileSystemWatcher watcher = new FileSystemWatcher();

            watcher.Path = Environment.CurrentDirectory;
            watcher.NotifyFilter = NotifyFilters.LastWrite;
            watcher.Filter = "connections.json";
            watcher.Changed += OnChanged;
            watcher.EnableRaisingEvents = true;
        }


        // Define the event handlers.
        private void OnChanged(object source, FileSystemEventArgs e)
        {
            List<ConnectionInfo> newList = new List<ConnectionInfo>();
            string s, json = "";

            using (StreamReader r = new StreamReader(File.Open(Environment.CurrentDirectory + "/connections.json", FileMode.Open, FileAccess.Read, FileShare.ReadWrite)))
            {
                while ((s = r.ReadLine()) != null)
                {
                    json += $"{s}\n";
                }
            }

            if (json != null && json != "")
            {
                if (File.Exists(Environment.CurrentDirectory + "/connections.json"))
                    newList = JsonConvert.DeserializeObject<List<ConnectionInfo>>(json);

                connections = newList;
                ReloadUI();
            }
        }

        private void addConnBtn_Click(object sender, EventArgs e)
        {
            addConnPanel.Visible = true;
            editConnBtn.Visible = false;

            addConnBtn.Visible = !addConnPanel.Visible;
            basePanel.Visible = !basePanel.Visible;
        }

        private void cancelAddBtn_Click(object sender, EventArgs e)
        {
            editConnBtn.Visible = true;
            addConnPanel.Visible = false;
            addConnBtn.Visible = !addConnPanel.Visible;
            basePanel.Visible = !basePanel.Visible;

            if (testThread != null)
                testThread = null;
        }

        public void enableUI(bool disableSave = false, bool enable = true)
        {
            inputPanel.Enabled = enable;
            testBtn.Enabled = enable;
            saveBtn.Enabled = !disableSave;
        }

        public void launchTerminal(string command)
        {
            try
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = $"/C wt ; {command}";
                process.StartInfo = startInfo;
                process.Start();
            }
            catch (Exception)
            {
                try
                {
                    System.Diagnostics.Process processs = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo startInfos = new System.Diagnostics.ProcessStartInfo();
                    startInfos.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfos.FileName = "pwsh";
                    processs.StartInfo = startInfos;
                    processs.Start();
                    
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = "cmd.exe";
                    startInfo.Arguments = $"/C start pwsh /C {command}";
                    process.StartInfo = startInfo;
                    process.Start();
                }
                catch (Exception e)
                {
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = "cmd.exe";
                    startInfo.Arguments = $"/C start powershell /C {command}";
                    process.StartInfo = startInfo;
                    process.Start();
                }
            }
        }

        public void ReloadUI()
        {
            int y = 0;
            int x = 0;

            int height = 72;
            int width = 272;

            int cols = 5;
            
            this.BeginInvoke(new MethodInvoker(delegate 
            {
                basePanel.Controls.Clear();
            }));

            foreach (ConnectionInfo connInfo in connections)
            {
                Panel p = new Panel();

                Label serverName = new Label();
                Label serverDetail = new Label();
                Label statusPoint = new Label();

                LinkLabel puttyLabel = new LinkLabel();
                LinkLabel vpnSettingsLabel = new LinkLabel();

                //Set the server name label (My Pi Server)
                serverName.Text = connInfo.name;
                serverName.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                serverName.Size = new Size(200, 24);
                serverName.Location = new Point(40, 0);

                //Set the detail label (user@example.host.com)
                serverDetail.Text = $"{connInfo.user}@{connInfo.host}";
                serverDetail.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                serverDetail.Size = new Size(200, 18);
                serverDetail.Location = new Point(47, 21);

                //Set the putty link label
                puttyLabel.Text = $"Console";
                puttyLabel.Font = new Font("Segoe UI", 9, FontStyle.Underline);
                puttyLabel.Size = new Size(52, 16);
                puttyLabel.Location = new Point(48, 37);
                puttyLabel.Enabled = false;

                //Set the edit link label
                vpnSettingsLabel.Text = $"VPN Settings";
                vpnSettingsLabel.Font = new Font("Segoe UI", 9, FontStyle.Underline);
                vpnSettingsLabel.Size = new Size(128, 16);
                vpnSettingsLabel.Location = new Point(96, 37);
                vpnSettingsLabel.Enabled = false;

                //Set the host panel parameters
                p.Location = new Point(x, y);
                p.Size = new Size(256, 64);
                p.BorderStyle = BorderStyle.FixedSingle;

                //Set the server name label (My Pi Server)
                statusPoint.Text = "•";
                statusPoint.Font = new Font("Segoe UI", 40, FontStyle.Bold);
                statusPoint.Size = new Size(32, 64);
                statusPoint.Location = new Point(0, -16);
                statusPoint.ForeColor = Color.BlueViolet;

                //Add the controls
                p.Controls.Add(serverName);
                p.Controls.Add(serverDetail);
                p.Controls.Add(puttyLabel);
                p.Controls.Add(vpnSettingsLabel);
                p.Controls.Add(statusPoint);

                
                this.BeginInvoke(new MethodInvoker(delegate 
                {
                    basePanel.Controls.Add(p); 
                }));

                y += height;

                if (y == (height * cols))
                {
                    y = 0;
                    x += width;
                }

                vpnSettingsLabel.Click += new EventHandler(delegate (Object o, EventArgs a) 
                {
                    wirePanel.Visible = true;
                    wirePanelGroup.Text = connInfo.name + " VPN user management";
                    closeConfiguratorBtn.Visible = true;
                    editConnBtn.Visible = false;
                    addConnBtn.Visible = false;
                    addConnPanel.Visible = false;
                    addUserBtn.Visible = true;
                    userAddTxt.Visible = true;
                    
                    loadVPNUsers(connInfo);
                    activeConnection = connInfo;
                });

                puttyLabel.Click += new EventHandler(delegate (Object o, EventArgs a) 
                {
                    DialogResult res = MessageBox.Show("Due to a security limitation in the SSH command we cannot auto-fill the password directly. Would you like to copy the password to the clipboard so you can manually paste it?", "Copy password to clipboard?", MessageBoxButtons.YesNoCancel,  MessageBoxIcon.Information);

                    if (res == DialogResult.Yes)
                        Clipboard.SetText($"{connInfo.pass}\n");
                    else if (res == DialogResult.Cancel)
                        return;

                    launchTerminal($"ssh {connInfo.user}@{connInfo.host} -p {connInfo.port}");
                });

                new Thread(() => {
                    using (var client = new SshClient(connInfo.host, connInfo.port, connInfo.user, connInfo.pass))
                    {
                        try 
                        {
                            client.Connect();

                            if (client.ConnectionInfo.IsAuthenticated)
                            {
                                SshCommand result = client.RunCommand($"echo {connInfo.pass} | sudo -S pivpn help | grep Control");

                                this.BeginInvoke(new MethodInvoker(delegate {
                                    statusPoint.ForeColor = Color.Green;
                                    puttyLabel.Enabled = true;

                                    if (result.Result == "::: Control all PiVPN specific functions!\n")
                                        vpnSettingsLabel.Enabled = true;
                                    else
                                        vpnSettingsLabel.Enabled = false;

                                }));
                            }
                            else
                            {
                                this.BeginInvoke(new MethodInvoker(delegate {
                                    statusPoint.ForeColor = Color.Red;
                                }));
                            }

                            client.Disconnect();
                        }
                        catch (Exception)
                        {
                            try 
                            {
                                this.BeginInvoke(new MethodInvoker(delegate {
                                    statusPoint.ForeColor = Color.Red;
                                }));
                            }
                            catch (Exception e)
                            { Console.WriteLine(e); }
                        }  
                    }
                }).Start();
            }
        }

        private void loadVPNUsers(ConnectionInfo connInfo)
        {
            using (var client = new SshClient(connInfo.host, connInfo.port, connInfo.user, connInfo.pass))
            {
                try 
                {
                    client.Connect();

                    if (client.ConnectionInfo.IsAuthenticated)
                    {
                        ShellStream stream = client.CreateShellStream("xterm", 80, 50, 1024, 1024, 1024);
                        SshCommand result = client.RunCommand($"echo {connInfo.pass} | sudo -S pivpn -c");

                        string pattern = @"^(?<user>[a-zA-Z0-9-_]*)\s*((?<remoteIp>\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b\:[0-9]{1,6})|\(none\))\s*(?<virtualIp>\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b)\s*(?<received>[.a-zA-Z0-9]*)\s*(?<sent>[.a-zA-Z0-9]*)\s*((?<month>[a-zA-Z]{3})\s(?<day>[0-9]{2})\s(?<year>[0-9]{4})\s-\s(?<time>(?:(?:([01]?\d|2[0-3]):)?([0-5]?\d):)?([0-5]?\d))|\(not yet\))";
                        RegexOptions options = RegexOptions.Multiline;

                        vpnSettingsList.Items.Clear();

                        foreach (Match m in Regex.Matches(result.Result, pattern, options))
                        {
                            ListViewItem item = new ListViewItem();

                            item.Text = m.Groups[6].Value;
                            item.SubItems.Add(m.Groups[7].Value);
                            item.SubItems.Add(m.Groups[8].Value);
                            item.SubItems.Add(m.Groups[9].Value);
                            item.SubItems.Add(m.Groups[10].Value);
                            item.SubItems.Add($"{m.Groups[14].Value} {m.Groups[12].Value}-{m.Groups[11].Value}-{m.Groups[13].Value}");

                            vpnSettingsList.Items.Add(item);
                        }
                    }

                    client.Disconnect();
                }
                catch (Exception)
                { }  
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connTestResultLabel.Text = "Connecting ...";
            connTestResultLabel.ForeColor = Color.Black;
            enableUI(true, false);
            
            testThread = null;
            testThread = new Thread(() => {
                using (var client = new SshClient(hostTxt.Text, int.Parse(portText.Text), userText.Text, passText.Text))
                {
                    try 
                    {
                        client.Connect();

                        if (client.ConnectionInfo.IsAuthenticated)
                        {
                            this.BeginInvoke(new MethodInvoker(delegate {
                                connTestResultLabel.Text = "Success";
                                connTestResultLabel.ForeColor = Color.Green;
                                enableUI(false, true);
                            }));
                        }
                        else
                        {
                            this.BeginInvoke(new MethodInvoker(delegate {
                                connTestResultLabel.Text = "Incorrect credentials";
                                connTestResultLabel.ForeColor = Color.Orange;
                                enableUI(true);
                            }));
                        }

                        client.Disconnect();
                    }
                    catch (AggregateException ag)
                    {
                        this.BeginInvoke(new MethodInvoker(delegate {
                            connTestResultLabel.Text = ag.InnerException.Message;
                            connTestResultLabel.ForeColor = Color.Red;
                            enableUI(true);
                        }));
                    }       
                    catch (SocketException socex)
                    {
                        this.BeginInvoke(new MethodInvoker(delegate {
                            connTestResultLabel.Text = socex.Message;
                            connTestResultLabel.ForeColor = Color.Red;
                            enableUI(true);
                        }));
                    }    
                    catch (SshAuthenticationException)
                    {
                        this.BeginInvoke(new MethodInvoker(delegate {
                            connTestResultLabel.Text = "Incorrect credentials";
                            connTestResultLabel.ForeColor = Color.Orange;
                            enableUI(true);
                        }));
                    }   
                }
            });
            testThread.Start();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            ConnectionInfo conInfo = new ConnectionInfo();

            conInfo.name = serverNameText.Text;
            conInfo.host = hostTxt.Text;
            conInfo.port = int.Parse(portText.Text);
            conInfo.user = userText.Text;
            conInfo.pass = passText.Text;
            
            connections.Add(conInfo);
            File.WriteAllText(Environment.CurrentDirectory + "/connections.json", JsonConvert.SerializeObject(connections, Formatting.Indented));
            ReloadUI();

            addConnPanel.Visible = true;
            editConnBtn.Visible = false;

            addConnBtn.Visible = !addConnPanel.Visible;
            basePanel.Visible = !basePanel.Visible;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReloadUI();
        }

        private void editConnBtn_Click(object sender, EventArgs e)
        {
            if (!File.Exists($"{Environment.CurrentDirectory + "/connections.json"}"))
                File.WriteAllText($"{Environment.CurrentDirectory + "/connections.json"}", "[]");

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = $"/C {Environment.CurrentDirectory + "/connections.json"}";
            process.StartInfo = startInfo;
            process.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wirePanel.Visible = false;
            editConnBtn.Visible = true;
            addConnBtn.Visible = true;
            closeConfiguratorBtn.Visible = false;
            addUserBtn.Visible = false;
            userAddTxt.Visible = false;

            vpnSettingsList.Items.Clear();
            vpnSettingsList.Items.Add(new ListViewItem("Loading ..."));
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            
            Regex r = new Regex(@"^[A-Za-z0-9-_.@]*$");
            if (!r.IsMatch(userAddTxt.Text))
            {
                MessageBox.Show("Name can only contain alphanumeric characters and these characters (.-@_).", "Invalid config name!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Enabled = true;
                return;
            }

            new Thread(() => {
                using (var client = new SshClient(activeConnection.host, activeConnection.port, activeConnection.user, activeConnection.pass))
                {
                    try 
                    {
                        client.Connect();

                        if (client.ConnectionInfo.IsAuthenticated)
                        {
                            ShellStream stream = client.CreateShellStream("xterm", 80, 50, 1024, 1024, 1024);
                            SshCommand result = client.RunCommand($"echo {userAddTxt.Text} | sudo -S pivpn add");

                            string pattern = @"^(?<user>[a-zA-Z0-9-_]*)\s*((?<remoteIp>\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b\:[0-9]{1,6})|\(none\))\s*(?<virtualIp>\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b)\s*(?<received>[.a-zA-Z0-9]*)\s*(?<sent>[.a-zA-Z0-9]*)\s*((?<month>[a-zA-Z]{3})\s(?<day>[0-9]{2})\s(?<year>[0-9]{4})\s-\s(?<time>(?:(?:([01]?\d|2[0-3]):)?([0-5]?\d):)?([0-5]?\d))|\(not yet\))";
                            RegexOptions options = RegexOptions.Multiline;

                            vpnSettingsList.Items.Clear();
                            Console.WriteLine(result.Result);

                            foreach (Match m in Regex.Matches(result.Result, pattern, options))
                            {
                                ListViewItem item = new ListViewItem();

                                item.Text = m.Groups[6].Value;
                                item.SubItems.Add(m.Groups[7].Value);
                                item.SubItems.Add(m.Groups[8].Value);
                                item.SubItems.Add(m.Groups[9].Value);
                                item.SubItems.Add(m.Groups[10].Value);
                                item.SubItems.Add($"{m.Groups[14].Value} {m.Groups[12].Value}-{m.Groups[11].Value}-{m.Groups[13].Value}");


                                this.BeginInvoke(new MethodInvoker(delegate {
                                    vpnSettingsList.Items.Add(item);
                                }));
                            }
                        }

                        client.Disconnect();
                    }
                    catch (Exception)
                    { }  
                }

                this.BeginInvoke(new MethodInvoker(delegate {
                    loadVPNUsers(activeConnection);
                    this.Enabled = true;
                }));
            }).Start();
        }

        private void deleteUserContextBtn_Click(object sender, EventArgs e)
        {
            if (vpnSettingsList.SelectedItems.Count > 0)
            {
                this.Enabled = false;

                String text = vpnSettingsList.SelectedItems[0].Text; 
                DialogResult res = MessageBox.Show($"Are you sure you want to remove:\n `{text}` from server `{activeConnection.name}`?", "Remove?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (res == DialogResult.Yes)
                {
                    using (var client = new SshClient(activeConnection.host, activeConnection.port, activeConnection.user, activeConnection.pass))
                    {
                        try 
                        {
                            client.Connect();

                            if (client.ConnectionInfo.IsAuthenticated)
                            {
                                ShellStream stream = client.CreateShellStream("xterm", 80, 50, 1024, 1024, 1024);
                                SshCommand result = client.RunCommand($"echo {userAddTxt.Text} | sudo -S pivpn -r  < <(cat <(echo \"{text}\") <(echo y))");
                                
                                if (result.Result.Contains($"::: Successfully deleted {text}"))
                                    MessageBox.Show($"Succesfully removed {text}", "User removed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                else
                                    MessageBox.Show("Failed to remove user?\n\nCommand output:\n" + result.Result, "User failed  to remove?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            client.Disconnect();
                                
                            this.BeginInvoke(new MethodInvoker(delegate {
                                loadVPNUsers(activeConnection);
                                this.Enabled = true;
                            }));
                        }
                        catch (Exception)
                        { this.Enabled = true; }  
                    }
                }
                else
                    this.Enabled = true;
            }
        }

        private void dlConfigContextBtn_Click(object sender, EventArgs e)
        {
            if (vpnSettingsList.SelectedItems.Count > 0)
            {
                String text = vpnSettingsList.SelectedItems[0].Text; 
                using (var sftp = new SftpClient(activeConnection.host, activeConnection.port, activeConnection.user, activeConnection.pass))
                {
                    sftp.Connect();
                    
                    Stream file = null;
                    SaveFileDialog fileDiag = new SaveFileDialog();
                    fileDiag.Filter = "WireGuard config|*.conf|OpenVPN config|*.ovpn";
                    fileDiag.FileName = $"{text}.conf";

                    try 
                    {
                        DialogResult result = fileDiag.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            file = File.OpenWrite(fileDiag.FileName);
                            sftp.DownloadFile($"/home/{activeConnection.user}/configs/{text}.conf", file);
                            MessageBox.Show($"Config file saved.\nNow import it into WireGuard/OpenVPN depending on what your PiVPN was setup to run.", "Saved config!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            file.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to download config file.\nError: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                        if (file != null)
                            file.Close();

                        if (File.Exists(fileDiag.FileName) && string.IsNullOrEmpty(File.ReadAllText(fileDiag.FileName)))
                            File.Delete(fileDiag.FileName);
                    }

                    sftp.Disconnect();
                }
            }
        }

        private void showQrConfigContextBtn_Click(object sender, EventArgs e)
        {
            if (vpnSettingsList.SelectedItems.Count > 0)
            {
                String text = vpnSettingsList.SelectedItems[0].Text; 
                using (var sftp = new SftpClient(activeConnection.host, activeConnection.port, activeConnection.user, activeConnection.pass))
                {
                    sftp.Connect();

                    try
                    {
                        Stream file = File.OpenWrite(Environment.CurrentDirectory + "/config.tmp");
                        sftp.DownloadFile($"/home/{activeConnection.user}/configs/{text}.conf", file);
                        file.Close();

                        Thread.Sleep(100);

                        if (File.Exists(Environment.CurrentDirectory + "/config.tmp"))
                        {
                            string qrData = File.ReadAllText(Environment.CurrentDirectory + "/config.tmp");
                            File.Delete(Environment.CurrentDirectory + "/config.tmp");

                            QRCodeGenerator qrGenerator = new QRCodeGenerator();
                            QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrData, QRCodeGenerator.ECCLevel.Q);
                            QRCode qrCode = new QRCode(qrCodeData);
                            Bitmap qrCodeImage = qrCode.GetGraphic(20);
                            
                            PictureBox pic = new PictureBox();
                            Form f = new Form();

                            f.Size = new Size(512, 512);
                            f.Text = $"User: {text} from {activeConnection.name}";

                            pic.Image = qrCodeImage;
                            pic.Dock = DockStyle.Fill;
                            pic.SizeMode = PictureBoxSizeMode.StretchImage;

                            f.Controls.Add(pic);
                            f.ShowDialog();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to download config file.\nError: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    sftp.Disconnect();
                }
            }
        }

        private void vpnSettingsList_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (vpnSettingsList.FocusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }
    }
}
