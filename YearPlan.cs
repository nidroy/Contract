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
    public partial class YearPlan : Form
    {
        public YearPlan()
        {
            InitializeComponent();

            dataGridView.Rows.Clear();
            DataSet ds = DatabaseContext.ExecuteQuery("SELECT * FROM [Year_plan]");
            dataGridView.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
