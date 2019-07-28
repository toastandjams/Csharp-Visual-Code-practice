using CustomishShirts.Library.Models;   //should match title from classes .cs and .csproj
//using CustomishShirts.Library.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Xml.Serialization;


namespace CustomishShirts.ConsoleApp
{   //following the Restaurant Review ex closely - 'static' means this class cannot be instantiated
    //cannot be instantiated using 'new'/heap
    static class Program
    {
        static void Main(string[] args)
        {
            //DECLARE VARIABLES using 'new'
            //from Restaurant ex:
            while (true)    //then my workflow:
            {
                Console.WriteLine("Type \'D\' for database searches or type \'C\' for customer service");
                Console.WriteLine();
                Console.Write("Enter option or \'q\' to quit:");
                var input = Console.ReadLine();

                //if statements depending on input from console
                if (input == "D")//this option for a database search
                {
                    //may need variable here to represent Location class and Customer class
                    //var history_choice = customishRepo.GetHistory();//tbd may need an extra .method()
                    Console.WriteLine("Type 'L' for Order History by Location or type 'H' for Order History by Customer");
                    var history_choice = Console.ReadLine(); //? use this or not?
                    //address the exception handling - 
                    if (history_choice == "L")
                    {
                        //ord_hist_loc(); based on methods in the repo
                    }
                    else if (history_choice == "H")
                    {
                        //ord_hist_cust(); based on methods in the repo
                    }
                }
                else if (input == "C")//this option for customer service
                {
                    //starting with writing out all Project req's:
                    Console.WriteLine("Hello, I'm here to help you with your order.");
                    Console.WriteLine("Are you a new customer?");
                    var new_cust = Console.ReadLine();
                //}//would like to use answer from this block for next block; not sure I have this correct
                 //add new customer/take new order
                    //var new_cust = Console.ReadLine();
                    if (new_cust == "Y")//if customer is new, do the following:
                    {
                        Console.WriteLine("Would you like to place a new order?");
                        //need to add var ____ = Console.Readline here
                        //cust_add();
                        //create_ord();
                        //create_item();
                        //fab_chk_inventory();
                    }
                    else if (new_cust == "N")//if the customer is existing, do the following:
                    {
                        //find_cust();
                        Console.WriteLine("Would you like to place a new order or check on an existing order?");
                        Console.WriteLine("Press 'N' for new order or press 'E' for existing order");
                        var ord_processing = Console.ReadLine();
                        if (ord_processing == "E")
                        {
                            //find_ord();
                        }//need to tweak workflow; shouldn't go to location req
                        else if (ord_processing == "N")
                        {
                            //create_ord();
                            //create_item();
                            //fab_chk_inventory();
                        }
                }
            }
                else if (input == "q")
                {
                    break;
                }
                //else 
                //{
                //    Console.WriteLine();
                //    Console.WriteLine($"Invalid input.  Please enter correct choice.");
                //}
                //need to tweak the flow here as even dB searches comes to the location option  
                //set pickup location
                Console.WriteLine("Which location would you like to have your order shipped to?");
                Console.WriteLine("To search for a location:");
                Console.WriteLine("press 'I' to search by store ID, 'Z' to search by zip code, or 'N' to search for name.");
                var location_ID = Console.ReadLine();
                if(location_ID == "I")//search for location by store ID
                {
                    //find_loc_ID();
                }
                else if(location_ID == "Z")//search for location by zip code
                {
                    //find_loc_zip();
                }
                else if(location_ID == "N")//search for location by Name
                {
                    //find_loc_name();
                }

                //display orders
                //display_ord();

                Console.WriteLine("Thank you for your order!");
                //send_order();

                //unit test at least 10 methods - by class
                //input validation - by class - maybe not by class?  Will refer to chart
                //exception handling - by class - maybe not by class?  Will refer to chart
                //logging
                //7/26 - started at the top, worked my way down; going to start on Class Library now
                //feeling better about this now that I can see the architecture
            }
        }
    }
}
