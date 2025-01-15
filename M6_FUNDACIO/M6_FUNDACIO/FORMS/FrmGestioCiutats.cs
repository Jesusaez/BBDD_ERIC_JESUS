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
    public partial class FrmGestioCiutats : Form
    {
        private FundacionesDBEntities fundacionesContext { get; set; }
        public FrmGestioCiutats(FundacionesDBEntities xfundacionesContext)
        {
            InitializeComponent();
            fundacionesContext = xfundacionesContext;
        }

        private void getContinents()
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
        private void cbContinents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbContinents.SelectedItem != null)
            {
                omplirCiutats();
            }
        }

        private void omplirCiutats()
        {
            var qryCursosInscrit = (from c in fundacionesContext.Ciutat
                                    orderby c.Nombre
                                    where (c.IDPais == (Int32)cbContinents.SelectedValue)
                                    select new
                                    {
                                        ID = c.ID,
                                        Nom = c.Nombre
                                    });

            Cursor = Cursors.WaitCursor;
            dgDades.DataSource = qryCursosInscrit.ToList().Distinct().ToList();

            dgDades.Columns["Nom"].HeaderText = "Nom Ciutat";
            Cursor = Cursors.Default;

        }


        private void FrmGestioCiutats_Load(object sender, EventArgs e)
        {
            getContinents();
        }
    }
}
