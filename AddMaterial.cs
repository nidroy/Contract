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
    public partial class AddMaterial : Form
    {
        public AddMaterial()
        {
            InitializeComponent();
            SelectMaterial();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            SelectMaterial();
        }

        private void SelectMaterial()
        {
            DataSet ds = DatabaseContext.ExecuteQuery(
                "SELECT " +
                "[name] as [Название], " +
                "[unit] as [Единица измерения], " +
                "[price] as [Цена] " +
                "FROM [Material];");

            dataGridView.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
