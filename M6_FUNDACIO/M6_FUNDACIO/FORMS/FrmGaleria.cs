using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M6_FUNDACIO.FORMS
{
    public partial class FrmGaleria : Form
    {
        FundacionesDBEntities fundacionesContext;
        public FrmGaleria(FundacionesDBEntities xfundacionesContext)
        {
            InitializeComponent();
            fundacionesContext = xfundacionesContext;
        }

        private void omplircombo()
        {
            Cursor = Cursors.WaitCursor;
            var qryEstudiants = (from p in fundacionesContext.Fundacion
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

        private void getGaleria()
        {
            var qryCursosInscrit = (from c in fundacionesContext.GaleriaImagenes
                                    where (c.FundacionID == (Int32)cbContinents.SelectedValue)
                                    select new
                                    {
                                        ID = c.ID,
                                        Descripcio = c.Descripcion,
                                        foto=c.Imagen
                                    });

            Cursor = Cursors.WaitCursor;
            dgDades.DataSource = qryCursosInscrit.ToList().Distinct().ToList();

            dgDades.Columns["foto"].Visible = false;
            dgDades.Columns["Nom"].HeaderText = "Nom Pais";
            Cursor = Cursors.Default;

        }


        private void cbContinents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbContinents.SelectedItem != null)
            {
                getGaleria();
            }
        }

        private void FrmGaleria_Load(object sender, EventArgs e)
        {
            omplircombo();
        }

        private void dgDades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pbImatge.Image= Base64ToImage(dgDades.SelectedRows[0].Cells["foto"].Value.ToString();) 
        }

        private Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);

            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                return Image.FromStream(ms);
            }
        }


    }
}
