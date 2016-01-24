using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainDrivenDesign.Domain.Entities;

namespace DomainDrivenDesign.Infra.Data.Migrations.Seed
{
    internal static class SecuritySeed
    {
        public static List<Security> Seed()
        {
            List<Security> securities = new List<Security>()
            {
                new Security() { SecurityId = 1, SecurityCode="GOOG", SecurityName="GOOGLE" },
                new Security() { SecurityId = 2, SecurityCode = "YAHOO", SecurityName = "YAHOO" },
                new Security() { SecurityId = 3, SecurityCode = "APPPL", SecurityName = "APPLE" },
                new Security() { SecurityId = 4, SecurityCode = "TEST", SecurityName = "SEED TEST"},
            };
            
            return securities;
        }
    }
}
