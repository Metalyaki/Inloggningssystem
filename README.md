Inloggningssystem
This is a console-based login system written in C#. The program allows an admin to manage users and provides a simple login interface for users.

Features
Admin Login: Admin can log in with a predefined username and password.
User Management: Admin can add new users.
Settings: Admin can change the console text color and title.
User Login: Users can log in with their username and password.
Session Timeout: Both admin and users have a session timeout feature.

Usage
Admin Login:
Username: admin
Password: admin
Admin can add users, change settings, log out, or exit the program.

User Login:
Enter the username and password.
Users can view their password, log out, or exit the program.

Admin Menu
Lägg till användare
: Add a new user.
Inställningar
Byt till slumpmässig textfärg
: Change the console text color.
Ändra konsolfönstrets titel
: Change the console window title.
Logga ut
: Log out from the admin account.
Avsluta
: Exit the program.

User Menu
Visa lösenord
: Display the user's password.
Logga ut
: Log out from the user account.
Avsluta
: Exit the program.

Session Timeout
Admin: 10 minutes
User: 2 minutes

How to Run
Open the project in Visual Studio.
Log in using the predefined username and password for admin.
Create your first user or change the application settings.

Classes
Program: The main class containing the entry point of the application.
Admin: Represents the admin user with methods to change text color and console title.
User: Represents a regular user with methods to get the username and password.
