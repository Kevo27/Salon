using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonEntity_new
{

    [MetadataType(typeof(CustomerMetadata))]
    public partial class Customer
    {
        public string FullName { get { return this.FName + " " + this.LName; } }
    }

    /// <summary>
    /// Metadata
    /// </summary>
        public class CustomerMetadata
        {
            [Required]
            public string LName { get; set; }

            [Required]
            public string FName { get; set; }
        }    
}
