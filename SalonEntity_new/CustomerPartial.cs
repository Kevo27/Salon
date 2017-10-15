using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonEntity_new
{

    [MetadataType(typeof(Customer))]
    public partial class Customer
    {
        public string FullName { get { return this.FName + " " + this.LName; } }
    }

    public partial class Customer
    {
        public class CustomerMetadata
        {
            
        }
    }
}
