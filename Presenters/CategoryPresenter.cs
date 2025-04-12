using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using Supermarket_mvp._Repositories;
using Supermarket_mvp.Presenters.Common;
using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace Supermarket_mvp.Presenters
{
    internal class CategoryPresenter
    {
        private ICategoryView view;
        private ICategoryRepository repository;
        private BindingSource categoryBindingSource;
        private IEnumerable<CategoryModel> categoryList;

        public CategoryPresenter(ICategoryView view, ICategoryRepository repository)
        {
            this.categoryBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            // Suscripción a eventos de la vista
            this.view.SearchEvent += SearchCategory;
            this.view.AddNewEvent += AddNewCategory;
            this.view.EditEvent += LoadSelectedCategoryToEdit;
            this.view.SaveEvent += SaveCategory;
            this.view.CancelEvent += CancelAction;
            this.view.DeleteEvent += DeleteSelectedCategory;

            // Enlace del DataGridView
            this.view.SetCategoryListBildingSource(categoryBindingSource);

            // Cargar datos iniciales
            LoadAllCategoryList();

            // Mostrar la vista
            this.view.Show();
        }

        private void LoadAllCategoryList()
        {
            categoryList = repository.GetAll();
            categoryBindingSource.DataSource = categoryList;
        }

        private void SearchCategory(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue)
                categoryList = repository.GetAll();
            else
                categoryList = repository.GetByValue(this.view.SearchValue);

            categoryBindingSource.DataSource = categoryList;
        }

        private void AddNewCategory(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void LoadSelectedCategoryToEdit(object sender, EventArgs e)
        {
            var category = (CategoryModel)categoryBindingSource.Current;
            view.Category_Id = category.Id.ToString();
            view.Category_Name = category.Name;
            view.Category_Observation = category.Observation;
            view.IsEdit = true;
        }

        private void SaveCategory(object sender, EventArgs e)
        {
            var model = new CategoryModel();
            model.Id = Convert.ToInt32(view.Category_Id);
            model.Name = view.Category_Name;
            model.Observation = view.Category_Observation;

            try
            {
                new ModelDataValidation().Validate(model);

                if (view.IsEdit)
                {
                    repository.Edit(model);
                    view.Message = "Category updated successfully";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Category added successfully";
                }

                view.IsSuccessful = true;
                LoadAllCategoryList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.Category_Id = "0";
            view.Category_Name = "";
            view.Category_Observation = "";
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void DeleteSelectedCategory(object sender, EventArgs e)
        {
            try
            {
                var category = (CategoryModel)categoryBindingSource.Current;
                repository.Delete(category.Id);
                view.IsSuccessful = true;
                view.Message = "Category deleted successfully";
                LoadAllCategoryList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error occurred: " + ex.Message;
            }
        }
    }
}