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
    public partial class RoadWork : Form
    {
        public RoadWork(int id)
        {
            InitializeComponent();

            DataSet ds = DatabaseContext.ExecuteQuery(string.Format(
                "SELECT [name], [price] " +
                "FROM [Road_work] " +
                "WHERE [id] = {0};", id));

            name.Text = ds.Tables[0].Rows[0][0].ToString();
            price.Text = ds.Tables[0].Rows[0][1].ToString();

            ds.Clear();

            ds = DatabaseContext.ExecuteQuery(string.Format(
                "SELECT " +
                "[material_id] as [Материал], " +
                "[count] as [Количество материалов], " +
                "[price] as [Стоимость материалов] " +
                "FROM [Work-Material] " +
                "WHERE [road_work_id] = {0};", id));

            dataGridView.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
