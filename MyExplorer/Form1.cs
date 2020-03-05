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

namespace MyExplorer
{
    public partial class Form1 : Form
    {
        string currentDir = @"C:\Users\gcep650\";
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add("a");
            treeView1.Nodes.Add("b");
            treeView1.Nodes.Add("c");

            for (int i = 0; i < 50; i++)
            {
                listView1.Items.Add(i.ToString());
            }
            ListViewItem h = listView1.Items.Add("hi");
            Random r = new Random();

            foreach (ListViewItem item in listView1.Items)
            {
                item.ImageIndex = r.Next(0, imageList1.Images.Count);
            }
            h.SubItems.Add("hi2");
            h.ImageIndex = 45;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void doubled(object sender, EventArgs e)
        {
            ListViewItem current = listView1.Items[listView1.SelectedItems[0].Index];
            TreeNode parentFolder = treeView1.SelectedNode;
            if (current.SubItems[1].Text.Equals("Directory"))
            {
                string newDir = "";
                //MessageBox.Show(currentDir);
                newDir = Path.Combine(currentDir, parentFolder.Text, current.Text + "\\");
                //newDir = System.IO.Path.Combine(currentDir, current.Text);
                MessageBox.Show(newDir);
                currentDir = newDir;
                loadDir(currentDir);
            }
            else if(current.SubItems[1].Text.Equals("Image"))
            {
                panel1.Controls.Clear();
                string newDir = Path.Combine(currentDir, parentFolder.Text, current.Text);
                //PhotoViewer viewer = new PhotoViewer(newDir);
                PictureBox temp = new PictureBox();
                temp.Load(newDir);
                FileExInfo viewer = new FileExInfo(current.SubItems[0].Text, temp.Image, imageList1.Images[current.ImageIndex], current.SubItems[1].Text, DateTime.Parse(current.SubItems[2].Text), bool.Parse(current.SubItems[3].Text));
                viewer.TopLevel = false;
                viewer.Parent = panel1;
                viewer.Size = panel1.Size;
                viewer.Show();
            }
            else if (current.SubItems[1].Text.Equals("Text document"))
            {
                panel1.Controls.Clear();
                string newDir = Path.Combine(currentDir, parentFolder.Text, current.Text);
                FileInfo f = new FileInfo(newDir);
                
                FileExInfo viewer = new FileExInfo(current.SubItems[0].Text, f.OpenText().ReadToEnd(), imageList1.Images[current.ImageIndex], current.SubItems[1].Text, DateTime.Parse(current.SubItems[2].Text), bool.Parse(current.SubItems[3].Text));
                viewer.TopLevel = false;
                viewer.Parent = panel1;
                viewer.Size = panel1.Size;
                viewer.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.SelectedImageIndex = 4;
            loadDir(currentDir);
        }

        private void loadDir(string dir)
        {
            treeView1.Nodes.Clear();
            TreeNode start = treeView1.Nodes.Add(dir);
            start.ImageIndex = 3;
            loadDirR(dir, start);
            /*foreach (string item in Directory.GetDirectories(dir))
            {
                TreeNode t = treeView1.Nodes.Add(item);
                t.ImageIndex = 3;

            }
            */

        }

        private void loadDirR(string dir, TreeNode t)
        {
            try
            {
                if (Directory.GetDirectories(dir).Count() < 1) { return; }
            }
            catch (Exception)
            {
                return;
            }
            
            foreach (string item in Directory.GetDirectories(dir))
            {
                Console.WriteLine(item);
                TreeNode node = t.Nodes.Add(item);
                //node.Name = "h";
                node.ImageIndex = 3;
                loadDirR(item, node);
            }
        }


        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listView1.Items.Clear();
            string[] split;
            try
            {
                foreach (string dir in Directory.GetDirectories(e.Node.Text))
                {
                    split = dir.Split('\\');
                    ListViewItem item = listView1.Items.Add(split[split.Length - 1]);
                    item.SubItems.Add(getFileType("dir"));
                    item.ImageIndex = 3;
                }

                foreach (string file in Directory.GetFiles(e.Node.Text))
                {
                    split = file.Split('\\');
                    ListViewItem f = listView1.Items.Add(split[split.Length - 1]);
                    FileInfo cFile = new FileInfo(file);
                    f.ImageIndex = getExtIndex(cFile.Extension);
                    f.SubItems.Add(getFileType(cFile.Extension));
                    f.SubItems.Add(cFile.LastWriteTime.ToShortDateString());
                    f.SubItems.Add(cFile.IsReadOnly.ToString());

                }
            }
            catch (System.UnauthorizedAccessException)
            {
                MessageBox.Show("You cannot access that directory.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private int getExtIndex(string ext)
        {
            switch (ext.ToLower())
            {
                case ".exe":
                    return 2;
                case ".png":
                case ".jpg":
                case ".bmp":
                case ".gif":
                case ".jpeg":
                    return 117;
                case ".txt":
                    return 70;
                case ".zip":
                case ".rar":
                    return 35;
                case ".pdf":
                    return 1;
                case ".ini":
                    return 69;
                case ".dll":
                    return 72;
                case ".xml":
                case ".html":
                    return 91;
                default:
                    return 0;
            }
        }

        private string getFileType(string ext)
        {
            switch (ext.ToLower())
            {
                case "dir":
                    return "Directory";
                case ".exe":
                    return "Executable";
                case ".png":
                case ".jpg":
                case ".bmp":
                case ".gif":
                case ".jpeg":
                    return "Image";
                case ".txt":
                    return "Text document";
                case ".zip":
                case ".rar":
                    return "Compressed archive";
                case ".pdf":
                    return "PDF Document";
                case ".ini":
                    return "Configuration settings";
                case ".dll":
                    return "Application extension";
                case ".xml":
                case ".html":
                    return "Web document";
                default:
                    return ext + " File";
            }
        }
    }
}
