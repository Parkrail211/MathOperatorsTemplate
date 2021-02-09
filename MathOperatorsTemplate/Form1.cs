﻿/* date: September 2021
 * author: Mr. T.
 * purpose: template created to demonstrate math operations
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MathOperatorsTemplate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void runButton_Click(object sender, EventArgs e)
        {
            //1. Declare a string variable, store your name in it, and display it
            String personName = "Parker";
            outputLabel.Text = $"{personName}";
            //2. Declare an integer variable, store your age in it, and display it
            int personAge = 16;
            outputLabel.Text += $"\n{personAge}";
            //3. Declare a double variable, store a decimal number, and display it
            double pi = 3.15;
            outputLabel.Text += $"\n{pi}";
            //4. Combine a text with a variable to display "Hello" followed by your name

            outputLabel.Text += $"\nHello {personName}";

            /* 5. Simple arithmetic is done by using the +, -, * and / operators, 
               (plus, minus, times and divide). Results of mathematical expressions 
               should be stored in a variable. 

               Uncomment and un the code below to see what the result is. Notice that 
               the output does not show the values of x and y, but instead the words x and y. 

               Change the code to subtract y from x, and output the following:

               x - y = 2
            */

            int x = 6;
            int y = 4;
            int answer = x - y;

            outputLabel.Text += $"\n\n{x} - {y} = {answer}";


            /* 6. Create a program that calculates how much money an employee has made based
               on their pay rate and the number of hours worked.


               - Create a variable to hold the rate of pay, (payRate), and set it to 15.25
               - Create a variable to hold the hours worked, (hoursWorked), and set it to 8
               - Create a variable to hold the total pay, (totalPay)
               - Calculate the total pay
               - Display the results to the screen as per the output below.

               Rate of Pay: 15.25
               Hours Worked: 8
               Total Pay: 122
            */
            double payRate = 15.25;
            int hoursWorked = 8;
            double totalPay = payRate * hoursWorked;

            outputLabel.Text += $"\nTotal Pay = {totalPay}";
            /* 7. Create a program which calculates the tax amount for meal at a restaurant.
                   
              - Create a variable to hold the bill amount, (billAmount), of 22.50
              - Create a variable to hold the tax rate, (taxRate), of 0.13
              - Create a variable to hold the tax amount, (taxAmount)
              - Calculate the tax, (billAmount * taxRate) and store it in taxAmount 

                Bill Amount: 22.50
                13% Tax: 2.925             
            */
            double billAmount = 22.50;
            double taxRate = 0.13;
            double taxAmount = billAmount * taxRate;

            outputLabel.Text += $"\nBill Amount: {billAmount}";
            outputLabel.Text += $"\n13% Tax: {taxAmount}";


            // 8. Increment your age variable by 1 using ++ and display i
            personAge++;
            outputLabel.Text += $"\nAge + 1 = {personAge}";

            // 9. Decrement the value created above by 1 using -- and dislay it          
            personAge--;
            outputLabel.Text += $"\nAge = {personAge}";

        }
    }
}
