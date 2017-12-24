namespace ClipHisto
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.rightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.startWithPCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainListbox = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.PictureBox();
            this.clearlist_button = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.rightClickMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.rightClickMenu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "ClipHisto";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // rightClickMenu
            // 
            this.rightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator2,
            this.startWithPCToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.rightClickMenu.Name = "contextMenuStrip1";
            this.rightClickMenu.Size = new System.Drawing.Size(143, 126);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(139, 6);
            // 
            // startWithPCToolStripMenuItem
            // 
            this.startWithPCToolStripMenuItem.Checked = true;
            this.startWithPCToolStripMenuItem.CheckOnClick = true;
            this.startWithPCToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.startWithPCToolStripMenuItem.Name = "startWithPCToolStripMenuItem";
            this.startWithPCToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.startWithPCToolStripMenuItem.Text = "Start with PC";
            this.startWithPCToolStripMenuItem.CheckedChanged += new System.EventHandler(this.startWithPCToolStripMenuItem_CheckedChanged);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemsToolStripMenuItem,
            this.itemsToolStripMenuItem1,
            this.itemsToolStripMenuItem2,
            this.itemsToolStripMenuItem3,
            this.itemsToolStripMenuItem4});
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.historyToolStripMenuItem.Text = "History ";
            // 
            // itemsToolStripMenuItem
            // 
            this.itemsToolStripMenuItem.CheckOnClick = true;
            this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            this.itemsToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.itemsToolStripMenuItem.Text = "10 items";
            this.itemsToolStripMenuItem.Click += new System.EventHandler(this.itemsToolStripMenuItem_Click);
            // 
            // itemsToolStripMenuItem1
            // 
            this.itemsToolStripMenuItem1.CheckOnClick = true;
            this.itemsToolStripMenuItem1.Name = "itemsToolStripMenuItem1";
            this.itemsToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.itemsToolStripMenuItem1.Text = "20 items";
            this.itemsToolStripMenuItem1.Click += new System.EventHandler(this.itemsToolStripMenuItem1_Click);
            // 
            // itemsToolStripMenuItem2
            // 
            this.itemsToolStripMenuItem2.CheckOnClick = true;
            this.itemsToolStripMenuItem2.Name = "itemsToolStripMenuItem2";
            this.itemsToolStripMenuItem2.Size = new System.Drawing.Size(118, 22);
            this.itemsToolStripMenuItem2.Text = "30 items";
            this.itemsToolStripMenuItem2.Click += new System.EventHandler(this.itemsToolStripMenuItem2_Click);
            // 
            // itemsToolStripMenuItem3
            // 
            this.itemsToolStripMenuItem3.CheckOnClick = true;
            this.itemsToolStripMenuItem3.Name = "itemsToolStripMenuItem3";
            this.itemsToolStripMenuItem3.Size = new System.Drawing.Size(118, 22);
            this.itemsToolStripMenuItem3.Text = "40 items";
            this.itemsToolStripMenuItem3.Click += new System.EventHandler(this.itemsToolStripMenuItem3_Click);
            // 
            // itemsToolStripMenuItem4
            // 
            this.itemsToolStripMenuItem4.CheckOnClick = true;
            this.itemsToolStripMenuItem4.Name = "itemsToolStripMenuItem4";
            this.itemsToolStripMenuItem4.Size = new System.Drawing.Size(118, 22);
            this.itemsToolStripMenuItem4.Text = "50 items";
            this.itemsToolStripMenuItem4.Click += new System.EventHandler(this.itemsToolStripMenuItem4_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(139, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mainListbox
            // 
            this.mainListbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainListbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainListbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.mainListbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainListbox.FormattingEnabled = true;
            this.mainListbox.ItemHeight = 32;
            this.mainListbox.Location = new System.Drawing.Point(16, 42);
            this.mainListbox.Name = "mainListbox";
            this.mainListbox.Size = new System.Drawing.Size(263, 320);
            this.mainListbox.TabIndex = 1;
            this.mainListbox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            this.mainListbox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Double click to copy";
            // 
            // close
            // 
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(264, 8);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(18, 23);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 3;
            this.close.TabStop = false;
            this.toolTip1.SetToolTip(this.close, "Hide");
            this.close.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // clearlist_button
            // 
            this.clearlist_button.ActiveLinkColor = System.Drawing.Color.SteelBlue;
            this.clearlist_button.AutoSize = true;
            this.clearlist_button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearlist_button.LinkColor = System.Drawing.Color.DodgerBlue;
            this.clearlist_button.Location = new System.Drawing.Point(227, 370);
            this.clearlist_button.Name = "clearlist_button";
            this.clearlist_button.Size = new System.Drawing.Size(51, 15);
            this.clearlist_button.TabIndex = 4;
            this.clearlist_button.TabStop = true;
            this.clearlist_button.Text = "Clear All";
            this.toolTip1.SetToolTip(this.clearlist_button, "Clear all items in the list");
            this.clearlist_button.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(40, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "ClipHisto";
            // 
            // icon
            // 
            this.icon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icon.Image = ((System.Drawing.Image)(resources.GetObject("icon.Image")));
            this.icon.Location = new System.Drawing.Point(19, 10);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(20, 24);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon.TabIndex = 6;
            this.icon.TabStop = false;
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.SystemColors.MenuBar;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(295, 395);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clearlist_button);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainListbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ClipHisto";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.rightClickMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip rightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListBox mainListbox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.ToolStripMenuItem startWithPCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.LinkLabel clearlist_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

