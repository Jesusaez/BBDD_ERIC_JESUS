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
    public partial class FrmCategoria : Form
    {
        FundacionesDBEntities fundacionesContext;
        FundacionCategoria funCat;
        FrmGestioABM fGestioABM;
        public FrmCategoria(FundacionesDBEntities xfundacionesContext)
        {
            InitializeComponent();
            fundacionesContext = xfundacionesContext;
        }

        private void getFundacions()
        {
            Cursor = Cursors.WaitCursor;
            var qryEstudiants = (from f in fundacionesContext.Fundacion
                                 orderby f.Nombre
                                 select new
                                 {
                                     id = f.ID,
                                     nom = f.Nombre
                                 });

            cbEstudiants.DisplayMember = "nom";
            cbEstudiants.ValueMember = "id";
            cbEstudiants.DataSource = qryEstudiants.ToList();
            Cursor = Cursors.Default;
        }

        private void cbEstudiants_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEstudiants.SelectedItem != null)
            {
                omplirCategoriaInscrit();
                omplirAltresCateogries();
            }
        }

        private void omplirAltresCateogries()
        {
            var qryCursosInscrit = (from cIns in fundacionesContext.FundacionCategoria
                                    where (cIns.FundacionID == (Int32)cbEstudiants.SelectedValue)
                                    select cIns.CategoriaID
                                   );

            var qryAltresCursos = (from c in fundacionesContext.Categoria
                                   where (!qryCursosInscrit.Contains(c.ID))
                                   orderby c.Nombre
                                   select new
                                   {
                                       Id = c.ID,
                                       Categoria = c.Nombre,
                                   });



            Cursor = Cursors.WaitCursor;
            dgNoMatriculat.DataSource = qryAltresCursos.ToList().Distinct().ToList();
            dgNoMatriculat.Columns["Id"].Visible = false;
            Cursor = Cursors.Default;
        }

        private void omplirCategoriaInscrit()
        {
            var qryCategoria = (from c in fundacionesContext.FundacionCategoria
                                    orderby c.Categoria.Nombre
                                    where (c.FundacionID == (Int32)cbEstudiants.SelectedValue)
                                    select new
                                    {
                                        Categoria = c.Categoria.Nombre,
                                        Id = c.ID
                                    });

            Cursor = Cursors.WaitCursor;
            dgMatriculat.DataSource = qryCategoria.ToList().Distinct().ToList();
            dgMatriculat.Columns["Id"].Visible = false;
            Cursor = Cursors.Default;
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            getFundacions();
            funCat = new FundacionCategoria();
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            funCat.FundacionID = (int)cbEstudiants.SelectedValue;
            funCat.CategoriaID = (int)dgNoMatriculat.SelectedRows[0].Cells["Id"].Value;
            fundacionesContext.FundacionCategoria.Add(funCat);
            fundacionesContext.SaveChanges();
            omplirCategoriaInscrit();
            omplirAltresCateogries();
        }

        private void pbDel_Click(object sender, EventArgs e)
        {
            funCat = fundacionesContext.FundacionCategoria.Find((int)dgMatriculat.SelectedRows[0].Cells["Id"].Value);
            fundacionesContext.FundacionCategoria.Remove(funCat);
            fundacionesContext.SaveChanges();
            omplirCategoriaInscrit();
            omplirAltresCateogries();
        }

        private void btNovaCat_Click(object sender, EventArgs e)
        {
            fGestioABM = new FrmGestioABM('A', "Categoria", fundacionesContext);
            fGestioABM.ShowDialog();
            omplirCategoriaInscrit();
            omplirAltresCateogries();

            fGestioABM = null;
        }

        private void btEliminarCat_Click(object sender, EventArgs e)
        {
            fGestioABM = new FrmGestioABM('B', "Categoria", fundacionesContext);
            fGestioABM.id = dgNoMatriculat.SelectedRows[0].Cells["id"].Value.ToString().Trim();
            fGestioABM.ShowDialog();
            omplirCategoriaInscrit();
            omplirAltresCateogries();

            fGestioABM = null;
        }

        private void dgNoMatriculat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            fGestioABM = new FrmGestioABM('M', "Categoria", fundacionesContext);
            fGestioABM.id = dgNoMatriculat.SelectedRows[0].Cells["id"].Value.ToString().Trim();
            fGestioABM.ShowDialog();
            omplirCategoriaInscrit();
            omplirAltresCateogries();

            fGestioABM = null;
        }
    }
}
