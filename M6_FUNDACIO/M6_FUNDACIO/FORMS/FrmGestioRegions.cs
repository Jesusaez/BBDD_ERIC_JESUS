using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M6_FUNDACIO.FORMS
{
    public partial class FrmGestioRegions : Form
    {
        private FundacionesDBEntities fundacionesContext { get; set; }
        FrmGestioABM fGestioABM;
        String gestio;
        public FrmGestioRegions(String xGestio,FundacionesDBEntities xfundacionesContext)
        {
            InitializeComponent();
            fundacionesContext = xfundacionesContext;
            gestio = xGestio;
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

            cbContinents.DisplayMember = "nom";
            cbContinents.ValueMember = "id";
            cbContinents.DataSource = qryGestio.ToList();
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

            cbContinents.DisplayMember = "nom";
            cbContinents.ValueMember = "id";
            cbContinents.DataSource = qryGestio.ToList();
            Cursor = Cursors.Default;
        }
        private void cbContinents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbContinents.SelectedItem != null)
            {
                omplirDades();
            }
        }
        private void omplirDades()
        {
            if (gestio == "Ciutat") omplirCiutats();
            else omplirPais();
        }
        private void omplirPais()
        {
            var qryCursosInscrit = (from c in fundacionesContext.Pais
                                    orderby c.Nombre
                                    where (c.IDContinente == (Int32)cbContinents.SelectedValue)
                                    select new
                                    {
                                        ID = c.ID,
                                        Nom = c.Nombre
                                    });

            Cursor = Cursors.WaitCursor;
            dgDades.DataSource = qryCursosInscrit.ToList().Distinct().ToList();

            dgDades.Columns["Nom"].HeaderText = "Nom Pais";
            Cursor = Cursors.Default;
        }
        private void omplirCiutats()
        {
            var qryCiutat = (from c in fundacionesContext.Ciutat
                                    orderby c.Nombre
                                    where (c.IDPais == (Int32)cbContinents.SelectedValue)
                                    select new
                                    {
                                        ID = c.ID,
                                        Nom = c.Nombre
                                    });

            Cursor = Cursors.WaitCursor;
            dgDades.DataSource = qryCiutat.ToList().Distinct().ToList();
            
            dgDades.Columns["Nom"].HeaderText = "Nom Ciutat";
            Cursor = Cursors.Default;
        }


        private void FrmGestioCiutats_Load(object sender, EventArgs e)
        {
            try
            {
                if (gestio == "Ciutat") getPais();
                else getContinents();
                lbRegio.Text = gestio;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos" + ex.Message, "ERROR");
            }

        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            fGestioABM = new FrmGestioABM('A',gestio, fundacionesContext);
            fGestioABM.idAdd = (int)cbContinents.SelectedValue;
            if (dgDades.SelectedRows != null)
            {
                fGestioABM.Name = "Añadir" + gestio;
                fGestioABM.ShowDialog();
            }
            omplirDades();

            fGestioABM = null;
        }

        private void pbDel_Click(object sender, EventArgs e)
        {
            omplirABM('B',gestio);
            if (dgDades.SelectedRows != null)
            {
                fGestioABM.Name = "Eliminar" + gestio;
                fGestioABM.ShowDialog();
            }
            omplirDades();

            fGestioABM = null;
        }
        private void omplirABM(char xOp, String xGestio)
        {
            fGestioABM = new FrmGestioABM(xOp, xGestio, fundacionesContext);
            fGestioABM.id = dgDades.SelectedRows[0].Cells["id"].Value.ToString().Trim();
            fGestioABM.nom = dgDades.SelectedRows[0].Cells["nom"].Value.ToString().Trim();
        }
        private void dgDades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            omplirABM('M',gestio);
            if (dgDades.SelectedRows != null)
            {
                fGestioABM.Name = "Modificar" + gestio;
                fGestioABM.ShowDialog();
            }
            omplirDades();

            fGestioABM = null;
        }
    }
}
