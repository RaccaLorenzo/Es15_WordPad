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
            this.Modificato = true;
        }



        public void salva(RichTextBox rtb)
        {
            if (modificato)
            {
                if (filename != "")
                    rtb.SaveFile(Application.StartupPath + filename );
                else
                    SalvaConNome(rtb.Text, rtb);
            }
        }

        private void SalvaConNome(string text, RichTextBox rtb)
        {
            SaveFileDialog dlgSalva = new SaveFileDialog();
            dlgSalva.Filter = "(*rtf)|*.rtf|" +
                "Tutti i file (*.*)|*.*";
            dlgSalva.Title = "Salva";
            DialogResult ris;
            ris = dlgSalva.ShowDialog();
            if (ris == DialogResult.OK)
            {
                Filename = dlgSalva.FileName;
                rtb.SaveFile(Application.StartupPath + "\\" + filename + ".rtf");
            }
                

        }

       
    }
}
