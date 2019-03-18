using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Sorting : Form
    {
        public Sorting()
        {
            InitializeComponent();
        }

        public static int[] mergeSort(int[] array)
        {
            int[] left;
            int[] right;
            int[] result = new int[array.Length];
            
            if (array.Length <= 1)
                return array;
            
            int midPoint = array.Length / 2;
            
            left = new int[midPoint];
            
            if (array.Length % 2 == 0)
                right = new int[midPoint];
            
            else
                right = new int[midPoint + 1];
            
            for (int i = 0; i < midPoint; i++)
                left[i] = array[i];
            
            int x = 0;
            for (int i = midPoint; i < array.Length; i++)
            {
                right[x] = array[i];
                x++;
            }
            
            left = mergeSort(left);
            right = mergeSort(right);
            result = merge(left, right);

            return result;
        }
        
        public static int[] merge(int[] left, int[] right)
        {
            int resultLength = right.Length + left.Length;
            int[] result = new int[resultLength];
            int indexLeft = 0, indexRight = 0, indexResult = 0;
            
            while (indexLeft < left.Length || indexRight < right.Length)
            {
                if (indexLeft < left.Length && indexRight < right.Length)
                {
                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    } 
                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }
                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }

            }
            return result;
        }

        private void QuickSort(int[] arr, int start, int end)
        {
            int i;
            if (start < end)
            {
                i = Partition(arr, start, end);

                QuickSort(arr, start, i - 1);
                QuickSort(arr, i + 1, end);
            }
        }

        private int Partition(int[] arr, int start, int end)
        {
            int temp;
            int p = arr[end];
            int i = start - 1;

            for (int j = start; j <= end - 1; j++)
            {
                if (arr[j] <= p)
                {
                    i++;
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            temp = arr[i + 1];
            arr[i + 1] = arr[end];
            arr[end] = temp;
            return i + 1;
        }

        private void btnSorting_Click(object sender, EventArgs e)
        {
            string[] strInput = txtInput.Text.Split(null);
            int[] input = Array.ConvertAll(strInput, int.Parse);

            if (btnMerge.Checked)
            {
                Stopwatch stopwatch = Stopwatch.StartNew();

                int[] output = mergeSort(input);

                stopwatch.Stop();
                txtExecutionTime.Text = (stopwatch.Elapsed.TotalMilliseconds * 1000000).ToString() + " Nanoseconds";

                txtOutput.Text = "";
                foreach (int p in output)
                    txtOutput.Text = txtOutput.Text + p + "  ";

            } else if (btnBubble.Checked)
            {
                Stopwatch stopwatch = Stopwatch.StartNew();

                int temp;

                for (int j = 0; j <= input.Length - 2; j++)
                {
                    for (int i = 0; i <= input.Length - 2; i++)
                    {
                        if (input[i] > input[i + 1])
                        {
                            temp = input[i + 1];
                            input[i + 1] = input[i];
                            input[i] = temp;
                        }
                    }
                }

                stopwatch.Stop();
                txtExecutionTime.Text = (stopwatch.Elapsed.TotalMilliseconds * 1000000).ToString() + " Nanoseconds";
                
                txtOutput.Text = "";
                foreach (int p in input)
                    txtOutput.Text = txtOutput.Text + p + "  ";
            } else if (btnQuick.Checked)
            {
                Stopwatch stopwatch = Stopwatch.StartNew();

                QuickSort(input, 0, input.Length - 1);

                stopwatch.Stop();
                txtExecutionTime.Text = (stopwatch.Elapsed.TotalMilliseconds * 1000000).ToString() + " Nanoseconds";

                txtOutput.Text = "";
                foreach (int p in input)
                    txtOutput.Text = txtOutput.Text + p + "  ";
            } else if (btnInsert.Checked)
            {
                Stopwatch stopwatch = Stopwatch.StartNew();

                int val, flag;

                for (int i = 1; i < input.Length; i++)
                {
                    
                    val = input[i];
                    flag = 0;
                    for (int j = i - 1; j >= 0 && flag != 1;)
                    {
                        if (val < input[j])
                        {
                            input[j + 1] = input[j];
                            j--;
                            input[j + 1] = val;
                        }
                        else flag = 1;
                    }
                }

                stopwatch.Stop();
                txtExecutionTime.Text = (stopwatch.Elapsed.TotalMilliseconds * 1000000).ToString() + " Nanoseconds";

                txtOutput.Text = "";
                foreach (int p in input)
                    txtOutput.Text = txtOutput.Text + p + "  ";
            }

        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            this.Hide();
            mainMenu.ShowDialog();
        }
    }
}
