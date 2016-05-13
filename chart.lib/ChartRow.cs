using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set;}
        public int RowNumber { get; set; }
        public virtual IList<ChartCell> Cells { get; set; }

        [Required]
        public Side Side { get; set; }
    }
}
