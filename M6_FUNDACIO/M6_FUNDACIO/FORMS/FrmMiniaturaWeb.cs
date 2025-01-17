using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M6_FUNDACIO.FORMS
{
    public partial class FrmMiniaturaWeb : Form
    {
        FundacionesDBEntities fundacionesContext;
        public FrmMiniaturaWeb(FundacionesDBEntities xfundacionesContext)
        {
            InitializeComponent();
            fundacionesContext = xfundacionesContext;
        }


        private Bitmap CaptureWebPage(string url)
        {
            Bitmap result = null;

            var thread = new Thread(() =>
            {
                using (WebBrowser browser = new WebBrowser())
                {
                    // Configurar la web
                    browser.ScrollBarsEnabled = false;
                    browser.ScriptErrorsSuppressed = true;

                    // evento
                    browser.DocumentCompleted += (s, e) =>
                    {
                        // Ajustar tamaño 
                        browser.Width = browser.Document.Body.ScrollRectangle.Width;
                        browser.Height = browser.Document.Body.ScrollRectangle.Height;

                        // Renderizar la página en un Bitmap 
                        result = new Bitmap(browser.Width, browser.Height);
                        browser.DrawToBitmap(result, new Rectangle(0, 0, result.Width, result.Height));

                        // Salir del hilo
                        Application.ExitThread();
                    };

                    // ir a la URL
                    browser.Navigate(url);
                    Application.Run();
                }
            });

            // Configurar el hilo
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join(); // Esperar a que el hilo acabe

            return result; // dar la captura
        }

        private void getMiniaturaWeb()
        {
            var qryCursosInscrit = (from c in fundacionesContext.Fundacion
                                    select new
                                    {
                                        ID = c.ID,
                                        Nombre = c.Nombre,
                                        Link_Web = c.Link_Web,
                                        foto = c.FotoWeb
                                    });

            Cursor = Cursors.WaitCursor;
            dgDades.DataSource = qryCursosInscrit.ToList().Distinct().ToList();
            dgDades.Columns["Link_Web"].HeaderText = "Link Pagina Web";
            dgDades.Columns["foto"].Visible = false;
            Cursor = Cursors.Default;

        }


        private void dgDades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgDades.SelectedRows[0].Cells["foto"].Value != null)
            {
                pbImatge.Image = Base64ToImage(dgDades.SelectedRows[0].Cells["foto"].Value.ToString());
            }
            else
            {
                pbImatge.Image = null;
            }
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

        private void pbAdd_Click(object sender, EventArgs e)
        {
            string xid = dgDades.SelectedRows[0].Cells["id"].Value.ToString().Trim();
            string xlink = dgDades.SelectedRows[0].Cells["Link Pagina Web"].Value.ToString();

            Bitmap imagenWeb = CaptureWebPage(xlink);
            pbImatge.Image = imagenWeb;

            Fundacion r = fundacionesContext.Fundacion.Find(int.Parse(xid));
            
            if (r != null)
            {
                r.FotoWeb = ImageToBase64(pbImatge.Image);
                ferCanvis();
            }

        }

        private void pbDel_Click(object sender, EventArgs e)
        {
            if (dgDades.Rows.Count > 0)
            {
                string xid = dgDades.SelectedRows[0].Cells["id"].Value.ToString().Trim();
                Fundacion r = fundacionesContext.Fundacion.Find(int.Parse(xid));  
                if (r != null)
                {
                    r.FotoWeb = null;
                    ferCanvis();
                }

            }
            else
            {
                MessageBox.Show("No has seleccionat cap fila", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            getMiniaturaWeb();
            pbImatge.Image = null;

        }

        private void FrmMiniaturaWeb_Load(object sender, EventArgs e)
        {
            getMiniaturaWeb();
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


    }

}
