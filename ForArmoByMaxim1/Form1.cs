using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ForArmoByMaxim1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (File.Exists("Searth.txt"))
            {
                tbCatalog.Text = File.ReadAllText("Searth.txt");
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnMore_Click_1(object sender, EventArgs e)
        {
            try
            {
                btnClear_Click(sender, e);
                DirectoryInfo dir = new DirectoryInfo(this.tbCatalog.Text);
                string searth = tbFname.Text;
                if (string.IsNullOrWhiteSpace(searth))
                {
                    searth = "*";
                }
                FindInDir(dir, searth, this.cbFdir.Checked);
                ListDirectory(treeView1, tbCatalog.Text);
                File.WriteAllText("Searth.txt", dir.FullName);
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void FindInDir(DirectoryInfo dir, string pattern, bool recursive)
        {
            foreach (FileInfo file in dir.GetFiles(pattern))
            {
                this.lbResult.Items.Add(file.Name);
            }
            if (recursive)
            {
                foreach (DirectoryInfo subdir in dir.GetDirectories())
                {
                    this.FindInDir(subdir, pattern, recursive);
                }
            }
        }

        public void FindFiles(string dir, string pattern)
        {
            this.FindInDir(new DirectoryInfo(dir), pattern, true);
        }

        


      
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.lbResult.Items.Clear();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            this.tbFname.Text = "";
            this.tbCatalog.Text = "";
            this.lbResult.Items.Clear();
            this.treeView1.Nodes.Clear();
        }

        private void lbAnswer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Process.Start(this.lbResult.SelectedItem.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.fBDialog.ShowDialog() == DialogResult.OK)
            {
                this.tbCatalog.Text = this.fBDialog.SelectedPath;
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void ListDirectory(TreeView treeView, string path)
        {
            treeView.Nodes.Clear();
            var rootDirectoryInfo = new DirectoryInfo(path);
            treeView.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));
        }

        private static TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            var directoryNode = new TreeNode(directoryInfo.Name);
            foreach (var directory in directoryInfo.GetDirectories())
                directoryNode.Nodes.Add(CreateDirectoryNode(directory));
            foreach (var file in directoryInfo.GetFiles())
                directoryNode.Nodes.Add(new TreeNode(file.Name));
            return directoryNode;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
