using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list of features and descriptions
        List<(string Feature, string Description)> table = new List<(string, string)>()
        {
            ("Login System", "Allows users to securely log in"),
            ("Dashboard", "Displays user-specific data and analytics"),
            ("Reports", "Generates detailed performance reports"),
            ("Notifications", "Sends alerts and updates to users"),
            ("Settings", "Allows customization of user preferences"),
            ("User Management", "Admins can create, update, or delete users"),
            ("Search Function", "Quickly find data using keywords"),
            ("Data Export", "Export data to formats like PDF or Excel"),
            ("Multi-language Support", "Supports multiple languages for users"),
            ("Security", "Ensures data protection with encryption"),
            ("Backup System", "Automatically backs up system data"),
            ("API Integration", "Connects with external services and APIs"),
            ("Role-Based Access", "Restricts access based on user roles"),
            ("Audit Logs", "Tracks system activities and user actions"),
            ("Performance Monitoring", "Monitors system speed and efficiency")
        };

        // Print table header
        Console.WriteLine("{0,-25} | {1,-60}", "Feature", "Description");
        Console.WriteLine(new string('-', 90));

        // Print table rows
        foreach (var row in table)
        {
            Console.WriteLine("{0,-25} | {1,-60}", row.Feature, row.Description);
        }
    }
}