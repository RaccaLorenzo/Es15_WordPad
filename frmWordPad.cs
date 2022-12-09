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

        private void SalvaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filemanager.salva(RtxtTesto);
        }

        private void SalvaconnomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filemanager.SalvaConNome("Ciao",RtxtTesto);
        }

        private void TagliaToolStripButton_Click(object sender, EventArgs e)
        {
            this.taglia();
        }

        private void TagliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.taglia();
        }

        private void CopiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.copia();
        }
        private void CopiaToolStripButton_Click(object sender, EventArgs e)
        {
            this.copia();
        }

        private void IncollaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.incolla();
        }

        private void IncollaToolStripButton_Click(object sender, EventArgs e)
        {
            this.incolla();
        }


        private void taglia()
        {
            RtxtTesto.Cut();
        }


        private void incolla()
        {
            RtxtTesto.Paste();
        }


        private void copia()
        {
            RtxtTesto.Copy();
        }
    }
}
