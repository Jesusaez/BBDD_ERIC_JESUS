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
    public partial class FrmGestioABM : Form
    {
        Char op;
        String formOp;
        public String id { get; set; } = "";
        public String nom { get; set; } = "";
        public DateTime data { get; set; } = new DateTime();

        //val
        FundacionesDBEntities fundacionesContext;
        Ciutat ciu;
        Pais pais;
        Categoria cat;
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
            if (tbNom.Text != "" && cbPais.Text != "")
            {
                switch (formOp)
                {
                    case "Ciutat":
                        ciu.IDPais = (int)cbPais.SelectedValue;
                        ciu.Nombre = tbNom.Text;
                        break;
                    case "Categoria":
                        cat.Nombre = tbNom.Text;
                        break;
                    case "Pais":
                        pais.IDContinente = (int)cbPais.SelectedValue;
                        pais.Nombre = tbNom.Text;
                        break;
                }
            }
        }
        private void getPais()
        {
            Cursor = Cursors.WaitCursor;
            var qryEstudiants = (from p in fundacionesContext.Pais
                                 orderby p.Nombre
                                 select new
                                 {
                                     id = p.ID,
                                     nom = p.Nombre
                                 });

            cbPais.DisplayMember = "nom";
            cbPais.ValueMember = "id";
            cbPais.DataSource = qryEstudiants.ToList();
            Cursor = Cursors.Default;

        }

        private void getContinent()
        {
            Cursor = Cursors.WaitCursor;
            var qryEstudiants = (from p in fundacionesContext.Continente
                                 orderby p.Nom
                                 select new
                                 {
                                     id = p.ID,
                                     nom = p.Nom
                                 });

            cbPais.DisplayMember = "nom";
            cbPais.ValueMember = "id";
            cbPais.DataSource = qryEstudiants.ToList();
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
            }
            fundacionesContext.SaveChanges();
        }

        private void FrmGestioABM_Load(object sender, EventArgs e)
        {
            if (formOp == "Ciutat") getPais();
            if (formOp == "Pais") getContinent();

            if (op == 'M' || op == 'B')
            {
                omplir();
                if (op == 'B')
                {
                    cbPais.Enabled = false;
                    tbNom.Enabled = false;
                }
            }
            else
            {
                if (formOp == "Ciutat") ciu = new Ciutat();
                else if (formOp == "Pais") pais = new Pais();
                else if (formOp == "Categoria") cat = new Categoria();
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
            }
            if (ciu != null || cat!= null || pais!= null)
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
                }
            }
        }
    }
}
