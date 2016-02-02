﻿// Liz Fallin
// BIT 285
// Assignment 1
// Password Generator.aspx.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    string lastName;

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void textBoxLastName_TextChanged(object sender, EventArgs e)
    {
        lastName = textBoxLastName.Text;
    }
    protected void textBoxBirthYear_TextChanged(object sender, EventArgs e)
    {

    }
    protected void textBoxFavoriteColor_TextChanged(object sender, EventArgs e)
    {

    }
    protected void btnSuggestPwds_Click(object sender, EventArgs e)
    {
        // Create five strings, based on the values in the three text boxes
        // Each string must be at least 8 chars long
        // White space will be removed before use
        // Random characters will be used to pad the three strings

        // ArrayList aList = new ArrayList();
        string[] aList = new string[5];

        // Create string of random chars,
        // to be used in passwords as needed for padding
        Random r = new Random();
        string rString = "";
        int rNum = 0;

        // Create a string of random lower case letters, to pad the three strings
        for (int i = 0; i < 15; i++)
        {
            rNum = r.Next(0, 26); // Zero to 25
	        rString = rString + (char)('a' + rNum);
        }

        // Delete any white space in the strings
        string lastName = textBoxLastName.Text.Replace(" ", "");
        string birthYear = textBoxBirthYear.Text.Replace(" ", ""); ;
        string favoriteColor = textBoxFavoriteColor.Text.Replace(" ", ""); ;

        // Append five random characters to the strings, to ensure that there are 
        // at least five chars in each one for the password suggestions below
        lastName += rString.Substring(0, 5);
        birthYear += rString.Substring(5, 5);
        favoriteColor += rString.Substring(10, 5);

        // Create a string which is the reverse of Birth Year
        char[] yearArray = birthYear.ToCharArray();
        Array.Reverse(yearArray);
        string reverseYear = new string(yearArray);

        // Create proposed passwords, using a combination of last name, birth year, favorite color, and random chars
        // Because each string has a minimum of five chars (see padding above), use up to five chars in combinations.
        aList[0] = (birthYear.Substring(0, 5) + lastName.Substring(0, 5));
        aList[1] = (lastName.Substring(0, 5) + birthYear.Substring(2, 2) + favoriteColor.Substring(0, 5));
        aList[2] = (reverseYear.Substring(0, 4) + lastName.Substring(0, 4) + favoriteColor.Substring(0, 2));
        aList[3] = (favoriteColor.Substring(0, 5) + lastName.Substring(0, 5));
        aList[4] = (lastName.Substring(3, 2) + birthYear.Substring(0, 4) + favoriteColor.Substring(3, 2));

        // Set the data source, and bind to the drop down list
        DropDownList1.DataSource = aList;
        DropDownList1.DataBind();

        // TODO 1/26: Save the selected element as the password
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        // Set the session variable "password" to the selected password
        Session["password"] = DropDownList1.SelectedItem.Text;
    }
}