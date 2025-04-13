using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Models;
using Supermarket_mvp.Views;

namespace Supermarket_mvp.Presenters
{
    internal class CustomersPresenter
    {
        private ICustomersView view;
        private ICustomersRepository repository;
        private BindingSource customerBindingSource;
        private IEnumerable<CustomersModel> customersList;

        public CustomersPresenter(ICustomersView view, ICustomersRepository repository)
        {
            this.customerBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchCustomers;
            this.view.AddNewEvent += AddNewCustomer;
            this.view.EditEvent += LoadSelectCustomersToEdit;
            this.view.DeleteEvent += DeleteSelectedCustomer;
            this.view.SaveEvent += SaveCustomer;
            this.view.CancelEvent += CancelAction;

            this.view.SetCustomersListBildingSource(customerBindingSource);

            LoadAllCustomersList();

            this.view.Show();
        }

        private void LoadAllCustomersList()
        {
            customersList = repository.GetAll();
            customerBindingSource.DataSource = customersList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SaveCustomer(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectedCustomer(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectCustomersToEdit(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewCustomer(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SearchCustomers(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                customersList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                customersList = repository.GetAll();
            }
            customerBindingSource.DataSource = customersList;
        }
    }
}
