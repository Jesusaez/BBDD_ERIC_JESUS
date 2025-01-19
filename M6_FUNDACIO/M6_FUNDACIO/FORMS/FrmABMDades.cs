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
    public partial class FrmABMDades : Form
    {
        FundacionesDBEntities fundacionesContext;
        Char op;
        public String id {  get; set; }
        Fundacion fund;
        public FrmABMDades(Char xop,FundacionesDBEntities xFundacionesContext)
        {
            InitializeComponent();
            fundacionesContext = xFundacionesContext;
            op = xop;
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (op)
                {
                    case 'A':
                        add();
                        break;
                    case 'M':
                        mod();
                        break;
                    case 'B':
                        del();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al afegir/eliminar les dades " + ex.Message, "ERROR");
            }

            this.Close();
        }

        private void del()
        {
            fundacionesContext.Fundacion.Remove(fund);
            fundacionesContext.SaveChanges();
        }

        private void mod()
        {
            novesDades();
            fundacionesContext.SaveChanges();
        }

        private void add()
        {
            novesDades();
            fundacionesContext.Fundacion.Add(fund);
            fundacionesContext.SaveChanges();
        }
        private void novesDades()
        {
            if (tbNom.Text != "" && tbDireccio.Text != "" && tbEmail.Text != "" && tbTelefon.Text != "")
            {
                fund.Nombre = tbNom.Text;
                fund.Direccion = tbDireccio.Text;
                fund.Telefono_Contacto = tbTelefon.Text;
                if (tbEmail.Text.Contains("@")) fund.Email_Contacto = tbEmail.Text;
                else MessageBox.Show("Direccio de correu no valida", "ERROR");
                if (cbCiutat.SelectedIndex!=-1)fund.IDCiutat = (int)cbCiutat.SelectedValue;
                if (cbCiutat.SelectedIndex != -1) fund.IDPais = (int)cbPais.SelectedValue;
                if (cbCiutat.SelectedIndex != -1) fund.IDContinent = (int)cbContinent.SelectedValue;
                if (tbWeb.Text != "")
                {
                    if (tbWeb.Text.Contains("https://")) fund.Link_Web = tbWeb.Text;
                    else fund.Link_Web = "https://" + tbWeb.Text;
                }
                if (tbHorari.Text != "") fund.HorarioVisita = tbHorari.Text;
            }
        }
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getContinents()
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

        private void FrmABMDades_Load(object sender, EventArgs e)
        {
            getContinents();
            if (op == 'M' || op == 'B')
            {
                omplir();
                if (op == 'B')
                {
                    cbPais.Enabled = false;
                    cbContinent.Enabled = false;
                    cbCiutat.Enabled = false;
                    tbDireccio.Enabled = false;
                    tbEmail.Enabled = false;
                    tbHorari.Enabled = false;
                    tbTelefon.Enabled = false;
                    tbWeb.Enabled = false;
                    tbNom.Enabled = false;
                }
            }
            else
            {
                fund = new Fundacion();
            }
        }
        private void omplir()
        {
            fund = fundacionesContext.Fundacion.Find(int.Parse(id.Trim()));

            tbDireccio.Text = fund.Direccion.ToString();
            tbEmail.Text = fund.Email_Contacto.ToString();
            tbHorari.Text = fund.HorarioVisita.ToString();
            tbNom.Text = fund.Nombre.ToString();
            tbTelefon.Text = fund.Telefono_Contacto.ToString();
            tbWeb.Text = fund.Link_Web.ToString();
            cbContinent.SelectedValue = (int)fund.Continente.ID;
            cbPais.SelectedValue = (int)fund.Pais.ID;
            cbCiutat.SelectedValue = (int)fund.Ciutat.ID;
        }
        private void cbContinent_SelectedIndexChanged(object sender, EventArgs e)
        {
            getPais();
        }
        private void getPais()
        {
            Cursor = Cursors.WaitCursor;
            var qryGestio = (from p in fundacionesContext.Pais
                             where p.IDContinente == (int)cbContinent.SelectedValue
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

        private void cbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            getCiutats();
        }
        private void getCiutats()
        {
            Cursor = Cursors.WaitCursor;
            var qryGestio = (from p in fundacionesContext.Ciutat
                             where p.IDPais == (int)cbPais.SelectedValue
                             orderby p.Nombre
                             select new
                             {
                                 id = p.ID,
                                 nom = p.Nombre
                             });

            cbCiutat.DisplayMember = "nom";
            cbCiutat.ValueMember = "id";
            cbCiutat.DataSource = qryGestio.ToList();
            Cursor = Cursors.Default;
        }

        private void tbTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
