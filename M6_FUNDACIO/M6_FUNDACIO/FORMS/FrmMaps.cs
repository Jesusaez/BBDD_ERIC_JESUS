using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M6_FUNDACIO.FORMS
{
    public partial class FrmMaps : Form
    {
        FundacionesDBEntities fundacionesContext;
        public FrmMaps(FundacionesDBEntities xfundacionesContext)
        {
            InitializeComponent();
            fundacionesContext = xfundacionesContext;
        }

        private void getPaisos()
        {
            Cursor = Cursors.WaitCursor;
            var qryEstudiants = (from p in fundacionesContext.Pais
                                 orderby p.Nombre
                                 select new
                                 {
                                     id = p.ID,
                                     nom = p.Nombre
                                 });

            cbContinents.DisplayMember = "nom";
            cbContinents.ValueMember = "id";
            cbContinents.DataSource = qryEstudiants.ToList();
            Cursor = Cursors.Default;

        }

        private void omplirFundacions()
        {
            var qryCursosInscrit = (from f in fundacionesContext.Fundacion
                                    orderby f.Nombre
                                    where f.ID == (Int32)cbContinents.SelectedValue
                                    select new
                                    {
                                        ID = f.ID,
                                        Nom = f.Nombre,
                                        linkMaps = f.link_GoogleMaps
                                    });

            Cursor = Cursors.WaitCursor;
            dgDades.DataSource = qryCursosInscrit.ToList().Distinct().ToList();

            dgDades.Columns["Nom"].HeaderText = "Nom Fundacio";
            dgDades.Columns["linkMaps"].HeaderText = "Link Google Maps";

            Cursor = Cursors.Default;

        }

        private void FrmMaps_Load(object sender, EventArgs e)
        {
            tbLink.Visible = false;
            lbLink.Visible = false;
            btAccept.Visible = false;
            btCancelar.Visible = false;


        }

        private void cbContinents_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbLink.Visible = false;
            lbLink.Visible = false;
            btAccept.Visible = false;
            btCancelar.Visible = false;
        }
    }
}
