using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace M6_FUNDACIO.FORMS
{
    public partial class FrmMaps : Form
    {
        FundacionesDBEntities fundacionesContext;
        FrmGestioABM fGestioABM;
        public FrmMaps(FundacionesDBEntities xfundacionesContext)
        {
            InitializeComponent();
            fundacionesContext = xfundacionesContext;
        }

        private void getPaisos()
        {
            Cursor = Cursors.WaitCursor;
            var qryContinents = (from p in fundacionesContext.Pais
                                 orderby p.Nombre
                                 select new
                                 {
                                     id = p.ID,
                                     nom = p.Nombre
                                 });

            cbContinents.DisplayMember = "nom";
            cbContinents.ValueMember = "id";
            cbContinents.DataSource = qryContinents.ToList();
            Cursor = Cursors.Default;

        }

        private void omplirFundacions()
        {
            var qryMaps = (from f in fundacionesContext.Fundacion
                                    orderby f.Nombre
                                    where f.IDPais == (Int32)cbContinents.SelectedValue
                                    select new
                                    {
                                        id = f.ID,
                                        Nom = f.Nombre,
                                        linkMaps = f.link_GoogleMaps
                                    });

            Cursor = Cursors.WaitCursor;
            dgDades.DataSource = qryMaps.ToList();

            dgDades.Columns["Nom"].HeaderText = "Nom Fundacio";
            dgDades.Columns["linkMaps"].HeaderText = "Link Google Maps";

            Cursor = Cursors.Default;

        }

        private void FrmMaps_Load(object sender, EventArgs e)
        {
            getPaisos();
            omplirFundacions();
        }

        private void cbContinents_SelectedIndexChanged(object sender, EventArgs e)
        {
            omplirFundacions();
        }

        private void googleMaps()
        {
            String nombreLugar = dgDades.SelectedRows[0].Cells["linkMaps"].Value.ToString();

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = nombreLugar,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el navegador: {ex.Message}", "Error");
            }
        }

        private void btObrirMaps_Click(object sender, EventArgs e)
        {
            if (dgDades.SelectedRows[0].Cells["linkMaps"].Value !=null) googleMaps();
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            fGestioABM = new FrmGestioABM('M', "Maps", fundacionesContext);
            fGestioABM.id = dgDades.SelectedRows[0].Cells["id"].Value.ToString();
            if (dgDades.SelectedRows != null)
            {
                fGestioABM.ShowDialog();
            }
            omplirFundacions();

            fGestioABM = null;
        }

        private void pbDel_Click(object sender, EventArgs e)
        {
            fGestioABM = new FrmGestioABM('B', "Maps", fundacionesContext);
            fGestioABM.id = dgDades.SelectedRows[0].Cells["id"].Value.ToString();
            if (dgDades.SelectedRows != null)
            {
                fGestioABM.ShowDialog();
            }
            omplirFundacions();

            fGestioABM = null;
        }
    }
}
