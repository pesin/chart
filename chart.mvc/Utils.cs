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
                    icon = "asterisk";
                    break;
                case Stitch.Purl:
                    break;
                case Stitch.YarnOver:
                    icon = "adjust";
                    break;
                case Stitch.K2:
                    icon = "menu-up";
                    break;
                case Stitch.P2:
                    icon = "triangle-top";
                    break;
                case Stitch.K3:
                    icon = "menu-up";
                    break;
                case Stitch.P3:
                    icon = "triangle-top";
                    break;
                case Stitch.Cable8_slip2b_k1_p1slip_k1slip_p1slip_slip1f_k1p1k1_k1slip:
                    icon = "align-justify";
                    break;
                default:
                    break;
            }

            return icon;
        }
    }
}
