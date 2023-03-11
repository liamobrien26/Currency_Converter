using System;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;
using System.Transactions;

internal class Program
{
    private static void Main(string[] args)
    {
        //American Dollars
        double USD = 1.40;

        //Euros
        double EUR = 1.14;

        //Brazilian Real
        double BRL = 4.77;

        //Japanese yen
        double JPY = 151.05;

        //Turkish Lira
        double TRY = 5.68;

        //Transaction Fees: Transaction fees are charged based on the amount of money the customer would like to exchange.

        double Upto299_99 = 3.5;
        double Between300__749_99 = 3;
        double Between750__999_99 = 2.5;
        double Between1000__1999_99 = 2;
        double Over2000 = 1.5;

        Console.WriteLine("----- CURRENCY CONVERTER-----");
        Console.WriteLine();
        Console.WriteLine("(PLEASE NOTE THERE IS A TRANSACTION LIMIT OF £2500!)");
        Console.WriteLine();
        //Staff discount
        double staffDiscount = 5.0;

        //Asks if a customer is a member of staff
        Console.WriteLine();
        Console.WriteLine("----- ASK CUSTOMER-----");
        Console.WriteLine("\nIs the customer a member of staff?\nYES or NO");
        string staff = Console.ReadLine().ToUpper();
        Console.Clear();

        //Allows the travel agent to enter the amount in pounds sterling (GBP) that the customer wishes to convert
        Console.WriteLine("-----LIMIT £2500-----");
        Console.WriteLine();
        Console.Write("Please enter the amount in GBP that the customer wishes to convert: (£0.00)\n£");
        double customerInput = Convert.ToDouble(Console.ReadLine());
        customerInput = Math.Round(customerInput, 2);
        Console.Clear();

        //Allows the travel agent to choose the currency requested by the customer
        Console.WriteLine("----- CURRENCY -----");
        Console.WriteLine("Input 1 for = American Dollars(USD)" +
            "\nInput 2 for = Euros(EUR)" +
            "\nInput 3 for = Brazilian Real(BRL)" +
            "\nInput 4 for = Japanese Yen(JPY)" +
            "\nInput 5 for = Turkish Lira(TRL)");
        Console.WriteLine();
        Console.WriteLine("Please enter the destination country/currency the customer wishes to convert: ");
        int currencyChoice = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        //Converts the amount entered in GBP to the chosen currency
        Console.WriteLine();

        switch (currencyChoice)
        {
            case 1:

                Console.WriteLine("----- CURRENCY AMOUNT -----\n\n£" + customerInput + " British Pounds = $" + Math.Round(customerInput * USD, 2) + " American Dollars");
                Console.WriteLine();
                break;

            case 2:
                Console.WriteLine("----- CURRENCY AMOUNT -----\n\n£" + customerInput + " British Pounds = €" + Math.Round(customerInput * EUR, 2) + " Euros");
                Console.WriteLine();
                break;

            case 3:
                Console.WriteLine("----- CURRENCY AMOUNT -----\n\n£" + customerInput + " British Pounds = R$" + Math.Round(customerInput * BRL, 2) + " Brazilian Real");
                Console.WriteLine();
                break;

            case 4:
                Console.WriteLine("----- CURRENCY AMOUNT -----\n\n£" + customerInput + " British Pounds =  JP¥" + Math.Round(customerInput * JPY, 3) + " Japanese yen");
                Console.WriteLine();
                break;

            case 5:
                Console.WriteLine("----- CURRENCY AMOUNT -----\n\n£" + customerInput + " British Pounds =  ₺" + Math.Round(customerInput * TRY, 2) + " Turkish Lira");
                Console.WriteLine();
                break;
            default:
                Console.WriteLine("NO VALID INPUT!PLEASE TRY AGAIN!");
                Console.WriteLine();
                Main(new String[0]);
                Console.Clear();
                break;
        }
        //-------------------------------------------------------------------------------------------------------------------
        if (customerInput <= 299.99)
        {

            Console.WriteLine("-----INVOICE-----");
            //Calculates a transaction fee depending on how much in GBP the customer converts
            double fee1 = customerInput * Upto299_99 / 100;
            fee1 = Math.Round(fee1, 2);

            Console.WriteLine("\nTransaction fee: " + "\n£" + fee1);
            Console.WriteLine();

            //Calculates the total cost amount to convert plus transaction fee) in GBP of converting to the chosen currency
            double sumForFee1 = Math.Round(fee1 + customerInput, 2);
            Console.WriteLine("Total amount after applying Transcation fee: \n£" + (sumForFee1));

            //Applies a discount of 5% to the total cost if the customer is also a member of staff
            if (staff == "YES")
            {
                double StaffSum = (Math.Round(sumForFee1 * staffDiscount / 100, 2));
                Console.WriteLine("\nThe customer is applicable for 5% employee discount!");
                Console.WriteLine();
                Console.WriteLine("Total amount after applying 5% employee discount: \n£" + (Math.Round(sumForFee1 - StaffSum, 2)));
            }
        }
        //______________________________________________________________________________________________________________________

        else if (customerInput >= 300 && customerInput <= 749.99)
        {
            Console.WriteLine("-----INVOICE-----");
            //Calculates a transaction fee depending on how much in GBP the customer converts
            double fee2 = customerInput * Between300__749_99 / 100;
            fee2 = Math.Round(fee2, 2);

            Console.WriteLine("\nTranscation fee: " + "\n£" + fee2);
            Console.WriteLine();

            //Calculates the total cost amount to convert plus transaction fee) in GBP of converting to the chosen currency
            double sumForFee2 = Math.Round(fee2 + customerInput, 2);
            Console.WriteLine("Total amount after applying Transcation fee: \n£" + (sumForFee2));

            //Applies a discount of 5% to the total cost if the customer is also a member of staff
            if (staff == "YES")
            {
                double StaffSum = (Math.Round(sumForFee2 * staffDiscount / 100, 2));
                Console.WriteLine("\nThe customer is applicable for 5% employee discount!");
                Console.WriteLine();
                Console.WriteLine("Total amount after applying 5% employee discount: \n£" + (Math.Round(sumForFee2 - StaffSum, 2)));
            }
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------

        else if (customerInput >= 750 && customerInput <= 999.99)
        {
            Console.WriteLine("-----INVOICE-----");
            //Calculates a transaction fee depending on how much in GBP the customer converts
            double fee3 = customerInput * Between750__999_99 / 100;
            fee3 = Math.Round(fee3, 2);

            Console.WriteLine("\nTranscation fee: " + "\n£" + fee3);
            Console.WriteLine();

            //Calculates the total cost amount to convert plus transaction fee) in GBP of converting to the chosen currency
            double sumForFee3 = Math.Round(fee3 + customerInput, 2);
            Console.WriteLine("Total amount after applying Transcation fee: \n£" + (sumForFee3));

            //Applies a discount of 5% to the total cost if the customer is also a member of staff
            if (staff == "YES")
            {
                double StaffSum = (Math.Round(sumForFee3 * staffDiscount / 100, 2));
                Console.WriteLine("\nThe customer is applicable for 5% employee discount!");
                Console.WriteLine();
                Console.WriteLine("Total amount after applying 5% employee discount: \n£" + (Math.Round(sumForFee3 - StaffSum, 2)));
            }
        }
        //---------------------------------------------------------------------------------------------------------------

        else if (customerInput >= 1000 && customerInput <= 1999.99)
        {
            Console.WriteLine("-----INVOICE-----");
            //Calculates a transaction fee depending on how much in GBP the customer converts
            double fee4 = customerInput * Between1000__1999_99 / 100;
            fee4 = Math.Round(fee4, 2);

            Console.WriteLine("\nTranscation fee: " + "\n£" + fee4);
            Console.WriteLine();

            //Calculates the total cost amount to convert plus transaction fee) in GBP of converting to the chosen currency
            double sumForFee4 = Math.Round(fee4 + customerInput, 2);
            Console.WriteLine("Total amount after applying Transcation fee: \n£" + (sumForFee4));

            //Applies a discount of 5% to the total cost if the customer is also a member of staff
            if (staff == "YES")
            {
                double StaffSum = (Math.Round(sumForFee4 * staffDiscount / 100, 2));
                Console.WriteLine("\nThe customer is applicable for 5% employee discount!");
                Console.WriteLine();
                Console.WriteLine("Total amount after applying 5% employee discount: \n£" + (Math.Round(sumForFee4 - StaffSum, 2)));
            }
        }
        //---------------------------------------------------------------------------------------------------------------
        else if (customerInput >= 2000 && customerInput <= 2500)
        {
            Console.WriteLine("-----INVOICE-----");
            //Calculates a transaction fee depending on how much in GBP the customer converts
            double fee5 = customerInput * Over2000 / 100;
            fee5 = Math.Round(fee5, 2);

            Console.WriteLine("\nTranscation fee: " + "\n£" + fee5);
            Console.WriteLine();

            //Calculates the total cost amount to convert plus transaction fee) in GBP of converting to the chosen currency
            double sumForFee5 = Math.Round(fee5 + customerInput, 2);
            Console.WriteLine("Total amount after applying Transcation fee: \n£" + (sumForFee5));

            //Applies a discount of 5% to the total cost if the customer is also a member of staff
            if (staff == "YES")
            {
                double StaffSum = (Math.Round(sumForFee5 * staffDiscount / 100, 2));
                Console.WriteLine("\nThe customer is applicable for 5% employee discount!");
                Console.WriteLine();
                Console.WriteLine("Total amount after applying 5% employee discount: \n£" + (sumForFee5 - StaffSum));
            }
        }

        //---------------------------------------------------------------------------------------------------------------
        //For over £2500

        else if (customerInput > 2500)
        {
            Console.WriteLine("!!!TRANSCATION LIMIT IS £2500! PLEASE ENTER LOWER AMOUNT!!!!");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Main(new String[0]);
        }

        else
        {
            Console.WriteLine("Please try again!");
            Main(new String[0]);
        }

    }

}




