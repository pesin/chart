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
    /// A  single cell or block of cells (horizontal)
    /// </summary>
    public  class ChartCell
    {
        public ChartCell()
        {
            BlockSize = 1;
        }

        /// <summary>
        /// Unique identifier
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get;  set; }

        /// <summary>
        /// Stitch type
        /// </summary>
        [Required]
        [EnumDataType(typeof(Stitch))]
        public virtual Stitch Stitch { get;  set; }


        /// <summary>
        /// Number of stitches in this block
        /// </summary>
        [Required]
        [Range(1,Int32.MaxValue)]
        public virtual int BlockSize { get; set; }
    }
}
