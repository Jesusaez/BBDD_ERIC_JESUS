using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace M6_FUNDACIO.FORMS
{
    public partial class FrmGestioABM : Form
    {
        Char op;
        String formOp;
        public String id { get; set; } = "";
        public int idAdd { get; set; }
        public String nom { get; set; } = "";
        public DateTime data { get; set; } = new DateTime();

        //val
        FundacionesDBEntities fundacionesContext;
        Ciutat ciu;
        Pais pais;
        Categoria cat;
        Fundacion fund;
        public FrmGestioABM(Char xop, String xformOp, FundacionesDBEntities xfundacionesContext)
        {
            op = xop;
            formOp = xformOp;
            fundacionesContext = xfundacionesContext;
            InitializeComponent();
        }

        private void add()
        {
            novesDades();
            
            switch (formOp)
            {
                case "Ciutat":
                    fundacionesContext.Ciutat.Add(ciu);
                    break;
                case "Categoria":
                    fundacionesContext.Categoria.Add(cat);
                    break;
                case "Pais":
                    fundacionesContext.Pais.Add(pais);
                    break;
            }
            fundacionesContext.SaveChanges();
        }

        private void novesDades()
        {
            if (tbNom.Text != "" && cbPais.Text != "" && formOp != "Categoria")
            {
                switch (formOp)
                {
                    case "Ciutat":
                        ciu.IDPais = (int)cbPais.SelectedValue;
                        ciu.Nombre = tbNom.Text;
                        break;
                    case "Pais":
                        pais.IDContinente = (int)cbPais.SelectedValue;
                        pais.Nombre = tbNom.Text;
                        break;
                }
            }
            else if (formOp == "Categoria")
            {
                if (tbNom.Text != "") cat.Nombre = tbNom.Text;
            }
            else
            {
                string lugarCodificado = HttpUtility.UrlEncode(tbNom.Text);
                string url = $"https://www.google.com/maps/search/?api=1&query={lugarCodificado}&t=k&z=21";
                fund.link_GoogleMaps = url;
            }
        }
        private void getPais()
        {
            Cursor = Cursors.WaitCursor;
            var qryPais = (from p in fundacionesContext.Pais
                                 orderby p.Nombre
                                 select new
                                 {
                                     id = p.ID,
                                     nom = p.Nombre
                                 });

            cbPais.DisplayMember = "nom";
            cbPais.ValueMember = "id";
            cbPais.DataSource = qryPais.ToList();
            Cursor = Cursors.Default;
        }

        private void getContinent()
        {
            Cursor = Cursors.WaitCursor;
            var qryCont = (from p in fundacionesContext.Continente
                                 orderby p.Nom
                                 select new
                                 {
                                     id = p.ID,
                                     nom = p.Nom
                                 });

            cbPais.DisplayMember = "nom";
            cbPais.ValueMember = "id";
            cbPais.DataSource = qryCont.ToList();
            Cursor = Cursors.Default;
        }
        private void mod()
        {
            novesDades();
            fundacionesContext.SaveChanges();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
            switch (formOp)
            {
                case "Ciutat":
                    fundacionesContext.Ciutat.Remove(ciu);
                    break;
                case "Categoria":
                    fundacionesContext.Categoria.Remove(cat);
                    break;
                case "Pais":
                    fundacionesContext.Pais.Remove(pais);
                    break;
                case "Maps":
                    fund.link_GoogleMaps = null;
                    break;
            }
            fundacionesContext.SaveChanges();
        }

        private void FrmGestioABM_Load(object sender, EventArgs e)
        {
            if (formOp == "Ciutat") getPais();
            if (formOp == "Pais") getContinent();
            if (formOp == "Categoria")
            {
                cbPais.Visible = false;
            }
            if (formOp == "Maps") lbMaps.Visible = true;

            if (op == 'M' || op == 'B')
            {
                omplir();
                if (op == 'B')
                {
                    cbPais.Enabled = false;
                    tbNom.Enabled = false;
                    lbMaps.Visible = false;
                }
            }
            else
            {
                if (formOp == "Ciutat") ciu = new Ciutat();
                else if (formOp == "Pais") pais = new Pais();
                else if (formOp == "Categoria") cat = new Categoria();
                else if (formOp == "Maps") fund = new Fundacion();

                if(formOp != "Categoria") cbPais.SelectedValue = idAdd;
            }
        }

        private void omplir()
        {
            switch (formOp)
            {
                case "Ciutat":
                    ciu = fundacionesContext.Ciutat.Find(int.Parse(id.Trim()));
                    break;
                case "Categoria":
                    cat = fundacionesContext.Categoria.Find(int.Parse(id.Trim()));
                    cbPais.Visible = false;
                    break;
                case "Pais":
                    pais = fundacionesContext.Pais.Find(int.Parse(id.Trim()));
                    break;
                case "Maps":
                    fund = fundacionesContext.Fundacion.Find(int.Parse(id.Trim()));
                    cbPais.Visible = false;
                    break;
            }
            if (ciu != null || cat!= null || pais!= null || fund!=null)
            {
                switch (formOp)
                {
                    case "Ciutat":
                        tbNom.Text = ciu.Nombre;
                        cbPais.SelectedValue = ciu.IDPais;
                        break;
                    case "Categoria":
                        tbNom.Text = cat.Nombre;
                        break;
                    case "Pais":
                        tbNom.Text = pais.Nombre;
                        cbPais.SelectedValue = pais.IDContinente;
                        break;
                    case "Maps":
                        tbNom.Text = fund.link_GoogleMaps;
                        break;
                }
            }
        }
    }
}
