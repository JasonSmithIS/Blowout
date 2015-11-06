using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlowOut.Models
{
    [Table("Client")]
    public class Client
    {
        [Key]
        public int ClientID { get; set; }
        public string ClientFirstName { get; set; }
        public string ClientLastName { get; set; }
        public string ClientAddress { get; set; }
        public string ClientCity { get; set; }
        public string ClientState { get; set; }
        public string ClientZip { get; set; }
        public string ClientEmail { get; set; }
        public string ClientPhone { get; set; }
    }
    [Table("Instrument")]
    public class Instrument 
    { 
        [Key]
        public int InstrumentID { get; set; }
        public string InstrumentDesc { get; set; }
        public int ClientID { get; set; }
        public string InstrumentImg { get; set; }
        public double InstrumentPrice { get; set; }
        public string InstrumentType { get; set; }
    }
}