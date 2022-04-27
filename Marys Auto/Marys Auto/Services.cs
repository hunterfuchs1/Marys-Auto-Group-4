using Marys_Auto.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        
       // string connectionString = "Data Source=Abdalla;Initial Catalog=MarysAutoDB2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private void submitButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    ///Customer Info Null Check
            //    if (String.IsNullOrEmpty(firstNameBox.Text) || String.IsNullOrEmpty(lastNameBox.Text) || String.IsNullOrEmpty(cityBox.Text) || String.IsNullOrEmpty(stateBox.Text) || String.IsNullOrEmpty(streetAdressBox.Text) || String.IsNullOrEmpty(phoneNumberBox.Text))
            //    {
            //        MessageBox.Show("One or more of the boxes were left blank in the Customer Info section. Please fill out every box.", "Customer Info Null");
            //    }

            //   /// Phone Number Check
            //    if (int.TryParse(phoneNumberBox.Text, out int num))
            //    {
            //        if (phoneNumberBox.Text.Length == 10)
            //        {
            //            //Vehicle Info Null Check
            //            if (String.IsNullOrEmpty(makeBox.Text) || String.IsNullOrEmpty(modelBox.Text) || String.IsNullOrEmpty(trimBox.Text) || String.IsNullOrEmpty(trimBox.Text) || String.IsNullOrEmpty(vinBox.Text) || String.IsNullOrEmpty(yearBox.Text))
            //            {
            //                MessageBox.Show("One or more of the boxes were left blank in the Vehicle Info section. Please fill out every box.", "Vehicle Info Null");
            //            }
            //            //Issue Text Box Null Check
            //            else if (String.IsNullOrEmpty(ServicesBox.Text))
            //            {
            //                MessageBox.Show("You have to specify an issue with the vehicle.", "Issue Text Box Null");
            //            }
            //            else if (String.IsNullOrEmpty(estimatedPriceBox.Text) || String.IsNullOrEmpty(actualPriceBox.Text))
            //            {
            //                MessageBox.Show("The Estimated Price or Actual Price is empty.", "Price Info Null");
            //            }
            //            else
            //            {
            //                ////////////////////////////////////////
            //                ///EVERYTHING VALIDATED NEW CODE HERE///
            //                ////////////////////////////////////////
            //                MessageBox.Show("Validated");



            //InsertServiceData();
            InsertServiceData();



            //            }
            //        }
            //       // If phone number isnt 10 digits long
            //        else
            //        {
            //            MessageBox.Show("That was an invalid phone number. Make sure you type out only numbers with nothing else. It should be 10 digits long.", "Phone Number Error");
            //        }
            //    }
            //   // If phone number has non ints in it
            //    else
            //    {
            //        MessageBox.Show("That was an invalid phone number. Make sure you type out only numbers with nothing else. It should be 10 digits long.", "Phone Number Error");
            //    }

            //}
            //catch (FormatException)
            //{
            //    MessageBox.Show("Your value was in an incorrect format. Please enter only number a number");
            //}
            //catch (OverflowException)
            //{
            //    MessageBox.Show("That amount was too much. Please enter another amount.");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.GetType() + " : " + ex.Message);
            //}
           
            
        }
        //////////////////////////////////////////////////////DO NOT DELETE - Working Function///////////////////////////////////////////////////////////////////
        //public void InsertServiceData()
        //{

        //    int customerId = 0;
        //    int employeeId = 0;
        //    int invoiceId = 0;
        //    int vehicleId = 0;
        //    //insert into Customers table
        //    using (SqlConnection con = new SqlConnection(connectionString))
        //    {

        //        string query;
        //        con.Open();
        //        query = "INSERT INTO Customers(CustomerFirstName,CustomerLastName,CustomerStreetAddress,CustomerCity,CustomerState,CustomerZipCode,CustomerPhoneAreaCode,CustomerPhoneNumber) VALUES(@CustomerFirstName,@CustomerLastName,@CustomerStreetAddress,@CustomerCity,@CustomerState,@CustomerZipCode,@CustomerPhoneAreaCode,@CustomerPhoneNumber) SELECT SCOPE_IDENTITY();";
        //        using (SqlCommand cmd = new SqlCommand(query, con))
        //        {
        //            cmd.Parameters.Add(new SqlParameter("@CustomerFirstName", firstNameBox.Text));
        //            cmd.Parameters.Add(new SqlParameter("@CustomerLastName", lastNameBox.Text));
        //            cmd.Parameters.Add(new SqlParameter("@CustomerStreetAddress", streetAdressBox.Text));
        //            cmd.Parameters.Add(new SqlParameter("@CustomerCity", cityBox.Text));
        //            cmd.Parameters.Add(new SqlParameter("@CustomerState", stateBox.Text));
        //            cmd.Parameters.Add(new SqlParameter("@CustomerZipCode", txtZip.Text));
        //            cmd.Parameters.Add(new SqlParameter("@CustomerPhoneAreaCode", txtArea.Text));
        //            cmd.Parameters.Add(new SqlParameter("@CustomerPhoneNumber", phoneNumberBox.Text));
        //            cmd.ExecuteNonQuery();
        //            customerId = Convert.ToInt32(cmd.ExecuteScalar());
        //        }
        //        con.Close();
        //        query = "INSERT INTO Vehicles(VehicleMake,VehicleModel,VehicleTrim,VehicleYear,VIN,Customer_ID) VALUES(@VehicleMake,@VehicleModel,@VehicleTrim,@VehicleYear,@VIN,@Customer_ID) SELECT SCOPE_IDENTITY();";
        //        con.Open();
        //        using (SqlCommand cmd = new SqlCommand(query, con))
        //        {
        //            cmd.Parameters.Add(new SqlParameter( "@VehicleMake", makeBox.SelectedItem.ToString()));
        //            cmd.Parameters.Add(new SqlParameter("@VehicleModel", modelBox.SelectedItem.ToString()));
        //            if (trimBox.SelectedItem == null)
        //            {
        //                cmd.Parameters.Add(new SqlParameter("@VehicleTrim", ""));
        //            }
        //            else
        //            {
        //                cmd.Parameters.Add(new SqlParameter("@VehicleTrim", trimBox.SelectedItem.ToString()));
        //            }

        //            cmd.Parameters.Add(new SqlParameter("@VehicleYear", yearBox.SelectedItem.ToString()));
        //            cmd.Parameters.Add(new SqlParameter("@VIN", vinBox.Text));
        //            cmd.Parameters.Add(new SqlParameter("@Customer_ID", customerId.ToString()));
        //            cmd.ExecuteNonQuery();
        //            vehicleId = Convert.ToInt32(cmd.ExecuteScalar());
        //        }

        //        con.Close();
        //    }

        //    //insert into employees table
        //    using (SqlConnection con = new SqlConnection(connectionString))
        //    {
        //        con.Open();
        //        string[] delim = TechnicianBox.SelectedItem.ToString().Split(' ');
        //        string fname = delim[0].Trim();
        //        string lname = delim[1].Trim();
        //        string title = "";
        //        decimal wage = 0;
        //        int experience = 0;
        //        if (fname == "Tina")
        //        {
        //            title = "Master Mechanic";
        //            wage = 80.00m;
        //            experience = 10;
        //        }else if (fname == "Brad")
        //        {
        //            title = "Automotive Technician";
        //            wage = 50.00m;
        //            experience = 5;
        //        }else if(fname == "Wendy")
        //        {
        //            title = "Tire/Lube Technician";
        //            wage = 30.00m;
        //            experience = 2;
        //        }
        //        else
        //        {
        //            title = "Owner";
        //            wage = 0;
        //            experience = 0;
        //        }
        //        string query = "INSERT INTO Employees(EmployeeFirstName,EmployeeLastName,JobTitle,HourlyWage,Experience) VALUES (@EmployeeFirstName,@EmployeeLastName,@JobTitle,@HourlyWage,@Experience)  SELECT SCOPE_IDENTITY();";

        //        using (SqlCommand cmd = new SqlCommand(query, con))
        //        {

        //            cmd.Parameters.Add(new SqlParameter("@EmployeeFirstName", fname));
        //            cmd.Parameters.Add(new SqlParameter("@EmployeeLastName", lname));
        //            cmd.Parameters.Add(new SqlParameter("@JobTitle", title));
        //            cmd.Parameters.Add(new SqlParameter("@HourlyWage", wage));
        //            cmd.Parameters.Add(new SqlParameter("@Experience", experience));

        //            cmd.ExecuteNonQuery();
        //            employeeId = Convert.ToInt32(cmd.ExecuteScalar());
        //        }

        //        con.Close();
        //    }

        //    //insert into Invoice table
        //    using (SqlConnection con = new SqlConnection(connectionString))
        //    {
        //        con.Open();
        //        string query = "INSERT INTO Invoice(Date,Vehicle_ID,Employee_ID,EstimatePrice,FinalPrice) VALUES (@Date,@Vehicle_ID,@Employee_ID,@EstimatePrice,@FinalPrice)  SELECT SCOPE_IDENTITY();";

        //        using (SqlCommand cmd = new SqlCommand(query, con))
        //        {
        //            DateTime myDateTime = DateTime.Now;
        //            cmd.Parameters.Add(new SqlParameter("@Date", myDateTime));
        //            cmd.Parameters.Add(new SqlParameter("@Vehicle_ID", vehicleId));
        //            cmd.Parameters.Add(new SqlParameter("@Employee_ID", employeeId));
        //            cmd.Parameters.Add(new SqlParameter("@EstimatePrice", estimatedPriceBox.Text));
        //            cmd.Parameters.Add(new SqlParameter("@FinalPrice", actualPriceBox.Text));
        //            cmd.ExecuteNonQuery();
        //            invoiceId = Convert.ToInt32(cmd.ExecuteScalar());
        //        }

        //        con.Close();
        //    }

        //    //insert into Services table
        //    using (SqlConnection con = new SqlConnection(connectionString))
        //    {
        //        con.Open();
        //        string query = "INSERT INTO Services(ServiceName, Invoice_ID) VALUES (@ServiceName,@Invoice_ID)";
        //        using (SqlCommand cmd = new SqlCommand(query, con))
        //        {
        //            cmd.Parameters.Add(new SqlParameter("@ServiceName", ServicesBox.SelectedItem.ToString()));
        //            cmd.Parameters.Add(new SqlParameter("@Invoice_ID", invoiceId));
        //            cmd.ExecuteNonQuery();
        //        }
        //        con.Close();
        //    }

        //    MessageBox.Show("Data Inserted", "Data Insertion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    clear();
        //}
        
        /// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        public void InsertServiceData()
        {
            Customer customer = new Customer();
            customer.Customer_ID = 0;
            customer.CustomerFirstName = firstNameBox.Text.Trim();
            customer.CustomerLastName = lastNameBox.Text.Trim();
            customer.CustomerStreetAddress = streetAdressBox.Text.Trim();
            customer.CustomerCity = cityBox.Text.Trim();
            customer.CustomerState = stateBox.Text.Trim();
            customer.CustomerZipCode = txtZip.Text.Trim();
            customer.CustomerPhoneAreaCode = txtArea.Text.Trim();
            customer.CustomerPhoneNumber = phoneNumberBox.Text.Trim();
            using (MarysAutoDB2Entities db = new MarysAutoDB2Entities())
            {
                db.Customers.Add(customer);

                db.SaveChanges();
            }

            Vehicle vehicle = new Vehicle();
            vehicle.Vehicle_ID = 0;
            vehicle.VehicleMake = makeBox.SelectedItem.ToString();
            vehicle.VehicleModel = modelBox.SelectedItem.ToString();
            if (trimBox.SelectedItem == null)
                vehicle.VehicleTrim = "";
            else
                vehicle.VehicleTrim = trimBox.SelectedItem.ToString();
            vehicle.VehicleYear = yearBox.SelectedItem.ToString();
            vehicle.VIN = vinBox.Text;
            vehicle.Customer_ID = customer.Customer_ID;
            using (MarysAutoDB2Entities db = new MarysAutoDB2Entities())
            {
                db.Vehicles.Add(vehicle);
                db.SaveChanges();
            }

            Employee employee = new Employee();
            employee.Employee_ID = 0;
            string[] delim = TechnicianBox.SelectedItem.ToString().Split(' ');
            employee.EmployeeFirstName = delim[0].Trim();
            employee.EmployeeLastName = delim[1].Trim();
            if (employee.EmployeeFirstName == "Tina")
                employee.JobTitle = "Master Mechanic";
            else if (employee.EmployeeFirstName == "Brad")
                employee.JobTitle = "Automotive Technician";
            else if (employee.EmployeeFirstName == "Wendy")
                employee.JobTitle = "Tire/Lube Technician";
            else
                employee.JobTitle = "Boss";
            if (employee.EmployeeFirstName == "Tina")
                employee.HourlyWage = 80.00m;
            else if (employee.EmployeeFirstName == "Brad")
                employee.HourlyWage = 50.00m;
            else if (employee.EmployeeFirstName == "Wendy")
                employee.HourlyWage = 30.00m;
            if (employee.EmployeeFirstName == "Tina")
                employee.Experience = 10;
            else if (employee.EmployeeFirstName == "Brad")
                employee.Experience = 5;
            else if (employee.EmployeeFirstName == "Wendy")
                employee.Experience = 2;
            using (MarysAutoDB2Entities db = new MarysAutoDB2Entities())
            {
                db.Employees.Add(employee);
                db.SaveChanges();
            }



            Service service = new Service();
            service.Service_ID = 0;
            service.ServiceName = ServicesBox.SelectedItem.ToString();
            using (MarysAutoDB2Entities db = new MarysAutoDB2Entities())
            {
                db.Services.Add(service);
                db.SaveChanges();
            }

            Invoice invoice = new Invoice();
            invoice.Invoice_ID = 0;
            DateTime todaysDate = DateTime.Today;
            invoice.Date = todaysDate;
            invoice.Employee_ID = employee.Employee_ID;
            invoice.Customer_ID = customer.Customer_ID;
            invoice.Service_ID = service.Service_ID;
            invoice.EstimatePrice = decimal.Parse(estimatedPriceBox.Text);
            invoice.FinalPrice = decimal.Parse(actualPriceBox.Text);
            using (MarysAutoDB2Entities db = new MarysAutoDB2Entities())
            {
                db.Invoices.Add(invoice);
                db.SaveChanges();
            }

            MessageBox.Show("Data Inserted", "Data Insertion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clear();
        
    }


        public void clear()
        {
            //Customer Info Reset
            firstNameBox.Text = "";
            lastNameBox.Text = "";
            cityBox.Text = "";
            stateBox.Text = "";
            streetAdressBox.Text = "";
            txtZip.Text = "";
            txtArea.Text = "";
            phoneNumberBox.Text = "";

            //Vehicle Info Reset
            makeBox.SelectedIndex = -1;
            modelBox.SelectedIndex = -1;
            trimBox.SelectedIndex = -1;
            vinBox.Text = "";
            yearBox.SelectedIndex = -1;

            //Issue Box Reset
            ServicesBox.SelectedIndex = -1;
            TechnicianBox.SelectedIndex = -1;
            estimatedPriceBox.Text = "$0.00";
            actualPriceBox.Text = "$0.00";


        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clear();
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
                modelList.Add("CLS");
                modelList.Add("S-Class");
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

        private void modelBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            List<string> trimList = new List<string>();
            if (makeBox.SelectedIndex == 0 && modelBox.SelectedIndex == 2)
                trimList.Add("Prestige AWD");
            else if (makeBox.SelectedIndex == 1 && modelBox.SelectedIndex == 1)
                trimList.Add("540i xDrive");
            else if (makeBox.SelectedIndex == 3 && modelBox.SelectedIndex == 1)
                trimList.Add("Premium Luxury");
            else if (makeBox.SelectedIndex == 4 && modelBox.SelectedIndex == 1)
                trimList.Add("3LT");
            else if (makeBox.SelectedIndex == 5 && modelBox.SelectedIndex == 1)
                trimList.Add("S");
            else if (makeBox.SelectedIndex == 6 && modelBox.SelectedIndex == 0)
                trimList.Add("R/T");
            else if (makeBox.SelectedIndex == 8 && modelBox.SelectedIndex == 1)
                trimList.Add("denali");
            else if (makeBox.SelectedIndex == 11 && modelBox.SelectedIndex == 1)
                trimList.Add("Luxe");
            else if (makeBox.SelectedIndex == 12 && modelBox.SelectedIndex == 0)
                trimList.Add("SE");
            else if (makeBox.SelectedIndex == 15 && modelBox.SelectedIndex == 1)
                trimList.Add("460 Premium");
            else if (makeBox.SelectedIndex == 16 && modelBox.SelectedIndex == 1)
                trimList.Add("Reserve");
            else if (makeBox.SelectedIndex == 17 && modelBox.SelectedIndex == 1)
                trimList.Add("Signature");
            else if (makeBox.SelectedIndex == 18 && modelBox.SelectedIndex == 1)
                trimList.Add("AMG S 63");
            else if (makeBox.SelectedIndex == 20 && modelBox.SelectedIndex == 0)
                trimList.Add("SV");
            else if (makeBox.SelectedIndex == 21 && modelBox.SelectedIndex == 0)
                trimList.Add("GT");
            else if (makeBox.SelectedIndex == 22 && modelBox.SelectedIndex == 1)
                trimList.Add("Turbo S");
            else if (makeBox.SelectedIndex == 25 && modelBox.SelectedIndex == 2)
                trimList.Add("Limited");
            else if (makeBox.SelectedIndex == 26 && modelBox.SelectedIndex == 0)
                trimList.Add("Sport");
            else if (makeBox.SelectedIndex == 27 && modelBox.SelectedIndex == 1)
                trimList.Add("Inscription");
            trimBox.DataSource = trimList;
        }
    }
}
