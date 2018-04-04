using System.Collections.Generic;

namespace mvc.Database.Entities
{
    public class CryptoCurrency
    {
        public CryptoCurrency()
        {
            Prices = new List<Price>();
        }

        public int Id { get; set; }

        //[Required]
        //[MaxLength(128)]
        public string Name { get; set; }

        public List<Price> Prices { get; set; }
    }
}
