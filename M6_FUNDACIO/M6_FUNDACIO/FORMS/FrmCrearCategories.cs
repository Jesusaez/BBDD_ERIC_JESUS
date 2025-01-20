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
    public partial class FrmCrearCategories : Form
    {
        private FundacionesDBEntities fundacionesContext { get; set; }
        FrmGestioABM fGestioABM;

        public FrmCrearCategories(FundacionesDBEntities xfundacionesContext)
        {
            InitializeComponent();
            fundacionesContext = xfundacionesContext;
        }

        private void omplirCategories()
        {
            var qryCursosInscrit = (from c in fundacionesContext.Categoria
                                    orderby c.Nombre
                                    select new
                                    {
                                        ID = c.ID,
                                        Nom = c.Nombre
                                    });

            Cursor = Cursors.WaitCursor;
            dgDades.DataSource = qryCursosInscrit.ToList().Distinct().ToList();

            dgDades.Columns["Nom"].HeaderText = "Nom Categoria";
            Cursor = Cursors.Default;

        }

        private void FrmCrearCategories_Load(object sender, EventArgs e)
        {
            omplirCategories();
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            fGestioABM = new FrmGestioABM('A', "Categoria", fundacionesContext);
            fGestioABM.ShowDialog();
            omplirCategories();

            fGestioABM = null;
        }

        private void pbDel_Click(object sender, EventArgs e)
        {
            fGestioABM = new FrmGestioABM('B', "Categoria", fundacionesContext);
            fGestioABM.id = dgDades.SelectedRows[0].Cells["id"].Value.ToString().Trim();
            fGestioABM.ShowDialog();
            omplirCategories();

            fGestioABM = null;
        }

        private void dgDades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            fGestioABM = new FrmGestioABM('M', "Categoria", fundacionesContext);
            fGestioABM.id = dgDades.SelectedRows[0].Cells["id"].Value.ToString().Trim();
            fGestioABM.ShowDialog();
            omplirCategories();

            fGestioABM = null;
        }
    }
}
