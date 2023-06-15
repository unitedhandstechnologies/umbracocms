# Umbraco CMS

Umbraco Version - Umbraco 10
SQL Version - 2017
Third Party - SMTP

## To Run

## Install Umbraco Template

Open vscode Terminal and execute this command

dotnet new -i Umbraco.Templates

## To Create a umbraco Project structure

Open vscode Terminal and execute this command

dotnet new umbraco -n "Project name"

cd "Project name"

## To Create a Solution file

dotnet new sln --name "Solution name"

## Project Code

Download and paste the source code in the view file
Download and paste the css, js, fonts and images in the wwwroot -> assets folder

## To Install DB - SSMS

Install the SSMS from the below link

To Download SQL Server:
https://www.microsoft.com/en-us/evalcenter/download-sql-server-2019

To Download SSMS:
https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16

## To Create db

Open the SSMS, right Click the database and Click "New database" to create a new database. Click ok

## vscode Terminal

In the terminal, execute dotnet run command. After executing that command, there will be a link to open the umbraco page. Click the localhost link. It will redirect to the umbraco login page.

In that page enter name, email and password. There will be a button called "Change database". Click that button and configure your database details. Click "install" button.

After clicking the install button, it will open the Umbraco content page, where we can update the website's content.

Umbraco settings page is used to create content definition.

## Dev Environment

Instance : http://65.2.172.18:5000/
Admin Url : http://65.2.172.18:5000/umbraco
Admin Email Id : auxesystech@gmail.com
Admin Password : auxes@1234

## Local db

Email Id : auxesystech@gmail.com
Password : auxes@1234
