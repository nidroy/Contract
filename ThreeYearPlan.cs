using System.Data;

namespace Contract
{
    public partial class ThreeYearPlan : Form
    {
        private int index = 0;

        public ThreeYearPlan()
        {
            InitializeComponent();

            DataSet ds = DatabaseContext.ExecuteQuery(
                "SELECT " +
                "(SELECT " +
                "(SELECT [number] " +
                "FROM [Year_plan] " +
                "JOIN [Year] " +
                "ON [Year_plan].[year_id] = [Year].[id] " +
                "WHERE [Year_plan].[id] = [first_year])" +
                "||' - '||" +
                "(SELECT [number] " +
                "FROM [Year_plan] " +
                "JOIN [Year] " +
                "ON [Year_plan].[year_id] = [Year].[id] " +
                "WHERE [Year_plan].[id] = [third_year])) as [Дата], " +
                "[first_year] as [Первый год], " +
                "[second_year] as [Второй год], " +
                "[third_year] as [Третий год], " +
                "[price] as [Стоимость] " +
                "FROM [Three-year_plan];");

            dataGridView.DataSource = ds.Tables[0].DefaultView;
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.CurrentCell.ColumnIndex > 0 &&
                dataGridView.CurrentCell.ColumnIndex < 4)
            {
                string str = dataGridView.CurrentCell.Value.ToString();
                int id;

                if (int.TryParse(str, out id))
                {
                    YearPlan yearPlan = new YearPlan(id);
                    yearPlan.ShowDialog();
                }
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = comboBox.SelectedIndex + 1;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (index == 1)
            {
                AddMaterial addMaterial = new AddMaterial();
                addMaterial.ShowDialog();
            }
        }
    }
}