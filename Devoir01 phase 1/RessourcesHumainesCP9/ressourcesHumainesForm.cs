/*
        Programmeur: Nathan Comeau
        Date: 1/20/2020
        But:  Afficher les employés avec un code postal débutant par 9 ainsi que leur superviseur
 
        Solution: RessoucesHumainesCP9.sln
        Projet:   RessoucesHumainesCP9.csproj
        Classe:   RessoucesHumainesForm.cs

        Base de données: Northwind (local)
        Champs: Employees.EmployeeID, Employees.LastName, Employees.FirstName, Employees.Title, Employees.BirthDate, Employees.HireDate, 
                Employees.ReportsTo, Employees.Photo, Employees_1.LastName AS Expr2, Employees_1.FirstName AS Expr3
        Tables: Employees,Employees_1
        Requêtes: //SELECT Employees.EmployeeID, Employees.LastName, Employees.FirstName, Employees.Title, Employees.BirthDate, Employees.HireDate, 
                  //       Employees.ReportsTo, Employees.Photo, Employees_1.LastName AS Expr2, 
                  //       Employees_1.FirstName AS Expr3
                  //FROM   Employees LEFT OUTER JOIN
                  //       Employees AS Employees_1 ON Employees.ReportsTo = Employees_1.EmployeeID
                  //WHERE(Employees.PostalCode LIKE N'9%')
 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RessourcesHumainesCP9
{
    public partial class ressourcesHumainesForm : Form
    {
        public ressourcesHumainesForm()
        {
            InitializeComponent();
        }

        private void ressourcesHumainesForm_Load(object sender, EventArgs e)
        {
            //SELECT Employees.EmployeeID, Employees.LastName, Employees.FirstName, Employees.Title, Employees.BirthDate, Employees.HireDate, 
            //       Employees.ReportsTo, Employees.Photo, Employees_1.LastName AS Expr2, 
            //       Employees_1.FirstName AS Expr3
            //FROM   Employees LEFT OUTER JOIN
            //       Employees AS Employees_1 ON Employees.ReportsTo = Employees_1.EmployeeID
            //WHERE(Employees.PostalCode LIKE N'9%')
            try
            {
                this.employeesTableAdapter.Fill(this.hRDataSet.Employees);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            

        }
    }
}
