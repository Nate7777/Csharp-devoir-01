/*
        Programmeur: Nathan Comeau
        Date: 1/21/2020
        But:  Afficher les employés avec un code postal débutant par 9 ainsi que leur superviseur
 
        Solution: RessoucesHumaines.sln
        Projet:   RessoucesHumaines.csproj
        Classe:   RessoucesHumainesForm.cs

        Base de données: Northwind (local)
        Champs: Employees.EmployeeID, Employees.LastName, Employees.FirstName, Employees.Title, Employees.BirthDate, Employees.HireDate, 
                Employees.Photo, Employees_1.LastName AS NomSuperviseur, Employees_1.FirstName AS PrenomSuperviseur
        Tables: Employees,Employees_1
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
        #region Constructeur
        public ressourcesHumainesForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Variables

        private string format = "{0,-10}{1,-20}{2,-20}";

        #endregion

        #region Load
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
                this.employeesTableAdapter.FillEmployeesSupervisorCodePostal9(this.hRDataSet.Employees);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        #endregion

        #region Methode click partagée 
        private void filterToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ToolStripMenuItem oItem = (ToolStripMenuItem)sender;

            if(oItem == tousLesEmployésSansSuperviseurToolStripMenuItem)
            {
                employeesBindingSource.Filter = "NomSuperviseur IS NULL";
            }
            else if(oItem == tousLesVendeursToolStripMenuItem)
            {
                employeesBindingSource.Filter = "Title = 'Sales Representative'";
            }
            else
            {
                employeesBindingSource.RemoveFilter();
            }
        }
        #endregion

        #region Impression

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(string.Format(format, "ID", "Nom", "Prenom"));
            Console.WriteLine("------------------------------------------");

            

            for(int i = 0; i < employeesBindingSource.Count; i++)
            {
                string id = (employeesBindingSource.List[i] as DataRowView)[0].ToString();
                string nom = (employeesBindingSource.List[i] as DataRowView)[1].ToString();
                string prenom = (employeesBindingSource.List[i] as DataRowView)[2].ToString();

                Console.WriteLine(string.Format(format, id, nom, prenom));
            }
            
        }

        #endregion
    }
}
