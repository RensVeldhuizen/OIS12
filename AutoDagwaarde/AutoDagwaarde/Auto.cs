using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDagwaarde
{
    enum BrandstofSoort
    {
        Benzine = 100,
        Diesel = 150,
        LPG = 90,
        Elektrisch = 130
    }
    class Auto
    {
        private int _KmStand = 0;
        private string _Kenteken;
        private int _Dagwaarde;
        private BrandstofSoort _brandstof;

        public void RijdKilometer(int gereden)
        {
            if (gereden > 0)
            {
                _KmStand = _KmStand + gereden;
            }
        }

        public BrandstofSoort brandstof()
        {
            return _brandstof;
        }

        public Auto(string kenteken, BrandstofSoort brndstof, int kmStand)
        {
            _Kenteken = kenteken;
            _brandstof = brndstof;
            _brandstof++;
            _KmStand = kmStand;
        }

        public int Dagwaarde()
        {
            _Dagwaarde = 500000 / _KmStand * (int)_brandstof;

            return _Dagwaarde;
        }

        public int KmStand()
        {
            return _KmStand;
        }

        public override string ToString()
        {
            string data = String.Format("{0} {1} auto {2}km heeft een dagwaarde van {3}.", _Kenteken, _brandstof, _KmStand, _Dagwaarde);
            return data;
        }
    }
}
