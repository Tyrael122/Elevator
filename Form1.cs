using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Elevator
{
    public partial class Form1 : Form
    {
        List<int> floors = new List<int>();
        private void moveScrollToTarget(int floor, int startValue, int delay)
        {
            while (floor != vScrollBar.Value)
            {
                //delay = changeDelay(aproximation, floor, fixedStartValue, delay);
                startValue = changeScrollPosition(floor, startValue, delay);
            }
        }
        private int changeScrollPosition(int floor, int startValue, int delay)
        {
            if (vScrollBar.Value > floor)
            {
                vScrollBar.Invoke((MethodInvoker)delegate ()
                {
                    vScrollBar.Value = --startValue;
                });
                Thread.Sleep(delay);
                return startValue;
            }
            else
            {
                vScrollBar.Invoke((MethodInvoker)delegate ()
                {
                    vScrollBar.Value = ++startValue;
                });
                Thread.Sleep(delay);
                return startValue;
            }
        }
        private void getPassengersInfo()
        {
            lbl_info.Invoke((MethodInvoker)delegate ()
            {
                lbl_info.Text = "Getting passengers onboard!";
            });
            Thread.Sleep(2500);
        }
        private void showFloorsInfo()
        {
            string infoFloors = "Going to ";
            if (floors.Count == 0)
            {
                infoFloors = "Passengers onboard!\nWhere do you want to go?";
            }
            else
            {
                foreach (int floor in floors)
                {
                    if (floor == 2)
                    {
                        infoFloors += "the 7° floor, then\n";
                    }
                    if (floor == 17)
                    {
                        infoFloors += "the 6° floor, then\n";
                    }
                    if (floor == 32)
                    {
                        infoFloors += "the 5° floor, then\n";
                    }
                    if (floor == 46)
                    {
                        infoFloors += "the 4° floor, then\n";
                    }
                    if (floor == 61)
                    {
                        infoFloors += "the 3° floor, then\n";
                    }
                    if (floor == 75)
                    {
                        infoFloors += "the 2° floor, then\n";
                    }
                    if (floor == 100)
                    {
                        infoFloors += "the 1° floor, then\n";
                    }
                    if (floor == floors.Last())
                    {
                        infoFloors = infoFloors.Remove(infoFloors.Length - 7);
                    }
                    infoFloors += ".";
                }
            }
            lbl_info.Invoke((MethodInvoker)delegate ()
            {
                lbl_info.Text = infoFloors;
            });
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int startValue = vScrollBar.Value, delay = 100;
            foreach (int floor in floors)
            {
                showFloorsInfo();
                moveScrollToTarget(floor, startValue, delay);
                getPassengersInfo();
                floors.Remove(floor);
                floors.Sort();
                showFloorsInfo();
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundProcess.RunWorkerAsync();
        }
        private void btn_andar1_Click(object sender, EventArgs e)
        {
            floors.Add(100);
        }

        private void btn_andar2_Click(object sender, EventArgs e)
        {
            floors.Add(75);
        }

        private void btn_andar3_Click(object sender, EventArgs e)
        {
            floors.Add(61);
        }

        private void btn_andar4_Click(object sender, EventArgs e)
        {
            floors.Add(46);
        }

        private void btn_andar5_Click(object sender, EventArgs e)
        {
            floors.Add(32);
        }

        private void btn_andar6_Click(object sender, EventArgs e)
        {
            floors.Add(17);
        }
        private void btn_andar7_Click(object sender, EventArgs e)
        {
            floors.Add(2);
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            backgroundProcess.RunWorkerAsync();
        }
    }
}
