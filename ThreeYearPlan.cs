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
            if (SelectCell())
            {
                YearPlan yearPlan = new YearPlan(dataGridView.CurrentCell.Value.ToString());
                yearPlan.ShowDialog();
            }
        }

        private bool SelectCell()
        {
            if (dataGridView.CurrentCell.ColumnIndex > 1 && dataGridView.CurrentCell.ColumnIndex < 5)
            {
                return NumericCell();
            }
            else
                return false;
        }

        private bool NumericCell()
        {
            string str = dataGridView.CurrentCell.Value.ToString();

            if (str == null || str == "")
                return false;
            else
                return int.TryParse(str, out int val);
        }
    }
}