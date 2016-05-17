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


        public ChartRow(string[] list):this()
        {
            if (list!=null && list.Length > 0)
            {
                for(int j = list.Length - 1; j >= 0; j--)
                {
                    ChartCell c = new ChartCell()
                    {
                        Stitch = Parser.String2Stitch(list[j])
                    };
                    this.Cells.Add(c);

                }
            }
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
