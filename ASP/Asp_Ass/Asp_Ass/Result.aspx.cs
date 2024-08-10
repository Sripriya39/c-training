using System;
using System.Web.UI;

namespace LineEndingIssue
{
    public partial class Result : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Get the user input from the session
            string name = (string)Session["Name"];
            string familyName = (string)Session["FamilyName"];
            string address = (string)Session["Address"];
            string city = (string)Session["City"];
            string zipCode = (string)Session["ZipCode"];
            string phone = (string)Session["Phone"];
            string email = (string)Session["Email"];

            // Display the user input
            lblName.Text = name;
            lblFamilyName.Text = familyName;
            lblAddress.Text = address;
            lblCity.Text = city;
            lblZipCode.Text = zipCode;
            lblPhone.Text = phone;
            lblEmail.Text = email;
        }
    }
}