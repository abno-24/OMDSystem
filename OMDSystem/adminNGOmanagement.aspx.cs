using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OMDSystem
{
    public partial class adminNGOmanagement : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();
        }

        //add button click event
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (CheckIfNgoExist())
            {
                Response.Write("<script>alert('NGO with this ID already exist. you cannot add NGO with same NGO ID');</script>");
            }
            else
            {
                AddNewNgo();
            }
        }

        //update button click event
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (CheckIfNgoExist())
            {
                UpdateNgo();
            }
            else
            {
                Response.Write("<script>alert('NGO Does not exist');</script>");
            }
        }

        //delete button click event
        protected void Button4_Click(object sender, EventArgs e)
        {
            if (CheckIfNgoExist())
            {
                DeleteNgo();
            }
            else
            {
                Response.Write("<script>alert('NGO Does not exist');</script>");
            }
        }

        //go button click event
        protected void Button1_Click(object sender, EventArgs e)
        {
            GetNgoById();
        }

        //user defined function

        void GetNgoById()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * from ngo_management where ngo_id='" + TextBox1.Text.Trim() + "';", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    TextBox2.Text = dt.Rows[0][1].ToString();
                }
                else
                {
                    Response.Write("<script>alert('Invalid Author ID');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        void DeleteNgo()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("DELETE FROM ngo_management WHERE ngo_id='" + TextBox1.Text.Trim() + "'", con);

                cmd.Parameters.AddWithValue("@ngo_id", TextBox1.Text.Trim());

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('NGO deleted successfully');</script>");
                clearForm();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        void UpdateNgo()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("UPDATE ngo_management SET ngo_name=@ngo_name WHERE ngo_id='"+TextBox1.Text.Trim()+"'", con);

                cmd.Parameters.AddWithValue("@ngo_name", TextBox2.Text.Trim());

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('NGO updated successfully');</script>");
                clearForm();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        void AddNewNgo()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO ngo_management(ngo_id,ngo_name) values(@ngo_id,@ngo_name)", con);

                cmd.Parameters.AddWithValue("@ngo_id", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@ngo_name", TextBox2.Text.Trim());

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('NGO added successfully');</script>");
                clearForm();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        bool CheckIfNgoExist()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * from ngo_management where ngo_id='" + TextBox1.Text.Trim()+"';", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;
            }
        }
        void clearForm()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
        }
    }
}