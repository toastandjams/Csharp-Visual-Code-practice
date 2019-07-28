using CustomishShirts.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomishShirts.Library.Repositories
{
    /// <summary>
    /// A repository managing data access for Customish objects.
    /// </summary>
    public class CustomishRepository
    {
        private readonly ICollection<Customers> _data;

        ///<summary>
        ///Theoretically initializes a new Customer repo
        ///</summary>
        ///<param name="data">The data source</param>
        
        public CustomishRepository(ICollection<Customers> data)
        {//this is an interface for the Customers db object/table
            //that is throwing a Null exception
            _data = data ?? throw new ArgumentNullException(nameof(data));
        }
        /// <summary>
        /// Get all customers with deferred execution.
        /// Deferred Execution of LINQ Query. 
        /// Deferred execution means that the evaluation of an expression is delayed 
        /// until its realized value is actually required. 
        /// It greatly improves performance by avoiding unnecessary execution.
        /// </summary>
        /// <returns>The collection of customers</returns>
        
        public IEnumerable<Customers> FindCustomer(string search = null)
        {
            if(search == null)
            {
                foreach (var item in _data)
                {
                    yield return item;
                }
            }
            else
            {
                foreach (var item in _data.Where(r => r.Name.Contains(search)))
                {
                    yield return item;
                }
            }
        }
        /// <summary>
        /// Get customers by ID.
        /// </summary>
        /// <returns>The customer</returns>
        
        public Customer FindCustbyID(int id)
        {
            return _data.First(r => r.Id == id);
        }

        /// <summary>
        /// Add a customer.
        /// </summary>
        /// <param name="customer">The customer</param>
        
        public void AddCustomer(Customer customer)
        {
            if (_data.Any(r => r.Id == customer.id))
            {
                throw new InvalidOperationException($"Customer with ID {customer.Id} already exists.");
                //error handling
            }
            _data.Add(customer);
        }
        /// <summary>
        /// Delete a customer. 
        /// </summary>
        /// <param name="customerId">The ID of the customer</param>
        public void RemoveCustomer(int customerId)
        {
            _data.Remove(_data.First(r => r.Id == restaurantId));
        }
        /// <summary>
        /// Update a customer entry.
        /// </summary>
        /// <param name="customer">The customer with updated information</param>
        public void UpdateCustomer(Customer customer)
        {
            RemoveCustomer(customer.Id);
            AddCustomer(customer);
        }
    }
}
