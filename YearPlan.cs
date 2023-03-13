using System.Data;

namespace Contract
{
    public partial class YearPlan : Form
    {
        public YearPlan(int id)
        {
            InitializeComponent();

            DataSet ds = DatabaseContext.ExecuteQuery(string.Format(
                "SELECT [number], [price] " +
                "FROM [Year_plan] " +
                "JOIN [Year] " +
                "ON [Year_plan].[year_id] = [Year].[id] " +
                "WHERE [Year_plan].[id] = {0};", id));

            year.Text = ds.Tables[0].Rows[0][0].ToString();
            price.Text = ds.Tables[0].Rows[0][1].ToString();

            ds.Clear();

            ds = DatabaseContext.ExecuteQuery(string.Format(
                "SELECT " +
                "[task] as [Задача куратора], " +
                "[contractor_report] as [Отчет подрядчика], " +
                "[customer_report] as [Отчет куратора] " +
                "FROM [Year_plan-Month_plan] " +
                "WHERE [year_plan_id] = {0};", id));

            dataGridView.DataSource = ds.Tables[0].DefaultView;
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string str = dataGridView.CurrentCell.Value.ToString();
            int id;

            if (int.TryParse(str, out id))
            {
                MonthPlan monthPlan = new MonthPlan(id);
                monthPlan.ShowDialog();
            }
        }
    }
}
