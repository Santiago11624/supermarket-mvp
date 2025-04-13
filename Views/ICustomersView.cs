using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Views
{
    internal interface ICustomersView
    {
        string Document_Number { get; set; }
        string Name { get; set; }
        string Last_Name { get; set; }
        string Phone { get; set; }
        string Address { get; set; }
        string Email { get; set; }
        string Birth_Date { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetCustomersListBildingSource(BindingSource customersList);
        void Show();
    }
}
