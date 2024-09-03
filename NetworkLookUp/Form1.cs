using System.Diagnostics;
using System.Text;
using System.Net.NetworkInformation;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;

namespace NetworkLookUp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeNetworkComboBox();
        }

        public void InitializeNetworkComboBox()
        {
            comboBox_NetworkInterface.DataBindings.Clear();
            var bindingSource = new BindingSource();
            var adapters = NetworkInterface.GetAllNetworkInterfaces();
            var networkDesc = new List<NetworkAdapterDesc>();
            var stringBuilder = new StringBuilder();
            foreach (var adapter in adapters)
            {
                Debug.Assert(adapter != null);
                var adapterProperties = adapter.GetIPProperties();
                var adapterType = adapter.NetworkInterfaceType;
                bool isEthernet = adapterType == NetworkInterfaceType.Ethernet;
                bool isWifi = adapterType == NetworkInterfaceType.Wireless80211;
                if (!isEthernet && !isWifi)
                {
                    continue;
                }

                var uniCast = adapterProperties.UnicastAddresses;
                foreach (var uni in uniCast)
                {
                    var addressFamiliy = uni.Address.AddressFamily;
                    if (uni.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        var adapterName = adapter.Name;
                        var adapterDescription = adapter.Description;
                        var adapterDesc = new NetworkAdapterDesc();
                        adapterDesc.Adapter = adapter;
                        var ipAddress = uni.Address.ToString();
                        var physiclAddress = adapter.GetPhysicalAddress();
                        stringBuilder.AppendFormat($"{adapterName} ({adapterType}) - {ipAddress}");
                        adapterDesc.Desc = stringBuilder.ToString();
                        networkDesc.Add(adapterDesc);
                        stringBuilder.Clear();
                    }
                }

            }

            bindingSource.DataSource = networkDesc;
            comboBox_NetworkInterface.DataSource = bindingSource;
            comboBox_NetworkInterface.DisplayMember = "Desc";
            comboBox_NetworkInterface.ValueMember = "Adapter";
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            InitializeNetworkComboBox();
        }

        private void button_LookUp_Click(object sender, EventArgs e)
        {
            var selectedAdapterDesc = comboBox_NetworkInterface.SelectedItem as NetworkAdapterDesc;
            if (selectedAdapterDesc == null)
            {
                Debug.Assert(false);
                return;
            }

            var adapter = selectedAdapterDesc.Adapter;
            if (adapter == null)
            {
                Debug.Assert(false);
                return;
            }

            var networkIp = textBox_TargetIP.Text;
            var userName = textBox_UserName.Text;
            var password = textBox_Password.Text;
            var networkPath = textBox_Path.Text;
            if (networkIp.Length == 0)
            {
                //Debug.Assert(false);
                //ToDo : 
                string message = "ip가 잘못 되었습니다.";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                return;
            }

            if (userName.Length == 0)
            {

            }

            if (networkPath.Length == 0)
            {
                string message = "경로가 잘못 되었습니다.";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                return;
            }


            var ipProperty = adapter.GetIPProperties();
            var credentials = new NetworkCredential(userName, password);

            using (new SharedFolderConnector(networkIp, credentials))
            {
                //ToDo : Access Shared Folder Directory on the remote device
                StringBuilder path = new();
                path.AppendFormat(networkIp);
                path.AppendFormat(networkPath);
                if (!Directory.Exists(path.ToString()))
                {
                    string message = "경로가 잘못 되었습니다.";
                    string caption = "Error Detected in Input";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;

                    // Displays the MessageBox.
                    result = MessageBox.Show(message, caption, buttons);
                    return;
                }

                treeView_FileSystem.Nodes.Clear();
                var rootNode = new TreeNode(path.ToString());   
                

                var dirList = Directory.GetDirectories(path.ToString());
                foreach (var item in dirList)
                {
                    treeView_FileSystem.Nodes.Add(item);
                }

                var filesList = Directory.GetFiles(path.ToString());
                foreach (var item in filesList)
                {
                    treeView_FileSystem.Nodes.Add(item.ToString());
                }
            }

        }

        private void AddFileSystemNodesRecursive(TreeNode? parent, string nodeTxt)
        {
            string path = nodeTxt;
            if (!Directory.Exists(path))
            {
                return;
            }
            
            var insertDirNode = new TreeNode(path.ToString()); 
            var dirList = Directory.GetDirectories(path.ToString());
            var filesList = Directory.GetFiles(path.ToString());
            foreach(var file in filesList)
            {
                var fileName = file.ToString();
                if (fileName.Contains("ini"))
                {
                    continue;
                }

                insertDirNode.Nodes.Add(new TreeNode(fileName));        
            }

            foreach (var dir in dirList)
            {
                AddFileSystemNodesRecursive(insertDirNode, dir);
            }

            if (parent == null)
            {
                treeView_FileSystem.Nodes.Add(insertDirNode);
            }

            else
            {
                parent.Nodes.Add(insertDirNode);    
            }
        }

        private void treeView_FileSystem_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var targetPath = e.Node.Text;
            bool doesDirExist = Directory.Exists(targetPath);
            if (doesDirExist)
            {
                var directoriesWithin = Directory.GetDirectories(targetPath);

            }
            else
            {
                //Directory does not exist
                Debug.Assert(false);

            }

        }
    }
}
