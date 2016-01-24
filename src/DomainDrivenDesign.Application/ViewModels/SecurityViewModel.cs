using System;
using System.ComponentModel.DataAnnotations;

namespace DomainDrivenDesign.Application.ViewModels
{
    public class SecurityViewModel
    {
        [Key]
        [Display(Name = "Security Id", Description = "")]
        public int SecurityId { get; set; }

        [Required(ErrorMessage = "Security Id is required")]
        [Display(Name = "Security Code", Description = "")]
        public string SecurityCode { get; set; }

        [Required(ErrorMessage = "Security Name is required")]
        [Display(Name = "Security Name", Description = "")]
        public string SecurityName { get; set; }

        [Required(ErrorMessage = "Insert a valid Sedol")]
        [MaxLength(7, ErrorMessage = "Sedol must be 7 digits ")]
        [Display(Name = "SEDOL", Description = "The SEDOL is used for all securities trading on the London Stock Exchange and other exchanges in the U.K.")]
        public string Sedol { get; set; }

        //CUSIP stands for “Committee on Uniform Securities Identification Procedures
        [Display(Name = "CUSIP", Description = "CUSIP number is key identifier used to uniquely identify the company or issuer and the type of security")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [MaxLength(9, ErrorMessage = "Provide 9 digits for CUSIP ")]
        public string Cusip { get; set; }

        /*
        ISIN stands for “International Securities Identification Number”. It is used to uniquely identifies a security. It is originated from ISO 6166. 
        ISIN is used to identify bonds, commercial paper, equities, warrants and most of the listed derivatives. The ISIN code is a 12 character alphanumerical code.
        One distinction is that ISIN code doesn’t change by exchange or currency it trades. It is unique unlike symbol that may change based on exhcnage and currency.
        To distinguish the exchange it has the same ISIN on each, though not the same ticker symbol. ISIN cannot specify a particular trading location in this case, and another identifier, 
        typically MIC or the three-letter exchange code, will have to be specified in addition to the ISIN. The SEDOL board of the London Stock Exchange has revised their own standards to address this issue.
        Example: LT0000610040
        */
        //ISIN stands for “International Securities Identification Number”
        [Display(Name = "ISIN", Description = "It is used to uniquely identifies a security")]
        public string Isin { get; set; }
    }
}
