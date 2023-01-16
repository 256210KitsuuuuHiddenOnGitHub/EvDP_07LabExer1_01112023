using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EvDP_07LabExer1_01112023
{
    public partial class FrmUpdateMember : Form
    {
        //This Server Must Be Ready
        SqlConnection listIF;

        public FrmUpdateMember()
        {
            InitializeComponent();

            //Form Update
            //Add All Members by sql update
            listIF = new SqlConnection("Data Source=KITSUUUU\\SQLEXPRESS;Initial Catalog=evdp_db;User ID=user_evdp1;Password=123");
            listIF.Open(); //Open Server
            SqlCommand IF = new SqlCommand("SELECT StudentID FROM Student_Info", listIF);

            //Update and Close
            using (SqlDataReader tempo = IF.ExecuteReader())
            {
                while (tempo.Read())
                {
                    string setOne = tempo.GetValue(0).ToString();
                    cb_SIDlst.Items.Add(setOne);    
                }
            }
            listIF.Close(); //Close Server
        }


        private void cb_SIDlst_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Pull update from SQL Server
            //Create Connection then Open
            listIF = new SqlConnection("Data Source=KITSUUUU\\SQLEXPRESS;Initial Catalog=evdp_db;User ID=user_evdp1;Password=123");
            listIF.Open();

            //Send SQL Command
            // created new declaration of string findList, and put value using a text on comboBox to send off commands
            SqlCommand setAll = new SqlCommand("SELECT * FROM Student_Info where StudentID = @findList", listIF);
            setAll.Parameters.AddWithValue("findList",cb_SIDlst.Text);

            //Temporary Call while Updating Realtime through SQL
            using (SqlDataReader sdr = setAll.ExecuteReader())
            {
                while (sdr.Read())
                {
                    txtbox_ulastname.Text = (sdr["LastName"].ToString().Trim());
                    txtbox_ufirstname.Text = (sdr["FirstName"].ToString().Trim());
                    txtbox_umiddlename.Text = (sdr["MiddleName"].ToString().Trim());
                    txtbox_uage.Text = (sdr["Age"].ToString().Trim());
                }
            }

            //Close Connection
            listIF.Close();
        }

        private void cbGenderlst_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Do Nothing
        }

        private void cbProgramlst_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Throw Exception and Do Nothing
            try
            {
                //Detect if Using Dummy Test
                string dummy = cbProgramlst.SelectedItem.ToString();
                if (dummy == "<---TEST--->")
                {
                    cbProgramlst.SelectedIndex = -1;
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //Data Update
            listIF = new SqlConnection("Data Source=KITSUUUU\\SQLEXPRESS;Initial Catalog=evdp_db;User ID=user_evdp1;Password=123");
            listIF.Open();

            //Sql Command
            SqlCommand upd = new SqlCommand("UPDATE Student_Info SET FirstName = @fname ,MiddleName = @mname ,LastName = @lname," +
                "Age = @ae, Gender = @gdr, Program = @prgrm WHERE StudentID = @sd ", listIF);
            upd.Parameters.AddWithValue("sd",cb_SIDlst.Text.ToString());
            upd.Parameters.AddWithValue("fname",txtbox_ufirstname.Text.ToString());
            upd.Parameters.AddWithValue("lname", txtbox_ulastname.Text.ToString());
            upd.Parameters.AddWithValue("mname", txtbox_umiddlename.Text.ToString());
            upd.Parameters.AddWithValue("ae", txtbox_uage.Text.ToString());
            upd.Parameters.AddWithValue("gdr", cbGenderlst.Text.ToString());
            upd.Parameters.AddWithValue("prgrm", cbProgramlst.Text.ToString());


            //Then Execute, Close Set
            upd.ExecuteNonQuery();
            listIF.Close();


        }
    }
}
