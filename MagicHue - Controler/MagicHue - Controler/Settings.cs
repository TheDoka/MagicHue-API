using System;
using System.Windows.Forms;

namespace MagicHue___Controler
{
    public partial class Settings : Form
    {

        public MagicHueAPI Instance = new MagicHueAPI();
        static Form1 FormOne;

        public Settings(Form1 frm)
        {
            InitializeComponent();
            FormOne = frm;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (LoginButton.Text == "Login")
            { 

                if ( Instance.Login(mailBox.Text, passBox.Text) )
                {
                    MessageBox.Show("Logged in!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormOne.listView1.Items.Clear();
                    FormOne.FillWith(Instance.GetAssociatedDevices());

                    FormOne.listView1.Enabled = true;
                    if (FormOne.listView1.Items.Count > 0)
                    {
                        FormOne.listView1.Items[0].Selected = true;
                        FormOne.listView1.Select();
                        FormOne.listView1.EnsureVisible(0);
                    }
                    FormOne.toolStripMenuItem1.Enabled = true;
                    FormOne.turnOnToolStripMenuItem1.Enabled = true;
                    FormOne.turnOffToolStripMenuItem1.Enabled = true;

                    FormOne.toolStripSplitButton1.Enabled = true;

                    FormOne.toolStripStatusLabel1.Text = "Logged in.";
                    FormOne.Instance = Instance;
                    LoginButton.Text = "Disconnect";
                    mailBox.Enabled = false;
                    passBox.Enabled = false;
                    this.Hide();

                } else {
                    MessageBox.Show("Login failed, please try again.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else {

                LoginButton.Text = "Login";
                mailBox.Enabled = true;
                passBox.Enabled = true;
                FormOne.listView1.Enabled = false;
                FormOne.contextMenuStrip2.Enabled = false;
                FormOne.toolStripMenuItem1.Enabled = false;
                FormOne.turnOnToolStripMenuItem1.Enabled = false;
                FormOne.turnOffToolStripMenuItem1.Enabled = false;
                FormOne.toolStripSplitButton1.Enabled = false;

                FormOne.toolStripStatusLabel1.Text = "Not logged in, please login.";
            }
            
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }
    }
}
