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
    public partial class FrmGestioPais : Form
    {
        private FundacionesDBEntities fundacionesContext { get; set; }
        public FrmGestioPais(FundacionesDBEntities xfundacionesContext)
        {
            InitializeComponent();
            fundacionesContext = xfundacionesContext;
        }

        private void getContinents()
        {
            Cursor = Cursors.WaitCursor;
            var qryEstudiants = (from p in fundacionesContext.Continente
                                 orderby p.Nom
                                 select new
                                 {
                                     id = p.ID,
                                     nom = p.Nom
                                 });

            cbContinents.DisplayMember = "nom";
            cbContinents.ValueMember = "id";
            cbContinents.DataSource = qryEstudiants.ToList();
            Cursor = Cursors.Default;

        }

        private void FrmGestioPais_Load(object sender, EventArgs e)
        {
            getContinents();
        }

        private void omplirContinents()
        {
            var qryCursosInscrit = (from c in fundacionesContext.Pais
                                    orderby c.Nombre
                                    where (c.IDContinente == (Int32)cbContinents.SelectedValue)
                                    select new
                                    {
                                        ID = c.ID,
                                        Nom = c.Nombre
                                    });

            Cursor = Cursors.WaitCursor;
            dgDades.DataSource = qryCursosInscrit.ToList().Distinct().ToList();

            dgDades.Columns["Nom"].HeaderText = "Nom Pais";
            Cursor = Cursors.Default;

        }

        private void cbContinents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbContinents.SelectedItem != null)
            {
                omplirContinents();
            }
        }
    }
}
