using System;
using System.Web.UI;

namespace LineEndingIssue
{
    public partial class Validator : Page
    {
        protected void btnCheck_Click(object sender, EventArgs e)
        {
            // Get the user input
            string name = txtName.Text;
            string familyName = txtFamilyName.Text;
            string address = txtAddress.Text;
            string city = txtCity.Text;
            string zipCode = txtZipCode.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;

            // Store the user input in session
            Session["Name"] = name;
            Session["FamilyName"] = familyName;
            Session["Address"] = address;
            Session["City"] = city;
            Session["ZipCode"] = zipCode;
            Session["Phone"] = phone;
            Session["Email"] = email;

            // Redirect to the next page
            Response.Redirect("Result.aspx");
        }
    }
}