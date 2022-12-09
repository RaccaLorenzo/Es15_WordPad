using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es15_WordPad
{
    public partial class frmWordPad : Form
    {
        clsFile filemanager;
        public frmWordPad()
        {
            InitializeComponent();
        }

        private void frmWordPad_Load(object sender, EventArgs e)
        {
            filemanager = new clsFile();
        }

        private void SalvaToolStripButton_Click(object sender, EventArgs e)
        {
            filemanager.salva(RtxtTesto);
        }
    }
}
