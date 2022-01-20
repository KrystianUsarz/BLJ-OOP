using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RechteckForm1
{
    class Rechteck
    {
        double height;
        double width;

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public double GetArea()
        {
            return height * width;
        }
    }
}
