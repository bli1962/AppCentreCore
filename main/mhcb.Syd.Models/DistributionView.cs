using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace mhcb.Syd.Models
{
    public class DistributionView
    {
        public int Id { get; set; }
        public int DocumentId { get; set; }
        public string DocumentLocation { get; set; }
        public string Status { get; set; }
        public string ChannelId { get; set; }
        public string DeliveryAddress { get; set; }    
        public string CustomerCode { get; set; }
        public string CustAbbr { get; set; }
        public string Reference { get; set; }
        public string DateAdded { get; set; }
        public string DateAvailable { get; set; }    
        public string DateSent { get; set; }   
        public string DateDeleted { get; set; }
        public string AddedBy { get; set; }
        public string SentBy { get; set; } 
        public string DeletedBy { get; set; }      
        public string AssociatedSubject { get; set; }     
        public string AssociatedBody { get; set; }
      
    }
}
