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
        Categoria cat;
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
                                       CourseId = c.ID,
                                       Title = c.Nombre,
                                   });



            Cursor = Cursors.WaitCursor;
            dgNoMatriculat.DataSource = qryAltresCursos.ToList().Distinct().ToList();

            dgNoMatriculat.Columns["CourseID"].Visible = false;
            dgNoMatriculat.Columns["Title"].HeaderText = "Categoria";
            Cursor = Cursors.Default;
        }

        private void omplirCategoriaInscrit()
        {
            var qryCategoria = (from c in fundacionesContext.FundacionCategoria
                                    orderby c.Categoria.Nombre
                                    where (c.FundacionID == (Int32)cbEstudiants.SelectedValue)
                                    select new
                                    {
                                        Categoria = c.Categoria.Nombre
                                    });

            Cursor = Cursors.WaitCursor;
            dgMatriculat.DataSource = qryCategoria.ToList().Distinct().ToList();
            Cursor = Cursors.Default;
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            getFundacions();
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            cat.Nombre = dgNoMatriculat.SelectedRows[0].Cells[1].Value.ToString();
            fundacionesContext.Categoria.Add(cat);
            //fundacionesContext.SaveChanges();
        }

        private void pbDel_Click(object sender, EventArgs e)
        {

        }
    }
}
