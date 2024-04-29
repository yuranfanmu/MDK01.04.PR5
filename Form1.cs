
namespace MDK01._04.PR5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            start();
        }

        private void AddSysInfoItem(string property, string value)
        {
            ListViewItem lvt;
            lvt = listView1.Items.Add(property);
            lvt.SubItems.Add(value);
        }

        private void start()
        {
            // Получим системную информацию для локальной машины.

            AddSysInfoItem("ComputerName", SystemInformation.ComputerName.ToString());

            AddSysInfoItem("UserDomainName", SystemInformation.UserDomainName.ToString());

            AddSysInfoItem("UserName", SystemInformation.UserName.ToString());

            AddSysInfoItem("Network", SystemInformation.Network.ToString());

            AddSysInfoItem("Secure", SystemInformation.Secure.ToString());

            AddSysInfoItem("Monitor Count", SystemInformation.MonitorCount.ToString());

            AddSysInfoItem("MousePresent", SystemInformation.MousePresent.ToString());

            AddSysInfoItem("MouseButtons", SystemInformation.MouseButtons.ToString());

            AddSysInfoItem("HouseButtonsSwapped", SystemInformation.MouseButtonsSwapped.ToString());

            AddSysInfoItem("Mouse Wheel", SystemInformation.MouseWheelPresent.ToString());

            AddSysInfoItem("UserInteractive", SystemInformation.UserInteractive.ToString());
        }

    }
}
