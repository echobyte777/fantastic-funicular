#include <iostream>
#include <fstream>
#include <string>

using namespace std;

void addTask() {
    ofstream file("tasks.txt", ios::app);
    string task;
    cout << "📝 Enter task: ";
    getline(cin, task);
    file << task << endl;
    file.close();
}

void viewTasks() {
    ifstream file("tasks.txt");
    string task;
    cout << "\n📌 To-Do List:\n";
    while (getline(file, task)) {
        cout << "- " << task << endl;
    }
    file.close();
}

int main() {
    int choice;
    cout << "1️⃣ Add Task\n2️⃣ View Tasks\nChoose an option: ";
    cin >> choice;
    cin.ignore();

    if (choice == 1) addTask();
    else if (choice == 2) viewTasks();
    else cout << "❌ Invalid option!\n";

    return 0;
}
