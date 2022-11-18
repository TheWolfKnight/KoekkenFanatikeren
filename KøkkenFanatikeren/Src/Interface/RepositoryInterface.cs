using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KøkkenFanatikeren.Src.Interface
{
    public interface ICustomer
    {
        IEnumerable<Database.Customer> GetCustomers();
        Database.Customer GetCustomerById(int customerId);
        void InsertCustomer(Database.Customer customer);
        void UpdateCustomer(Database.Customer customer);
        void DeleteCustomer(Database.Customer customer);
        void Save();
    }


    public interface IEmployee
    {
        IEnumerable<Database.Employee> GetEmployees();
        Database.Employee GetEmployeeById(int employeeId);
        void InsertEmployee(Database.Employee employee);
        void UpdateEmployee(Database.Employee employee);
        void DeleteEmployee(Database.Employee employee);
        void Save();
    }


    public interface IItem
    {
        IEnumerable<Database.Item> GetItems();
        Database.Item GetItemById(int itemId);
        void InsertItem(Database.Item item);
        void UpdateItem(Database.Item item);
        void DeleteItem(Database.Item item);
        void Save();
    }


    public interface IItemCategory
    {
        IEnumerable<Database.ItemCategory> GetItemCategories();
        Database.ItemCategory GetItemCategoryByCategory(int itemCategory);
        void InsertItemCategory(Database.ItemCategory itemCategory);
        void UpdateItemCategory(Database.ItemCategory itemCategory);
        void DeleteItemCategory(Database.ItemCategory itemCategory);
        void Save();
    }


    public interface IOrder
    {
        IEnumerable<Database.Order> GetOrders();
        Database.Order GetOrderById(int orderId);
        void InsertOrder(Database.Order order);
        void UpdateOrder(Database.Order order);
        void DeleteOrder(Database.Order order);
        void Save();
    }


    public interface IOrderItem
    {
        IEnumerable<Database.OrderItem> GetOrderItems();
        IEnumerable<Database.OrderItem> GetOrderItemsByOrderId(int orderId);
        IEnumerable<Database.OrderItem> GetOrderItemsByItemId(int itemId);
        void InsertOrderItem(Database.OrderItem orderItem);
        void UpdateOrderItem(Database.OrderItem orderItem);
        void DeleteOrderItem(Database.OrderItem orderItem);
        void Save();
    }
}
