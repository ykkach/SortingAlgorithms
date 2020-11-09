using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading;
using System.Timers;
using SortingAlgorithms;
using Algorithms;
using System.IO;
using System.Windows.Forms.VisualStyles;

namespace SortingAlgorithms
{
    public partial class Form1 : Form
    {
        double MaxSortingTime = 59.9;
        static List<int[]> listOfArrays;
        int[] intArray;
        Random random = new Random();
        double[] sortingTimes = new double[6]; 

        public Form1()
        {
            InitializeComponent();
        }

        private void randomizeArray()
        {
            for (int i = 0; i < intArray.Length; ++i)
            {
                intArray[i] = random.Next(-10000, 10000);
            }
        }

        private void Randomize_Click(object sender, EventArgs e)
        {
            listOfArrays = new List<int[]>();
            intArray = new int[Convert.ToInt32(numOfElements.Text)];
            randomizeArray();
            for(int i = 0; i < 6; i++)
            {
                listOfArrays.Add(intArray);
            }

//            dataGridView1.Rows.Clear();
//            dataGridView1.ColumnCount = 1;
//            dataGridView1.ColumnHeadersVisible = true;
//            dataGridView1.RowHeadersVisible = false;
//            dataGridView1.Columns[0].Name = "Initial array";
//            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
//            dataGridView1.ColumnHeadersDefaultCellStyle.Font =
//                new Font(dataGridView1.Font, FontStyle.Bold);
//            dataGridView1.ShowEditingIcon = false;
//            dataGridView1.AutoResizeRows(
//DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
//            dataGridView1.AllowUserToAddRows = false;

//            foreach (int element in listOfArrays[5])
//            {
//                dataGridView1.Rows.Add(Convert.ToString(element));
//            }
            
        }

        private void fillChart()
        {/*
            for (int i = 0; i < sortingTimes.Length; i++) {
                if(sortingTimes[i] > 1.0)
                    sortingTimes[i]  = 0.9999;
            }
            chart.ChartAreas[0].AxisY.Maximum = 1.0;
            chart.ChartAreas[0].AxisY.Minimum = 0.0;
            chart.Series["Time"].Points.AddXY("Bubble", sortingTimes[0]);
            chart.Series["Time"].Points.AddXY("Selection", sortingTimes[1]);
            chart.Series["Time"].Points.AddXY("Shell", sortingTimes[2]);
            chart.Series["Time"].Points.AddXY("Merge", sortingTimes[3]);
            chart.Series["Time"].Points.AddXY("Quick", sortingTimes[4]);
            chart.Series["Time"].Points.AddXY("Counting", sortingTimes[5]);
            chart.Titles.Add("Executing time");*/
        }

        private void sort_Click(object sender, EventArgs e)
        {
            Bubble_Sort();
            Selection_Sort();
            Shell_Sort();
            Merge_Sort();
            Quick_Sort();
            Counting_Sort();
            //fillChart();
        }

        private void Bubble_Sort()
        {
            
            CancellationTokenSource cancelTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(60));
            CancellationToken token = cancelTokenSource.Token;
            
            BubbleSort bubbleSort = new BubbleSort();

            Stopwatch stopwatch = new Stopwatch();

            Task task = new Task(() =>
            {
                stopwatch.Start();
                bubbleSort.bubble_sort(listOfArrays[0], token);
                stopwatch.Stop();
                double time = Math.Round(stopwatch.Elapsed.TotalSeconds, 5);
                if (time < MaxSortingTime)
                {
                    bubbleTime.Text +=  "\n" + Math.Round(stopwatch.Elapsed.TotalSeconds, 5).ToString() + " sec.";
                }
                else
                {
                    bubbleTime.Text += "\n > 1 min.";
                }
            });
            task.Start();
        }

        private void Selection_Sort()
        {

            CancellationTokenSource cancelTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(60));
            CancellationToken token = cancelTokenSource.Token;

            SelectionSort selectionSort = new SelectionSort();

            Stopwatch stopwatch = new Stopwatch();

