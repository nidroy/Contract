using System.Data;

namespace Contract
{
    public partial class ThreeYearPlan : Form
    {
        public ThreeYearPlan()
        {
            InitializeComponent();

            dataGridView.Rows.Clear();
            DataSet ds = DatabaseContext.ExecuteQuery(
                "SELECT [name] as [Название], [first_year] as [Первый год], [second_year] as [Второй год], [third_year] as [Третий год], [price] as [Стоимость] FROM [Three-year_plan];");
            dataGridView.DataSource = ds.Tables[0].DefaultView;
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SelectCell())
            {
                int id = Convert.ToInt32(dataGridView.CurrentCell.Value);
                YearPlan yearPlan = new YearPlan(id);
                yearPlan.ShowDialog();
            }
        }

        private bool SelectCell()
        {
            if (dataGridView.CurrentCell.ColumnIndex == 1 || dataGridView.CurrentCell.ColumnIndex == 2 || dataGridView.CurrentCell.ColumnIndex == 3)
                return NumericCell();
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