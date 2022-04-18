namespace Marys_Auto
{
    partial class Services
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.actualPriceBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.estimatedPriceBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trimBox = new System.Windows.Forms.ComboBox();
            this.yearBox = new System.Windows.Forms.ComboBox();
            this.modelBox = new System.Windows.Forms.ComboBox();
            this.makeBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.vinBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.customerInfoBox = new System.Windows.Forms.GroupBox();
            this.phoneNumberBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.stateBox = new System.Windows.Forms.TextBox();
            this.streetAdressBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ServicesBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TechnicianBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.customerInfoBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // actualPriceBox
            // 
            this.actualPriceBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.actualPriceBox.Location = new System.Drawing.Point(313, 356);
            this.actualPriceBox.Name = "actualPriceBox";
            this.actualPriceBox.Size = new System.Drawing.Size(84, 22);
            this.actualPriceBox.TabIndex = 23;
            this.actualPriceBox.Text = "$0.00";
            this.actualPriceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Actual Price";
            // 
            // estimatedPriceBox
            // 
            this.estimatedPriceBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.estimatedPriceBox.Location = new System.Drawing.Point(313, 325);
            this.estimatedPriceBox.Name = "estimatedPriceBox";
            this.estimatedPriceBox.Size = new System.Drawing.Size(84, 22);
            this.estimatedPriceBox.TabIndex = 22;
            this.estimatedPriceBox.Text = "$0.00";
            this.estimatedPriceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(192, 325);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 16);
            this.label15.TabIndex = 17;
            this.label15.Text = "Estimated Price";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(310, 423);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(123, 40);
            this.submitButton.TabIndex = 26;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(173, 423);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(125, 40);
            this.clearButton.TabIndex = 25;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trimBox);
            this.groupBox1.Controls.Add(this.yearBox);
            this.groupBox1.Controls.Add(this.modelBox);
            this.groupBox1.Controls.Add(this.makeBox);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.vinBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(310, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 217);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehicle Info";
            // 
            // trimBox
            // 
            this.trimBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trimBox.FormattingEnabled = true;
            this.trimBox.Items.AddRange(new object[] {
            "Trim 1 Example",
            "Trim 2 Example",
            "Trim 3 Example",
            "Trim 4 Example",
            "Trim 5 Example",
            "Etc edit later"});
            this.trimBox.Location = new System.Drawing.Point(87, 88);
            this.trimBox.Name = "trimBox";
            this.trimBox.Size = new System.Drawing.Size(157, 24);
            this.trimBox.TabIndex = 20;
            // 
            // yearBox
            // 
            this.yearBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearBox.FormattingEnabled = true;
            this.yearBox.Items.AddRange(new object[] {
            "1970",
            "1971",
            "1972",
            "1973",
            "1974",
            "1975",
            "1976",
            "1977",
            "1978",
            "1979",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            ""});
            this.yearBox.Location = new System.Drawing.Point(87, 152);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(157, 24);
            this.yearBox.TabIndex = 19;
            // 
            // modelBox
            // 
            this.modelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelBox.FormattingEnabled = true;
            this.modelBox.Location = new System.Drawing.Point(87, 56);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(157, 24);
            this.modelBox.TabIndex = 18;
            // 
            // makeBox
            // 
            this.makeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.makeBox.FormattingEnabled = true;
            this.makeBox.Items.AddRange(new object[] {
            "Audi",
            "BMW",
            "Buick",
            "Cadillac",
            "Chevrolet",
            "Chrysler",
            "Dodge",
            "Ford",
            "GMC",
            "Honda",
            "Hyundai",
            "Infiniti",
            "Jaguar",
            "Jeep",
            "Kia",
            "Lexus",
            "Lincoln",
            "Mazda",
            "Mercedes-Benz",
            "Mercury",
            "Nissan",
            "Pontiac",
            "Porsche",
            "Saturn",
            "Subaru",
            "Toyota",
            "Volkswagen",
            "Volvo"});
            this.makeBox.Location = new System.Drawing.Point(87, 21);
            this.makeBox.Name = "makeBox";
            this.makeBox.Size = new System.Drawing.Size(157, 24);
            this.makeBox.TabIndex = 17;
            this.makeBox.SelectedIndexChanged += new System.EventHandler(this.makeBox_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "Year";
            // 
            // vinBox
            // 
            this.vinBox.Location = new System.Drawing.Point(87, 118);
            this.vinBox.Name = "vinBox";
            this.vinBox.Size = new System.Drawing.Size(157, 22);
            this.vinBox.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Model";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "VIN";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Make";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "Trim";
            // 
            // customerInfoBox
            // 
            this.customerInfoBox.Controls.Add(this.phoneNumberBox);
            this.customerInfoBox.Controls.Add(this.label11);
            this.customerInfoBox.Controls.Add(this.stateBox);
            this.customerInfoBox.Controls.Add(this.streetAdressBox);
            this.customerInfoBox.Controls.Add(this.lastNameBox);
            this.customerInfoBox.Controls.Add(this.label2);
            this.customerInfoBox.Controls.Add(this.cityBox);
            this.customerInfoBox.Controls.Add(this.label3);
            this.customerInfoBox.Controls.Add(this.label5);
            this.customerInfoBox.Controls.Add(this.firstNameBox);
            this.customerInfoBox.Controls.Add(this.label1);
            this.customerInfoBox.Controls.Add(this.label4);
            this.customerInfoBox.Location = new System.Drawing.Point(25, 16);
            this.customerInfoBox.Name = "customerInfoBox";
            this.customerInfoBox.Size = new System.Drawing.Size(256, 217);
            this.customerInfoBox.TabIndex = 18;
            this.customerInfoBox.TabStop = false;
            this.customerInfoBox.Text = "Customer Info";
            // 
            // phoneNumberBox
            // 
            this.phoneNumberBox.Location = new System.Drawing.Point(137, 180);
            this.phoneNumberBox.Name = "phoneNumberBox";
            this.phoneNumberBox.Size = new System.Drawing.Size(107, 22);
            this.phoneNumberBox.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "Phone Number";
            // 
            // stateBox
            // 
            this.stateBox.Location = new System.Drawing.Point(137, 118);
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(107, 22);
            this.stateBox.TabIndex = 4;
            // 
            // streetAdressBox
            // 
            this.streetAdressBox.Location = new System.Drawing.Point(137, 152);
            this.streetAdressBox.Name = "streetAdressBox";
            this.streetAdressBox.Size = new System.Drawing.Size(107, 22);
            this.streetAdressBox.TabIndex = 5;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(137, 54);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(107, 22);
            this.lastNameBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Street Adress";
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(137, 86);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(107, 22);
            this.cityBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "State";
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(137, 26);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(107, 22);
            this.firstNameBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "City";
            // 
            // ServicesBox
            // 
            this.ServicesBox.FormattingEnabled = true;
            this.ServicesBox.Items.AddRange(new object[] {
            "Oil and Filter Change",
            "Tire Rotation",
            "Tire Replacement",
            "Brake Repair",
            "Air Conditioning Service",
            "Electrical Systems Service",
            "Transmission Repair"});
            this.ServicesBox.Location = new System.Drawing.Point(195, 281);
            this.ServicesBox.Name = "ServicesBox";
            this.ServicesBox.Size = new System.Drawing.Size(254, 24);
            this.ServicesBox.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(85, 284);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 16);
            this.label13.TabIndex = 27;
            this.label13.Text = "Services";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(85, 254);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 16);
            this.label14.TabIndex = 27;
            this.label14.Text = "Technician";
            // 
            // TechnicianBox
            // 
            this.TechnicianBox.FormattingEnabled = true;
            this.TechnicianBox.Items.AddRange(new object[] {
            "Tina Massey",
            "Brad Peterson",
            "Wendy Myers"});
            this.TechnicianBox.Location = new System.Drawing.Point(195, 251);
            this.TechnicianBox.Name = "TechnicianBox";
            this.TechnicianBox.Size = new System.Drawing.Size(254, 24);
            this.TechnicianBox.TabIndex = 28;
            // 
            // Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TechnicianBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ServicesBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.actualPriceBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.estimatedPriceBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.customerInfoBox);
            this.Name = "Services";
            this.Size = new System.Drawing.Size(592, 500);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.customerInfoBox.ResumeLayout(false);
            this.customerInfoBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox actualPriceBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox estimatedPriceBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox trimBox;
        private System.Windows.Forms.ComboBox yearBox;
        private System.Windows.Forms.ComboBox modelBox;
        private System.Windows.Forms.ComboBox makeBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox vinBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox customerInfoBox;
        private System.Windows.Forms.TextBox phoneNumberBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox stateBox;
        private System.Windows.Forms.TextBox streetAdressBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ServicesBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox TechnicianBox;
    }
}
