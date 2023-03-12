using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contract
{
    public partial class MonthPlan : Form
    {
        public MonthPlan(int id)
        {
            InitializeComponent();

            dataGridView.Rows.Clear();
            DataSet ds = DatabaseContext.ExecuteQuery(string.Format(
                "SELECT [Month].[name], [price] FROM [Month_plan] JOIN [Month] ON [Month_plan].[month_id] = [Month].[id] WHERE [Month_plan].[id] = {0};", id));
            month.Text = ds.Tables[0].Rows[0][0].ToString();
            price.Text = ds.Tables[0].Rows[0][1].ToString();

            ds.Clear();

            ds = DatabaseContext.ExecuteQuery(string.Format(
                "SELECT [road_object_id] as [Дорожный объект], [road_work_id] as [Дорожная работа], [count] as [Количество работ], [price] as [Стоимость работы] FROM [Plan-Object-Work] WHERE [month_plan_id] = {0};", id));
            dataGridView.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
