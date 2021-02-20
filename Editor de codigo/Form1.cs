using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor_de_codigo
{
    public partial class Form1 : Form
    {
        String Archivo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {

        }

        private void Abrir_Click(object sender, EventArgs e)
        {
            /*String A;
            openFileDialog1.ShowDialog();
            System.IO.StreamReader archivo = new System.IO.StreamReader(openFileDialog1.FileName);
            A = archivo.ReadLine();
            richTextBox1.Text = A.ToString();*/
            OpenFileDialog OpenFile = new OpenFileDialog();
            OpenFile.Filter = "Texto|*.txt";
            if (OpenFile.ShowDialog()==DialogResult.OK)
            {
                Archivo = OpenFile.FileName;
                using (StreamReader A = new StreamReader(Archivo)) {
                    richTextBox1.Text = A.ReadToEnd();
                }
            }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            /*saveFileDialog1.FileName = "Sin titulo.txt";
            var guardar = saveFileDialog1.ShowDialog();
            if (guardar == DialogResult.OK) {
                using (var guardar_archivo = new StreamReader(saveFileDialog1.FileName)) 
                {
                    guardar_archivo.ReadToEnd(richTextBox1.Text);
                }
            }*/
            SaveFileDialog SaveFile = new SaveFileDialog();
            SaveFile.Filter = "Texto|*.txt";
            if (Archivo != null)
            {
                using (StreamWriter G = new StreamWriter(Archivo))
                {
                    G.Write(richTextBox1.Text);
                }
            }
            else {
                if (SaveFile.ShowDialog() == DialogResult.OK) {
                    Archivo = SaveFile.FileName;
                    using (StreamWriter g= new StreamWriter(SaveFile.FileName)) {
                        g.Write(richTextBox1.Text);
                    }
                }

            
            }
        }
    }
}
