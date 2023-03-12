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
                "SELECT [name] as [��������], [first_year] as [������ ���], [second_year] as [������ ���], [third_year] as [������ ���], [price] as [���������] FROM [Three-year_plan];");
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

        private void dataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string str = dataGridView.CurrentRow.Cells[1].Value.ToString();
            int id;

            if (int.TryParse(str, out id))
            {
                DataSet ds = DatabaseContext.ExecuteQuery(string.Format(
                    "SELECT [number] FROM [Year_plan] JOIN [Year] ON [Year_plan].[year_id] = [Year].[id] WHERE [Year_plan].[id] = {0};", id));
                date.Text = ds.Tables[0].Rows[0][0].ToString();
                date.Text = string.Format("{0} - {1}", date.Text, int.Parse(date.Text) + 2);
            }
        }
    }
}