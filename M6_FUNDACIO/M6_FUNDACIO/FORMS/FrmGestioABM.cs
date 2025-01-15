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

        public String nom { get; set; } = "";
        public String id { get; set; } = "";
        public String cognom { get; set; } = "";
        public DateTime data { get; set; } = new DateTime();

        //val
        FundacionesDBEntities fundacionesContext;
        public FrmGestioABM(Char xop, FundacionesDBEntities xfundacionesContext)
        {
            op = xop;
            fundacionesContext = xfundacionesContext;
            InitializeComponent();
        }

        private void add()
        {
            novesDades();
            schoolContext.Person.Add(p);
            schoolContext.SaveChanges();
        }

        private void novesDades()
        {
            if (tbNom.Text != "" && tbCognom.Text != "")
            {
                p.FirstName = tbNom.Text.Trim();
                p.LastName = tbCognom.Text.Trim();
                p.EnrollmentDate = dtData.Value.Date;
            }
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
                case 'D':
                    del();
                    break;
            }
            this.Close();
        }

        private void del()
        {
            throw new NotImplementedException();
        }

        //private void FrmABMEstudiants_Load(object sender, EventArgs e)
        //{
        //    if (op == 'M')
        //    {
        //        p = schoolContext.Person.Find(int.Parse(id.Trim()));

        //        if (p != null)
        //        {
        //            omplir();
        //        }
        //    }
        //    else p = new Person();
        //}

        private void omplir()
        {
            tbNom.Text = p.FirstName;
            tbCognom.Text = p.LastName;
            dtData.Text = p.EnrollmentDate.ToString();
        }
    }
}
