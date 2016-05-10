using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chart.lib
{
    public class ChartRow
    {

        public ChartRow()
        {
            this.Side = Side.RS;
            this.Cells = new List<ChartCell>();
        }

        [Key]
        public int ID { get; set;}
        public virtual IList<ChartCell> Cells { get; set; }

        [Required]
        public Side Side { get; set; }
    }
}
