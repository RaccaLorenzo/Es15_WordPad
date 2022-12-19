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

        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void SinistraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RtxtTesto.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void CentroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RtxtTesto.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void DestraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RtxtTesto.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void puntatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RtxtTesto.SelectionBullet = true;
        }

        private void numeratiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuovoToolStripButton_Click(object sender, EventArgs e)
        {
            nuovo();
        }

        private void RtxtTesto_TextChanged(object sender, EventArgs e) => filemanager.Modificato = true;

        private void apriToolStripButton_Click(object sender, EventArgs e)
        {
            filemanager.ApriFile(RtxtTesto);
        }

        private void nuovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuovo();
        }


        private void nuovo()
        {

            if (filemanager.Modificato)
            {
                DialogResult dr = MessageBox.Show("Vuoi salvare", "WordPad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    filemanager.salva(RtxtTesto);
                    filemanager.Filename = "";
                    filemanager.Modificato = false;
                    RtxtTesto.Clear();
                }

            }

        }

        private void apriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filemanager.ApriFile(RtxtTesto);
        }

        private void fontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = RtxtTesto.Font;
            fd.ShowDialog();
            RtxtTesto.Font = fd.Font;
        }

        private void coloreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = RtxtTesto.ForeColor;
            cd.ShowDialog();
            RtxtTesto.ForeColor = cd.Color;
        }

        private void EsciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void AnnullaToolStripButton_Click(object sender, EventArgs e)
        {
            annulla();
        }

        private void RipristinaToolStripButton_Click(object sender, EventArgs e)
        {
            ripristina();
        }

        private void AnnullaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            annulla();
        }

        private void RipristinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ripristina();
        }

        private void annulla()
        {
            RtxtTesto.Undo();
        }

        private void ripristina()
        {
            RtxtTesto.Redo();
        }
    }

    
}
