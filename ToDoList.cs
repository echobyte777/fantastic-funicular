using System;
using System.Collections.Generic;

class ToDoList {
    static void Main() {
        List<string> tasks = new List<string>();
        
        while (true) {
            Console.WriteLine("\n📝 To-Do List");
            Console.WriteLine("1️⃣ Add Task");
            Console.WriteLine("2️⃣ View Tasks");
            Console.WriteLine("3️⃣ Exit");
            Console.Write("Choose an option: ");
            
            string choice = Console.ReadLine();
            
            if (choice == "1") {
                Console.Write("Enter a task: ");
                string task = Console.ReadLine();
                tasks.Add(task);
                Console.WriteLine("✅ Task added!");
            }
            else if (choice == "2") {
                Console.WriteLine("\n📌 Your Tasks:");
                if (tasks.Count == 0) Console.WriteLine("No tasks yet.");
                else foreach (string task in tasks) Console.WriteLine("- " + task);
            }
            else if (choice == "3") {
                Console.WriteLine("👋 Goodbye!");
                break;
            }
            else {
                Console.WriteLine("❌ Invalid option! Try again.");
            }
        }
    }
}
