using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chart.lib
{
    public  class ChartCell
    {
        [Key]
        public int Id { get;  set; }

        [Required]
        [EnumDataType(typeof(Stitch))]
        public Stitch Stitch { get;  set; }
    }
}
