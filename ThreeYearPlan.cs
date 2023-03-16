using System.Data;

namespace Contract
{
    public partial class ThreeYearPlan : Form
    {
        private int index = 0;

        public ThreeYearPlan()
        {
            InitializeComponent();
            SelectThreeYearPlan();
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

        private void updateButton_Click(object sender, EventArgs e)
        {
            SelectThreeYearPlan();
        }

        private void SelectThreeYearPlan()
        {
            index = 0;
            comboBox.SelectedIndex = -1;
            comboBox.Text = "���������� �����";

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
                "WHERE [Year_plan].[id] = [third_year])) as [����], " +
                "[first_year] as [������ ���], " +
                "[second_year] as [������ ���], " +
                "[third_year] as [������ ���], " +
                "[price] as [���������] " +
                "FROM [Three-year_plan];");

            dataGridView.DataSource = ds.Tables[0].DefaultView;
        }
    }
}