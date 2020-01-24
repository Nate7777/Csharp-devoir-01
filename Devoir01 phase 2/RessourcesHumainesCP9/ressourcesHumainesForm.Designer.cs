namespace RessourcesHumainesCP9
{
    partial class ressourcesHumainesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label employeeIDLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label birthDateLabel;
            System.Windows.Forms.Label hireDateLabel;
            System.Windows.Forms.Label photoLabel;
            System.Windows.Forms.Label nomSuperviseurLabel;
            System.Windows.Forms.Label prenomSuperviseurLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ressourcesHumainesForm));
            this.hRDataSet = new RessourcesHumainesCP9.HRDataSet();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new RessourcesHumainesCP9.HRDataSetTableAdapters.EmployeesTableAdapter();
            this.employeesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.tousLesVendeursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tousLesEmployésSansSuperviseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parNomDeFamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parDateDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voirLesDossiersDeTousLesEmployésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeIDLabel1 = new System.Windows.Forms.Label();
            this.lastNameLabel1 = new System.Windows.Forms.Label();
            this.firstNameLabel1 = new System.Windows.Forms.Label();
            this.titleLabel1 = new System.Windows.Forms.Label();
            this.birthDateLabel1 = new System.Windows.Forms.Label();
            this.hireDateLabel1 = new System.Windows.Forms.Label();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.nomSuperviseurLabel1 = new System.Windows.Forms.Label();
            this.prenomSuperviseurLabel1 = new System.Windows.Forms.Label();
            employeeIDLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            birthDateLabel = new System.Windows.Forms.Label();
            hireDateLabel = new System.Windows.Forms.Label();
            photoLabel = new System.Windows.Forms.Label();
            nomSuperviseurLabel = new System.Windows.Forms.Label();
            prenomSuperviseurLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingNavigator)).BeginInit();
            this.employeesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeIDLabel
            // 
            employeeIDLabel.AutoSize = true;
            employeeIDLabel.Location = new System.Drawing.Point(42, 76);
            employeeIDLabel.Name = "employeeIDLabel";
            employeeIDLabel.Size = new System.Drawing.Size(62, 17);
            employeeIDLabel.TabIndex = 1;
            employeeIDLabel.Text = "Numéro:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(42, 115);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(105, 17);
            lastNameLabel.TabIndex = 3;
            lastNameLabel.Text = "Nom de famille:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(42, 154);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(61, 17);
            firstNameLabel.TabIndex = 5;
            firstNameLabel.Text = "Prénom:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(42, 193);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(66, 17);
            titleLabel.TabIndex = 7;
            titleLabel.Text = "Fonction:";
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Location = new System.Drawing.Point(42, 232);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new System.Drawing.Size(130, 17);
            birthDateLabel.TabIndex = 9;
            birthDateLabel.Text = "Date de naissance:";
            // 
            // hireDateLabel
            // 
            hireDateLabel.AutoSize = true;
            hireDateLabel.Location = new System.Drawing.Point(42, 271);
            hireDateLabel.Name = "hireDateLabel";
            hireDateLabel.Size = new System.Drawing.Size(123, 17);
            hireDateLabel.TabIndex = 11;
            hireDateLabel.Text = "Date d\'embauche:";
            // 
            // photoLabel
            // 
            photoLabel.AutoSize = true;
            photoLabel.Location = new System.Drawing.Point(463, 82);
            photoLabel.Name = "photoLabel";
            photoLabel.Size = new System.Drawing.Size(49, 17);
            photoLabel.TabIndex = 18;
            photoLabel.Text = "Photo:";
            // 
            // nomSuperviseurLabel
            // 
            nomSuperviseurLabel.AutoSize = true;
            nomSuperviseurLabel.Location = new System.Drawing.Point(42, 306);
            nomSuperviseurLabel.Name = "nomSuperviseurLabel";
            nomSuperviseurLabel.Size = new System.Drawing.Size(141, 17);
            nomSuperviseurLabel.TabIndex = 19;
            nomSuperviseurLabel.Text = "Nom du Superviseur:";
            // 
            // prenomSuperviseurLabel
            // 
            prenomSuperviseurLabel.AutoSize = true;
            prenomSuperviseurLabel.Location = new System.Drawing.Point(42, 344);
            prenomSuperviseurLabel.Name = "prenomSuperviseurLabel";
            prenomSuperviseurLabel.Size = new System.Drawing.Size(161, 17);
            prenomSuperviseurLabel.TabIndex = 20;
            prenomSuperviseurLabel.Text = "Prenom du Superviseur:";
            // 
            // hRDataSet
            // 
            this.hRDataSet.DataSetName = "HRDataSet";
            this.hRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.hRDataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // employeesBindingNavigator
            // 
            this.employeesBindingNavigator.AddNewItem = null;
            this.employeesBindingNavigator.BindingSource = this.employeesBindingSource;
            this.employeesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.employeesBindingNavigator.DeleteItem = null;
            this.employeesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.employeesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.printToolStripButton,
            this.toolStripDropDownButton1});
            this.employeesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.employeesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.employeesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.employeesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.employeesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.employeesBindingNavigator.Name = "employeesBindingNavigator";
            this.employeesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.employeesBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.employeesBindingNavigator.TabIndex = 0;
            this.employeesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = global::RessourcesHumainesCP9.Properties.Resources.PrintHS;
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.printToolStripButton.Text = "Print";
            this.printToolStripButton.Click += new System.EventHandler(this.printToolStripButton_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tousLesVendeursToolStripMenuItem,
            this.tousLesEmployésSansSuperviseurToolStripMenuItem,
            this.parNomDeFamilleToolStripMenuItem,
            this.parDateDToolStripMenuItem,
            this.voirLesDossiersDeTousLesEmployésToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::RessourcesHumainesCP9.Properties.Resources.Filter;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // tousLesVendeursToolStripMenuItem
            // 
            this.tousLesVendeursToolStripMenuItem.Name = "tousLesVendeursToolStripMenuItem";
            this.tousLesVendeursToolStripMenuItem.Size = new System.Drawing.Size(389, 26);
            this.tousLesVendeursToolStripMenuItem.Text = "Tous les vendeurs";
            this.tousLesVendeursToolStripMenuItem.Click += new System.EventHandler(this.filterToolStripMenuItem_Click_1);
            // 
            // tousLesEmployésSansSuperviseurToolStripMenuItem
            // 
            this.tousLesEmployésSansSuperviseurToolStripMenuItem.Name = "tousLesEmployésSansSuperviseurToolStripMenuItem";
            this.tousLesEmployésSansSuperviseurToolStripMenuItem.Size = new System.Drawing.Size(389, 26);
            this.tousLesEmployésSansSuperviseurToolStripMenuItem.Text = "Tous les employés n\'ayant pas de superviseur";
            this.tousLesEmployésSansSuperviseurToolStripMenuItem.Click += new System.EventHandler(this.filterToolStripMenuItem_Click_1);
            // 
            // parNomDeFamilleToolStripMenuItem
            // 
            this.parNomDeFamilleToolStripMenuItem.Name = "parNomDeFamilleToolStripMenuItem";
            this.parNomDeFamilleToolStripMenuItem.Size = new System.Drawing.Size(389, 26);
            this.parNomDeFamilleToolStripMenuItem.Text = "Par nom de famille...";
            // 
            // parDateDToolStripMenuItem
            // 
            this.parDateDToolStripMenuItem.Name = "parDateDToolStripMenuItem";
            this.parDateDToolStripMenuItem.Size = new System.Drawing.Size(389, 26);
            this.parDateDToolStripMenuItem.Text = "Par date d\'embauche...";
            // 
            // voirLesDossiersDeTousLesEmployésToolStripMenuItem
            // 
            this.voirLesDossiersDeTousLesEmployésToolStripMenuItem.Name = "voirLesDossiersDeTousLesEmployésToolStripMenuItem";
            this.voirLesDossiersDeTousLesEmployésToolStripMenuItem.Size = new System.Drawing.Size(389, 26);
            this.voirLesDossiersDeTousLesEmployésToolStripMenuItem.Text = "Voir les dossiers de tous les employés";
            this.voirLesDossiersDeTousLesEmployésToolStripMenuItem.Click += new System.EventHandler(this.filterToolStripMenuItem_Click_1);
            // 
            // employeeIDLabel1
            // 
            this.employeeIDLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employeeIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "EmployeeID", true));
            this.employeeIDLabel1.Location = new System.Drawing.Point(214, 76);
            this.employeeIDLabel1.Name = "employeeIDLabel1";
            this.employeeIDLabel1.Size = new System.Drawing.Size(220, 23);
            this.employeeIDLabel1.TabIndex = 2;
            this.employeeIDLabel1.Text = "label1";
            // 
            // lastNameLabel1
            // 
            this.lastNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "LastName", true));
            this.lastNameLabel1.Location = new System.Drawing.Point(214, 115);
            this.lastNameLabel1.Name = "lastNameLabel1";
            this.lastNameLabel1.Size = new System.Drawing.Size(220, 23);
            this.lastNameLabel1.TabIndex = 4;
            this.lastNameLabel1.Text = "label1";
            // 
            // firstNameLabel1
            // 
            this.firstNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "FirstName", true));
            this.firstNameLabel1.Location = new System.Drawing.Point(214, 154);
            this.firstNameLabel1.Name = "firstNameLabel1";
            this.firstNameLabel1.Size = new System.Drawing.Size(220, 23);
            this.firstNameLabel1.TabIndex = 6;
            this.firstNameLabel1.Text = "label1";
            // 
            // titleLabel1
            // 
            this.titleLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Title", true));
            this.titleLabel1.Location = new System.Drawing.Point(214, 193);
            this.titleLabel1.Name = "titleLabel1";
            this.titleLabel1.Size = new System.Drawing.Size(220, 23);
            this.titleLabel1.TabIndex = 8;
            this.titleLabel1.Text = "label1";
            // 
            // birthDateLabel1
            // 
            this.birthDateLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.birthDateLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "BirthDate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "yyyy-MM-dd"));
            this.birthDateLabel1.Location = new System.Drawing.Point(214, 232);
            this.birthDateLabel1.Name = "birthDateLabel1";
            this.birthDateLabel1.Size = new System.Drawing.Size(220, 23);
            this.birthDateLabel1.TabIndex = 10;
            this.birthDateLabel1.Text = "label1";
            // 
            // hireDateLabel1
            // 
            this.hireDateLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hireDateLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "HireDate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "yyyy-MM-dd"));
            this.hireDateLabel1.Location = new System.Drawing.Point(214, 271);
            this.hireDateLabel1.Name = "hireDateLabel1";
            this.hireDateLabel1.Size = new System.Drawing.Size(220, 23);
            this.hireDateLabel1.TabIndex = 12;
            this.hireDateLabel1.Text = "label1";
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.employeesBindingSource, "Photo", true));
            this.photoPictureBox.Location = new System.Drawing.Point(466, 121);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(273, 267);
            this.photoPictureBox.TabIndex = 19;
            this.photoPictureBox.TabStop = false;
            // 
            // nomSuperviseurLabel1
            // 
            this.nomSuperviseurLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomSuperviseurLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "NomSuperviseur", true));
            this.nomSuperviseurLabel1.Location = new System.Drawing.Point(214, 305);
            this.nomSuperviseurLabel1.Name = "nomSuperviseurLabel1";
            this.nomSuperviseurLabel1.Size = new System.Drawing.Size(220, 24);
            this.nomSuperviseurLabel1.TabIndex = 20;
            this.nomSuperviseurLabel1.Text = "label1";
            // 
            // prenomSuperviseurLabel1
            // 
            this.prenomSuperviseurLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prenomSuperviseurLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "PrenomSuperviseur", true));
            this.prenomSuperviseurLabel1.Location = new System.Drawing.Point(214, 344);
            this.prenomSuperviseurLabel1.Name = "prenomSuperviseurLabel1";
            this.prenomSuperviseurLabel1.Size = new System.Drawing.Size(220, 23);
            this.prenomSuperviseurLabel1.TabIndex = 21;
            this.prenomSuperviseurLabel1.Text = "label1";
            // 
            // ressourcesHumainesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(prenomSuperviseurLabel);
            this.Controls.Add(this.prenomSuperviseurLabel1);
            this.Controls.Add(nomSuperviseurLabel);
            this.Controls.Add(this.nomSuperviseurLabel1);
            this.Controls.Add(photoLabel);
            this.Controls.Add(this.photoPictureBox);
            this.Controls.Add(employeeIDLabel);
            this.Controls.Add(this.employeeIDLabel1);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameLabel1);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameLabel1);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleLabel1);
            this.Controls.Add(birthDateLabel);
            this.Controls.Add(this.birthDateLabel1);
            this.Controls.Add(hireDateLabel);
            this.Controls.Add(this.hireDateLabel1);
            this.Controls.Add(this.employeesBindingNavigator);
            this.Name = "ressourcesHumainesForm";
            this.Text = "Ressources Humaines";
            this.Load += new System.EventHandler(this.ressourcesHumainesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingNavigator)).EndInit();
            this.employeesBindingNavigator.ResumeLayout(false);
            this.employeesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HRDataSet hRDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private HRDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingNavigator employeesBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Label employeeIDLabel1;
        private System.Windows.Forms.Label lastNameLabel1;
        private System.Windows.Forms.Label firstNameLabel1;
        private System.Windows.Forms.Label titleLabel1;
        private System.Windows.Forms.Label birthDateLabel1;
        private System.Windows.Forms.Label hireDateLabel1;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem tousLesVendeursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tousLesEmployésSansSuperviseurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parNomDeFamilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parDateDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voirLesDossiersDeTousLesEmployésToolStripMenuItem;
        private System.Windows.Forms.Label nomSuperviseurLabel1;
        private System.Windows.Forms.Label prenomSuperviseurLabel1;
    }
}

