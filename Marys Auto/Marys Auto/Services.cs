using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marys_Auto
{
    public partial class Services : UserControl
    {
        public Services()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Customer Info Null Check
                if (String.IsNullOrEmpty(firstNameBox.Text) || String.IsNullOrEmpty(lastNameBox.Text) || String.IsNullOrEmpty(cityBox.Text) || String.IsNullOrEmpty(stateBox.Text) || String.IsNullOrEmpty(streetAdressBox.Text) || String.IsNullOrEmpty(phoneNumberBox.Text))
                {
                    MessageBox.Show("One or more of the boxes were left blank in the Customer Info section. Please fill out every box.", "Customer Info Null");
                }

                //Phone Number Check 
                if (int.TryParse(phoneNumberBox.Text, out int num))
                {
                    if (phoneNumberBox.Text.Length == 10)
                    {
                        //Vehicle Info Null Check
                        if (String.IsNullOrEmpty(makeBox.Text) || String.IsNullOrEmpty(modelBox.Text) || String.IsNullOrEmpty(trimBox.Text) || String.IsNullOrEmpty(trimBox.Text) || String.IsNullOrEmpty(vinBox.Text) || String.IsNullOrEmpty(yearBox.Text))
                        {
                            MessageBox.Show("One or more of the boxes were left blank in the Vehicle Info section. Please fill out every box.", "Vehicle Info Null");
                        }
                        //Issue Text Box Null Check
                        else if (String.IsNullOrEmpty(ServicesBox.Text))
                        {
                            MessageBox.Show("You have to specify an issue with the vehicle.", "Issue Text Box Null");
                        }
                        else if (String.IsNullOrEmpty(estimatedPriceBox.Text) || String.IsNullOrEmpty(actualPriceBox.Text))
                        {
                            MessageBox.Show("The Estimated Price or Actual Price is empty.", "Price Info Null");
                        }
                        else
                        {
                            ////////////////////////////////////////
                            ///EVERYTHING VALIDATED NEW CODE HERE///
                            ////////////////////////////////////////
                            MessageBox.Show("Validated");









                        }
                    }
                    //If phone number isnt 10 digits long
                    else
                    {
                        MessageBox.Show("That was an invalid phone number. Make sure you type out only numbers with nothing else. It should be 10 digits long.", "Phone Number Error");
                    }
                }
                //If phone number has non ints in it
                else
                {
                    MessageBox.Show("That was an invalid phone number. Make sure you type out only numbers with nothing else. It should be 10 digits long.", "Phone Number Error");
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Your value was in an incorrect format. Please enter only number a number");
            }
            catch (OverflowException)
            {
                MessageBox.Show("That amount was too much. Please enter another amount.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType() + " : " + ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Customer Info Reset
            firstNameBox.Text = "";
            lastNameBox.Text = "";
            cityBox.Text = "";
            stateBox.Text = "";
            streetAdressBox.Text = "";
            phoneNumberBox.Text = "";

            //Vehicle Info Reset
            makeBox.SelectedIndex = -1;
            modelBox.SelectedIndex = -1;
            trimBox.SelectedIndex = -1;
            vinBox.Text = "";
            yearBox.SelectedIndex = -1;

            //Issue Box Reset
            ServicesBox.SelectedIndex = -1;

            estimatedPriceBox.Text = "$0.00";
            actualPriceBox.Text = "$0.00";
        }

        private void makeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> modelList = new List<string>();
            if (makeBox.SelectedIndex == 0)
            {
                modelList.Add("A3");
                modelList.Add("A5");
                modelList.Add("A7");
            }
            else if (makeBox.SelectedIndex == 1)
            {
                modelList.Add("3 Series");
                modelList.Add("5 Series");
            }
            else if (makeBox.SelectedIndex == 2)
            {
                modelList.Add("LaCross");
                modelList.Add("Enclave");
            }
            else if (makeBox.SelectedIndex == 3)
            {
                modelList.Add("CT5");
                modelList.Add("Escalade");
            }
            else if (makeBox.SelectedIndex == 4)
            {
                modelList.Add("Malibu");
                modelList.Add("Corvette");
                modelList.Add("Tahoe");
            }
            else if (makeBox.SelectedIndex == 5)
            {
                modelList.Add("200");
                modelList.Add("300");
            }
            else if (makeBox.SelectedIndex == 6)
            {
                modelList.Add("Charger");
                modelList.Add("Durango");
            }
            else if (makeBox.SelectedIndex == 7)
            {
                modelList.Add("Mustang");
                modelList.Add("Expedition");
            }
            else if (makeBox.SelectedIndex == 8)
            {
                modelList.Add("Yukon");
                modelList.Add("Sierra");
            }
            else if (makeBox.SelectedIndex == 9)
            {
                modelList.Add("Accord");
                modelList.Add("Pilot");
            }
            else if (makeBox.SelectedIndex == 10)
            {
                modelList.Add("Accent");
                modelList.Add("Santa Cruz");
            }
            else if (makeBox.SelectedIndex == 11)
            {
                modelList.Add("Q50");
                modelList.Add("Q60");
            }
            else if (makeBox.SelectedIndex == 12)
            {
                modelList.Add("XF");
                modelList.Add("F-Type");
            }
            else if (makeBox.SelectedIndex == 13)
            {
                modelList.Add("Grand Cherokee");
                modelList.Add("Compass");
            }
            else if (makeBox.SelectedIndex == 14)
            {
                modelList.Add("Forte");
                modelList.Add("Sportage");
            }
            else if (makeBox.SelectedIndex == 15)
            {
                modelList.Add("CT");
                modelList.Add("GX");
            }
            else if (makeBox.SelectedIndex == 16)
            {
                modelList.Add("Aviator");
                modelList.Add("Navigator");
            }
            else if (makeBox.SelectedIndex == 17)
            {
                modelList.Add("Mazda6");
                modelList.Add("CX-5");
            }
            else if (makeBox.SelectedIndex == 18)
            {
                modelList.Add("A-class");
                modelList.Add("B-class");
            }
            else if (makeBox.SelectedIndex == 19)
            {
                modelList.Add("Milan");
                modelList.Add("Mariner");
            }
            else if (makeBox.SelectedIndex == 20)
            {
                modelList.Add("Maxima");
                modelList.Add("Murano");
            }
            else if (makeBox.SelectedIndex == 21)
            {
                modelList.Add("G6");
                modelList.Add("Vibe");
            }
            else if (makeBox.SelectedIndex == 22)
            {
                modelList.Add("Macan");
                modelList.Add("Panamera");
            }
            else if (makeBox.SelectedIndex == 23)
            {
                modelList.Add("Aura");
                modelList.Add("Astra");
            }
            else if (makeBox.SelectedIndex == 24)
            {
                modelList.Add("Outback");
                modelList.Add("Legacy");
            }
            else if (makeBox.SelectedIndex == 25)
            {
                modelList.Add("Camry");
                modelList.Add("Highlander");
                modelList.Add("RAV4");
            }
            else if (makeBox.SelectedIndex == 26)
            {
                modelList.Add("Jetta");
                modelList.Add("Passat");
            }
            else if (makeBox.SelectedIndex == 27)
            {
                modelList.Add("XC40");
                modelList.Add("XC60");
            }
            modelBox.DataSource = modelList;
        }
    }
}
