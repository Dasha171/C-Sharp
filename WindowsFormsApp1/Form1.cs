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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string s = treeView1.SelectedNode.Text;
            MessageBox.Show(s);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            if(node == null)
            {
                treeView1.Nodes.Add(textBox1.Text);
            }
            else
            {
                node.Nodes.Add(textBox1.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void openFileDialog3_FileOk(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string fileNam2 = openFileDialog1.FileName;
            FileStream stream = File.Open(fileNam2, FileMode.Open, FileAccess.Read);
            if(stream != null)
            {
                StreamReader reader = new StreamReader(stream);
                textBox2.Text = reader.ReadToEnd();
                stream.Close();
            }
            string s = "";
            int num_node=0;
            for(int i = 0; i < textBox2.Lines.Count()-1; i++)
            {
                s = textBox2.Lines[i];
                if (s[0] != ' ')
                {
                    treeView1.Nodes.Add(s);
                    num_node++;
                }
                else
                {
                    TreeNode node = treeView1.Nodes[num_node-1];
                    node.Nodes.Add(s);
                }

            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string fileName = saveFileDialog1.FileName;
            FileStream stream = File.Open(fileName, FileMode.Create, FileAccess.Write);
            if(stream != null)
            {
                StreamWriter writer = new StreamWriter(stream);
                writer.Write(textBox2.Text);
                writer.Flush();
                writer.Close();
            }
        }
    }
}
