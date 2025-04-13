using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using Supermarket_mvp._Repositories;

namespace Supermarket_mvp.Presenters
{
    internal class MainPresenter
    {
        private readonly IMainView mainView;
        private readonly string sqlConnetionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnetionString = sqlConnectionString;

            this.mainView.ShowPayModeView += ShowPayModeView;
            this.mainView.ShowCustomerView += ShowCustomerView;
            this.mainView.ShowCategoryView += ShowCategoryView;
        }

        private void ShowCategoryView(object? sender, EventArgs e)
        {
            ICategoryView view = new CategoryView();
            ICategoryRepository repository = new CategoryRepository(sqlConnetionString);
            new CategoryPresenter(view, repository);
        }

        private void ShowCustomerView(object? sender, EventArgs e)
        {
            ICustomersView view = new CustomersView();
            ICustomersRepository repository = new CustomersRepository(sqlConnetionString);
            new CustomersPresenter(view, repository);
        }

        private void ShowPayModeView(object? sender, EventArgs e)
        {
            IPayModeView view = PayModeView.GetInstance((MainView)mainView);
            IPayModeRepository repository = new PayModeRepository(sqlConnetionString);
            new PayModePresenter(view, repository);
        }
    }
}
