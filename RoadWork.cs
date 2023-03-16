using System.Data;

namespace Contract
{
    public partial class RoadWork : Form
    {
        private int id;

        public RoadWork(int id)
        {
            InitializeComponent();
            this.id = id;
            SelectRoadWork();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            SelectRoadWork();
        }

        private void SelectRoadWork()
        {
            name.Text = string.Empty;
            price.Text = string.Empty;

            DataSet ds = DatabaseContext.ExecuteQuery(string.Format(
                "SELECT [name], [price] " +
                "FROM [Road_work] " +
                "WHERE [id] = {0};", id));

            name.Text = ds.Tables[0].Rows[0][0].ToString();
            price.Text = ds.Tables[0].Rows[0][1].ToString();

            ds.Clear();

            ds = DatabaseContext.ExecuteQuery(string.Format(
                "SELECT " +
                "[name] as [Название материала], " +
                "[unit] as [Единица измерения], " +
                "[Material].[price] as [Цена], " +
                "[count] as [Количество], " +
                "[Work-Material].[price] as [Стоимость] " +
                "FROM [Work-Material] " +
                "JOIN [Material] " +
                "ON [Work-Material].[material_id] = [Material].[id] " +
                "WHERE [road_work_id] = {0};", id));

            dataGridView.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
