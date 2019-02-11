namespace CarRentalSystemDesignNew
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlVehicles = new System.Windows.Forms.Panel();
            this.pnlBooking = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmb2 = new System.Windows.Forms.ComboBox();
            this.lblDropOFF = new System.Windows.Forms.Label();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.lblPickUp = new System.Windows.Forms.Label();
            this.dateTimePicker6 = new System.Windows.Forms.DateTimePicker();
            this.lblToTime = new System.Windows.Forms.Label();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.lblRental = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.lblToDate = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.txtInsuranceNo = new System.Windows.Forms.TextBox();
            this.lblInsurance = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtCustFname = new System.Windows.Forms.TextBox();
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblVehName = new System.Windows.Forms.Label();
            this.lblVName = new System.Windows.Forms.Label();
            this.lblVID = new System.Windows.Forms.Label();
            this.lblVehicleID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBOOK = new System.Windows.Forms.Button();
            this.dataGridVehicles = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlReservations = new System.Windows.Forms.Panel();
            this.dgrReservations = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlVehicles.SuspendLayout();
            this.pnlBooking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVehicles)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.pnlReservations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1848, 898);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlVehicles);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1840, 869);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vehicles";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlVehicles
            // 
            this.pnlVehicles.Controls.Add(this.pnlBooking);
            this.pnlVehicles.Controls.Add(this.btnBOOK);
            this.pnlVehicles.Controls.Add(this.dataGridVehicles);
            this.pnlVehicles.Location = new System.Drawing.Point(17, 21);
            this.pnlVehicles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlVehicles.Name = "pnlVehicles";
            this.pnlVehicles.Size = new System.Drawing.Size(1365, 737);
            this.pnlVehicles.TabIndex = 0;
            // 
            // pnlBooking
            // 
            this.pnlBooking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBooking.Controls.Add(this.btnSave);
            this.pnlBooking.Controls.Add(this.cmb2);
            this.pnlBooking.Controls.Add(this.lblDropOFF);
            this.pnlBooking.Controls.Add(this.cmb1);
            this.pnlBooking.Controls.Add(this.lblPickUp);
            this.pnlBooking.Controls.Add(this.dateTimePicker6);
            this.pnlBooking.Controls.Add(this.lblToTime);
            this.pnlBooking.Controls.Add(this.dateTimePicker5);
            this.pnlBooking.Controls.Add(this.label2);
            this.pnlBooking.Controls.Add(this.dateTimePicker4);
            this.pnlBooking.Controls.Add(this.lblRental);
            this.pnlBooking.Controls.Add(this.dateTimePicker3);
            this.pnlBooking.Controls.Add(this.lblToDate);
            this.pnlBooking.Controls.Add(this.dateTimePicker2);
            this.pnlBooking.Controls.Add(this.lblFromDate);
            this.pnlBooking.Controls.Add(this.txtInsuranceNo);
            this.pnlBooking.Controls.Add(this.lblInsurance);
            this.pnlBooking.Controls.Add(this.dateTimePicker1);
            this.pnlBooking.Controls.Add(this.lblDOB);
            this.pnlBooking.Controls.Add(this.txtPhone);
            this.pnlBooking.Controls.Add(this.lblPhone);
            this.pnlBooking.Controls.Add(this.txtLastName);
            this.pnlBooking.Controls.Add(this.lblLastName);
            this.pnlBooking.Controls.Add(this.txtCustFname);
            this.pnlBooking.Controls.Add(this.lblCustName);
            this.pnlBooking.Controls.Add(this.lblVehName);
            this.pnlBooking.Controls.Add(this.lblVName);
            this.pnlBooking.Controls.Add(this.lblVID);
            this.pnlBooking.Controls.Add(this.lblVehicleID);
            this.pnlBooking.Controls.Add(this.label1);
            this.pnlBooking.Location = new System.Drawing.Point(15, 318);
            this.pnlBooking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBooking.Name = "pnlBooking";
            this.pnlBooking.Size = new System.Drawing.Size(1322, 391);
            this.pnlBooking.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(13, 303);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 43);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmb2
            // 
            this.cmb2.FormattingEnabled = true;
            this.cmb2.Items.AddRange(new object[] {
            "Airport",
            "Midtown",
            "Uptown",
            "Downtown"});
            this.cmb2.Location = new System.Drawing.Point(124, 171);
            this.cmb2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb2.Name = "cmb2";
            this.cmb2.Size = new System.Drawing.Size(121, 24);
            this.cmb2.TabIndex = 30;
            // 
            // lblDropOFF
            // 
            this.lblDropOFF.AutoSize = true;
            this.lblDropOFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDropOFF.Location = new System.Drawing.Point(11, 175);
            this.lblDropOFF.Name = "lblDropOFF";
            this.lblDropOFF.Size = new System.Drawing.Size(88, 20);
            this.lblDropOFF.TabIndex = 29;
            this.lblDropOFF.Text = "Drop Off:";
            // 
            // cmb1
            // 
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Items.AddRange(new object[] {
            "Airport",
            "Midtown",
            "Uptown",
            "Downtown"});
            this.cmb1.Location = new System.Drawing.Point(124, 126);
            this.cmb1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(121, 24);
            this.cmb1.TabIndex = 28;
            // 
            // lblPickUp
            // 
            this.lblPickUp.AutoSize = true;
            this.lblPickUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPickUp.Location = new System.Drawing.Point(11, 130);
            this.lblPickUp.Name = "lblPickUp";
            this.lblPickUp.Size = new System.Drawing.Size(80, 20);
            this.lblPickUp.TabIndex = 27;
            this.lblPickUp.Text = "Pick Up:";
            // 
            // dateTimePicker6
            // 
            this.dateTimePicker6.Location = new System.Drawing.Point(751, 127);
            this.dateTimePicker6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker6.Name = "dateTimePicker6";
            this.dateTimePicker6.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker6.TabIndex = 26;
            this.dateTimePicker6.ValueChanged += new System.EventHandler(this.dateTimePicker6_ValueChanged);
            // 
            // lblToTime
            // 
            this.lblToTime.AutoSize = true;
            this.lblToTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToTime.Location = new System.Drawing.Point(624, 126);
            this.lblToTime.Name = "lblToTime";
            this.lblToTime.Size = new System.Drawing.Size(77, 20);
            this.lblToTime.TabIndex = 25;
            this.lblToTime.Text = "ToTime:";
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.Location = new System.Drawing.Point(396, 127);
            this.dateTimePicker5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker5.TabIndex = 24;
            this.dateTimePicker5.ValueChanged += new System.EventHandler(this.dateTimePicker5_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(261, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "From Time:";
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(1108, 85);
            this.dateTimePicker4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker4.TabIndex = 22;
            this.dateTimePicker4.ValueChanged += new System.EventHandler(this.dateTimePicker4_ValueChanged);
            // 
            // lblRental
            // 
            this.lblRental.AutoSize = true;
            this.lblRental.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRental.Location = new System.Drawing.Point(971, 85);
            this.lblRental.Name = "lblRental";
            this.lblRental.Size = new System.Drawing.Size(115, 20);
            this.lblRental.TabIndex = 21;
            this.lblRental.Text = "Rental Date:";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(751, 82);
            this.dateTimePicker3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker3.TabIndex = 20;
            this.dateTimePicker3.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDate.Location = new System.Drawing.Point(624, 87);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(82, 20);
            this.lblToDate.TabIndex = 19;
            this.lblToDate.Text = "To Date:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(396, 87);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 18;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromDate.Location = new System.Drawing.Point(260, 87);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(104, 20);
            this.lblFromDate.TabIndex = 17;
            this.lblFromDate.Text = "From Date:";
            // 
            // txtInsuranceNo
            // 
            this.txtInsuranceNo.Location = new System.Drawing.Point(124, 85);
            this.txtInsuranceNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInsuranceNo.Name = "txtInsuranceNo";
            this.txtInsuranceNo.Size = new System.Drawing.Size(121, 22);
            this.txtInsuranceNo.TabIndex = 14;
            // 
            // lblInsurance
            // 
            this.lblInsurance.AutoSize = true;
            this.lblInsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsurance.Location = new System.Drawing.Point(11, 87);
            this.lblInsurance.Name = "lblInsurance";
            this.lblInsurance.Size = new System.Drawing.Size(87, 20);
            this.lblInsurance.TabIndex = 13;
            this.lblInsurance.Text = "Insurane:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1108, 52);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(973, 52);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(56, 20);
            this.lblDOB.TabIndex = 11;
            this.lblDOB.Text = "DOB:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(793, 52);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(137, 22);
            this.txtPhone.TabIndex = 10;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(624, 54);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(138, 20);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "Phone Number:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(396, 48);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 22);
            this.txtLastName.TabIndex = 8;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(260, 48);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(106, 20);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtCustFname
            // 
            this.txtCustFname.Location = new System.Drawing.Point(145, 46);
            this.txtCustFname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustFname.Name = "txtCustFname";
            this.txtCustFname.Size = new System.Drawing.Size(100, 22);
            this.txtCustFname.TabIndex = 6;
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustName.Location = new System.Drawing.Point(11, 46);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(108, 20);
            this.lblCustName.TabIndex = 5;
            this.lblCustName.Text = "First Name:";
            // 
            // lblVehName
            // 
            this.lblVehName.AutoSize = true;
            this.lblVehName.Location = new System.Drawing.Point(412, 224);
            this.lblVehName.Name = "lblVehName";
            this.lblVehName.Size = new System.Drawing.Size(84, 17);
            this.lblVehName.TabIndex = 4;
            this.lblVehName.Text = "lblVehName";
            // 
            // lblVName
            // 
            this.lblVName.AutoSize = true;
            this.lblVName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVName.Location = new System.Drawing.Point(261, 222);
            this.lblVName.Name = "lblVName";
            this.lblVName.Size = new System.Drawing.Size(131, 20);
            this.lblVName.TabIndex = 3;
            this.lblVName.Text = "Vehicle Name:";
            // 
            // lblVID
            // 
            this.lblVID.AutoSize = true;
            this.lblVID.Location = new System.Drawing.Point(121, 224);
            this.lblVID.Name = "lblVID";
            this.lblVID.Size = new System.Drawing.Size(44, 17);
            this.lblVID.TabIndex = 2;
            this.lblVID.Text = "lblVID";
            this.lblVID.Click += new System.EventHandler(this.lblVID_Click);
            // 
            // lblVehicleID
            // 
            this.lblVehicleID.AutoSize = true;
            this.lblVehicleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleID.Location = new System.Drawing.Point(11, 224);
            this.lblVehicleID.Name = "lblVehicleID";
            this.lblVehicleID.Size = new System.Drawing.Size(102, 20);
            this.lblVehicleID.TabIndex = 1;
            this.lblVehicleID.Text = "Vehicle ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(571, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Booking Details";
            // 
            // btnBOOK
            // 
            this.btnBOOK.Location = new System.Drawing.Point(1163, 203);
            this.btnBOOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBOOK.Name = "btnBOOK";
            this.btnBOOK.Size = new System.Drawing.Size(111, 43);
            this.btnBOOK.TabIndex = 1;
            this.btnBOOK.Text = "Book";
            this.btnBOOK.UseVisualStyleBackColor = true;
            this.btnBOOK.Click += new System.EventHandler(this.btnBOOK_Click);
            // 
            // dataGridVehicles
            // 
            this.dataGridVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVehicles.Location = new System.Drawing.Point(15, 18);
            this.dataGridVehicles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridVehicles.Name = "dataGridVehicles";
            this.dataGridVehicles.RowTemplate.Height = 24;
            this.dataGridVehicles.Size = new System.Drawing.Size(1127, 228);
            this.dataGridVehicles.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pnlReservations);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1840, 869);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reservations";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlReservations
            // 
            this.pnlReservations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlReservations.Controls.Add(this.dgrReservations);
            this.pnlReservations.Controls.Add(this.label3);
            this.pnlReservations.Location = new System.Drawing.Point(20, 34);
            this.pnlReservations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlReservations.Name = "pnlReservations";
            this.pnlReservations.Size = new System.Drawing.Size(1777, 801);
            this.pnlReservations.TabIndex = 0;
            // 
            // dgrReservations
            // 
            this.dgrReservations.Location = new System.Drawing.Point(29, 69);
            this.dgrReservations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgrReservations.Name = "dgrReservations";
            this.dgrReservations.Size = new System.Drawing.Size(1688, 590);
            this.dgrReservations.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(863, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Reservation Details";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1844, 834);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pnlVehicles.ResumeLayout(false);
            this.pnlBooking.ResumeLayout(false);
            this.pnlBooking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVehicles)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.pnlReservations.ResumeLayout(false);
            this.pnlReservations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrReservations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel pnlVehicles;
        private System.Windows.Forms.Panel pnlBooking;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label lblVehName;
        private System.Windows.Forms.Label lblVName;
        private System.Windows.Forms.Label lblVID;
        private System.Windows.Forms.Label lblVehicleID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBOOK;
        private System.Windows.Forms.DataGridView dataGridVehicles;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtCustFname;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtInsuranceNo;
        private System.Windows.Forms.Label lblInsurance;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label lblRental;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker6;
        private System.Windows.Forms.Label lblToTime;
        private System.Windows.Forms.ComboBox cmb2;
        private System.Windows.Forms.Label lblDropOFF;
        private System.Windows.Forms.ComboBox cmb1;
        private System.Windows.Forms.Label lblPickUp;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlReservations;
        private System.Windows.Forms.DataGridView dgrReservations;
        private System.Windows.Forms.Label label3;
    }
}

