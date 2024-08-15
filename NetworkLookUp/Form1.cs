using System.Diagnostics;
using System.Text;
using System.Net.NetworkInformation;
using System.Net;

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

            var networkPath = textBox_TargetIP.Text;
            var userName = textBox_UserName.Text;
            var password = textBox_Password.Text;
            if(networkPath.Length == 0)
            {
                //Debug.Assert(false);
                //ToDo : 
            }
            
            if(userName.Length == 0)
            {

            }

            var ipProperty = adapter.GetIPProperties();
            var credentials = new NetworkCredential(userName, password);

            using (new SharedFolderConnector(networkPath, credentials))
            {
                var fileList = Directory.GetFiles(networkPath);
                foreach (var item in fileList)
                {
                    treeView_FileSystem.Nodes.Add(item);    
                }
                
            }

        }
    }
}
