using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FillSpheres
{
    public class Color
    {
        private int red;
        private int green;
        private int blue;
        private int alpha;

        public Color(int red, int green, int blue, int alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        public Color(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = 255;
        }

        public int Red
        {
            get { return red; }
            set { red = value; }
        }

        public int Green
        {
            get { return green; }
            set { green = value; }
        }

        public int Blue
        {
            get { return blue; }
            set { blue = value; }
        }

        public int Alpha
        {
            get { return alpha; }
            set { alpha = value; }
        }

        public int GetGrey()
        {
            return (red + green + blue) / 3;
        }

        public string Name
        {
            get
            {
                switch (Red)
                {
                    case 255 when Green == 0 && Blue == 0:
                        return "Red 100%";
                    case 0 when Green == 255 && Blue == 0:
                        return "Green 100%";
                    case 0 when Green == 0 && Blue == 255:
                        return "Blue 100%";
                    default:
                        return "Mixed";
                }
            }
        }
    }
}