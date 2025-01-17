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
        FrmGestioABM fGestioABM;
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

        private void pbAdd_Click(object sender, EventArgs e)
        {
            fGestioABM = new FrmGestioABM('A',"Ciutat", fundacionesContext);
            if (dgDades.SelectedRows != null)
            {
                fGestioABM.ShowDialog();
            }
            omplirCiutats();

            fGestioABM = null;
        }

        private void pbDel_Click(object sender, EventArgs e)
        {
            fGestioABM = new FrmGestioABM('B', "Ciutat", fundacionesContext);
            if (dgDades.SelectedRows != null)
            {
                fGestioABM.ShowDialog();
            }
            omplirCiutats();

            fGestioABM = null;
        }

        private void dgDades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            fGestioABM = new FrmGestioABM('M', "Ciutat", fundacionesContext);
            fGestioABM.id = dgDades.SelectedRows[0].Cells["id"].Value.ToString().Trim();
            fGestioABM.nom = dgDades.SelectedRows[0].Cells["nom"].Value.ToString().Trim();
            if (dgDades.SelectedRows != null)
            {
                fGestioABM.ShowDialog();
            }
            omplirCiutats();

            fGestioABM = null;
        }
    }
}
