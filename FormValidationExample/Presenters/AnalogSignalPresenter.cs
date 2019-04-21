using FormValidationExample.Model;
using FormValidationExample.Services;
using FormValidationExample.Views;
using FormValidationExample.Views.Args;
using System;

namespace FormValidationExample.Presenters
{
    public class AnalogSignalPresenter
    {
        private IAnalogSignal _signal;

        private IAnalogSignalView _view;

        private IAnalogSignalService _service;


        public AnalogSignalPresenter(IAnalogSignal signal, IAnalogSignalView view, IAnalogSignalService service) {
            _signal = signal;
            _view = view;
            _service = service;

            view.LoadModel(_signal);

            BindHandlersToView();
        }

        private void BindHandlersToView() {
            _view.SignalNameChanged += _view_SignalNameChanged;

        }

        private void _view_SignalNameChanged(object sender, ValueChangedEventArgs e)
        {
            try
            {
                Console.WriteLine($"Signal name changed to : {e.Value}");

                if (e.Value.Equals("red"))
                {
                    _view.InvalidateSignalName("The name is already used!");
                }
                else
                {
                    _signal.Name = e.Value;
                    _service.Update(_signal);
                }
            }
            catch (Exception ex) {
                Console.WriteLine($"Exception occured durring SignalName Change event due to: {ex.Message}");
            }
          
        }
    }
}
