namespace MagicHue___Controler
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.SettingsButton = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.DeviceName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DeviceStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DeviceAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getAssociatedDevicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnOnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.turnOnToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.turnOffToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.green2 = new System.Windows.Forms.ToolStripMenuItem();
            this.red2 = new System.Windows.Forms.ToolStripMenuItem();
            this.blue2 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorWheel1 = new MechanikaDesign.WinForms.UI.ColorPicker.ColorWheel();
            this.label2 = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsButton,
            this.toolStripSplitButton1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 173);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(310, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // SettingsButton
            // 
            this.SettingsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SettingsButton.DropDownButtonWidth = 0;
            this.SettingsButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingsButton.Image")));
            this.SettingsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(21, 20);
            this.SettingsButton.Text = "SettingsButton";
            this.SettingsButton.ToolTipText = "Settings";
            this.SettingsButton.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(152, 17);
            this.toolStripStatusLabel1.Text = "Not logged in, please login.";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DeviceName,
            this.DeviceStatus,
            this.DeviceAddress});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Enabled = false;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(286, 150);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseUp);
            // 
            // DeviceName
            // 
            this.DeviceName.Text = "Device";
            this.DeviceName.Width = 92;
            // 
            // DeviceStatus
            // 
            this.DeviceStatus.Text = "Status";
            this.DeviceStatus.Width = 43;
            // 
            // DeviceAddress
            // 
            this.DeviceAddress.Text = "Device MAC Address";
            this.DeviceAddress.Width = 150;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDeviceToolStripMenuItem,
            this.deleteDeviceToolStripMenuItem,
            this.getAssociatedDevicesToolStripMenuItem,
            this.turnOnToolStripMenuItem,
            this.turnOffToolStripMenuItem,
            this.sendColorToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(196, 136);
            // 
            // addDeviceToolStripMenuItem
            // 
            this.addDeviceToolStripMenuItem.Name = "addDeviceToolStripMenuItem";
            this.addDeviceToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.addDeviceToolStripMenuItem.Text = "Add Device";
            this.addDeviceToolStripMenuItem.Click += new System.EventHandler(this.addDeviceToolStripMenuItem_Click);
            // 
            // deleteDeviceToolStripMenuItem
            // 
            this.deleteDeviceToolStripMenuItem.Name = "deleteDeviceToolStripMenuItem";
            this.deleteDeviceToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.deleteDeviceToolStripMenuItem.Text = "Delete Device";
            this.deleteDeviceToolStripMenuItem.Click += new System.EventHandler(this.deleteDeviceToolStripMenuItem_Click);
            // 
            // getAssociatedDevicesToolStripMenuItem
            // 
            this.getAssociatedDevicesToolStripMenuItem.Name = "getAssociatedDevicesToolStripMenuItem";
            this.getAssociatedDevicesToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.getAssociatedDevicesToolStripMenuItem.Text = "Get Associated Devices";
            this.getAssociatedDevicesToolStripMenuItem.Click += new System.EventHandler(this.getAssociatedDevicesToolStripMenuItem_Click);
            // 
            // turnOnToolStripMenuItem
            // 
            this.turnOnToolStripMenuItem.Name = "turnOnToolStripMenuItem";
            this.turnOnToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.turnOnToolStripMenuItem.Text = "Turn On";
            this.turnOnToolStripMenuItem.Click += new System.EventHandler(this.turnOnToolStripMenuItem_Click);
            // 
            // turnOffToolStripMenuItem
            // 
            this.turnOffToolStripMenuItem.Name = "turnOffToolStripMenuItem";
            this.turnOffToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.turnOffToolStripMenuItem.Text = "Turn Off";
            this.turnOffToolStripMenuItem.Click += new System.EventHandler(this.turnOffToolStripMenuItem_Click);
            // 
            // sendColorToolStripMenuItem
            // 
            this.sendColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.greenToolStripMenuItem,
            this.redToolStripMenuItem,
            this.blueToolStripMenuItem});
            this.sendColorToolStripMenuItem.Name = "sendColorToolStripMenuItem";
            this.sendColorToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.sendColorToolStripMenuItem.Text = "SendColor";
            this.sendColorToolStripMenuItem.Click += new System.EventHandler(this.sendColorToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip2;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.turnOnToolStripMenuItem1,
            this.turnOffToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(181, 114);
            // 
            // turnOnToolStripMenuItem1
            // 
            this.turnOnToolStripMenuItem1.Enabled = false;
            this.turnOnToolStripMenuItem1.Name = "turnOnToolStripMenuItem1";
            this.turnOnToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.turnOnToolStripMenuItem1.Text = "Turn On";
            this.turnOnToolStripMenuItem1.Click += new System.EventHandler(this.turnOnToolStripMenuItem1_Click);
            // 
            // turnOffToolStripMenuItem1
            // 
            this.turnOffToolStripMenuItem1.Enabled = false;
            this.turnOffToolStripMenuItem1.Name = "turnOffToolStripMenuItem1";
            this.turnOffToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.turnOffToolStripMenuItem1.Text = "Turn Off";
            this.turnOffToolStripMenuItem1.Click += new System.EventHandler(this.turnOffToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.green2,
            this.red2,
            this.blue2});
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "SendColor";
            // 
            // green2
            // 
            this.green2.Name = "green2";
            this.green2.Size = new System.Drawing.Size(181, 22);
            this.green2.Text = "Green";
            this.green2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // red2
            // 
            this.red2.Name = "red2";
            this.red2.Size = new System.Drawing.Size(181, 22);
            this.red2.Text = "Red";
            this.red2.Click += new System.EventHandler(this.red2_Click);
            // 
            // blue2
            // 
            this.blue2.Name = "blue2";
            this.blue2.Size = new System.Drawing.Size(181, 22);
            this.blue2.Text = "Blue";
            this.blue2.Click += new System.EventHandler(this.blue2_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // colorWheel1
            // 
            this.colorWheel1.BackColor = System.Drawing.Color.DimGray;
            this.colorWheel1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorWheel1.Location = new System.Drawing.Point(310, 12);
            this.colorWheel1.Name = "colorWheel1";
            this.colorWheel1.Size = new System.Drawing.Size(150, 150);
            this.colorWheel1.TabIndex = 4;
            this.colorWheel1.Text = "colorWheel1";
            this.colorWheel1.ColorChanged += new System.EventHandler(this.colorWheel1_ColorChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(324, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 6;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(460, 12);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(13, 150);
            this.vScrollBar1.TabIndex = 7;
            this.vScrollBar1.Value = 100;
            this.vScrollBar1.ValueChanged += new System.EventHandler(this.vScrollBar1_ValueChanged);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownButtonWidth = 0;
            this.toolStripSplitButton1.Enabled = false;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(21, 20);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(311, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(310, 195);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.colorWheel1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Magic Home - Controller ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ColumnHeader DeviceName;
        private System.Windows.Forms.ColumnHeader DeviceStatus;
        private System.Windows.Forms.ColumnHeader DeviceAddress;
        private System.Windows.Forms.ToolStripSplitButton SettingsButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDeviceToolStripMenuItem;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolStripMenuItem getAssociatedDevicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turnOnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turnOffToolStripMenuItem;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem sendColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem green2;
        private System.Windows.Forms.ToolStripMenuItem red2;
        private System.Windows.Forms.ToolStripMenuItem blue2;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        public System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem turnOnToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem turnOffToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label label2;
        private MechanikaDesign.WinForms.UI.ColorPicker.ColorWheel colorWheel1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        public System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.Label label1;
    }
}

