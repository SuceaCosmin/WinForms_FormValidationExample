using FormValidationExample.Model;
using FormValidationExample.Presenters;
using FormValidationExample.Services;
using FormValidationExample.Views;
using System;
using System.Windows.Forms;

namespace FormValidationExample
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

            Form1 form = new Form1();

            IAnalogSignal signal = new AnalogSignal() {
                Name = "Signal",
                Value="35"
            };

            IAnalogSignalService service = new AnalogSignalService();

            AnalogSignalView view = new AnalogSignalView();

            AnalogSignalPresenter presenter = new AnalogSignalPresenter(signal,view, service);

          
            form.AddAnalogSignalView(view);
            Application.Run(form);
        }
    }
}
