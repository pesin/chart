using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chart.lib
{
    /// <summary>
    /// Obviously this class is going to become more sofisticated
    /// </summary>
    class Parser
    {
        public static Stitch String2Stitch(String str)
        {
            if (str.Equals("k"))
            {
                return StitchFactory.getKnit();

            }
            if (str.Equals("p"))
            {
                return StitchFactory.getPurl();

            }

            return new Stitch()
            {
                StitchType=StitchType.Whaaaat,

            };
        }
    }
}
