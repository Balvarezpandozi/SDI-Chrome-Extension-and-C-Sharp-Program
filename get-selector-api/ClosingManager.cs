using System.Diagnostics;

namespace get_selector_api
{
    public class ClosingManager
    {
        WebApplication App;
        public ClosingManager(WebApplication app) {
            App = app;
            new Task(checkGoogleChromeIsOpen).Start();
        }

        private void checkGoogleChromeIsOpen()
        {
            while (true)
            {
                Process[] chromeInstances = Process.GetProcessesByName("chrome");
                if (chromeInstances.Length < 1)
                {
                    App.StopAsync();
                }
                Thread.Sleep(100);
            }
            
        }
    }
}
