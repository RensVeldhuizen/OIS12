using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankRekening
{
    public partial class fBankrekening : Form
    {
        private Bankrekening bankrekeningLinks;
        private Bankrekening bankrekeningRechts;
        public fBankrekening()
        {
            InitializeComponent();
            bankrekeningLinks = new Bankrekening("Duck, Dagobert");
            bankrekeningRechts = new Bankrekening("Piet, Lut", 10);
        }

        private void fBankrekening_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void btStortenLinks_Click(object sender, EventArgs e)
        {
            int bedrag = bankrekeningLinks.CheckNummer(tbEuroLinks.Text, tbCentLinks.Text);
            bankrekeningLinks.Stort(bedrag);
            GetData();
            bankrekeningLinks.Write(bankrekeningLinks, " stort ", bedrag, bankrekeningLinks.GetSaldo());
        }

        private void btStortenRechts_Click(object sender, EventArgs e)
        {
            bankrekeningRechts.Stort(bankrekeningRechts.CheckNummer(tbEuroRechts.Text, tbCentenRechts.Text));
            GetData();
        }

        private void btOpnemenLinks_Click(object sender, EventArgs e)
        {
            int Saldo = bankrekeningLinks.CheckNummer(tbEuroLinks.Text, tbCentLinks.Text);
            bankrekeningLinks.Opnemen(bankrekeningLinks, Saldo);
            GetData();
        }

        private void btOpnemenRechts_Click(object sender, EventArgs e)
        {
            int Saldo = bankrekeningRechts.CheckNummer(tbEuroRechts.Text, tbCentenRechts.Text);
            bankrekeningRechts.Opnemen(bankrekeningRechts,Saldo);
            GetData();
        }

        private void btRechts_Click(object sender, EventArgs e)
        {
            int Saldo = bankrekeningRechts.CheckNummer(tbEuroLinks.Text, tbCentLinks.Text);
            bankrekeningLinks.MaakOver(bankrekeningLinks, bankrekeningRechts, Saldo);
            GetData();
        }

        private void btLinks_Click(object sender, EventArgs e)
        {
            int Saldo = bankrekeningLinks.CheckNummer(tbEuroRechts.Text, tbCentenRechts.Text);
            bankrekeningRechts.MaakOver(bankrekeningRechts, bankrekeningLinks, Saldo);
            GetData();
        } 

        private void GetData()
        {
            lNrLinks.Text = bankrekeningLinks.rekeningnummer();
            lNaamLinks.Text = bankrekeningLinks.naam;
            lSaldoLinks.Text = bankrekeningLinks.saldo().ToString("C");

            lNrRechts.Text = bankrekeningRechts.rekeningnummer();
            lNaamRechts.Text = bankrekeningRechts.naam;
            lSaldoRechts.Text = bankrekeningRechts.saldo().ToString("C");
        }

    }
}
