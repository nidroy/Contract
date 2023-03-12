using System.Data;

namespace Contract
{
    public partial class YearPlan : Form
    {
        public YearPlan(string id)
        {
            InitializeComponent();

            dataGridView.Rows.Clear();
            DataSet ds = DatabaseContext.ExecuteQuery("SELECT * FROM [Year_plan] WHERE [id] = " + id);
            dataGridView.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
