using EX19.Controllers;
using EX19.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX19.View
{
    internal class ProductInput
    {
        public static string NameInput()
        {
            string name = InputHelper.GetValidatedInput(
                "Type the product's name: ",
                input => ProductValidations.IsValidName(input),
                input => input.ToString(),
                "Verify if the name have only characters and digits.");
            return name;
        }
        public static double PriceInput()
        {
            double price = InputHelper.GetValidatedInput(
                "Type the product's price: $",
                input => ProductValidations.IsValidPrice(input),
                input => double.Parse(input),
                "Verify if the price is higher than 0.");
            return price;
        }
        public static double CustomFeeInput()
        {
            double customFee = InputHelper.GetValidatedInput(
                "Type the product's custom fee (in percentage, which is between 0% and 99.9%): ",
                input => ProductValidations.IsCustomFeeValid(input),
                input => double.Parse(input),
                "Verify if the custom fee is a percentage between 0% and 99.9%.");
            return customFee / 100;
        }
        public static DateTime ManufactureDateInput()
        {
            DateTime manufactureDate = InputHelper.GetValidatedInput(
                "Type the product's Manufacture date (dd/MM/yyyy format): ",
                input => ProductValidations.IsDateValid(input),
                input => DateTime.Parse(input),
                "Verify if the date is in the dd/MMMM/yyyy format.");
            return manufactureDate;
        }
        public static int QuantityInput()
        {
            int quantity = InputHelper.GetValidatedInput(
                "Type how many products will be bought: ",
                input => ProductValidations.IsQuantityValid(input),
                input => int.Parse(input),
                "The quantity must be an integer positive number.");
            return quantity;
        }
    }
}
