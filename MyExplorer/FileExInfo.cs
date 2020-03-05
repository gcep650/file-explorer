using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyExplorer
{
    public partial class FileExInfo : Form
    {
        public FileExInfo(string name, string text, Image icon, string filetype, DateTime dateModified, bool readOnly)
        {
            InitializeComponent();
            pictureContents.Visible = false;
            fileText.Text = text;
            setContents(name, icon, filetype, dateModified, readOnly);
        }

        public FileExInfo(string name, Image icon, string filetype, DateTime dateModified, bool readOnly)
        {
            InitializeComponent();
            groupBox1.Visible = false;
            setContents(name, icon, filetype, dateModified, readOnly);
        }

        public FileExInfo(string name, Image image, Image icon, string filetype, DateTime dateModified, bool readOnly)
        {
            InitializeComponent();
            fileText.Visible = false;
            pictureContents.Image = image;
            setContents(name, icon, filetype, dateModified, readOnly);
        }

        public void setContents(string name, Image icon, string type, DateTime date, bool readOnly)
        {
            nameL.Text = name;
            iconBox.Image = icon;
            typeL.Text = type;
            dateL.Text = date.ToShortDateString();
            if (readOnly)
            {
                readL.Text = "Yes";
            }
            else { readL.Text = "No"; }
        }
    }
}
