using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DB
{
   public class Branch
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Code {  get; set; }
        public string Description   { get; set; }
        public string Address { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        
        public int CoinId { get; set; }

       
        [ForeignKey("CoinId")]
      
        public virtual Coin Coin { get; set; }



    }
}
