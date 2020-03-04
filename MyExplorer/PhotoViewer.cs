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
    public partial class PhotoViewer : Form
    {
        private string path;
        public PhotoViewer(string imagePath)
        {
            InitializeComponent();
            path = imagePath;
        }

        private void PhotoViewer_Load(object sender, EventArgs e)
        {
            imageBox.Load(path);
        }

        private void zoomIn_Click(object sender, EventArgs e)
        {
            
        }

        private void zoomOut_Click(object sender, EventArgs e)
        {

        }
    }
}
