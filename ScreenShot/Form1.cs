using System;
using System.Drawing;
using System.Windows.Forms;

namespace ScreenShot
{
    public partial class Form1 : Form
    {
        class WebsiteCaptureMaker
        {
            private WebBrowser internetBrowser;

            public WebsiteCaptureMaker() //браузер
            {
                internetBrowser = new WebBrowser(); //экземпляр браузера
                internetBrowser.ScrollBarsEnabled = false;
                internetBrowser.ScriptErrorsSuppressed = true;
                
            }

            public Bitmap MakeScreenshot(string _websiteURL) //метод скриншота
            {
                internetBrowser.Navigate(_websiteURL);//заходим на сайт, не отображая скроллбара но показывая скрипты
                while (internetBrowser.ReadyState != WebBrowserReadyState.Complete || internetBrowser.IsBusy)
                Application.DoEvents();

                internetBrowser.Width = internetBrowser.Document.Body.ScrollRectangle.Width; //ширина скрина
                internetBrowser.Height = internetBrowser.Document.Body.ScrollRectangle.Height; //высота скрина

                Bitmap websiteScreenshot = new Bitmap(internetBrowser.Width, internetBrowser.Height);
                internetBrowser.DrawToBitmap(websiteScreenshot, new Rectangle(0, 0, internetBrowser.Width, internetBrowser.Height));

                return websiteScreenshot;
            }

            public void Dispose()
            {
                internetBrowser.Dispose();
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int h = 0;
            string date = DateTime.Now.ToString("yyyyMMddhhmm"); //дата скрина
            WebsiteCaptureMaker captureMaker = new WebsiteCaptureMaker();
            Bitmap websiteCapture = captureMaker.MakeScreenshot(textBox1.Text);
            websiteCapture.Save("screenshot" + date + ".jpg");
            //websiteCapture.Dispose();
            websiteCapture.Dispose();
        }
    }
}
