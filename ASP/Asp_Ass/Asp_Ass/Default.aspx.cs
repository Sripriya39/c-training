using System;
using System.Web.UI;
using System.Text.RegularExpressions;

namespace ProductSelector
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Initialize the image control
            imgProduct.ImageUrl = "";
        }

        protected void btnGetPrice_Click(object sender, EventArgs e)
        {
            // Validate the user input
            if (!ValidateInput())
            {
                return;
            }

            // Get the selected product
            string product = ddlProduct.SelectedValue;

            // Display the product image
            imgProduct.ImageUrl = $"~/images/{product}.jpg";

            // Get the price of the selected product
            decimal price = GetPrice(product);

            // Display the price
            lblPrice.Text = $"The price of {product} is ${price:F2}";
            lblError.Text = "";
        }

        private bool ValidateInput()
        {
            // Name different from family name
            if (txtName.Text == txtFamilyName.Text)
            {
                lblError.Text = "Name cannot be the same as family name";
                return false;
            }

            // Address at least 2 letters
            if (txtAddress.Text.Length < 2)
            {
                lblError.Text = "Address must be at least 2 letters";
                return false;
            }

            // City at least 2 letters
            if (txtCity.Text.Length < 2)
            {
                lblError.Text = "City must be at least 2 letters";
                return false;
            }

            // Zip-code 5 digits
            if (txtZipCode.Text.Length != 5 || !int.TryParse(txtZipCode.Text, out int zipCode))
            {
                lblError.Text = "Zip code must be 5 digits";
                return false;
            }

            // Phone according to the format XX-XXXXXXX or XXX-XXXXXXX
            string phonePattern = @"^(?:\d{2}-|\d{3}-)\d{7}$";
            if (!Regex.IsMatch(txtPhone.Text, phonePattern))
            {
                lblError.Text = "Phone number must be in the format XX-XXXXXXX or XXX-XXXXXXX";
                return false;
            }

            // E-mail is a valid email
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (!Regex.IsMatch(txtEmail.Text, emailPattern))
            {
                lblError.Text = "E-mail address is not valid";
                return false;
            }

            return true;
        }

        private decimal GetPrice(string product)
        {
            
            decimal price = 0;
            switch (product)
            {
                case "Phone":
                    price = 19.99m;
                    break;
                case "Laptop":
                    price = 29.99m;
                    break;
                case "PC":
                    price = 39.99m;
                    break;
            }
            return price;
        }
    }
}