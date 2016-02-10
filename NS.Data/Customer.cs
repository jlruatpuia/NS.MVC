using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NS.Data
{
    [Table("customer")]
    class Customer
    {
        [Column("CustomerID")]
        public int CustomerID { get; set; }
        public string CustomerNo { get; set; }
        public string CustomerName { get; set; }
        public string Category { get; set; }
        public string Sex { get; set; }
        public string DOB { get; set; }
        public string Address { get; set; }
        [Column("TelOff")]
        public string MobileNo { get; set; }
        [Column("TelRes")]
        public string PhoneNo { get; set; }
        [Column("EmailPri")]
        public string EmailID { get; set; }
        public string PanNo { get; set; }
        public string PlanSelected { get; set; }
        public string Speed { get; set; }
        public byte[] Photo { get; set; }
        public bool Pending { get; set; }
    }
}
