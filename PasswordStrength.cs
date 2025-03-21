using System;
using System.Text.RegularExpressions;

class PasswordStrength {
    static void Main() {
        Console.Write("🔑 Enter a password: ");
        string password = Console.ReadLine();

        if (password.Length >= 8 && 
            Regex.IsMatch(password, @"\d") &&
            Regex.IsMatch(password, @"[A-Z]") &&
            Regex.IsMatch(password, @"[!@#$%^&*()]")) {
            Console.WriteLine("✅ Strong password!");
        } else {
            Console.WriteLine("❌ Weak password. Use at least 8 characters, a number, an uppercase letter, and a special symbol.");
        }
    }
}
