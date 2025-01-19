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
        FrmGestioRegions fRegions;
        FrmGaleria fGaleria;
        FrmMaps fMaps;
        FrmMiniaturaWeb fMiniaturaWeb;
        FrmValoracio fValoracio;
        FrmDades fDades;
        FrmCategoria fCategoria;
        FrmConsulta fConsulta;

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

        #region "GESTION ZONAS"
        private void ciudadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String xnom = "Ciudades";

            if (!(ja_esta_obert(xnom)))
            {
                fRegions = new FrmGestioRegions("Ciutat",fundacionesContext); // fem un nou formulari i l'afegim a la llista de formularis
                fRegions.Name = xnom;
                fRegions.MdiParent = this;
                fRegions.Show();
            }
            fRegions.Activate();
        }
        private void paisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String xnom = "Paises";

            if (!(ja_esta_obert(xnom)))
            {
                fRegions = new FrmGestioRegions("Pais", fundacionesContext); // fem un nou formulari i l'afegim a la llista de formularis
                fRegions.Name = xnom;
                fRegions.MdiParent = this;
                fRegions.Show();
            }
            fRegions.Activate();
        }
        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String xnom = "Categorias";

            if (!(ja_esta_obert(xnom)))
            {
                fCategoria = new FrmCategoria(fundacionesContext); // fem un nou formulari i l'afegim a la llista de formularis
                fCategoria.Name = xnom;
                fCategoria.MdiParent = this;
                fCategoria.Show();
            }
            fCategoria.Activate();
        }
        #endregion


        #region "VISUALIZACIÓN"
        private void galeriaImagenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String xnom = "Galeria Imagenes";

            if (!(ja_esta_obert(xnom)))
            {
                fGaleria = new FrmGaleria(false,fundacionesContext); // fem un nou formulari i l'afegim a la llista de formularis
                fGaleria.Name = xnom;
                fGaleria.MdiParent = this;
                fGaleria.Show();
            }
            fGaleria.Activate();
        }

        private void consultaItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String xnom = "Consulta Items";

            if (!(ja_esta_obert(xnom)))
            {
                fConsulta = new FrmConsulta(fundacionesContext); // fem un nou formulari i l'afegim a la llista de formularis
                fConsulta.Name = xnom;
                fConsulta.MdiParent = this;
                fConsulta.Show();
            }
            fConsulta.Activate();
        }

        #endregion


        #region "GESTION"

        private void valoracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String xnom = "Valoracion";

            if (!(ja_esta_obert(xnom)))
            {
                fValoracio = new FrmValoracio(fundacionesContext); // fem un nou formulari i l'afegim a la llista de formularis
                fValoracio.Name = xnom;
                fValoracio.MdiParent = this;
                fValoracio.Show();
            }
            fValoracio.Activate();
        }

        private void googleMapsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String xnom = "Google Maps";

            if (!(ja_esta_obert(xnom)))
            {
                fMaps = new FrmMaps(fundacionesContext); // fem un nou formulari i l'afegim a la llista de formularis
                fMaps.Name = xnom;
                fMaps.MdiParent = this;
                fMaps.Show();
            }
            fMaps.Activate();
        }

        private void creacionMiniaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String xnom = "Creacion Miniatura";

            if (!(ja_esta_obert(xnom)))
            {
                fMiniaturaWeb = new FrmMiniaturaWeb(fundacionesContext); // fem un nou formulari i l'afegim a la llista de formularis
                fMiniaturaWeb.Name = xnom;
                fMiniaturaWeb.MdiParent = this;
                fMiniaturaWeb.Show();
            }
            fMiniaturaWeb.Activate();
        }

        private void galeriaImagenesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            String xnom = "Galeria Imagenes";

            if (!(ja_esta_obert(xnom)))
            {
                fGaleria = new FrmGaleria(true,fundacionesContext); // fem un nou formulari i l'afegim a la llista de formularis
                fGaleria.Name = xnom;
                fGaleria.MdiParent = this;
                fGaleria.Show();
            }
            fGaleria.Activate();
        }

        private void datosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String xnom = "Datos";

            if (!(ja_esta_obert(xnom)))
            {
                fDades = new FrmDades(fundacionesContext); // fem un nou formulari i l'afegim a la llista de formularis
                fDades.Name = xnom;
                fDades.MdiParent = this;
                fDades.Show();
            }
            fDades.Activate();
        }

        #endregion
    }
}
