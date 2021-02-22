
namespace Editor_de_codigo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Nuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.Abrir = new System.Windows.Forms.ToolStripMenuItem();
            this.Guardar = new System.Windows.Forms.ToolStripMenuItem();
            this.Salir = new System.Windows.Forms.ToolStripMenuItem();
            this.edicionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Deshacer = new System.Windows.Forms.ToolStripMenuItem();
            this.Rehacer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Copiar = new System.Windows.Forms.ToolStripMenuItem();
            this.Cortar = new System.Windows.Forms.ToolStripMenuItem();
            this.Pegar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SeleccionarTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.EliminarTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.Estilos = new System.Windows.Forms.ToolStripMenuItem();
            this.Formato = new System.Windows.Forms.ToolStripMenuItem();
            this.Fuente = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.edicionToolStripMenuItem,
            this.Estilos,
            this.Formato});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Nuevo,
            this.Abrir,
            this.Guardar,
            this.Salir});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // Nuevo
            // 
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.Nuevo.Size = new System.Drawing.Size(158, 22);
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // Abrir
            // 
            this.Abrir.Name = "Abrir";
            this.Abrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.Abrir.Size = new System.Drawing.Size(158, 22);
            this.Abrir.Text = "Abrir";
            this.Abrir.Click += new System.EventHandler(this.Abrir_Click);
            // 
            // Guardar
            // 
            this.Guardar.Name = "Guardar";
            this.Guardar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.Guardar.Size = new System.Drawing.Size(158, 22);
            this.Guardar.Text = "Guardar";
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Salir
            // 
            this.Salir.Name = "Salir";
            this.Salir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.Salir.Size = new System.Drawing.Size(158, 22);
            this.Salir.Text = "Salir";
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // edicionToolStripMenuItem
            // 
            this.edicionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Deshacer,
            this.Rehacer,
            this.toolStripSeparator1,
            this.Copiar,
            this.Cortar,
            this.Pegar,
            this.toolStripSeparator2,
            this.SeleccionarTodo,
            this.EliminarTodo});
            this.edicionToolStripMenuItem.Name = "edicionToolStripMenuItem";
            this.edicionToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.edicionToolStripMenuItem.Text = "Edicion";
            // 
            // Deshacer
            // 
            this.Deshacer.Name = "Deshacer";
            this.Deshacer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.Deshacer.Size = new System.Drawing.Size(209, 22);
            this.Deshacer.Text = "Deshacer";
            this.Deshacer.Click += new System.EventHandler(this.Deshacer_Click);
            // 
            // Rehacer
            // 
            this.Rehacer.Name = "Rehacer";
            this.Rehacer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.Rehacer.Size = new System.Drawing.Size(209, 22);
            this.Rehacer.Text = "Reshacer";
            this.Rehacer.Click += new System.EventHandler(this.Rehacer_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(206, 6);
            // 
            // Copiar
            // 
            this.Copiar.Name = "Copiar";
            this.Copiar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.Copiar.Size = new System.Drawing.Size(209, 22);
            this.Copiar.Text = "Copiar";
            this.Copiar.Click += new System.EventHandler(this.Copiar_Click);
            // 
            // Cortar
            // 
            this.Cortar.Name = "Cortar";
            this.Cortar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.Cortar.Size = new System.Drawing.Size(209, 22);
            this.Cortar.Text = "Cortar";
            this.Cortar.Click += new System.EventHandler(this.Cortar_Click);
            // 
            // Pegar
            // 
            this.Pegar.Name = "Pegar";
            this.Pegar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.Pegar.Size = new System.Drawing.Size(209, 22);
            this.Pegar.Text = "Pegar";
            this.Pegar.Click += new System.EventHandler(this.Pegar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(206, 6);
            // 
            // SeleccionarTodo
            // 
            this.SeleccionarTodo.Name = "SeleccionarTodo";
            this.SeleccionarTodo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.SeleccionarTodo.Size = new System.Drawing.Size(209, 22);
            this.SeleccionarTodo.Text = "Seleccionar todo ";
            this.SeleccionarTodo.Click += new System.EventHandler(this.SeleccionarTodo_Click);
            // 
            // EliminarTodo
            // 
            this.EliminarTodo.Name = "EliminarTodo";
            this.EliminarTodo.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.X)));
            this.EliminarTodo.Size = new System.Drawing.Size(209, 22);
            this.EliminarTodo.Text = "Eliminar todo";
            this.EliminarTodo.Click += new System.EventHandler(this.EliminarTodo_Click);
            // 
            // Estilos
            // 
            this.Estilos.Name = "Estilos";
            this.Estilos.Size = new System.Drawing.Size(52, 20);
            this.Estilos.Text = "Estilos";
            this.Estilos.Click += new System.EventHandler(this.Estilos_Click);
            // 
            // Formato
            // 
            this.Formato.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Fuente});
            this.Formato.Name = "Formato";
            this.Formato.Size = new System.Drawing.Size(64, 20);
            this.Formato.Text = "Formato";
            // 
            // Fuente
            // 
            this.Fuente.Name = "Fuente";
            this.Fuente.Size = new System.Drawing.Size(110, 22);
            this.Fuente.Text = "Fuente";
            this.Fuente.Click += new System.EventHandler(this.Fuente_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 426);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Olympus Text";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Nuevo;
        private System.Windows.Forms.ToolStripMenuItem Abrir;
        private System.Windows.Forms.ToolStripMenuItem Guardar;
        private System.Windows.Forms.ToolStripMenuItem edicionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Deshacer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Copiar;
        private System.Windows.Forms.ToolStripMenuItem Cortar;
        private System.Windows.Forms.ToolStripMenuItem Pegar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem SeleccionarTodo;
        private System.Windows.Forms.ToolStripMenuItem EliminarTodo;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem Salir;
        private System.Windows.Forms.ToolStripMenuItem Rehacer;
        private System.Windows.Forms.ToolStripMenuItem Estilos;
        private System.Windows.Forms.ToolStripMenuItem Formato;
        private System.Windows.Forms.ToolStripMenuItem Fuente;
    }
}

