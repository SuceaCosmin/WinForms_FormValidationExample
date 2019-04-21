using System.Collections.Generic;
using FormValidationExample.Model;

namespace FormValidationExample.Services
{
    public interface IAnalogSignalService
    {
        void Add(IAnalogSignal analogSignal);
        IEnumerable<IAnalogSignal> GetAll();
        void Remove(IAnalogSignal analogSignal);
        void Update(IAnalogSignal analogSignal);
    }
}