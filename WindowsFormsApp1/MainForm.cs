using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;


namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        private ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.IContainer components;
        private ContextMenuStrip contextMenuStrip2;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private ContextMenuStrip contextMenuStrip3;
        private ContextMenuStrip contextMenuStrip4;
        private ContextMenuStrip contextMenuStrip5;
        private TextBox textBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem menuItemOpen;
        private ToolStripMenuItem menuItemSave;
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
        private SaveFileDialog saveFileDialog1;
        private Button button1;
        private ToolStripTextBox toolStripTextBox1;
        public MainForm()
        {
            InitializeComponent();

            Button openFolderButton = new Button();
            openFolderButton.Text = "Открыть папку";
            openFolderButton.Click += OpenFolderButton_Click;
            Controls.Add(openFolderButton);
            Button close = new Button();
            close.Text = "Закрыть";

           

        }
        private void OpenFolderButton_Click(object sender, EventArgs e)
        {
             openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            FileStream stream = File.Open(filename, FileMode.Open, FileAccess.Read);
            if(stream != null)
            {
                StreamReader reader= new StreamReader(stream);
                textBox1.Text = reader.ReadToEnd();
                stream.Close();
            }
         
        }
        private void MenuItemSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string filename2 = saveFileDialog1.FileName;
            FileStream stream = File.Open(filename2, FileMode.Open, FileAccess.Write);
            if(stream != null)
            {
                StreamWriter writer= new StreamWriter(stream);
                writer.Write(textBox1.Text);
                writer.Flush();
                stream.Close();
            }
        }

        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 30);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(633, 348);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(633, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemOpen,
            this.menuItemSave});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
            // 
            // menuItemOpen
            // 
            this.menuItemOpen.Name = "menuItemOpen";
            this.menuItemOpen.Size = new System.Drawing.Size(166, 26);
            this.menuItemOpen.Text = "Открыть";
            this.menuItemOpen.Click += new System.EventHandler(this.OpenFolderButton_Click);
            this.menuItemOpen.DoubleClick += new System.EventHandler(this.menuItemOpen_DoubleClick);
            // 
            // menuItemSave
            // 
            this.menuItemSave.Name = "menuItemSave";
            this.menuItemSave.Size = new System.Drawing.Size(166, 26);
            this.menuItemSave.Text = "Сохранить";
            this.menuItemSave.Click += new System.EventHandler(this.MenuItemSave_Click);
            this.menuItemSave.DoubleClick += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button1.ForeColor = System.Drawing.Color.Indigo;
            this.button1.Location = new System.Drawing.Point(71, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 22);
            this.button1.TabIndex = 2;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(633, 378);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.MediumBlue;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuItemOpen_DoubleClick(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
