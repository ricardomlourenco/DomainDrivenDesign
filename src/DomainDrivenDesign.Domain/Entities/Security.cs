using System;

namespace DomainDrivenDesign.Domain.Entities
{
 public class Security
    {
        public int SecurityId { get; set; }
        public string SecurityCode { get; set; }
        public string SecurityName { get; set; }
        public string Sedol { get; set; }
        public string Cusip { get; set; }
        public string Isin { get; set; }
    }
}
