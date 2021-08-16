using System;
using System.Windows.Forms;

namespace Tip_Calculator
{
   
    public partial class CalculateTip : Form
    {
        //Variable Declarations
        private double billAmt;
        private float tipPercentage;
        private double noOfPeople;
        //Constructor
        public CalculateTip()
        {
            InitializeComponent();
        }
// Form load Event
        private void Form1_Load(object sender, EventArgs e)
        {
            
            tipPercentage = 0;
            billAmt = 0;
            noOfPeople = 0;
            MessageBox.Show("Welcome to Tip Calculator. Enter Amount, Tip% and No. of People");        }
      
//Calculation Logic Here
      private void CalculateLogic()
        {
            if (txtBillAmt.Text.Length > 0 && Convert.ToInt32(txtBillAmt.Text) > 0) {
                billAmt = Convert.ToInt32(txtBillAmt.Text);
            }
            else
            {
                return;
            }
            if (txtTipPercentage.Text.Length > 0 && Convert.ToInt32(txtTipPercentage.Text) > 0) {
                tipPercentage = Convert.ToInt32(txtTipPercentage.Text);
            }
            else
            {
                return;
            }
            if(txtNoOfPeople.Text.Length > 0 && Convert.ToDouble(txtNoOfPeople.Text) > 0)
            {
                noOfPeople = Convert.ToDouble(txtNoOfPeople.Text);

            }
            else
            {
                return;
            }

            //----------------------TIP CALCULATOR----------------------------------------//

            double preAmt = ((double)(tipPercentage * billAmt) / 100); //50
            Console.WriteLine(preAmt);
            double postAmt =   preAmt / noOfPeople;//25
            Console.Write(postAmt);
            
           lblTipPerPerson.Text = '$' + Convert.ToString(string.Format("{0:00.00}", postAmt));



            //----------------------TOTAL PER PERSON CALCULATOR--------------------------//

            double preTotalAmt = preAmt + billAmt;
            double postPerPerson = preTotalAmt / noOfPeople;
            lblTotalPerPerson.Text = "$" + Convert.ToString(string.Format("{0:00.00}", postPerPerson) );


        }
        //Button increaseTip Event
        private void btnIncreaseTip_Click(object sender, EventArgs e)
        {
            tipPercentage = tipPercentage + 1;
            txtTipPercentage.Text = Convert.ToString(tipPercentage);
        }
        //Button Decrease tip Event
        private void btnDecreaseTip_Click(object sender, EventArgs e)
        {
            tipPercentage  = tipPercentage -  1;
            txtTipPercentage.Text = Convert.ToString(tipPercentage);

        }
        //Button decrease-people  Event
        private void btnDecreasePeople_Click(object sender, EventArgs e)
        {
           
            noOfPeople -= 1;
            txtNoOfPeople.Text = Convert.ToString(noOfPeople);
        }
        //Button Increase-people  Event
        private void btnIncresePeople_Click(object sender, EventArgs e)
        {
            noOfPeople = noOfPeople + 1;
            txtNoOfPeople.Text = Convert.ToString(noOfPeople);


        }
        //Text change event: Changes after every keystroke and getting current values of textbox and perform Logic
        //and calling CalculateLogic() in every event so that it updates the bill amount
        private void txtBillAmt_TextChanged(object sender, EventArgs e)
        {
            CalculateLogic();
        }

        private void txtTipPercentage_TextChanged(object sender, EventArgs e)
        {
            CalculateLogic();
        }

        private void txtNoOfPeople_TextChanged(object sender, EventArgs e)
        {
            CalculateLogic();
        }
    }
}
