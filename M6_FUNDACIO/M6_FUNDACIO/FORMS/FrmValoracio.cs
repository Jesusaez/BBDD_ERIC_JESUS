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
    public partial class FrmValoracio : Form
    {
        FundacionesDBEntities fundacionesContext;
        Ressenya res;
        public FrmValoracio(FundacionesDBEntities xfundacionesContext)
        {
            InitializeComponent();
            fundacionesContext = xfundacionesContext;
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            res = new Ressenya();

            try
            {
                res.ID_Fundacion = (int)cbFundacions.SelectedValue;
                res.Valoracio = (int)nUdReseña.Value;
                res.Descripcio = tbDescripcio.Text;
                fundacionesContext.Ressenya.Add(res);
                fundacionesContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al afegir les dades" + ex.Message, "ERROR");
            }
            this.Close();
        }
        private void getFundacions()
        {
            Cursor = Cursors.WaitCursor;
            var qryFundacions = (from f in fundacionesContext.Fundacion
                                 orderby f.Nombre
                                 select new
                                 {
                                     id = f.ID,
                                     nom = f.Nombre
                                 });

            cbFundacions.DisplayMember = "nom";
            cbFundacions.ValueMember = "id";
            cbFundacions.DataSource = qryFundacions.ToList();
            Cursor = Cursors.Default;
        }
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmValoracio_Load(object sender, EventArgs e)
        {
            getFundacions();
        }
    }
}
