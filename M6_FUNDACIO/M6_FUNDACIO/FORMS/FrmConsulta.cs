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
    public partial class FrmConsulta : Form
    {
        FundacionesDBEntities fundacionesContext;
        public FrmConsulta(FundacionesDBEntities xfundacionesContext)
        {
            InitializeComponent();
            fundacionesContext = xfundacionesContext;
        }

        private void omplirFundacionsContinent()
        {
            var qryFund = (from f in fundacionesContext.Fundacion
                                   where f.IDContinent == (int)cbContinent.SelectedValue
                                   orderby f.Nombre
                                    select new
                                    {
                                        ID = f.ID,
                                        Nom = f.Nombre,
                                        Direccio = f.Direccion,
                                        Ciutat = f.Ciutat.Nombre,
                                        Pais = f.Pais.Nombre,
                                        Continent = f.Continente.Nom,
                                        Telefon = f.Telefono_Contacto,
                                        Email = f.Email_Contacto,
                                        LinkWeb = f.Link_Web,
                                        Horario = f.HorarioVisita,
                                    });

            Cursor = Cursors.WaitCursor;
            dgDades.DataSource = qryFund.ToList().Distinct().ToList();

            dgDades.Columns["Nom"].HeaderText = "Nom Fundacio";
            dgDades.Columns["LinkWeb"].HeaderText = "Link Pagina Web";

            Cursor = Cursors.Default;
        }
        private void omplirFundacionsPais()
        {
            var qryFund = (from f in fundacionesContext.Fundacion
                           where f.IDPais == (int)cbPais.SelectedValue
                           orderby f.Nombre
                           select new
                           {
                               ID = f.ID,
                               Nom = f.Nombre,
                               Direccio = f.Direccion,
                               Ciutat = f.Ciutat.Nombre,
                               Pais = f.Pais.Nombre,
                               Continent = f.Continente.Nom,
                               Telefon = f.Telefono_Contacto,
                               Email = f.Email_Contacto,
                               LinkWeb = f.Link_Web,
                               Horario = f.HorarioVisita,
                           });

            Cursor = Cursors.WaitCursor;
            dgDades.DataSource = qryFund.ToList().Distinct().ToList();

            dgDades.Columns["Nom"].HeaderText = "Nom Fundacio";
            dgDades.Columns["LinkWeb"].HeaderText = "Link Pagina Web";

            Cursor = Cursors.Default;
        }
        private void omplirFundacionsCategoria()
        {
            var qryFund = (from f in fundacionesContext.Fundacion
                                     join a in fundacionesContext.FundacionCategoria on f.ID equals a.FundacionID
                                     join b in fundacionesContext.Categoria on a.CategoriaID equals b.ID
                                     where b.ID == (int)cbCategoria.SelectedValue
                                     orderby f.Nombre
                                     select new
                                     {
                                         ID = f.ID,
                                         Nom = f.Nombre,
                                         Direccio = f.Direccion,
                                         Ciutat = f.Ciutat.Nombre,
                                         Pais = f.Pais.Nombre,
                                         Continent = f.Continente.Nom,
                                         Telefon = f.Telefono_Contacto,
                                         Email = f.Email_Contacto,
                                         LinkWeb = f.Link_Web,
                                         Horario = f.HorarioVisita,
                                     });

            Cursor = Cursors.WaitCursor;
            dgDades.DataSource = qryFund.ToList().Distinct().ToList();

            dgDades.Columns["Nom"].HeaderText = "Nom Fundacio";
            dgDades.Columns["LinkWeb"].HeaderText = "Link Pagina Web";

            Cursor = Cursors.Default;
        }
        private void getPais()
        {
            Cursor = Cursors.WaitCursor;
            var qryGestio = (from p in fundacionesContext.Pais
                             orderby p.Nombre
                             select new
                             {
                                 id = p.ID,
                                 nom = p.Nombre
                             });

            cbPais.DisplayMember = "nom";
            cbPais.ValueMember = "id";
            cbPais.DataSource = qryGestio.ToList();
            Cursor = Cursors.Default;
        }
        private void getCategoria()
        {
            Cursor = Cursors.WaitCursor;
            var qryGestio = (from p in fundacionesContext.Categoria
                             orderby p.Nombre
                             select new
                             {
                                 id = p.ID,
                                 nom = p.Nombre
                             });

            cbCategoria.DisplayMember = "nom";
            cbCategoria.ValueMember = "id";
            cbCategoria.DataSource = qryGestio.ToList();
            Cursor = Cursors.Default;
        }
        private void getContient()
        {
            Cursor = Cursors.WaitCursor;
            var qryGestio = (from p in fundacionesContext.Continente
                             orderby p.Nom
                             select new
                             {
                                 id = p.ID,
                                 nom = p.Nom
                             });

            cbContinent.DisplayMember = "nom";
            cbContinent.ValueMember = "id";
            cbContinent.DataSource = qryGestio.ToList();
            Cursor = Cursors.Default;
        }
        private void rbContinent_CheckedChanged(object sender, EventArgs e)
        {
            if (rbContinent.Checked){
                cbContinent.Enabled = true;
                cbPais.Enabled = false;
                cbCategoria.Enabled = false;
                cbCategoria.DataSource = null;
                cbPais.DataSource = null;
                getContient();
                //omplirFundacionsContinent();
            }
        }

        private void rbPais_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPais.Checked)
            {
                cbContinent.Enabled = false;
                cbPais.Enabled = true;
                cbCategoria.Enabled = false;
                cbContinent.DataSource = null;
                cbCategoria.DataSource = null;
                getPais();
            }
        }

        private void rbCategoria_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCategoria.Checked)
            {
                cbContinent.Enabled = false;
                cbPais.Enabled = false;
                cbCategoria.Enabled = true;
                cbContinent.DataSource = null;
                cbPais.DataSource = null;
                getCategoria();
            }
        }

        private void FrmConsulta_Load(object sender, EventArgs e)
        {
            cbContinent.Enabled = true;
            cbPais.Enabled = false;
            cbCategoria.Enabled = false;
            getContient();
            omplirFundacionsContinent();
        }

        private void cbContinent_SelectedIndexChanged(object sender, EventArgs e)
        {
            omplirFundacionsContinent();
        }

        private void cbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            omplirFundacionsPais();
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            omplirFundacionsCategoria();
        }
    }
}
