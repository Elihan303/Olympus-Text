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
            richTextBox1.Clear();
            Archivo = null;
        }

        private void Abrir_Click(object sender, EventArgs e)
        {
           
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

        private void Salir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Deshacer_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void Rehacer_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void Copiar_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void Cortar_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void Pegar_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void SeleccionarTodo_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void EliminarTodo_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void Estilos_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog()==DialogResult.OK) {
                richTextBox1.ForeColor = color.Color;
            }
        }

        private void Fuente_Click(object sender, EventArgs e)
        {
            FontDialog fuente = new FontDialog();
            
            if (fuente.ShowDialog()==DialogResult.OK) {
                richTextBox1.Font = fuente.Font;
            }
        }
    }
}