            Task task = new Task(() =>
            {
                stopwatch.Start();
                selectionSort.selection_sort(listOfArrays[1], token);
                stopwatch.Stop();
                double time = Math.Round(stopwatch.Elapsed.TotalSeconds, 5);
                if (time < MaxSortingTime)
                {
                    selectionTime.Text += "\n" + Math.Round(stopwatch.Elapsed.TotalSeconds, 5).ToString() + " sec.";
                }
                else
                {
                    selectionTime.Text += "\n > 1 min.";
                }
            });
            task.Start();
        }

        void Shell_Sort()
        {
            CancellationTokenSource cancelTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(60));
            CancellationToken token = cancelTokenSource.Token;

            ShellSort shellSort = new ShellSort();
            Stopwatch stopwatch = new Stopwatch();

            Task task = new Task(() =>
            {
                stopwatch.Start();
                shellSort.shell_sort(listOfArrays[2], token);
                stopwatch.Stop();
                double time = Math.Round(stopwatch.Elapsed.TotalSeconds, 5);
                if (time < MaxSortingTime)
                {
                    shellTime.Text += "\n" + Math.Round(stopwatch.Elapsed.TotalSeconds, 5).ToString() + " sec.";
                }
                else
                {
                    shellTime.Text += "\n > 1 min.";
                }
            });
            task.Start();
        }
        void Merge_Sort()
        {
            CancellationTokenSource cancelTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(60));
            CancellationToken token = cancelTokenSource.Token;
            MergeSort mergeSort = new MergeSort();
            Stopwatch stopwatch = new Stopwatch();

            Task task1 = new Task(() =>
            {
                stopwatch.Start();
                mergeSort.merge_Sort(listOfArrays[3], 0, listOfArrays[3].Length - 1, token);
                stopwatch.Stop();
                double time = Math.Round(stopwatch.Elapsed.TotalSeconds, 5);
                if (time < MaxSortingTime)
                {
                    mergeTime.Text += "\n" + Math.Round(stopwatch.Elapsed.TotalSeconds, 5).ToString() + " sec.";
                }
                else
                {
                    mergeTime.Text += "\n > 1 min.";
                }
            });
            task1.Start();
        }

        void Quick_Sort()
        {
            CancellationTokenSource cancelTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(60));
            CancellationToken token = cancelTokenSource.Token;
            QuickSort quickSort = new QuickSort();
            Stopwatch stopwatch = new Stopwatch();

            Task task1 = new Task(() =>
            {
                stopwatch.Start();
                quickSort.Quick_Sort(listOfArrays[4], 0, listOfArrays[4].Length - 1, token);
                stopwatch.Stop();
                double time = Math.Round(stopwatch.Elapsed.TotalSeconds, 5);
                if (time < MaxSortingTime)
                {
                    quickTime.Text += "\n" + Math.Round(stopwatch.Elapsed.TotalSeconds, 5).ToString() + " sec.";
                }
                else
                {
                    quickTime.Text += "\n > 1 min.";
                }
            });
            task1.Start();
        }

        void Counting_Sort()
        {
            CancellationTokenSource cancelTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(60));
            CancellationToken token = cancelTokenSource.Token;
            CountingSort countingSort = new CountingSort();
            Stopwatch stopwatch = new Stopwatch();

            Task task1 = new Task(() =>
            {
                stopwatch.Start();
                countingSort.counting_Sort(listOfArrays[5], token);
                stopwatch.Stop();
                double time = Math.Round(stopwatch.Elapsed.TotalSeconds, 5);
                if (time < MaxSortingTime)
                {
                    countingTime.Text += "\n" + Math.Round(stopwatch.Elapsed.TotalSeconds, 5).ToString() + " sec.";
                }
                else
                {
                    countingTime.Text += "\n > 1 min.";
                }
            });
            task1.Start();
        }

        private void outputResults_Click(object sender, EventArgs e)
        {
            string sLog;
            for (int i = 0; i < 6; i++)
            {
                sLog = "";
                foreach (int element in listOfArrays[i])
                {
                    sLog += element.ToString() + ", ";
                }

                writeToFile(sLog, i);
            }
        }

        static async void writeToFile(string logString, int index)
        {
            string pathToLogFile = @"C:\\Users\\Yaroslav\\Desktop\\other\\student\\2nd_course\\АСД\\SortingAlgorithms";
            DirectoryInfo dirInfo = new DirectoryInfo(pathToLogFile);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            string filename = $"{pathToLogFile}\\intermediateRes" + index.ToString() + ".txt";

            using (FileStream fstream = new FileStream(filename, FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(logString);
                await fstream.WriteAsync(array, 0, array.Length);
            }
        }
    }
}
