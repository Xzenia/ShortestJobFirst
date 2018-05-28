using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShortestJobFirst
{
    public partial class Form1 : Form
    {
        int counter = 0, temp = 0;
        int burstTimeInput = 0, arrivalTimeInput = 0;
        List<int> arrivalTime = new List<int>();
        List<int> burstTime = new List<int>();
        List<int> processList = new List<int>();
        List<int> waitingTime = new List<int>();
        List<int> turnaroundTime = new List<int>();
        DataTable dt = new DataTable();
        Boolean isGenerated = false;
        List<Color> colorList = new List<Color>();
        public Form1()
        {
            InitializeComponent();
            setupDataTable();
            sjf.DataSource = dt;

            colorList.Add(Color.Green);
            colorList.Add(Color.Red);
            colorList.Add(Color.Blue);
            colorList.Add(Color.Purple);
            colorList.Add(Color.Pink);
            colorList.Add(Color.Orange);
            colorList.Add(Color.Yellow);
            colorList.Add(Color.Turquoise);
        }

        private void setupDataTable()
        {
            dt.Columns.Add("Processes", typeof(int));
            dt.Columns.Add("Arrival Time", typeof(int));
            dt.Columns.Add("Burst Time", typeof(int));
            dt.Columns.Add("Waiting Time", typeof(int));
            dt.Columns.Add("Turnaround Time", typeof(int));
            dt.Columns.Add("Response Time", typeof(int));
        }

        private void addProcessBtn_Click(object sender, EventArgs e)
        {
            int errorFlag = 0, parsedValue = 0;
            if (isGenerated)
            {
                clearLists();
                dt.Rows.Clear();
                counter = 0;
                isGenerated = false;
            }
            //Input checks
            if (!int.TryParse(burstTimeTextBox.Text, out parsedValue) || Convert.ToInt32(burstTimeTextBox.Text) == 0)
            {
                errorFlag = 1;
                MessageBox.Show("Input is invalid!");
            }
            else if (arrivalTimeTextBox.Text == "" || !int.TryParse(arrivalTimeTextBox.Text, out parsedValue))
            {
                arrivalTimeInput = 0;
                burstTimeInput = Convert.ToInt32(burstTimeTextBox.Text);
            }
            else
            {
                burstTimeInput = Convert.ToInt32(burstTimeTextBox.Text);
                arrivalTimeInput = Convert.ToInt32(arrivalTimeTextBox.Text);
            }

            if (errorFlag == 1)
            {
                arrivalTimeTextBox.Text = "";
                burstTimeTextBox.Text = "";
                errorFlag = 0;
            }
            else
            {
                processList.Add(counter + 1);
                arrivalTime.Add(arrivalTimeInput);
                burstTime.Add(burstTimeInput);
                dt.Rows.Add(counter + 1, arrivalTimeInput, burstTimeInput);
                arrivalTimeTextBox.Text = "";
                burstTimeTextBox.Text = "";

                counter++; 
            }

        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            dt.Rows.Clear();
            clearLists();
            for (int ctr = 0; ctr < 8; ctr++)
            {
                processList.Add(ctr+1);
                temp = rnd.Next(1, 11);
                burstTime.Add(temp);
                arrivalTime.Add(rnd.Next(0, temp));
                dt.Rows.Add(processList[ctr], arrivalTime[ctr], burstTime[ctr]);
            }

            isGenerated = true;
        }

        private void sortLists()
        {
            /*
             *  A rather messy attempt at sorting the lists but prioritizing the processes with an arrival time of zero.
             *  This sorts the array then finds the processes with an arrival time of zero before sorting them again. 
             *  
             *  It first checks whether or not more than one processes have an arrival time of zero then sorts them accordingly.
             *  If there are more than one zeroes, it will sort those processes by burst time. If there's only one process with an 
             *  arrival time of zero, it will just sort the next process and the rest of the other processes. 
             *  
             */

            selectionSort(0);
            int minimum;
            int last = 0;

            //Finds the lowest value in the arrival time list. 

            int lowest = arrivalTime[0];
            for (int ctr = 0; ctr < processList.Count(); ctr++)
            {
                if (arrivalTime[ctr] <= lowest)
                {
                    lowest = arrivalTime[ctr];
                }
            }

            // Searches for the lowest value in the arrival time array and puts it at the top.
            for (int ctr2 = 0; ctr2 < processList.Count(); ctr2++)
            {
                minimum = ctr2;
                for (int ctr3 = minimum + 1; ctr3 < processList.Count(); ctr3++)
                {
                    if (arrivalTime[ctr3] == lowest)
                    {
                        minimum = ctr3;
                        break;
                    }
                }

                temp = processList[minimum];
                processList[minimum] = processList[ctr2];
                processList[ctr2] = temp;

                temp = burstTime[minimum];
                burstTime[minimum] = burstTime[ctr2];
                burstTime[ctr2] = temp;

                temp = arrivalTime[minimum];
                arrivalTime[minimum] = arrivalTime[ctr2];
                arrivalTime[ctr2] = temp;
            }

            /*  
             *  If there are more than one processes with the lowest arrival time, sort these processes 
             *  and sort the processes with an arrival time greater than zero.
             */

            for (int ctr = 0; ctr < processList.Count(); ctr++)
            {
                if (arrivalTime[ctr] == lowest)
                {
                    last++;
                }
            }

            selectionSort(last);
            //Sort the burst times of the processes with the lowest arrival time.
            if (arrivalTime[1] == lowest)
            {
 
                for (int ctr = 0; ctr < processList.Count(); ctr++)
                {
                    minimum = ctr;
                    for (int ctr2 = minimum + 1; ctr2 < processList.Count(); ctr2++)
                    {
                        if (arrivalTime[ctr2] == lowest && burstTime[minimum] > burstTime[ctr2])
                        {
                            minimum = ctr2;
                        }
                    }

                    temp = processList[minimum];
                    processList[minimum] = processList[ctr];
                    processList[ctr] = temp;

                    temp = burstTime[minimum];
                    burstTime[minimum] = burstTime[ctr];
                    burstTime[ctr] = temp;

                    temp = arrivalTime[minimum];
                    arrivalTime[minimum] = arrivalTime[ctr];
                    arrivalTime[ctr] = temp;
                }
            }
        }

        private void selectionSort(int start)
        {
            // Sort the "three-dimensional list" by burst time. Again, selection sort is used. 
            for (int ctr = start; ctr < processList.Count(); ctr++)
            {
                int minimum = ctr;
                for (int ctr2 = minimum + 1; ctr2 < processList.Count(); ctr2++)
                {
                    if (burstTime[minimum] == burstTime[ctr2])
                    {
                        if (arrivalTime[minimum] > arrivalTime[ctr2])
                        {
                            minimum = ctr2;
                        }
                    }
                    else if (burstTime[minimum] > burstTime[ctr2])
                    {
                        minimum = ctr2;
                    }
                }

                temp = processList[minimum];
                processList[minimum] = processList[ctr];
                processList[ctr] = temp;

                temp = burstTime[minimum];
                burstTime[minimum] = burstTime[ctr];
                burstTime[ctr] = temp;

                temp = arrivalTime[minimum];
                arrivalTime[minimum] = arrivalTime[ctr];
                arrivalTime[ctr] = temp;
            }
        }

        private void shortestJobFirst()
        {
            float wtTemp, totalWt, totalTt, TtTemp;
            temp = arrivalTime[0];
            totalWt = 0;
            totalTt = 0;
            
            dt.Rows.Clear();
            //Add all the burst times and append the waiting times and the turnaround times.
            for (int ctr = 0; ctr < processList.Count(); ctr++)
            {
                wtTemp = temp - arrivalTime[ctr];
                if (wtTemp < 0)
                {
                    wtTemp = arrivalTime[ctr] - temp;
                }

                waitingTime.Add(Convert.ToInt32(wtTemp));
                totalWt += wtTemp;
                temp += burstTime[ctr];
                
                TtTemp = temp - arrivalTime[ctr];
                if (TtTemp < 0)
                {
                    TtTemp = arrivalTime[ctr] - temp;
                }

                turnaroundTime.Add(Convert.ToInt32(TtTemp));
                totalTt += temp - arrivalTime[ctr];
                dt.Rows.Add(processList[ctr], arrivalTime[ctr], burstTime[ctr], waitingTime[ctr], turnaroundTime[ctr], burstTime[ctr]);
            }
            getAverages(temp, totalWt, totalTt);
            getCpuUtilization(temp);
            getThroughput(temp);

            createGanttChart();
        }

        private void getThroughput(int burstTimeSum)
        {
            throughputNumeratorTextBox.Text = processList.Count().ToString();
            throughputDenominatorTextBox.Text = burstTimeSum.ToString();
        }

        private void getCpuUtilization(int temp)
        {
            float burstTimeSum = temp;
            float cpuUtilization = ((burstTimeSum - arrivalTime[0])/burstTimeSum) * 100;
            cpuUtilizationTextBox.Text = cpuUtilization.ToString();
        }
        private void getAverages(float totalBurstTime, float totalWaitingTime, float totalTurnaroundTime)
        {
            float avgWaitTime, avgResponseTime, avgTurnaroundTime;
            avgWaitTime = totalWaitingTime / processList.Count();
            avgTurnaroundTime = totalTurnaroundTime / processList.Count();
            avgResponseTime = avgWaitTime;

            avgWaitingTimeTextBox.Text = avgWaitTime.ToString();
            avgResponseTimeTextBox.Text = avgResponseTime.ToString();
            avgTurnaroundTimeTextBox.Text = avgTurnaroundTime.ToString();

        }

        private void createGanttChart()
        {
            int left = 0, tempCtr = 0, colorCtr = 0;
            temp = 0;

            for (int ctr = 0; ctr < processList.Count(); ctr++)
            {
                Button ganttChartItem = new Button();

                temp += burstTime[ctr];
                ganttChartItem.Height = 50;
                ganttChartItem.Width = temp + 50;

                if (colorCtr < colorList.Count())
                {
                    ganttChartItem.BackColor = colorList[colorCtr];
                    colorCtr++;
                }
                else
                {
                    colorCtr = 0;
                    ganttChartItem.BackColor = colorList[colorCtr];
                    colorCtr++;

                }

                ganttChartItem.Location = new Point(left, 30);
                ganttChartItem.Text = "P" + processList[ctr];
                ganttChartItem.Name = "P" + processList[ctr];
                ganttChart.Controls.Add(ganttChartItem);
                left += ganttChartItem.Width;

            }
            temp = arrivalTime[0];
            left = 0;
            for (int ctr = 0; ctr < processList.Count(); ctr++)
            {
                Label measureLabel = new Label();
                measureLabel.Text = temp.ToString();
                measureLabel.Location = new Point(left-2, 90);
                temp += burstTime[ctr];
                left += temp + 50;
                ganttChart.Controls.Add(measureLabel);
                measureLabel.BringToFront();
                tempCtr++;
            }

            Label measureEndLabel = new Label();
            measureEndLabel.Text = temp.ToString();
            measureEndLabel.Location = new Point(left - 2, 90);
            ganttChart.Controls.Add(measureEndLabel);
            measureEndLabel.BringToFront();
        }

        private void clearLists()
        {
            counter = 0;

            processList.Clear();
            arrivalTime.Clear();
            burstTime.Clear();
            waitingTime.Clear();
            turnaroundTime.Clear();
            ganttChart.Controls.Clear();
            avgResponseTimeTextBox.Text = "";
            avgTurnaroundTimeTextBox.Text = "";
            avgWaitingTimeTextBox.Text = "";
            cpuUtilizationTextBox.Text = "";
            throughputDenominatorTextBox.Text = "";
            throughputNumeratorTextBox.Text = "";

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearLists();
            dt.Rows.Clear();
        }

        private void simulateBtn_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            if (!processList.Any())
            {
                MessageBox.Show("There are no processes available!!!");
            }
            else if (processList.Count() <= 1)
            {
                MessageBox.Show("There should be more than 1 processes present!");
                clearLists();
            }
            else
            {
                sortLists();
                shortestJobFirst();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
