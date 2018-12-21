Project Name: Gym management system
Course: Database Systems

Load database:
the Gym.bak file is the full backup of the database 
for the program application. It contains almost 50,000 
rows in Subscriptions table. The ERD script is not the final
script of the database, some changes were made due to keys and
paticipation constraints. Therefore, the full backup can be restored
to use the database for the application.
Gym.sln is the VS C# project file.

Instructions to run:
Choose how you want to log in:

admin credentials:
ID: admin
password: mygym

member credentials:
ID: bri@007
password: heyya
(Any other ID and respective password from
dbo.Members will work for member log-in.)

The other option is to sign-up.
It is a transaction that inserts new members in Members
table.

Procedures and views have been used in Packages,
Schedule and Trainer details forms. Rest is done by 
querying.
one example:
procedure name: your_trainers
view name: all_packages
