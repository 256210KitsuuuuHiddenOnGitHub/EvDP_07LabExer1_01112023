//Import Sql
using System.Data;
using System.Data.SqlClient;

namespace EvDP_07LabExer1_01112023
{
    public partial class FrmClubRegistration : Form
    {
        public FrmClubRegistration()
        {
            InitializeComponent();
        }

        private void dtg_update_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Do Nothing Yet
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Establish SQL Connection
            SqlConnection callout = new SqlConnection("Data Source=KITSUUUU\\SQLEXPRESS;Initial Catalog=evdp_db;User ID=user_evdp1;Password=123");
            //Alternative
            //SqlConnection callout = new SqlConnection(@"Data Source=KITSUUUU\SQLEXPRESS;Initial Catalog=evdp_db;User ID=user_evdp1;Password=123");

            //Set Commands SQL (Sql Is Strict, Must Allign at SAME PLACE or Facing Error, also case sensitive) + Sql Connection
            callout.Open(); //Activate SQL Connection
            SqlCommand sqlSend = new SqlCommand("INSERT INTO Student_Info VALUES (@StudentID,@FirstName,@MiddleName,@LastName,@Age,@Gender,@Program)", callout);

            //Handout Code
            //sqlSend.Parameters.Add("@StudentID", SqlDbType.BigInt).Value = Int64.Parse(txtBox_sid.Text);
            //sqlSend.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = txtBox_firstname.Text.ToString();
            //sqlSend.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = txtBox_middlename.Text.ToString();
            //sqlSend.Parameters.Add("@LastName", SqlDbType.VarChar).Value = txtBox_lastname.Text.ToString();
            //sqlSend.Parameters.Add("@Age", SqlDbType.Int).Value = int.Parse(txtBox_age.Text);
            //sqlSend.Parameters.Add("@Gender", SqlDbType.VarChar).Value = cbGender.Text.ToString();
            //sqlSend.Parameters.Add("@Program", SqlDbType.VarChar).Value = cbProgram.Text.ToString();

            //My Alternative Command (Fast Switch)
            sqlSend.Parameters.AddWithValue("@StudentID", Int64.Parse(txtBox_sid.Text));
            sqlSend.Parameters.AddWithValue("@FirstName",txtBox_firstname.Text.ToString());
            sqlSend.Parameters.AddWithValue("@MiddleName",txtBox_middlename.Text.ToString());
            sqlSend.Parameters.AddWithValue("@LastName",txtBox_lastname.Text.ToString());
            sqlSend.Parameters.AddWithValue("@Age",int.Parse(txtBox_age.Text));
            sqlSend.Parameters.AddWithValue("@Gender",cbGender.Text.ToString());
            sqlSend.Parameters.AddWithValue("@Program",cbProgram.Text.ToString());

            //End Command
            sqlSend.ExecuteNonQuery();
            callout.Close();
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //Take Refresh Command
            //Establish SQL Connection
            SqlConnection rf = new SqlConnection("Data Source=KITSUUUU\\SQLEXPRESS;Initial Catalog=evdp_db;User ID=user_evdp1;Password=123");
            rf.Open();

            //Get Info by sql data adapter
            SqlDataAdapter dataDB = new SqlDataAdapter("Select * FROM Student_Info",rf);
            //Create Data Table and fill
            DataTable dtb = new DataTable();
            dataDB.Fill(dtb);

            //Update then Close SQL connection
            dtg_update.DataSource = dtb;
            rf.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Do Open Another Form
            FrmUpdateMember frmU = new FrmUpdateMember();
            frmU.ShowDialog();
        }

        private void cbProgram_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Throw Exception and Do Nothing
            try
            {
                //Detect if Using Dummy Test
                string dummy = cbProgram.SelectedItem.ToString();
                if (dummy == "<---TEST--->")
                {
                    cbProgram.SelectedIndex = -1;
                }
                else
                {
                    //Do Nothing
                }
            }
            catch (Exception)
            {
                //Do Nothing 
            }

        }
    }
}