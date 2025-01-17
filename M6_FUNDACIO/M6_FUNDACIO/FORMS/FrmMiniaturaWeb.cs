using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            // Crear un hilo STA para manejar el WebBrowser
            var thread = new Thread(() =>
            {
                using (WebBrowser browser = new WebBrowser())
                {
                    // Configurar el navegador
                    browser.ScrollBarsEnabled = false;
                    browser.ScriptErrorsSuppressed = true;

                    // Manejar el evento de carga completa
                    browser.DocumentCompleted += (s, e) =>
                    {
                        // Ajustar el tamaño del navegador al contenido
                        browser.Width = browser.Document.Body.ScrollRectangle.Width;
                        browser.Height = browser.Document.Body.ScrollRectangle.Height;

                        // Renderizar la página en un Bitmap temporal
                        result = new Bitmap(browser.Width, browser.Height);
                        browser.DrawToBitmap(result, new Rectangle(0, 0, result.Width, result.Height));

                        // Salir del hilo
                        Application.ExitThread();
                    };

                    // Navegar a la URL
                    browser.Navigate(url);
                    Application.Run();
                }
            });

            // Configurar el hilo como STA y ejecutarlo
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join(); // Espera a que el hilo termine antes de continuar

            return result; // Devuelve el Bitmap con la captura
        }
    }
}
