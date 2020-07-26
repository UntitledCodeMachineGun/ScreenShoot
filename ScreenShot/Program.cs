using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Awesomium.Core;
using FlashBrokerLib;

namespace ScreenShot
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]



        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            /*var webView = WebCore.CreateWebView(1920, 1080);
            webView.Source = new Uri("http://videoprobki.ua/camera/183-ulitsa-bratislavskaya-lesnoi-prospekt?c=Kyiiv");

            webView.LoadingFrameComplete += (s, e) =>
            {
                if (!e.IsMainFrame)
                    return;
                BitmapSurface surface = (BitmapSurface)webView.Surface;
                surface.SaveToPNG("result.png", true);

                WebCore.Shutdown();
            };

            WebCore.Run();
            webView.Dispose();*/
        }
    }
}
