using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace GPMS
{
    public partial class frmStaff : Form
    {

        private string query;
        private string optn;
        public frmStaff()
            
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
                        panel1.Left = (this.Width - panel1.Width) / 2;
                        panel1.Top = (this.Height - panel1.Height) / 2;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "KUMMMS Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtStaff_ID.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "GPMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtStaff_ID.Focus();
            }
            else if (txtStaff_Name.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "GPMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtStaff_Name.Focus();
            }

           /* else if (IsCharacter(txtStaff_Name.Text.ToString()))
            {
                MessageBox.Show("Invalid Name!", "GPMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtStaff_Name.Focus();
            }*/
            else if (txtNational_ID.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "GPMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNational_ID.Focus();
            }
            else if (txtAddress.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "GPMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAddress.Focus();
            }
            else if (txtPhone_Number.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "GPMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPhone_Number.Focus();
            }
            else if (txtPhone_Number.Text.Length != 13)
            {
                MessageBox.Show("Invalid Phone Number!", "GPMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPhone_Number.Focus();
            }

            else if (!txtPhone_Number.Text.Contains("+"))
            {
                MessageBox.Show("Invalid Phone Number!", "GPMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPhone_Number.Focus();
            }
            else if (txtLocation.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "GPMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtLocation.Focus();
            }
            else if (txtRemark.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "GPMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtRemark.Focus();
            }
            else if (cmbRole.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "GPMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbRole.Focus();
            }
            else if (txtVehicle_ID.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "GPMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtVehicle_ID.Focus();
            }
            else if (txtOffice_ID.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "GPMS Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtOffice_ID.Focus();
            }
            else
            {
                string gender = "";
                //string msg = "";
                {
                    if (rbnMale.Checked == true)
                    {
                        gender = "Male";
                    }
                    else
                    {
                        gender = "Female";
                    }

                    Conn cn = new Conn();
                    cn.CloseConnection();
                    //cn.OpenConnection();
                    if (cn.OpenConnection() == true)
                    {

                        string query = "INSERT INTO staff (Staff_ID, Staff_Name, National_ID, Phone_Number, Location, Address, Role, Remark, Gender, Office_ID, Vehicle_ID) VALUES('" + txtStaff_ID.Text.ToString() + "', '" + txtStaff_Name.Text + "', '" + txtNational_ID.Text.ToString() + "','" + txtPhone_Number.Text.ToString() + "','" + txtLocation.Text.ToString() + "','" + txtAddress.Text + "','" + cmbRole.Text + "','" + txtRemark.Text + "','" + gender + "','" + txtOffice_ID.Text.ToString() + "','" + txtVehicle_ID.Text.ToString() + ")";
                        MySqlCommand cmd = new MySqlCommand(query, cn.connect);
                        MySqlDataReader datareader = cmd.ExecuteReader();



                        //MySqlDataReader datareader = cmd.ExecuteReader();
                        MessageBox.Show("Records have been successfully saved");
                    }

                       /* if (MessageBox.Show(optn, "GPMS Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            //create command and assign the query and connection from the constructor


                            //Execute command
                            //cmd.ExecuteNonQuery();

                            //close connection


                            
                            MessageBox.Show(msg, "GPMS Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }*/
                        else
                        {

                            cn.CloseConnection();
                            MessageBox.Show("Changes not Effected!", "GPMS Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        



                    }
                }
            }
        

        private void txtOffice_ID_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
