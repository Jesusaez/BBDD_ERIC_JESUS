using M6_FUNDACIO.FORMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M6_FUNDACIO
{
    public partial class FrmMain : Form
    {
        private FundacionesDBEntities fundacionesContext { get; set; } = new FundacionesDBEntities();
        FrmGestion fGestion;
        public FrmMain()
        {
            InitializeComponent();
        }


        private Boolean ja_esta_obert(String xnom)
        {

            int x1 = 0;
            Boolean xb = false;

            while ((x1 < this.MdiChildren.Length) && (!(xb)))
            {
                xb = (this.MdiChildren[x1].Name == xnom);
                x1++;
            }
            return (xb);
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Segur que vols sortir?", "SORTIR", MessageBoxButtons.OKCancel)==DialogResult.Cancel)
            {
                e.Cancel=true;
            }
        }

        #region "GESTION"
        private void ciudadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String xnom = "Ciudades";

            if (!(ja_esta_obert(xnom)))
            {
                fGestion = new FrmGestion(fundacionesContext); // fem un nou formulari i l'afegim a la llista de formularis
                fGestion.Name = xnom;
                fGestion.MdiParent = this;
                fGestion.Show();
            }
            fGestion.Activate();
        }
        private void paisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String xnom = "Paises";

            if (!(ja_esta_obert(xnom)))
            {
                fGestion = new FrmGestion(fundacionesContext); // fem un nou formulari i l'afegim a la llista de formularis
                fGestion.Name = xnom;
                fGestion.MdiParent = this;
                fGestion.Show();
            }
            fGestion.Activate();
        }
        #endregion


        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String xnom = "Paises";

            if (!(ja_esta_obert(xnom)))
            {
                fGestion = new FrmGestion(fundacionesContext); // fem un nou formulari i l'afegim a la llista de formularis
                fGestion.Name = xnom;
                fGestion.MdiParent = this;
                fGestion.Show();
            }
            fGestion.Activate();
        }

        private void galeriaImagenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String xnom = "Paises";

            if (!(ja_esta_obert(xnom)))
            {
                fGestion = new FrmGestion(fundacionesContext); // fem un nou formulari i l'afegim a la llista de formularis
                fGestion.Name = xnom;
                fGestion.MdiParent = this;
                fGestion.Show();
            }
            fGestion.Activate();
        }

        private void consultaItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String xnom = "Paises";

            if (!(ja_esta_obert(xnom)))
            {
                fGestion = new FrmGestion(fundacionesContext); // fem un nou formulari i l'afegim a la llista de formularis
                fGestion.Name = xnom;
                fGestion.MdiParent = this;
                fGestion.Show();
            }
            fGestion.Activate();
        }

        private void valoracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String xnom = "Valoracion";

            if (!(ja_esta_obert(xnom)))
            {
                fGestion = new FrmGestion(fundacionesContext); // fem un nou formulari i l'afegim a la llista de formularis
                fGestion.Name = xnom;
                fGestion.MdiParent = this;
                fGestion.Show();
            }
            fGestion.Activate();
        }

        private void googleMapsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String xnom = "Google Maps";

            if (!(ja_esta_obert(xnom)))
            {
                fGestion = new FrmGestion(fundacionesContext); // fem un nou formulari i l'afegim a la llista de formularis
                fGestion.Name = xnom;
                fGestion.MdiParent = this;
                fGestion.Show();
            }
            fGestion.Activate();
        }

        private void creacionMiniaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String xnom = "Creacion Miniatura";

            if (!(ja_esta_obert(xnom)))
            {
                fGestion = new FrmGestion(fundacionesContext); // fem un nou formulari i l'afegim a la llista de formularis
                fGestion.Name = xnom;
                fGestion.MdiParent = this;
                fGestion.Show();
            }
            fGestion.Activate();
        }

        private void galeriaImagenesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            String xnom = "Galeria Imagenes";

            if (!(ja_esta_obert(xnom)))
            {
                fGestion = new FrmGestion(fundacionesContext); // fem un nou formulari i l'afegim a la llista de formularis
                fGestion.Name = xnom;
                fGestion.MdiParent = this;
                fGestion.Show();
            }
            fGestion.Activate();
        }

        private void datosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String xnom = "Datos";

            if (!(ja_esta_obert(xnom)))
            {
                fGestion = new FrmGestion(fundacionesContext); // fem un nou formulari i l'afegim a la llista de formularis
                fGestion.Name = xnom;
                fGestion.MdiParent = this;
                fGestion.Show();
            }
            fGestion.Activate();
        }
    }
}
