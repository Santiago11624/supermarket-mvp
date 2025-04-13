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
    public partial class CategoryView : Form, ICategoryView
    {
        private string message;
        private bool isSuccessful;
        private bool isEdit;
        private string searchValue;
        private static CategoryView instance;
        public CategoryView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPageCategoryDetail);
        }

        public string Category_Id { get => TxtCategoryId.Text; set => TxtCategoryId.Text = value; }
        public string Category_Name { get => TxtCategoryName.Text; set => TxtCategoryName.Text = value; }
        public string Category_Observation { get => TxtCategoryObservation.Text; set => TxtCategoryObservation.Text = value; }

        public string SearchValue { get => searchValue; set => searchValue = value; }
        public bool IsEdit { get => isEdit; set => isEdit = value; }
        public bool IsSuccessful { get => isSuccessful; set => isSuccessful = value; }
        public string Message { get => message; set => message = value; }
        

        public void SetCategoryListBildingSource(BindingSource categoryList)
        {
            DgCategory.DataSource = categoryList;
        }

        public new void Show()
        {
            base.Show();
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        private void AssociateAndRaiseViewEvents()
        {
            TxtSearch.KeyDown += (s, e) =>
            {
                BtnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
                TxtSearch.KeyDown += (s, e) =>
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        SearchEvent?.Invoke(this, EventArgs.Empty);
                    }
                };
            };

            BtnNew.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageCategoryList);
                tabControl1.TabPages.Add(tabPageCategoryDetail);
                tabPageCategoryDetail.Text = "Add New Category";
            };

            BtnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageCategoryList);
                tabControl1.TabPages.Add(tabPageCategoryDetail);
                tabPageCategoryDetail.Text = "Edit Category";
            };

            BtnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);

                if (IsSuccessful)
                {
                    tabControl1.TabPages.Remove(tabPageCategoryDetail);
                    tabControl1.TabPages.Add(tabPageCategoryList);
                }

                MessageBox.Show(Message);
            };

            BtnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageCategoryDetail);
                tabControl1.TabPages.Add(tabPageCategoryList);
            };

            BtnDelete.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete the selected category?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

            BtnClose.Click += delegate
            {
                this.Close();
            };
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        public static CategoryView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new CategoryView();
                instance.MdiParent = parentContainer;

                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new CategoryView();
                }
                instance.BringToFront();
            }

            return instance;
        }
    }
}
