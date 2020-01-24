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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            panel1.Left = (this.Width - panel1.Width) / 2;
            panel1.Top = (this.Height - panel1.Height) / 2;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "GPMS Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "GPMS Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
            }
            else
            {
                Conn cn = new Conn();
                string query2 = "";
                query2 = "SELECT * FROM user WHERE User_Name='" + txtUsername.Text.ToString() + "' AND Passsword='" + txtPassword.Text.ToString() + "' AND Active=1";

                //open connection
                if (cn.OpenConnection() == true)
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query2, cn.connect);
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    //Read the data and store them in the list
                    if (dataReader.Read())
                    {
                        //list[0].Add(dataReader["id"] + "");
                        //list[1].Add(dataReader["name"] + "");
                        if (dataReader["Username"].ToString() == txtUsername.Text && dataReader["Passsword"].ToString() == txtPassword.Text)
                        {
                            Session.Username = dataReader["Staff_Name"].ToString();
                            Session.Previlege = dataReader["Privileges"].ToString();
                            Session.User_ID = dataReader["Staff_ID"].ToString();
                            Session.logintime = DateTime.Now.ToString();
                            MDIParent1 mdi = new MDIParent1();
                            mdi.Visible = true;
                            this.Hide();
                        }

                        else
                        {
                            MessageBox.Show("Username/Password Mismatch!\nPlease Try again!", "PIMS Error Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtUsername.Text = "";
                            txtPassword.Text = "";
                            txtUsername.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username/Password Mismatch!\nPlease Try again!", "PIMS Error Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtUsername.Text = "";
                        txtPassword.Text = "";
                        txtUsername.Focus();
                    }

                    //close Data Reader
                    dataReader.Close();


                    //close connection
                    cn.CloseConnection();
                }

            }

                
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
