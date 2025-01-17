using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
            Cursor = Cursors.Default;

        }


        private void cbContinents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbContinents.SelectedItem != null)
            {
                pbImatge.Image = null;
                lbDesc.Visible = false;
                tbDesc.Visible = false;
                btAccept.Visible = false;  
                btCancelar.Visible = false;
                getGaleria();
            }
        }

        private void FrmGaleria_Load(object sender, EventArgs e)
        {
            lbDesc.Visible=false;
            tbDesc.Visible=false;
            btAccept.Visible = false;
            btCancelar.Visible = false;
            omplircombo();
        }

        private void dgDades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgDades.SelectedRows[0].Cells["foto"].Value!=null)
            {
                pbImatge.Image = Base64ToImage(dgDades.SelectedRows[0].Cells["foto"].Value.ToString());
            }
            else
            {
                pbImatge.Image = null;
            }
            lbDesc.Visible = false;
            tbDesc.Visible = false;
            btAccept.Visible = false;
            btCancelar.Visible = false;
        }

        private Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);

            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                return Image.FromStream(ms);
            }
        }

        public static string ImageToBase64(Image image)
        {

                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                    return Convert.ToBase64String(ms.ToArray());
                }
            
        }

        private void pbDel_Click(object sender, EventArgs e)
        {
            if (dgDades.Rows.Count > 0)
            {
                string xid= dgDades.SelectedRows[0].Cells["id"].Value.ToString().Trim();
                GaleriaImagenes p = fundacionesContext.GaleriaImagenes.Find(int.Parse(xid));  // localitzem el territori que volem eliminar

                if (p != null)
                {
                    fundacionesContext.GaleriaImagenes.Remove(p);
                    ferCanvis();
                }

            }
            else
            {
                MessageBox.Show("No has seleccionat cap fila", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            getGaleria();
            pbImatge.Image = null;
        }

        private Boolean ferCanvis()
        {
            Boolean xb = false;
            try
            {
                fundacionesContext.SaveChanges();
                xb = true;
            }
            catch (Exception excp)
            {
                // Hauríem de posar un missatge que sigui més entenedor per a l'usuari ja que el missatge de l'excepció és molt tècnic
                // Aquí ho fem així perquè estem fent exemples de desenvolupament i, per a tu, és més interessant veure l'error des d'aquest punt de vista tècnic
                MessageBox.Show(excp.InnerException.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Eliminem l'acció que volíem realitzar perquè, si no ho fem, en el pròxim SaveChanges() es tornarà a provar de fer
                // Això passa perquè les accions es van posant en una cua i no s'eliminen de la cua si no es fa efectiu el canvi.
                // Es pot comprovar que passa això comentant aquestes línies del for, fent una alta d'un ID ja existent i després posar un ID correcte.
                foreach (var accio in fundacionesContext.ChangeTracker.Entries())
                {
                    accio.State = EntityState.Detached;
                }

            }
            return xb;
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            
            tbDesc.Text = "";
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
                Title = "Seleccionar una imagen"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog.FileName;
                pbImatge.Image=Image.FromFile(rutaArchivo);
                lbDesc.Visible = true;
                tbDesc.Visible = true;
                btAccept.Visible = true;
                btCancelar.Visible = true;
            }
            else
            {
                Console.WriteLine("No se seleccionó ningún archivo.");
            }
        }

        private void btAccept_Click(object sender, EventArgs e)
        {
            GaleriaImagenes p = new GaleriaImagenes();

            p.FundacionID = (Int32)cbContinents.SelectedValue;
            p.Descripcion = tbDesc.Text;
            p.Imagen = ImageToBase64(pbImatge.Image);
            fundacionesContext.GaleriaImagenes.Add(p);
            ferCanvis();
            lbDesc.Visible = false;
            tbDesc.Visible = false;
            btAccept.Visible = false;
            btCancelar.Visible = false;
            getGaleria();
            pbImatge.Image = null;

        }

    }
}
