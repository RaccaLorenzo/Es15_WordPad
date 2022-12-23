using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Es15_WordPad
{
    class clsFile
    {

        //campi privati
        private string filename;
        private bool modificato;
        //property
        public string Filename
        {
            get
            {
                return filename;
            }
            set
            {
                filename = value;
            }
        }
        public bool Modificato
        {
            get
            {
                return modificato;
            }
            set
            {
                modificato = value;
            }
        }
        //costruttore/i
        public clsFile()
        {
            this.Filename = "";
            this.Modificato = false;
        }



        public void salva(RichTextBox rtb)
        {
            if (modificato)
            {
                if (filename != "")
                {
                    DialogResult ris = MessageBox.Show("Vuoi salvare?","WordPad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if(ris == DialogResult.Yes)
                    rtb.SaveFile(filename);
                }
                else
                    SalvaConNome(rtb.Text, rtb);
                modificato = false;
            }
        }

        public void SalvaConNome(string text, RichTextBox rtb)
        {
            SaveFileDialog dlgSalva = new SaveFileDialog();
            dlgSalva.Filter = "Pagina WordPad (*rtf)|*.rtf|" +
                "Tutti i file (*.*)|*.*";
            dlgSalva.Title = "Salva con Nome";
            DialogResult ris;
            ris = dlgSalva.ShowDialog();
            if (ris == DialogResult.OK)
            {
                rtb.SaveFile(dlgSalva.FileName);//funziona
                filename = dlgSalva.FileName;
                modificato = false;
            }
        }
        
        

        public void ApriFile(RichTextBox rtb)
        {
            OpenFileDialog dlgApri = new OpenFileDialog();
            dlgApri.Filter = "Pagina WordPad (*.rtf)|*.rtf|" +
                "Tutti i file (*.*)|*.*";
            dlgApri.Title = "Apri";
            dlgApri.InitialDirectory = Environment.GetFolderPath(
                Environment.SpecialFolder.Desktop);
            DialogResult ris;
            ris = dlgApri.ShowDialog();
            if (ris == DialogResult.OK)
            {
                rtb.LoadFile(dlgApri.FileName);
            }
        }
    }
}
