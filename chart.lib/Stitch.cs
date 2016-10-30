using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chart.lib
{
  
    /// <summary>
    /// One stich
    /// </summary>
    public class Stitch
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StichId { get; set; }

        [EnumDataType(typeof(StitchType))]
        public StitchType StitchType { get; set; }

        public bool ReverseIndicator { get; set; }

        [Range(1, Int32.MaxValue)]
        public int BaseStiches { get; set; }

        [Range(1, Int32.MaxValue)]
        public int MadeStitches { get; set; }
        public bool SlipLeftSideLoop { get; set; }

        public Stitch()
        {
            this.BaseStiches = 1;
            this.MadeStitches = 1;
            this.ReverseIndicator = false;
            this.SlipLeftSideLoop = true;
        }
    }

   
}
