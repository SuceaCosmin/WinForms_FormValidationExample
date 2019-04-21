using System;
using FormValidationExample.Model;
using FormValidationExample.Views.Args;

namespace FormValidationExample.Views
{
    public interface IAnalogSignalView
    {
        event EventHandler<ValueChangedEventArgs> SignalNameChanged;

        void LoadModel(IAnalogSignal analogSignal);

        void InvalidateSignalName(string message);
  
    }
}