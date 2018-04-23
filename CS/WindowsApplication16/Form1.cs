using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Layout;

namespace WindowsApplication16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void layoutView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            LayoutView view = sender as LayoutView;
            BindingList<Person> list = view.DataSource as BindingList<Person>;
            Person p = list[e.ListSourceRowIndex];
            if (e.Column.FieldName == "Title")
            {
                Employee emp = p as Employee;
                if (emp != null)
                {
                    if (e.IsGetData)
                    {
                        e.Value = (p as Employee).Title;
                    }
                }
            }
            if (e.Column.FieldName == "TotalTurnover")
            {
                Customer cust = p as Customer;
                if (cust != null)
                {
                    if (e.IsGetData)
                    {
                        e.Value = (p as Customer).TotalTurnover;
                    }
                }
            }
        }
       

        private void layoutView1_CustomCardLayout(object sender, DevExpress.XtraGrid.Views.Layout.Events.LayoutViewCustomCardLayoutEventArgs e)
        {
            LayoutView view = sender as LayoutView;
            Person p = view.GetRow(e.RowHandle) as Person;
            string colTitleName = view.Columns["Title"].LayoutViewField.Name;
            string colTotalTurnover = view.Columns["TotalTurnover"].LayoutViewField.Name;
            if (p.GetType() == typeof(Employee))
            {
                e.CardDifferences.AddItemDifference(colTitleName,
                    LayoutItemDifferenceType.ItemVisibility, true);
                e.CardDifferences.AddItemDifference(colTotalTurnover,
                    LayoutItemDifferenceType.ItemVisibility, false);
            }
            if (p.GetType() == typeof(Customer))
            {
                e.CardDifferences.AddItemDifference(colTitleName,
                    LayoutItemDifferenceType.ItemVisibility, false);
                e.CardDifferences.AddItemDifference(colTotalTurnover,
                    LayoutItemDifferenceType.ItemVisibility, true);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindingList<Person> list = new BindingList<Person>();
            list.Add(new Employee());
            list.Add(new Customer());
            gridControl1.DataSource = list;
            layoutView1.OptionsBehavior.Editable = false;
        }
    }

    class Person
    {
        public string Name { get { return "Person Name"; } }
    }

    class Employee : Person
    {
        public string Title { get { return "Title"; } }
    }

    class Customer : Person
    {
        public decimal TotalTurnover { get { return 3000; } }
    }
}