namespace Supermarket_mvp.Views
{
    partial class CustomersView
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
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPageCustomersList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            BtnSearch = new Button();
            DgCustomers = new DataGridView();
            TextSearch = new TextBox();
            label2 = new Label();
            tabPageCustomersDetail = new TabPage();
            pictureBox2 = new PictureBox();
            BtnCancel = new Button();
            BtnSave = new Button();
            TextEmail = new TextBox();
            TextPhone = new TextBox();
            TextAdress = new TextBox();
            TextBirthday = new TextBox();
            TextLastName = new TextBox();
            TextName = new TextBox();
            TextDocument = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageCustomersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgCustomers).BeginInit();
            tabPageCustomersDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(952, 125);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(156, 38);
            label1.Name = "label1";
            label1.Size = new Size(189, 46);
            label1.TabIndex = 1;
            label1.Text = "Customers";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.customer_review;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCustomersList);
            tabControl1.Controls.Add(tabPageCustomersDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 125);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(952, 449);
            tabControl1.TabIndex = 1;
            // 
            // tabPageCustomersList
            // 
            tabPageCustomersList.Controls.Add(BtnClose);
            tabPageCustomersList.Controls.Add(BtnDelete);
            tabPageCustomersList.Controls.Add(BtnEdit);
            tabPageCustomersList.Controls.Add(BtnNew);
            tabPageCustomersList.Controls.Add(BtnSearch);
            tabPageCustomersList.Controls.Add(DgCustomers);
            tabPageCustomersList.Controls.Add(TextSearch);
            tabPageCustomersList.Controls.Add(label2);
            tabPageCustomersList.Location = new Point(4, 29);
            tabPageCustomersList.Name = "tabPageCustomersList";
            tabPageCustomersList.Padding = new Padding(3);
            tabPageCustomersList.Size = new Size(944, 416);
            tabPageCustomersList.TabIndex = 0;
            tabPageCustomersList.Text = "Customers List";
            tabPageCustomersList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(732, 348);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(204, 60);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(732, 265);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(204, 60);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(732, 176);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(204, 60);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(732, 89);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(204, 60);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(666, 24);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(60, 61);
            BtnSearch.TabIndex = 3;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // DgCustomers
            // 
            DgCustomers.AllowUserToAddRows = false;
            DgCustomers.AllowUserToDeleteRows = false;
            DgCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCustomers.Location = new Point(28, 89);
            DgCustomers.Name = "DgCustomers";
            DgCustomers.ReadOnly = true;
            DgCustomers.RowHeadersWidth = 51;
            DgCustomers.Size = new Size(698, 319);
            DgCustomers.TabIndex = 2;
            // 
            // TextSearch
            // 
            TextSearch.Location = new Point(28, 56);
            TextSearch.Name = "TextSearch";
            TextSearch.PlaceholderText = "Data to search";
            TextSearch.Size = new Size(632, 27);
            TextSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 24);
            label2.Name = "label2";
            label2.Size = new Size(145, 23);
            label2.TabIndex = 0;
            label2.Text = "Search Customer";
            // 
            // tabPageCustomersDetail
            // 
            tabPageCustomersDetail.Controls.Add(pictureBox2);
            tabPageCustomersDetail.Controls.Add(BtnCancel);
            tabPageCustomersDetail.Controls.Add(BtnSave);
            tabPageCustomersDetail.Controls.Add(TextEmail);
            tabPageCustomersDetail.Controls.Add(TextPhone);
            tabPageCustomersDetail.Controls.Add(TextAdress);
            tabPageCustomersDetail.Controls.Add(TextBirthday);
            tabPageCustomersDetail.Controls.Add(TextLastName);
            tabPageCustomersDetail.Controls.Add(TextName);
            tabPageCustomersDetail.Controls.Add(TextDocument);
            tabPageCustomersDetail.Controls.Add(label9);
            tabPageCustomersDetail.Controls.Add(label8);
            tabPageCustomersDetail.Controls.Add(label7);
            tabPageCustomersDetail.Controls.Add(label6);
            tabPageCustomersDetail.Controls.Add(label5);
            tabPageCustomersDetail.Controls.Add(label4);
            tabPageCustomersDetail.Controls.Add(label3);
            tabPageCustomersDetail.Location = new Point(4, 29);
            tabPageCustomersDetail.Name = "tabPageCustomersDetail";
            tabPageCustomersDetail.Padding = new Padding(3);
            tabPageCustomersDetail.Size = new Size(944, 416);
            tabPageCustomersDetail.TabIndex = 1;
            tabPageCustomersDetail.Text = "Customers Details";
            tabPageCustomersDetail.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.satisfaccion;
            pictureBox2.Location = new Point(593, 44);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(307, 237);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(772, 309);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(80, 80);
            BtnCancel.TabIndex = 15;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(650, 309);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(80, 80);
            BtnSave.TabIndex = 14;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TextEmail
            // 
            TextEmail.Location = new Point(129, 369);
            TextEmail.Name = "TextEmail";
            TextEmail.PlaceholderText = "Customers@gmail.com";
            TextEmail.Size = new Size(350, 27);
            TextEmail.TabIndex = 13;
            // 
            // TextPhone
            // 
            TextPhone.Location = new Point(129, 315);
            TextPhone.Name = "TextPhone";
            TextPhone.PlaceholderText = "+57 ****************";
            TextPhone.Size = new Size(350, 27);
            TextPhone.TabIndex = 12;
            // 
            // TextAdress
            // 
            TextAdress.Location = new Point(129, 200);
            TextAdress.Name = "TextAdress";
            TextAdress.PlaceholderText = "######";
            TextAdress.Size = new Size(350, 27);
            TextAdress.TabIndex = 11;
            // 
            // TextBirthday
            // 
            TextBirthday.Location = new Point(129, 258);
            TextBirthday.Name = "TextBirthday";
            TextBirthday.PlaceholderText = "XX/XX/XXXX";
            TextBirthday.Size = new Size(350, 27);
            TextBirthday.TabIndex = 10;
            TextBirthday.TextChanged += textBox5_TextChanged;
            // 
            // TextLastName
            // 
            TextLastName.Location = new Point(129, 145);
            TextLastName.Name = "TextLastName";
            TextLastName.PlaceholderText = "Last Name";
            TextLastName.Size = new Size(350, 27);
            TextLastName.TabIndex = 9;
            // 
            // TextName
            // 
            TextName.Location = new Point(129, 84);
            TextName.Name = "TextName";
            TextName.PlaceholderText = "Name";
            TextName.Size = new Size(350, 27);
            TextName.TabIndex = 8;
            // 
            // TextDocument
            // 
            TextDocument.Location = new Point(129, 27);
            TextDocument.Name = "TextDocument";
            TextDocument.PlaceholderText = "CC";
            TextDocument.Size = new Size(350, 27);
            TextDocument.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(35, 369);
            label9.Name = "label9";
            label9.Size = new Size(46, 20);
            label9.TabIndex = 6;
            label9.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 318);
            label8.Name = "label8";
            label8.Size = new Size(108, 20);
            label8.TabIndex = 5;
            label8.Text = "Phone Number";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 261);
            label7.Name = "label7";
            label7.Size = new Size(64, 20);
            label7.TabIndex = 4;
            label7.Text = "Birthday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 203);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 3;
            label6.Text = "Adress";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 148);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 2;
            label5.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 87);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 1;
            label4.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 30);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 0;
            label3.Text = "Document";
            // 
            // CustomersView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 574);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "CustomersView";
            Text = "Customers Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageCustomersList.ResumeLayout(false);
            tabPageCustomersList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgCustomers).EndInit();
            tabPageCustomersDetail.ResumeLayout(false);
            tabPageCustomersDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageCustomersList;
        private TabPage tabPageCustomersDetail;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private Button BtnSearch;
        private DataGridView DgCustomers;
        private TextBox TextSearch;
        private Label label2;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TextEmail;
        private TextBox TextPhone;
        private TextBox TextAdress;
        private TextBox TextBirthday;
        private TextBox TextLastName;
        private TextBox TextName;
        private TextBox TextDocument;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox2;
    }
}