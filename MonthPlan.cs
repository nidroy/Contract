using System.Data;

namespace Contract
{
    public partial class MonthPlan : Form
    {
        public MonthPlan(int id)
        {
            InitializeComponent();

            DataSet ds = DatabaseContext.ExecuteQuery(string.Format(
                "SELECT [Month].[name], [price] " +
                "FROM [Month_plan] " +
                "JOIN [Month] " +
                "ON [Month_plan].[month_id] = [Month].[id] " +
                "WHERE [Month_plan].[id] = {0};", id));

            month.Text = ds.Tables[0].Rows[0][0].ToString();
            price.Text = ds.Tables[0].Rows[0][1].ToString();

            ds.Clear();

            ds = DatabaseContext.ExecuteQuery(string.Format(
                "SELECT " +
                "[road_object_id] as [Дорожный объект], " +
                "[road_work_id] as [Дорожная работа], " +
                "[count] as [Количество работ], " +
                "[price] as [Стоимость работы] " +
                "FROM [Plan-Object-Work] " +
                "WHERE [month_plan_id] = {0};", id));

            dataGridView.DataSource = ds.Tables[0].DefaultView;
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.CurrentCell.ColumnIndex == 0)
                SelectRoadObject();
            else if (dataGridView.CurrentCell.ColumnIndex == 1)
                SelectRoadWork();
        }

        private void SelectRoadObject()
        {
            string str = dataGridView.CurrentCell.Value.ToString();
            int id;

            if (int.TryParse(str, out id))
            {
                RoadObject roadObject = new RoadObject(id);
                roadObject.ShowDialog();
            }
        }

        private void SelectRoadWork()
        {
            string str = dataGridView.CurrentCell.Value.ToString();
            int id;

            if (int.TryParse(str, out id))
            {
                RoadWork roadWork = new RoadWork(id);
                roadWork.ShowDialog();
            }
        }
    }
}
