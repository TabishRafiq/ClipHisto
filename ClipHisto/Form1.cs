using Microsoft.Win32;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClipHisto
{
    public partial class Form1 : Form
    {
        
        string lastData;
        public Form1()
        {
            this.Visible = false;
            InitializeComponent();
            if (System.Diagnostics.Process.GetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location)).Length > 1)
            {
                notifyIcon1.ShowBalloonTip(1, "ClipHisto", "The application is already running in backgorund.", ToolTipIcon.Warning);
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }           
            notifyIcon1.ShowBalloonTip(1, "ClipHisto", "Your application is here in system tray. Double click icon to launch.", ToolTipIcon.None);
        }
        private void SetStartup()
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (ClipHisto.Properties.Settings.Default.start_with_pc == true)
            rk.SetValue("ClipHisto", Application.ExecutablePath.ToString());
            else
            rk.DeleteValue("ClipHisto", false);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
         

            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, Screen.PrimaryScreen.Bounds.Height - this.Height-40);
            SetStartup();
            unCheckAll();
            if (Properties.Settings.Default.history_level == 10)
                itemsToolStripMenuItem.Checked = true;
            else if (Properties.Settings.Default.history_level == 20)
                itemsToolStripMenuItem1.Checked = true;
            else if (Properties.Settings.Default.history_level == 30)
                itemsToolStripMenuItem2.Checked = true;
            else if (Properties.Settings.Default.history_level == 40)
                itemsToolStripMenuItem3.Checked = true;
            else
                itemsToolStripMenuItem4.Checked = true;

        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (mainListbox.Items.Count <= 0)
                return;

            var rect = new Rectangle(e.Bounds.X, e.Bounds.Y, mainListbox.Width, 32);
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font, rect,
                                          e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          Color.White,
                                          Color.FromArgb(255, 217, 236, 252)); 

            Brush databr = new SolidBrush(Color.FromArgb(255, 5, 5, 5));
            Brush timebr = new SolidBrush(Color.FromArgb(255, 9, 136, 239));

            e.DrawBackground();
            var co = (clipObject)mainListbox.Items[e.Index];
            Font n = new Font("Segoe UI", 7.5f, FontStyle.Italic);
            e.Graphics.DrawString(textLimiter(co.data,42), e.Font, databr, e.Bounds.X + 5, e.Bounds.Y, StringFormat.GenericDefault);
            e.Graphics.DrawString(co.time, n, timebr, e.Bounds.X + 5, e.Bounds.Y + 17, StringFormat.GenericDefault);
            databr.Dispose();
            timebr.Dispose();
            e.Graphics.Flush();
            e.DrawFocusRectangle();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Clipboard.GetText().ToString() == "")
                return;

            string currentData = Clipboard.GetText();          
            if (currentData != lastData )
            {
                mainListbox.BeginUpdate();

                clipObject co = new clipObject();
                co.data = currentData;
                co.time = DateTime.Now.ToLongTimeString();
                mainListbox.Items.Insert(0, co);
                lastData = currentData;

                if (mainListbox.Items.Count > Properties.Settings.Default.history_level)
                    mainListbox.Items.RemoveAt(Properties.Settings.Default.history_level - 1);

                mainListbox.EndUpdate();
            }
          
        }

        public string textLimiter(string source, int length)
        {
            string final;
            final = source.Split('\n')[0];
            if (source.Length > length)
            {
                try
                {
                    final = final.Substring(0, length);
                    final += "...";
                }
                catch (Exception)
                {
                }
            }
            return final;
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var op = (clipObject)mainListbox.Items[mainListbox.SelectedIndex];
            Clipboard.SetText(op.data);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void startWithPCToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            ClipHisto.Properties.Settings.Default.start_with_pc = startWithPCToolStripMenuItem.Checked;
            ClipHisto.Properties.Settings.Default.Save();
        }
        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unCheckAll();
            itemsToolStripMenuItem.Checked = true;
            Properties.Settings.Default.history_level = 10;
            Properties.Settings.Default.Save();
        }

        private void unCheckAll()
        {
            itemsToolStripMenuItem.Checked = false;
            itemsToolStripMenuItem1.Checked = false;
            itemsToolStripMenuItem2.Checked = false;
            itemsToolStripMenuItem3.Checked = false;
            itemsToolStripMenuItem4.Checked = false;    
        }
        private void itemsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            unCheckAll();
            itemsToolStripMenuItem1.Checked = true;
            Properties.Settings.Default.history_level = 20;
            Properties.Settings.Default.Save();
        }

        private void itemsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            unCheckAll();
            itemsToolStripMenuItem2.Checked = true;
            Properties.Settings.Default.history_level = 30;
            Properties.Settings.Default.Save();
        }

        private void itemsToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            unCheckAll();
            itemsToolStripMenuItem3.Checked = true;
            Properties.Settings.Default.history_level = 40;
            Properties.Settings.Default.Save();
        }

        private void itemsToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            unCheckAll();
            itemsToolStripMenuItem4.Checked = true;
            Properties.Settings.Default.history_level = 50;
            Properties.Settings.Default.Save();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainListbox.Items.Clear();
            GC.Collect();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.Silver, ButtonBorderStyle.Solid);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about aboutbox = new about();
            aboutbox.ShowDialog();
        }

        private void mainListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool IsAlreadyOpen(Type formType)

        {
           bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == formType)
                {
                    f.BringToFront();
                    f.WindowState = FormWindowState.Normal;
                    MessageBox.Show("Already open");
                    isOpen = true;
                }
            }
            return isOpen;
        }
    }
    public class clipObject
        {
        public string data;
        public string time;
        }

}
