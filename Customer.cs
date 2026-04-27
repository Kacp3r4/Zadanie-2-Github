using System;
using System.Collections.Generic;
using System.Text;

namespace Abonaments
{
    internal class AbonamentOffer
    {
        public int DlugoscUmowyMiesiace { get; }
        public decimal OplataMiesieczna { get; }
        private double _znizkaNaAparat;
        public double ZnizkaNaAparat
        {
            get
            {
                return _znizkaNaAparat;
            }
            set
            {
                if (value > 50)
                {
                    _znizkaNaAparat = 50;
                }
                else
                {
                    _znizkaNaAparat = value;
                }
            }
        }
        public AbonamentOffer(int dlugoscUmowyMiesiace, decimal oplataMiesieczna, double znizkaNaAparat)
        {
            DlugoscUmowyMiesiace = dlugoscUmowyMiesiace;
            OplataMiesieczna = oplataMiesieczna;
            ZnizkaNaAparat = znizkaNaAparat;
        }
        public string PobierzInformacje()
        {
            return $"Umowa: {DlugoscUmowyMiesiace} msc, Opłata: {OplataMiesieczna:C}, Zniżka: {ZnizkaNaAparat}%";
        }
    }
}