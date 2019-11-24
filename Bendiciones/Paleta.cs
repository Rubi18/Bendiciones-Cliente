using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Bendiciones
{
    class Paleta
    {
        static string hexValue1 = "#D3BFD9";
        static string hexValue2 = "#f7f700";
        static string hexValue3 = "#FFA214";
        static string hexValue4 = "#A6401B";
        static string hexValue5 = "#401309";
        static string hexValue6 = "#FFFFFF";
        static string hexValue7 = "#F6F7FB";
        static string hexValue8 = "#2C2C2C";
        static string hexValue9 = "#FF8F02";

        private Color lila = System.Drawing.ColorTranslator.FromHtml(hexValue1);
        private Color amarillo = System.Drawing.ColorTranslator.FromHtml(hexValue2);
        private Color naranja = System.Drawing.ColorTranslator.FromHtml(hexValue3);
        private Color marronClaro = System.Drawing.ColorTranslator.FromHtml(hexValue4);
        private Color marron = System.Drawing.ColorTranslator.FromHtml(hexValue5);
        private Color blanco = System.Drawing.ColorTranslator.FromHtml(hexValue6);
        private Color grisClaro = System.Drawing.ColorTranslator.FromHtml(hexValue7); 
        private Color grisOscuro = System.Drawing.ColorTranslator.FromHtml(hexValue8);
        private Color naranjaOscuro = System.Drawing.ColorTranslator.FromHtml(hexValue9);

        public Color Lila { get => lila; set => lila = value; }
        public Color Amarillo { get => amarillo; set => amarillo = value; }
        public Color Naranja { get => naranja; set => naranja = value; }
        public Color MarronClaro { get => marronClaro; set => marronClaro = value; }
        public Color Marron { get => marron; set => marron = value; }
        public Color Blanco { get => blanco; set => blanco = value; }
        public Color GrisClaro { get => grisClaro; set => grisClaro = value; }
        public Color GrisOscuro { get => grisOscuro; set => grisOscuro = value; }
        public Color NaranjaOscuro { get => naranjaOscuro; set => naranjaOscuro = value; }
    }
}
