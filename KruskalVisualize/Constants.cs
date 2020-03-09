using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KruskalVisualize
{
    public static class Constants
    {
        public const string FILE_PATH_1 = "save1.txt";
        public const string FILE_PATH_2 = "save2.txt";
        public const string FILE_PATH_3 = "save3.txt";

        public const int ELLIPSE_WIDTH = 30;
        public const int ELLIPSE_HEIGHT = 30;
        public const int ELLIPSE_OFFSET_X = ELLIPSE_WIDTH / 2;
        public const int ELLIPSE_OFFSET_Y = ELLIPSE_HEIGHT / 2;

        public const float EDGE_WEIGHT_OFFSET_MULTIPLIER = 0.20f;

        public const int WEIGHT_TEXT_SIZE = 16;
        public const int WEIGHT_TEXT_OFFSET = WEIGHT_TEXT_SIZE / 2;
    }
}
