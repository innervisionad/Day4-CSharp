using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotteryNumberMultipleControl
{
    public partial class Form1 : Form
    {

        Random random = new Random();
        List<int> lotteryNumbers = new List<int>();
        int lotteryMaximum = 59;


        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPredict_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= lotteryMaximum; i++)
            {
                lotteryNumbers.Add(i);
            }
            foreach (Control control in Controls)
            {
                Label numberLabel = control as Label;

                if(numberLabel != null)
                {
                    // choose a random number
                    int randomnumber = random.Next(1, lotteryNumbers.Count);
                    //use the random number to get a number from the lottery
                    // numbers list
                    int numberChosen = lotteryNumbers[randomnumber];
                    //remove the chosen number form the list so it can't be chosen
                    //again
                    lotteryNumbers.Remove(numberChosen);
                    //display the chosen number
                    numberLabel.Text = numberChosen.ToString();
                }
            }

        }






        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
