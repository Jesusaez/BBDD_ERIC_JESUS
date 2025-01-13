using M6_FUNDACIO.FORMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M6_FUNDACIO
{
    public partial class FrmMain : Form
    {
        private FundacionesDBEntities fundacionesContext { get; set; } = new FundacionesDBEntities();
        FrmGestion fGestion;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void paisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String xnom = "Paises";

            if (!(ja_esta_obert(xnom)))
            {
                fGestion = new FrmGestion(fundacionesContext); // fem un nou formulari i l'afegim a la llista de formularis
                fGestion.Name = xnom;
                fGestion.MdiParent = this;
                fGestion.Show();
            }
            fGestion.Activate();
        }
        private Boolean ja_esta_obert(String xnom)
        {

            int x1 = 0;
            Boolean xb = false;

            while ((x1 < this.MdiChildren.Length) && (!(xb)))
            {
                xb = (this.MdiChildren[x1].Name == xnom);
                x1++;
            }
            return (xb);
        }
    }
}
