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
    }
}
