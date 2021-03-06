using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OMDSystem
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string sessionrole = Session["role"] as string;
                if (string.IsNullOrEmpty(sessionrole))
                {
                    LinkButton1.Visible = true; //user login linkbutton
                    LinkButton2.Visible = true; //sign linkbutton

                    LinkButton3.Visible = false; //user logout linkbutton
                    LinkButton4.Visible = false; //Hello user linkbutton

                    Linkbutton5.Visible = true; //Admin Login button
                    Linkbutton6.Visible = true; //NGO Login button
                    Linkbutton7.Visible = true; //NGO Register linkbutton
                    Linkbutton8.Visible = false; //Admin NGO management linkbutton
                }
                else if (Session["role"].Equals("user"))
                {
                    LinkButton1.Visible = false; //user login linkbutton
                    LinkButton2.Visible = false; //sign linkbutton

                    LinkButton3.Visible = true; //user logout linkbutton
                    LinkButton4.Visible = true; //Hello user linkbutton
                    LinkButton4.Text = "Hello" +" "+ Session["username"].ToString();

                    Linkbutton5.Visible = true; //Admin Login button
                    Linkbutton6.Visible = false; //NGO Login button
                    Linkbutton7.Visible = false; //NGO Register linkbutton
                    Linkbutton8.Visible = false; //Admin NGO management linkbutton
                }

                else if (Session["role"].Equals("admin"))
                {
                    LinkButton1.Visible = false; //user login linkbutton
                    LinkButton2.Visible = false; //sign linkbutton

                    LinkButton3.Visible = true; //user logout linkbutton
                    LinkButton4.Visible = true; //Hello user linkbutton
                    LinkButton4.Text = "Hello Admin";

                    Linkbutton5.Visible = false; //Admin Login button
                    Linkbutton6.Visible = false; //NGO Login button
                    Linkbutton7.Visible = false; //NGO Register linkbutton
                    Linkbutton8.Visible = true; //Admin NGO management linkbutton
                }
            }
            catch (Exception ex)
            {

            }
        }

        protected void Linkbutton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminLogin.aspx");
        }

        protected void Linkbutton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("ngoLogin.aspx");
        }

        protected void Linkbutton7_Click(object sender, EventArgs e)
        {
            Response.Redirect("ngoRegister.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("userLogin.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("userSignup.aspx");
        }

        protected void Linkbutton8_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminNGOmanagement.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Session["username"] = "";
            Session["fullname"] = "";
            Session["role"] = "";

            LinkButton1.Visible = true; //user login linkbutton
            LinkButton2.Visible = true; //sign linkbutton

            LinkButton3.Visible = false; //user logout linkbutton
            LinkButton4.Visible = false; //Hello user linkbutton

            Linkbutton5.Visible = true; //Admin Login button
            Linkbutton6.Visible = false; //NGO Login button
            Linkbutton7.Visible = false; //NGO Register linkbutton
            Linkbutton8.Visible = false; //Admin NGO management linkbutton

            Response.Redirect("Homepage.aspx");
        }
    }
}