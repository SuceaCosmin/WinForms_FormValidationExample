namespace FormValidationExample.Model
{
    public class AnalogSignal : IAnalogSignal
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }

        override
        public string ToString()
        {
            return $"AnalogSignal: Id={Id}, Name={Name}";
        }
    }
}
