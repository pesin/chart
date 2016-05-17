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
                return Stitch.Knit;

            }
            if (str.Equals("p"))
            {
                return Stitch.Purl;

            }

            try
            {
                Stitch stitchValue = (Stitch)Enum.Parse(typeof(Stitch), str);
                if (Enum.IsDefined(typeof(Stitch), stitchValue))
                {
                    return stitchValue;
                }
              
            }
            catch (ArgumentException)
            {
                //unknown stitch
            }
            return Stitch.Whaaaat;
        }
    }
}
