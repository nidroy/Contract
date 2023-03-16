using System.Data;

namespace Contract
{
    public partial class RoadWork : Form
    {
        public RoadWork(int id)
        {
            InitializeComponent();

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
