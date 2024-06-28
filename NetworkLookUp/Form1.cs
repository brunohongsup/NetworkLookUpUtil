using System.Diagnostics;
using System.Text;
using System.Net.NetworkInformation;

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
            comboBox_NetworkInterface.Items.Clear();    
            comboBox_NetworkInterface.DataBindings.Clear(); 
            var bindingSource = new BindingSource();    
            var adapters = NetworkInterface.GetAllNetworkInterfaces();   
            var networkDesc = new List<NetworkAdapterDesc>();
            var stringBuilder = new StringBuilder();
            foreach(var adapter in adapters)
            {
                Debug.Assert(adapter != null);
                var adapterDesc = new NetworkAdapterDesc();   
                adapterDesc.Adapter = adapter;
                var adapterName = adapter.Name;
                var adapterType = adapter.NetworkInterfaceType;
                var adapterDescription = adapter.Description;
                var adapterProperties = adapter.GetIPProperties();  
                var uniCast = adapterProperties.UnicastAddresses;
                foreach(var uni in uniCast)
                {
                    var ipAddress = uni.Address;
                }
                var physiclAddress = adapter.GetPhysicalAddress();
                stringBuilder.AppendFormat($"{adapterName} ({adapterType}) - {adapterDescription}");
                adapterDesc.Desc = stringBuilder.ToString();
                networkDesc.Add( adapterDesc );
                stringBuilder.Clear();
            }

            bindingSource.DataSource = networkDesc; 
            comboBox_NetworkInterface.DataSource = bindingSource;
            comboBox_NetworkInterface.DisplayMember = "Desc";
            comboBox_NetworkInterface.ValueMember = "Adapter";
        }
    }
}
