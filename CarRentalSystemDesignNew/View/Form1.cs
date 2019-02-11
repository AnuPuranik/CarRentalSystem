using CarRentalSystemDesignNew.Model;
using CarRentalSystemDesignNew.View;
using CarRentalSystemDesignNew.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarRentalSystemDesignNew
{
    public partial class Form1 : Form
    {

        DataTable dt_Vehicle = new DataTable();
        DataTable dt_Reservations = new DataTable();
        Boolean init = false;
        List<Vehicles> ListVehicles = new List<Vehicles>();
        List<Bookings> ListBookings = new List<Bookings>();


        public Form1()
        {
            InitializeComponent();
            //Function to create new Vehicle's objects and add to the list
            LoadVehicleList();
            // Function to add Vehicles list to Datatable so that it is displayed in View Grid
            LoadGrid();
            //Load reservations DataTable
            LoadReservations();
           
            
            pnlBooking.Visible = false;



        }

        public void LoadReservations()
        {
          dt_Reservations=  LoadDatatables.LoadReservationsDataTable();
        }

        public void LoadResrvationsTab()
        {
           
            DataTable dt_result = ReturnDataTables.Reservations_DataTable(ListBookings, dt_Reservations);
            dgrReservations.DataSource = dt_result;
            dgrReservations.Update();
            dgrReservations.Refresh();

        }
        public void LoadVehicleList()
        {
            if (init == false)
            {
               ListVehicles= Initialization.LoadVehicleList();
               dt_Vehicle= LoadDatatables.LoadVehilcesDataTable();
            }
            init = true;

        }


        public void LoadGrid()
        {
            pnlBooking.Visible = false;
            dataGridVehicles.DataSource = null;
            DataTable result = ReturnDataTables.Vehicles_DataTable(ListVehicles,dt_Vehicle);
            dataGridVehicles.DataSource = result;
            dataGridVehicles.Update();
            dataGridVehicles.Refresh();

        }

     

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy";
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "MM/dd/yyyy";
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "MM/dd/yyyy";
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker4.Format = DateTimePickerFormat.Custom;
            dateTimePicker4.CustomFormat = "MM/dd/yyyy";

        }

        private void dateTimePicker5_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker5.Format = DateTimePickerFormat.Custom;
            dateTimePicker5.CustomFormat = "HH:mm";
            dateTimePicker5.ShowUpDown = true;
        }

        private void dateTimePicker6_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker6.Format = DateTimePickerFormat.Custom;
            dateTimePicker6.CustomFormat = "HH:mm";
            dateTimePicker6.ShowUpDown = true;
        }

        private void InitializeNullValues()
        {
            txtCustFname.Text = string.Empty;
            txtLastName.Text = string.Empty;
            dateTimePicker1.Text = string.Empty;
            txtInsuranceNo.Text = string.Empty;
            txtPhone.Text = string.Empty;
            dateTimePicker2.Text = string.Empty;
            dateTimePicker3.Text = string.Empty;
            dateTimePicker5.Text = string.Empty;
            dateTimePicker6.Text = string.Empty;
            lblVehName.Text = string.Empty;
            cmb1.Text = string.Empty;
            cmb2.Text = string.Empty;
            lblVID.Text = string.Empty;
            dateTimePicker2.Text = string.Empty;
            dateTimePicker3.Text = string.Empty;
        }
        private void btnBOOK_Click(object sender, EventArgs e)
        {
            InitializeNullValues();
          
            pnlBooking.Visible = true;
            string Vid, VName = string.Empty;

            if (dataGridVehicles.SelectedRows.Count > 0)
            {
                int RowIndex = dataGridVehicles.SelectedRows[0].Index;
                DataGridViewRow dr = dataGridVehicles.Rows[RowIndex];
                Vid = dr.Cells["Vehicle Id"].Value.ToString();
                VName = dr.Cells["Vehicle Name"].Value.ToString();

                Label label_VID = this.Controls.Find("lblVID", true).FirstOrDefault() as Label;
                Label label_Vname = this.Controls.Find("lblVehName", true).FirstOrDefault() as Label;
                label_VID.Text = Vid;
                label_Vname.Text = VName;
            }
        }

        private Boolean ValidateOnlyNumbers()
        {
            int parsedValue;
            if (!int.TryParse(txtPhone.Text, out parsedValue))
            {
                MessageBox.Show("Phone Number is a number only field");
                return false;
            }

            if (!int.TryParse(txtInsuranceNo.Text, out parsedValue))
            {
                MessageBox.Show("Insurance Number is a number only field");
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Boolean res=ValidateOnlyNumbers();

            ErrorObject result = ValidateBookng.IsValid(ListBookings, lblVID.Text, dateTimePicker2.Text, dateTimePicker3.Text, dateTimePicker5.Text, dateTimePicker6.Text);


            if (result.GetIsValid() && res == true)
            {
                save_booking();
                MessageBox.Show(result.GetErrorMsg());
              
                LoadGrid();
            }
            else
            {
                MessageBox.Show(result.GetErrorMsg());

            }
            


        }


        public void save_booking()
        {
            
           ListBookings= SaveBookings.Save(txtCustFname.Text, txtLastName.Text, dateTimePicker1.Text, dateTimePicker2.Text, dateTimePicker5.Text, dateTimePicker6.Text, dateTimePicker3.Text, cmb1.Text, cmb2.Text,
               lblVehName.Text, lblVID.Text, txtInsuranceNo.Text, dateTimePicker1.Text, txtPhone.Text);
            
         

            LoadResrvationsTab();

            UpdateRentalDetails(Convert.ToInt32(lblVID.Text));

        }
        public void UpdateRentalDetails(int VID)
        {
            var item = ListVehicles.FirstOrDefault(o => o.GetVehicleID() == VID);
            int count = 0;
            if (item != null)
            {
                if(item.GetIsAvailable()==true)
                {
                    item.SetIsAvailable(false);
                }
               
                count = item.GetVehicleCount();
                count--;
                item.SetTotalVehicleCount(count);
                

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblVID_Click(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
           
        }







    }
}
