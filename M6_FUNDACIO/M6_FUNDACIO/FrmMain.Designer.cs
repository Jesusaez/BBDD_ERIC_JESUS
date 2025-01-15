namespace M6_FUNDACIO
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ciudadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.galeriaImagenesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.creacionMiniaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.googleMapsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valoracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.galeriaImagenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.gestionToolStripMenuItem,
            this.gestionItemsToolStripMenuItem,
            this.visualizaciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sToolStripMenuItem.Text = "Salir";
            this.sToolStripMenuItem.Click += new System.EventHandler(this.sToolStripMenuItem_Click);
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paisesToolStripMenuItem,
            this.ciudadesToolStripMenuItem,
            this.categoriasToolStripMenuItem});
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.gestionToolStripMenuItem.Text = "Gestion";
            // 
            // paisesToolStripMenuItem
            // 
            this.paisesToolStripMenuItem.Name = "paisesToolStripMenuItem";
            this.paisesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.paisesToolStripMenuItem.Text = "Paises";
            this.paisesToolStripMenuItem.Click += new System.EventHandler(this.paisesToolStripMenuItem_Click);
            // 
            // ciudadesToolStripMenuItem
            // 
            this.ciudadesToolStripMenuItem.Name = "ciudadesToolStripMenuItem";
            this.ciudadesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ciudadesToolStripMenuItem.Text = "Ciudades";
            this.ciudadesToolStripMenuItem.Click += new System.EventHandler(this.ciudadesToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // gestionItemsToolStripMenuItem
            // 
            this.gestionItemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosToolStripMenuItem,
            this.galeriaImagenesToolStripMenuItem1,
            this.creacionMiniaturaToolStripMenuItem,
            this.googleMapsToolStripMenuItem,
            this.valoracionToolStripMenuItem});
            this.gestionItemsToolStripMenuItem.Name = "gestionItemsToolStripMenuItem";
            this.gestionItemsToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.gestionItemsToolStripMenuItem.Text = "Gestion Items";
            // 
            // datosToolStripMenuItem
            // 
            this.datosToolStripMenuItem.Name = "datosToolStripMenuItem";
            this.datosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.datosToolStripMenuItem.Text = "Datos";
            this.datosToolStripMenuItem.Click += new System.EventHandler(this.datosToolStripMenuItem_Click);
            // 
            // galeriaImagenesToolStripMenuItem1
            // 
            this.galeriaImagenesToolStripMenuItem1.Name = "galeriaImagenesToolStripMenuItem1";
            this.galeriaImagenesToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.galeriaImagenesToolStripMenuItem1.Text = "Galeria Imagenes";
            this.galeriaImagenesToolStripMenuItem1.Click += new System.EventHandler(this.galeriaImagenesToolStripMenuItem1_Click);
            // 
            // creacionMiniaturaToolStripMenuItem
            // 
            this.creacionMiniaturaToolStripMenuItem.Name = "creacionMiniaturaToolStripMenuItem";
            this.creacionMiniaturaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.creacionMiniaturaToolStripMenuItem.Text = "Creacion Miniatura";
            this.creacionMiniaturaToolStripMenuItem.Click += new System.EventHandler(this.creacionMiniaturaToolStripMenuItem_Click);
            // 
            // googleMapsToolStripMenuItem
            // 
            this.googleMapsToolStripMenuItem.Name = "googleMapsToolStripMenuItem";
            this.googleMapsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.googleMapsToolStripMenuItem.Text = "Google Maps";
            this.googleMapsToolStripMenuItem.Click += new System.EventHandler(this.googleMapsToolStripMenuItem_Click);
            // 
            // valoracionToolStripMenuItem
            // 
            this.valoracionToolStripMenuItem.Name = "valoracionToolStripMenuItem";
            this.valoracionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.valoracionToolStripMenuItem.Text = "Valoracion";
            this.valoracionToolStripMenuItem.Click += new System.EventHandler(this.valoracionToolStripMenuItem_Click);
            // 
            // visualizaciónToolStripMenuItem
            // 
            this.visualizaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.galeriaImagenesToolStripMenuItem,
            this.consultaItemsToolStripMenuItem});
            this.visualizaciónToolStripMenuItem.Name = "visualizaciónToolStripMenuItem";
            this.visualizaciónToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.visualizaciónToolStripMenuItem.Text = "Visualización";
            // 
            // galeriaImagenesToolStripMenuItem
            // 
            this.galeriaImagenesToolStripMenuItem.Name = "galeriaImagenesToolStripMenuItem";
            this.galeriaImagenesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.galeriaImagenesToolStripMenuItem.Text = "Galeria Imagenes";
            this.galeriaImagenesToolStripMenuItem.Click += new System.EventHandler(this.galeriaImagenesToolStripMenuItem_Click);
            // 
            // consultaItemsToolStripMenuItem
            // 
            this.consultaItemsToolStripMenuItem.Name = "consultaItemsToolStripMenuItem";
            this.consultaItemsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.consultaItemsToolStripMenuItem.Text = "Consulta Items";
            this.consultaItemsToolStripMenuItem.Click += new System.EventHandler(this.consultaItemsToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Fundaciones";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paisesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ciudadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem galeriaImagenesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem creacionMiniaturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem googleMapsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem valoracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem galeriaImagenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaItemsToolStripMenuItem;
    }
}

