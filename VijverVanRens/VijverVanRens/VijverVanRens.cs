using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VijverVanRens
{
    public partial class vijver : Form
    {
        Random r = new Random();
        List<Eend> Eenden = new List<Eend>();
        List<Kikker> kikkers = new List<Kikker>();
        public vijver()
        {
            InitializeComponent();
        }

        private void VijverVanRens_Load(object sender, EventArgs e)
        {
            maakEenden(7);
            maakKikkers(2);
        }

        private void maakEenden(int Hoeveelheid)
        {
            string sGeslacht = "";

            for (int i = 1; i < Hoeveelheid; i++)
            {
                Eend eend = new Eend();
                //Random geslacht genereren
                int iGeslacht = r.Next(2);
                if (iGeslacht == 1)
                {
                    sGeslacht = "Man";
                }
                else
                {
                    sGeslacht = "Vrouw";
                }
                //Eenden toevoegen aan de list
                eend.setGeslacht(sGeslacht);
                eend.setNaam("Eend" + i);
                Eenden.Add(eend);

                //Label op form plaatsen voor iedere eend
                int x = r.Next(this.Width);
                int y = r.Next(this.Height);
                Label lEend = new Label
                {
                    Text = "Eend" + i,
                    Location = new Point(x,y)
                };
                lEend.Click += new EventHandler(KlikEend);
                this.Controls.Add(lEend);
            }   
        }

       private void maakKikkers(int Hoeveelheid)
        {
            for (int i = 1; i < Hoeveelheid; i++)
            {
                Kikker kikker = new Kikker();
                kikker.setNaam("kikker");

                kikkers.Add(kikker);

                int x = r.Next(this.Width);
                int y = r.Next(this.Height);
                Label lKikker = new Label
                {
                    Text = "Kikker" + i,
                    Location = new Point(x, y)
                };

                this.Controls.Add(lKikker);
            }
            
        }

        private void KlikEend(object sender, EventArgs e)
        {
            Label clickedlabel = sender as Label;
            var vEend = Eenden.Find(item => item.getNaam() == clickedlabel.Text);
            MessageBox.Show("Geslacht: " + vEend.getGeslacht());
        }
    }
}
