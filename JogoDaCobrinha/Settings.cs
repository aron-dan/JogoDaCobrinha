using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaCobrinha
{
    class Settings
    {

        public static int Widh { get; set; }
        public static int Height { get; set; }
        public static string direction;

        public Settings()
        {
            Widh = 16;
            Height = 16;
            direction = "left";
        }

    }
}
