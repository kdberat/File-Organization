using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fileorgodev
{
    public partial class Form1 : Form
    {
        public int valueCount;
        public int[] array;
        public int hash;
        public int foundedIndex;
        public int generatedNumberRange;
        public string[] binary;
        public static int leftleft = 1;
        public static int left = 1;
        public static int right = 1;
        public static double count = 0;
        public static int indx;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void generateNumberButton_Click(object sender, EventArgs e)
        {

            valueCount = Int32.Parse(arraySizeValue.Text);
            generatedNumberRange = Int32.Parse(numberRange_textBox.Text);
            generateArray(valueCount);

            SethashKey();
            createTableRows(REISCH_dataGrid);

            REISCH();

            setProbsTable();
            setProbsStatistics();

            BinaryTree(valueCount, hash);

        }

        private void REISCH()
        {
            SethashKey();
            Random r=new Random();
            int index;
             
            for (int i = 0; i < valueCount; i++)
            {
                index = array[i] % hash;

                if (REISCH_dataGrid.Rows[index].Cells[1].Value == null)
                {
                    REISCH_dataGrid.Rows[index].Cells[1].Value = array[i];
                }
                // not empty
                else
                {
                    int line = hash - 1;

                    while (REISCH_dataGrid.Rows[line].Cells[1].Value != null)
                        line= r.Next(hash) ;

                    REISCH_dataGrid.Rows[line].Cells[1].Value = array[i];

                  
                    REISCH_dataGrid.Rows[line].Cells[2].Value = REISCH_dataGrid.Rows[index].Cells[2].Value;
                    REISCH_dataGrid.Rows[index].Cells[2].Value = REISCH_dataGrid.Rows[line].Cells[0].Value;
                }
    }
        }
        

        private void setProbsTable()
        {
            dataGrid.RowCount = valueCount;

            for (int i = 0; i < valueCount; i++)
            {
                dataGrid.Rows[i].Cells[0].Value = array[i];
                dataGrid.Rows[i].Cells[1].Value = probCounts_Standart(REISCH_dataGrid, array[i]);
            }
        }

        private int probCounts_Standart(DataGridView table, int i)
        {
            int probCounter = 1;
            int lookingIndex = i % hash;

            while (Convert.ToInt32(table.Rows[lookingIndex].Cells[1].Value) != i)
            {
                lookingIndex = Convert.ToInt32(table.Rows[lookingIndex].Cells[2].Value);
                probCounter++;
                if (probCounter > valueCount)
                    return -1;
            }
            return probCounter;
        }

        public int TotalProbCount(int column)
        {
            int sum = 0;

            for (int i = 0; i < valueCount; i++)
                sum += Convert.ToInt32(dataGrid.Rows[i].Cells[column].Value);

            return sum;
        }
     
        public float avarageProb(int column)
        {
            return (float)TotalProbCount(column) / valueCount;
        }

        public void setProbsStatistics()
        {
            ProbsStatistics_textBox.Text = "REISCH --> Prob= " + TotalProbCount(1) + Environment.NewLine +"Avarage Prob = " + avarageProb(1) + Environment.NewLine + Environment.NewLine + "Packing Factor " + Math.Round(((double)valueCount / hash) * 100) + "%";
        }

        void createTableRows(DataGridView table)
        {
            table.RowCount = hash;

            for (int i = 0; i < hash; i++)
            {
                table.Rows[i].Cells[0].Value = i;
                table.Rows[i].Cells[1].Value = null;
                table.Rows[i].Cells[2].Value = null;
            }
        }

        private void SethashKey()
        {
            int number = (valueCount + valueCount / 11) + 1;

            while (!isPrimeNumber(number))
            {
                number++;
            }

            hash = number;
        }

        public static bool isPrimeNumber(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }

        private void generateArray(int valueCount)
        {
            Random rastgele = new Random();
            int value;
            array = new int[valueCount];

            for (int i = 0; i < valueCount; i++)
            {
                value = rastgele.Next(0, generatedNumberRange);
                array[i] = value;
            }
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            int deger = Convert.ToInt32(searchValue_textBox.Text);
            if (probCounts_Standart(REISCH_dataGrid, deger) == -1)
                searchResults_textBox.Text = "That number is not generate";
            else
            {
                searchResults_textBox.Text = "I found!!" + Environment.NewLine + "index => " + probSearch_Standart(REISCH_dataGrid, deger) + Environment.NewLine;                 
            }
        }

        private int probSearch_Standart(DataGridView table, int i)
        {
            int lookingIndex = i % hash;

            while (Convert.ToInt32(table.Rows[lookingIndex].Cells[1].Value) != i)
            {
                lookingIndex = Convert.ToInt32(table.Rows[lookingIndex].Cells[2].Value);
            }
            return lookingIndex;
        }

        public void BinaryTree(int valueCount, int hashKey)
        {
            binary = new string[hashKey];
            double[] poweroftwo = new double[hashKey + 1];
            for (int a = 1; a <= hashKey; a++)
            {
                poweroftwo[a] = Convert.ToDouble(Math.Pow(2.0, a));

            }
            for (int i = 0; i < valueCount; i++)
            {
                indx = array[i] % hashKey;
                if (binary[indx] == null)
                {
                    binary[indx] = Convert.ToString(array[i]);
                    count++;
                    break;
                }
                else

                {
                    for (int j = 0; j < poweroftwo.Length; j++)
                    {
                        if (count == poweroftwo[i]) //leftleft
                        {
                            LeftLeft(i, indx);
                            count++;
                            //break;
                        }
                        else if (count % 2 == 0 && poweroftwo[j] != count) // right
                        {
                            Right(i, indx);
                            count++;
                            //break;
                        }
                        else if (count % 2 != 0 && poweroftwo[i] != count) //left
                        {
                            Left(i, indx);
                            count++;
                            //break;
                        }
                    }


                }
            }
            listBox3.Items.Clear();
            Print();
        }
        public void Print()
        {

            for (int i = 0; i < hash; i++)
            {
                listBox3.Items.Add(String.Format("Index:{0}\tKey:{1}", i, binary[i]));
            }
        }
        public static int q;
        public void LeftLeft(int i, int indx)
        {
            q = (array[i] / hash) % hash;
            if (binary[i + indx] == null)
            {
                binary[i + indx] = Convert.ToString(array[i]);
                return;

            }
            count++;
        }
        public void Left(int i, int indx)
        {
            q = (array[i] / hash) % hash;
            if (binary[i + indx] == null)
            {
                binary[i + indx] = Convert.ToString(array[i]);
                return;
            }
            count++;

        }
        public void Right(int i, int indx)
        {
            q = (array[i] / hash) % hash;
            if (binary[i + indx] == null)
            {
                binary[i + indx] = Convert.ToString(array[i]);
                return;
            }
            count++;
        }

    }
}
