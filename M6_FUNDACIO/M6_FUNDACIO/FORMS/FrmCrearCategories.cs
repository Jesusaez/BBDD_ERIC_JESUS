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
        Categoria cat;

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
            cat = new Categoria();
        }
    }
}
