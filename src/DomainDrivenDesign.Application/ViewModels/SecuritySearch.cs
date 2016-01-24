using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDrivenDesign.Application.ViewModels
{
    public class SecuritySearch
    {
        [DisplayName("Security Code")]
        public string NameToSearch { get; set; }

        [DisplayName("Search for text")]
        public string TextToSearch { get; set; }

        public IEnumerable<SecurityViewModel> Securities { get; set; }
    }
}
