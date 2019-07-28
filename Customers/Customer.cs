//should have reference from Orders object?
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace CustomishShirts.Library.Models//this should match using statement in main! find .csproj file
//do I add that manually or is it created automatically?
//also, a little confused about the naming conventions here
{
    /// <summary>
    /// A customer object, having an ID num, first and last names, phone num, email address,
    /// and an order history list. 
    /// </summary>
    public class Customer
    {
        //backing fields for the "Fname", "Lname", "Phone" and "Email" properties
        //this definition allows for validation to the setter
        private string _fname;
        private string _lname;
        private string _phone;
        private string _email;

        ///<summary>
        ///Customer ID. Zero indicates a missing value.
        ///</summary>
        public int ID { get; set; }//why does ID just have this field and 
                                   //fname/lname/phone/email have backfields
                                   //expression bodies?

        ///<summary>
        ///customer Fname and Lname following; not null
        ///</summary>
        public string Fname
        {
            //expression-body syntax for accessing _fname backing field
            //equivalent to 'get { return _fname; }'
            get => _fname;
            set
            {
                //'value' is value passed to setter
                if (value.Length == 0)
                {
                    //exception handler to validate input
                    throw new ArgumentException("First name must not be empty.", nameof(value));
                }
                _fname = value;
            }
        }
        ///<summary>
        ///customer Fname and Lname following; not null
        ///</summary>
        public string Lname
        {
            //expression-body syntax for accessing _lname backing field
            //equivalent to 'get { return _lname; }'
            get => _lname;
            set
            {
                //'value' is value passed to setter
                if (value.Length == 0)
                {
                    //exception handler to validate input
                    throw new ArgumentException("Last name must not be empty.", nameof(value));
                }
                _lname = value;
            }
        }
        public string Phone//is string best datatype for 'phone'?
        {
            //expression-body syntax for accessing  _phone backing field
            //equivalent to 'get { return _phone; }'
            get => _phone;
            set
            {
                //'value' is value passed to setter
                if (value.Length == 0)
                {
                    //exception handler to validate input
                    throw new ArgumentException("Phone number must not be empty.", nameof(value));
                }
                _phone = value;
            }
        }
        public string Email//is string best datatype for 'email'?
        {
            //expression-body syntax for accessing  _email backing field
            //equivalent to 'get { return _email; }'
            get => _email;
            set
            {
                //'value' is value passed to setter
                if (value.Length == 0)
                {
                    //exception handler to validate input
                    throw new ArgumentException("Email must not be empty.", nameof(value));
                }
                _email = value;
                //although some customers may not want to share either phone num or email
                //I'm making it mandatory since in this scenario we don't take physical addresses
            }
        }
        //referring to the RestaurantReview example: there is no 'review' list but there will be
        //an 'order' (history) list.  This can be null since new customers won't have a history
        ///<summary>
        ///Customer Order History
        ///</summary>
        
        ///<remarks>
        ///from RR ex: Depends on concrete "List" to simplify serialization.
        ///The default value is an empty list
        ///</remarks>
        
        //public List<Order> Orders { get; set; } = new List<Order>();
        //this is commented out until it's hooked up with the Orders object; it allows main to run
        //still need to establish Orders class - tbd and add the reference
        //comments from the RR are very helpful here to understand what is happening in the class.
    }
}
