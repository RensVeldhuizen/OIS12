using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VijverVanRens
{
    class Eend
    {
        private string naam;
        private string geslacht;

        public string getGeslacht()
        {
            return this.geslacht;
        }

        public void setGeslacht(string geslacht)
        {
            this.geslacht = geslacht;
        }
        public string getNaam()
        {
            return this.naam;
        }
        public void setNaam(string naam)
        {
            this.naam = naam;
        }
        
    }
}
