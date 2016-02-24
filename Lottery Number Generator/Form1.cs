using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery_Number_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click_1(object sender, EventArgs e)
        {
            // Create an array to hold the numbers.
            const int SIZE = 5;
            int[] lotteryNumbers = new int[SIZE];

            // Create a Random object.
            Random rand = new Random();

            // Fill the array with random numbers, in the range of 0 to 75.
            for (int index = 0; index < lotteryNumbers.Length; index++)
            {
                lotteryNumbers[index] = rand.Next(75);
            }

            // Display the array elements in the Label controls.
            firstLabel1.Text = lotteryNumbers[0].ToString();
            secondLabel2.Text = lotteryNumbers[1].ToString();
            thirdLabel3.Text = lotteryNumbers[2].ToString();
            fourthLabel4.Text = lotteryNumbers[3].ToString();
            fifthLabel5.Text = lotteryNumbers[4].ToString();
        }

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void MegaButton_Click(object sender, EventArgs e)
        {

            // Create an array to hold the numbers.
            const int SIZE = 1;
            int[] lotteryNumbers = new int[SIZE];

            // Create a Random object.
            Random rand = new Random();

            // Fill the array with random numbers, in the range of 0 to 15.
            for (int index = 0; index < lotteryNumbers.Length; index++)
            {
                lotteryNumbers[index] = rand.Next(15);
            }

            // Display the array elements in the Label controls.
            MegaBallLabel1.Text = lotteryNumbers[0].ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
