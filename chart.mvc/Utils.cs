using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using chart.lib;

namespace chart.mvc
{
   public static class Utils
    {
        public static String GetStitchIcon(Stitch stitch)
        {
            String icon = "unchecked";
            switch (stitch)
            {
                case Stitch.Knit:
                    icon = "k";
                    break;
                case Stitch.Purl:
                    icon = "p";
                    break;
              
               
                default:
                    break;
            }

            return icon;
        }
    }
}
