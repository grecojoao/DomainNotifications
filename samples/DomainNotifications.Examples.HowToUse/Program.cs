using DomainNotifications.Examples.HowToUse.Models;
using System;

namespace DomainNotifications.Examples.HowToUse
{
    static class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            customer.Validate();
            Console.WriteLine($"Customer validation - " +
                $"IsInvalid: {customer.IsInvalid}, " +
                $"Notifications: {customer.Notifications.Count}, " +
                $"Notifications message: {customer.NotificationsMessage()}");

            customer = new Customer("Name", "Surname");
            customer.Validate();
            Console.WriteLine($"Customer validation - " +
                $"IsValid: {customer.IsValid}, " +
                $"Notifications: {customer.Notifications.Count}");
        }
    }
}