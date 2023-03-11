using System.Data;

namespace Contract
{
    public partial class ThreeYearPlan : Form
    {
        public ThreeYearPlan()
        {
            InitializeComponent();

            dataGridView.Rows.Clear();
            DataSet ds = DatabaseContext.ExecuteQuery("SELECT * FROM [Three-year_plan]");
            dataGridView.DataSource = ds.Tables[0].DefaultView;
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.CurrentCell.ColumnIndex == 2)
            {
                YearPlan yearPlan = new YearPlan();
                yearPlan.ShowDialog();
            }
        }
    }
}