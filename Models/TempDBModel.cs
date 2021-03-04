using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IzonStore.Models
{
    public class TempDBModel
    {
        [Key]
        public string Item { get; set; }
        public string Name { get; set; }
    }
}
