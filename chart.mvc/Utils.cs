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
            switch (stitch.StitchType)
            {
                case StitchType.Basic:
                    icon = (stitch.ReverseIndicator?"p": "k");
                    break;
                case StitchType.YarnOver:
                    icon = "o";
                    break;
              
               
                default:
                    break;
            }

            return icon;
        }
    }
}
