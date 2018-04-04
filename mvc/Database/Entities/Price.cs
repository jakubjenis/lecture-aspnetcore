using System;

namespace mvc.Database.Entities
{
    public class Price
    {
        public Price()
        {
        }
        
        public Price(double value, Currency currency = Currency.Usd) 
            : this(value, DateTime.Now, currency)
        {
            Value = value;
            Currency = currency;
            Timestamp = DateTime.Now;
        }

        public Price(double value, DateTime timestamp, Currency currency = Currency.Usd)
        {
            Value = value;
            Currency = currency;
            Timestamp = timestamp;
        }

        public int Id { get; set; }
        
        public Currency Currency { get; set; }
        
        public double Value { get; set; }
        
        public DateTime Timestamp { get; set; }
    }
}
