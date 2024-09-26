using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DegreeDays
{
    public partial class formDegreeDay : Form
    {
        double baseTemp = 0;
        double highTemp = 0;
        double lowTemp = 0;
        double degreeDay = 0;




        public formDegreeDay()
        {
            InitializeComponent();
        }


        //Utility Methods
        private void clearTempLables()
        {
            lblError.Text = String.Empty;
            lblDegreeDays.Text = String.Empty;
        }
        private void clearTextBoxes()
        {
            txtBoxLow.Text = String.Empty;
            txtBoxHigh.Text = String.Empty;
            txtBoxBase.Text = String.Empty;
        }

        private void resetVariables()
        {
            baseTemp = 0;
            highTemp = 0;
            lowTemp = 0;
            degreeDay = 0;
        }
        //Form Loading
        private void formDegreeDay_Load(object sender, EventArgs e)
        {
            clearTempLables();
        }
        //Events
        //Boolean method for determining if all or at least one of the values are empty
        private Boolean missingValues(string setting) 
        {
            if (setting.Equals("&&"))
            {
                if (txtBoxBase.Text.Equals(String.Empty) &&
                    txtBoxHigh.Text.Equals(String.Empty) &&
                    txtBoxLow.Text.Equals(String.Empty))
                {
                    return true;
                }
                else {  return false; }
            }
            else if (setting.Equals("||"))
            {
                if (txtBoxBase.Text.Equals(String.Empty) ||
                    txtBoxHigh.Text.Equals(String.Empty) ||
                    txtBoxLow.Text.Equals(String.Empty))
                {
                    return true;
                }
                else { return false; }
            }
            else
            {
                throw new ArgumentException("Invalid argument", nameof(setting));
            }
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            Dictionary<string, Boolean> validNumbers = new Dictionary<string, bool>();

            validNumbers.Add(nameof(baseTemp), double.TryParse(txtBoxBase.Text, out baseTemp));
            validNumbers.Add(nameof(lowTemp), double.TryParse(txtBoxLow.Text, out lowTemp));
            validNumbers.Add(nameof(highTemp), double.TryParse(txtBoxHigh.Text, out highTemp));

            //Check if there is an error
            if (validNumbers.ContainsValue(false))
            {
                //Determine if all values are empty
                if (missingValues("&&")) 
                {
                    lblError.Text = "ERROR: Missing values";
                }
                //Determine if at least one value is empty
                else if (missingValues("||")) 
                {
                    //See if there is an error BESIDES the missing value
                    if ((!validNumbers[nameof(baseTemp)] && !txtBoxBase.Text.Equals(String.Empty)) ||
                        (!validNumbers[nameof(lowTemp)] && !txtBoxLow.Text.Equals(String.Empty)) ||
                        (!validNumbers[nameof(highTemp)] && !txtBoxHigh.Text.Equals(String.Empty)))
                    {
                        lblError.Text = "ERROR: Missing values and nonnumeric input type enterted;"
                    }
                }
                //If there are no missing values set this error message
                else
                {
                    lblError.Text = "ERROR: Nonnumeric input type enterted";
                }
                return;
            }

            //Calculate eletric degree days
            degreeDay = Math.Abs(baseTemp-((highTemp+lowTemp) / 2));

            //Set lable on form
            lblDegreeDays.Text = degreeDay.ToString() + "°";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
            clearTempLables();
            resetVariables();   
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
