﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chart.lib
{
    public  class Chart
    {

        public Chart()
        {

            this.Rows = new List<ChartRow>();
        }
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        public string RawText { get; set; }

        //rows
        public virtual IList<ChartRow> Rows { get; set; }

    }
}
