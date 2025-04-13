using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp.Views
{
    public partial class CustomersView : Form, ICustomersView
    {
        private  bool isEdit;
        private bool isSuccessful;
        private string message;
        public CustomersView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            tabControl1.TabPages.Remove(tabPageCustomersDetail);
        }

        private void AssociateAndRaiseViewEvents()
        {
            BtnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };

            TextSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
        }

        public string Document_Number 
        { 
            get { return TextDocument.Text; } 
            set { TextDocument.Text = value; }
        }
        public string Name 
        { 
            get { return TextName.Text; } 
            set { TextName.Text = value; }
        }
        public string Last_Name 
        { 
            get { return TextLastName.Text; } 
            set { TextName.Text = value; }
        }
        public string Address 
        { 
            get { return TextAdress.Text; } 
            set { TextAdress.Text = value; }
        }
        public string Birth_Date 
        { 
            get { return TextBirthday.Text; } 
            set { TextBirthday.Text = value; }
        }
        public string Phone 
        { 
            get { return TextPhone.Text; } 
            set { TextPhone.Text = value; }
        }
        public string Email 
        { 
            get { return TextEmail.Text; } 
            set { TextPhone.Text = value; }
        }


        public string SearchValue 
        { 
            get { return TextSearch.Text; } 
            set { TextSearch.Text = value; }
        }
        public bool IsEdit 
        { 
            get { return isEdit; } 
            set { isEdit = value; }
        }
        public bool IsSuccessful 
        { 
            get { return isSuccessful; } 
            set { isSuccessful = value; }
        }
        public string Message 
        { 
            get { return message; } 
            set { message = value; }
        }
        

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetCustomersListBildingSource(BindingSource customersList)
        {
            DgCustomers.DataSource = customersList;
        }


        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
