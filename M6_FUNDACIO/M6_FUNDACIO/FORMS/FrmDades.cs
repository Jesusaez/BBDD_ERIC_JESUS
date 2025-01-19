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
    public partial class FrmDades : Form
    {
        FundacionesDBEntities fundacionesContext;
        FrmABMDades fABMDades;
        public FrmDades(FundacionesDBEntities xfundacionesContext)
        {
            InitializeComponent();
            fundacionesContext = xfundacionesContext;
        }

        private void omplirFundacions()
        {
            var qryCursosInscrit = (from f in fundacionesContext.Fundacion
                                    orderby f.Nombre
                                    select new
                                    {
                                        ID = f.ID,
                                        Nom = f.Nombre,
                                        Direccio = f.Direccion,
                                        Ciutat = f.Ciutat.Nombre,
                                        Pais= f.Pais.Nombre,
                                        Continent = f.Continente.Nom,
                                        Telefon = f.Telefono_Contacto,
                                        Email = f.Email_Contacto,
                                        LinkWeb = f.Link_Web,
                                        Horario = f.HorarioVisita,
                                    });

            Cursor = Cursors.WaitCursor;
            dgDades.DataSource = qryCursosInscrit.ToList().Distinct().ToList();

            dgDades.Columns["Nom"].HeaderText = "Nom Fundacio";
            dgDades.Columns["LinkWeb"].HeaderText = "Link Pagina Web";

            Cursor = Cursors.Default;

        }


        private void FrmDades_Load(object sender, EventArgs e)
        {
            omplirFundacions();
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            fABMDades = new FrmABMDades('A', fundacionesContext);
            //fABMDades.idAdd = (int)cbContinents.SelectedValue;
            if (dgDades.SelectedRows != null)
            {
                fABMDades.ShowDialog();
            }
            omplirFundacions();

            fABMDades = null;
        }
        private void omplirABM(char xOp)
        {
            fABMDades = new FrmABMDades(xOp, fundacionesContext);
            fABMDades.id = dgDades.SelectedRows[0].Cells["id"].Value.ToString().Trim();
        }
        private void pbDel_Click(object sender, EventArgs e)
        {
            omplirABM('B');
            if (dgDades.SelectedRows != null)
            {
                fABMDades.ShowDialog();
            }
            omplirFundacions();

            fABMDades = null;
        }

        private void dgDades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            omplirABM('M');
            if (dgDades.SelectedRows != null)
            {
                fABMDades.ShowDialog();
            }
            omplirFundacions();

            fABMDades = null;
        }
    }
}
