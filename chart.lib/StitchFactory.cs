using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace chart.lib
{
   
    public static class StitchFactory
    {
        public static Stitch getPurl()
        {
            return getOneBasicStitch(true);
        }

        public static Stitch getKnit()
        {
            return getOneBasicStitch(false);
        }


        private static Stitch getOneBasicStitch(bool reverseIndicator)
        {
            return new Stitch()
            {
                BaseStiches = 1,
                MadeStitches = 1,
                ReverseIndicator = reverseIndicator,
                SlipLeftSideLoop = true,
                StitchType = StitchType.Basic
            };
        }
    }
}
