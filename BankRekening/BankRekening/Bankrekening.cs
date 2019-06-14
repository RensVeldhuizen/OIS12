using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankRekening
{
    class Bankrekening
    {
        private readonly int _rekeningnummer;
        private string _naam;
        private int _saldo; 
        private static int _volgendeVrijeRekeningnummer = 2001;

        public string rekeningnummer()
        {
            return _rekeningnummer.ToString();
        }

        public string naam
        {
            get{ return _naam; }
            set { _naam = value; }
        }

        public double saldo()
        {
            double dSaldo = _saldo;
            double KommaGetal = dSaldo / 100;

            return KommaGetal;
        }

        public int GetSaldo()
        {
            return _saldo;
        }

        public Bankrekening(string naam)
        {
            _naam = naam;
            _saldo = 0;
            _rekeningnummer = _volgendeVrijeRekeningnummer;
            _volgendeVrijeRekeningnummer++;
        }

        public Bankrekening(string naam, int saldo)
        {
            _naam = naam;
            _saldo = saldo;
            _rekeningnummer = _volgendeVrijeRekeningnummer;
            _volgendeVrijeRekeningnummer++;
        }

        public void NeemOp(int bedrag)
        {
            int NieuwSaldo = _saldo - bedrag;
            _saldo = NieuwSaldo;
        }

        public void Stort(int bedrag)
        {
            _saldo = _saldo + bedrag;
        }

        public void MaakOver(Bankrekening andereRekening, int bedrag)
        {
            andereRekening.Stort(bedrag);
            NeemOp(bedrag);
        }

        public int CheckNummer(string sEuro, string sCenten)
        {
            int euro;
            int cent;
            int totaal;
            if (int.TryParse(sEuro, out euro) && int.TryParse(sCenten, out cent))
            {
                totaal = euro * 100 + cent;
                if (totaal > 0)
                {
                    return totaal;
                }
                else
                {
                   
                    return 0;
                }
            }
            else
            {
             
                return 0;
            }
        }

        public bool CheckNieuwSaldo(int bedrag, int saldo)
        {
            int iSaldo = saldo;
            int NieuweSaldo = saldo - bedrag;
            if (NieuweSaldo >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Opnemen(Bankrekening rekening, int bedrag)
        {
            if (CheckNieuwSaldo(bedrag, rekening.GetSaldo()))
            {
                rekening.NeemOp(bedrag);
            }
            else
            {
                
            }
        }

        public void MaakOver(Bankrekening rekening1, Bankrekening rekening2, int bedrag)
        {
            if (CheckNieuwSaldo(bedrag, rekening1.GetSaldo()))
            {
                rekening1.MaakOver(rekening2, bedrag);
            }
            else
            {
                
            }
        }

        public void Write(Bankrekening rek, string type, int bedrag, int saldo)
        {
            string rekening = rek.naam;
            string transactietype = type;
            int hoeveelheid = bedrag;
            int nieuweSaldo = saldo;

            StringBuilder text = new StringBuilder(rekening + transactietype + hoeveelheid + ", Nieuwe saldo: " + nieuweSaldo);

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\Rens\source\repos\BankRekening\transacties.txt", true))
            {
                file.WriteLine(text.ToString());
            }
        }
    }
}
