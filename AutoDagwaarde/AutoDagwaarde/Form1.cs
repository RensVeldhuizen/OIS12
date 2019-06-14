using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoDagwaarde
{
    public partial class Form1 : Form
    {
        List<Auto> autos = new List<Auto>()
            {
                new Auto("AB-123-C",BrandstofSoort.Benzine, 10000),
                new Auto("AQ-123-A",BrandstofSoort.Diesel, 22000),
                new Auto("AQ-673-A",BrandstofSoort.Elektrisch, 17000),
                new Auto("AQ-5643-A",BrandstofSoort.LPG, 13000)
            };
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            autos.Add(new Auto("",BrandstofSoort.Benzine,10000));
            foreach (Auto auto in autos)
            {
                auto.Dagwaarde();
                listBox1.Items.Add(auto.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Auto auto in autos)
            {
                if (auto.KmStand() < 100000)
                {
                    auto.RijdKilometer(rnd.Next(1000, 20000));
                    auto.Dagwaarde();   
                }
                listBox1.Items.Add(auto.ToString());

                BrandstofSoort brandstof = auto.brandstof();
                brandstof++;
                MessageBox.Show(brandstof.ToString());
            }

            
        }
    }
}
