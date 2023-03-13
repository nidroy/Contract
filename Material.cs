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
    public partial class Material : Form
    {
        public Material(int id)
        {
            InitializeComponent();

            DataSet ds = DatabaseContext.ExecuteQuery(string.Format(
                "SELECT " +
                "[name] as [Название], " +
                "[unit] as [Единица измерения], " +
                "[price] as [Цена] " +
                "FROM [Material] " +
                "WHERE [id] = {0};", id));

            dataGridView.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
