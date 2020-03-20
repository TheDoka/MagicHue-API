using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;


namespace MagicHue___Controler
{


    public partial class Form1 : Form
    {
        public MagicHueAPI Instance = new MagicHueAPI();
        static Settings settings_form;
        static Form1 FormOne;

        public Form1()
        {
            InitializeComponent();
            FormOne = this;
            settings_form = new Settings(FormOne);
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
         
            settings_form.Show();
        }
    
        public void FillWith(DeviceInfo[] Devices)
        {

            for (int i = 0; i < Devices.Length; i++)
            {
                listView1.Items.Add(new ListViewItem(new string[] { Devices[i].deviceName, Devices[i].isOnline.ToString(), Devices[i].macAddress}));
            }

        }

        private void getAssociatedDevicesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Instance.IsLogged())
            { 
                
                DeviceInfo[] a = Instance.GetAssociatedDevices();
                for (int i = 0; i < a.Length; i++)
                {

                    if ( controllerExist(a[i].macAddress) )
                    {
                        MessageBox.Show("Device is already in the list.");
                    } else {
                        FillWith(a);
                    }

                }

            } else {
                MessageBox.Show("Can't get user devices, please login.");
            }

        }

        private bool controllerExist(string MAC)
        {
            int i = 0;
            while (i < listView1.Items.Count && listView1.Items[i].SubItems[2].Text.ToLower() != MAC.ToLower())
            {
                i++;
            }
          
            return i < listView1.Items.Count;
        }

        private void turnOnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Instance.TurnOn(listView1.SelectedItems[0].SubItems[2].Text, "71230fa3");
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured, the device may be unavailable.");
            }
            
        }

        private void turnOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Instance.TurnOff(listView1.SelectedItems[0].SubItems[2].Text);
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured, the device may be unavailable.");
            }
        }

        public void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void addDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string MAC = null;
            MAC = Interaction.InputBox("MAC", "", "", -1, -1);
            if (!controllerExist(MAC))
            {
                listView1.Items.Add(new ListViewItem(new string[] { "", "", MAC }));
            } else {
                MessageBox.Show("Device already exists.");
            }


        }

        private void SetColor(string title, string MAC, string hexColor)
        {

            if (Instance.IsLogged())
            {
                if (hexColor == null)
                {
                    hexColor = Interaction.InputBox("Color", "", "", -1, -1);
                }

                if (MAC == null)
                { 
                    if (listView1.Items.Count > 0)
                    { 
                        Instance.TurnOn(listView1.SelectedItems[0].SubItems[2].Text, hexColor);
                    } else {
                        MessageBox.Show("Please add at least one device.");
                    }
                } else {
                    Instance.TurnOn(MAC, hexColor);
                }


            }
            else
            {
                MessageBox.Show("Can't get user devices, please login.");
            }
        }

        private void sendColorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SetColor("Color", null, null);

        }

        private void deleteDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Remove(listView1.SelectedItems[0]);
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetColor("Color", null, "00ff00");
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetColor("Color", null, "ff0000");
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetColor("Color", null, "0000ff"); 
        }

        private void turnOnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Instance.IsLogged())
            {
                DeviceInfo[] z = Instance.GetAssociatedDevices();
                for (int i = 0; i < z.Length; i++)
                {
                    Instance.TurnOn(z[i].macAddress, "0000ff");
                }
            }
            else
            {
                MessageBox.Show("Can't get user devices, please login.");
            }
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {


        }

        private void turnOffToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Instance.IsLogged())
            {
                DeviceInfo[] z = Instance.GetAssociatedDevices();
                for (int i = 0; i < z.Length; i++)
                {
                    Instance.TurnOff(z[i].macAddress);
                }
            }
            else
            {
                MessageBox.Show("Can't get user devices, please login.");
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SetColor("Color", null, "00ff00");
        }

        private void red2_Click(object sender, EventArgs e)
        {
            SetColor("Color", null, "ff0000");
        }

        private void blue2_Click(object sender, EventArgs e)
        {
            SetColor("Color", null, "0000ff");
        }

        private void listView1_MouseUp(object sender, MouseEventArgs e)
        {
            if (listView1.Items.Count > 0)
            {

                if (listView1.SelectedItems.Count < 1)
                {
                    FormOne.listView1.Items[0].Selected = true;
                    FormOne.listView1.Select();
                    FormOne.listView1.EnsureVisible(0);
                }

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }


    public class Device
    {
        public DeviceInfo[] data { get; set; }
    }

    public class DeviceInfo
    {
        public int deviceType { get; set; }
        public int ledVersionNum { get; set; }
        public string moduleID { get; set; }
        public string macAddress { get; set; }
        public string timeZoneID { get; set; }
        public int dstOffset { get; set; }
        public int rawOffset { get; set; }
        public string deviceName { get; set; }
        public object state { get; set; }
        public object firmwareVer { get; set; }
        public object routerSSID { get; set; }
        public object localIP { get; set; }
        public int routerRssi { get; set; }
        public bool isOnline { get; set; }
    }


}
