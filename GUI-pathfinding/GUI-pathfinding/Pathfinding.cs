using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EV3WifiLib;
using Newtonsoft.Json;

namespace GUI_pathfinding
{
    public partial class Pathfinding : Form
    {
        private EV3Wifi myEV3;
        private Timer messageReceiveTimer;
        List<Highscores> scores = new List<Highscores>();
        int iSeconden = 0;
        int iMinuten = 0;
        int iScore = 0;
        public Pathfinding()
        {
            InitializeComponent();

            messageReceiveTimer = new Timer();
            messageReceiveTimer.Interval = 100;

            myEV3 = new EV3Wifi();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            scores = JsonConvert.DeserializeObject<List<Highscores>>(File.ReadAllText("highscores.json"));
            generateHighscore();
            string ipAddress = "192.168.202.63";
            if (!IPAddress.TryParse(ipAddress, out IPAddress address))
            {
                MessageBox.Show("Fill in valid IP address of EV3");
            }
            else if (myEV3.Connect("123", ipAddress) == true)
            {
                messageReceiveTimer.Start();
            }
            else
            {
                myEV3.Disconnect();
                MessageBox.Show("Failed to connect to EV3 with IP address " + ipAddress);
                Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (iSeconden > 59)
            {
                iSeconden = 0;
                iMinuten++;
            }
            iSeconden++;
            iScore++;
            lTijd.Text = "Tijd: "+ iMinuten.ToString()+ ":" + iSeconden.ToString();

            if (myEV3.isConnected)
            {
                string strMessage = myEV3.ReceiveMessage("EV3_OUTBOX0");
                if (strMessage != "")
                {
                    if (strMessage == "lijn")
                    {
                        timer1.Stop();
                        strMessage = "";
                        scores.Add(new Highscores()
                        {
                            score = iScore
                        });
                        string json = JsonConvert.SerializeObject(scores.ToArray());

                        System.IO.File.WriteAllText(@"C:\Users\Rens\source\repos\GUI-pathfinding\GUI-pathfinding\bin\Debug\highscores.json", json);
                        MessageBox.Show("Gehaald!");

                        iSeconden = 0;
                        iMinuten = 0;
                        iScore = 0;

                        lbHighscores.Items.Clear();
                        scores = JsonConvert.DeserializeObject<List<Highscores>>(File.ReadAllText("highscores.json"));
                        generateHighscore();
                        strMessage = "";
                    }
                }
            }
        }

        private void btForward_Click(object sender, EventArgs e)
        {
            if (myEV3.isConnected)
            {
                TimerStart();
                myEV3.SendMessage("forward", "0");
            }
            TimerStart();
        }

        private void btLeft_Click(object sender, EventArgs e)
        {
            if (myEV3.isConnected)
            {
                TimerStart();
                myEV3.SendMessage("left", "0");
            }
        }

        private void btRight_Click(object sender, EventArgs e)
        {
            if (myEV3.isConnected)
            {
                TimerStart();
                myEV3.SendMessage("right", "0");
            }
        }

        private void btBackward_Click(object sender, EventArgs e)
        {
            if (myEV3.isConnected)
            {
                TimerStart();
                myEV3.SendMessage("backward", "0");
            }
        }

        private void TimerStart()
        {
            if (!timer1.Enabled)
            {
                timer1.Start();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            iSeconden = 0;
            iMinuten = 0;
            iScore = 0;
            lTijd.Text = "Tijd: 0:0";
        }

        private void generateHighscore()
        {
            int i = 1;
            var result = scores.OrderBy(a => a.score);
            foreach (var item in result)
            {
                if (i < 10)
                {
                    lbHighscores.Items.Add(i + "e:   " + item.score + "s");
                    i++;
                }
                if (i == 10)
                {
                    lbHighscores.Items.Add(i + "e: " + item.score + "s");
                    i++;
                }
            }
        }
    }
}
