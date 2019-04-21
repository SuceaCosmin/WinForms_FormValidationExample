using FormValidationExample.Model;
using System;
using System.Collections.Generic;

namespace FormValidationExample.Services
{
    public class AnalogSignalService : IAnalogSignalService
    {

        public void Add(IAnalogSignal analogSignal) {
            Console.WriteLine($"Added {analogSignal} to data source!");
        }

        public void Update(IAnalogSignal analogSignal) {
            Console.WriteLine($"Updated {analogSignal} in data source!");
        }

        public IEnumerable<IAnalogSignal> GetAll() {

            return new List<IAnalogSignal>();
        }

        public void Remove(IAnalogSignal analogSignal) {
            Console.WriteLine($"Removed {analogSignal} from data source!");
        }

    }
}
