using System.Data;

namespace Contract
{
    public partial class RoadObject : Form
    {
        public RoadObject(int id)
        {
            InitializeComponent();

            DataSet ds = DatabaseContext.ExecuteQuery(string.Format(
                "SELECT " +
                "[name] as [Название], " +
                "[passport] as [Паспорт], " +
                "[status] as [Состояние], " +
                "[priority] as [Приоритет], " +
                "[photo] as [Фотография] " +
                "FROM [Road_object] " +
                "WHERE [id] = {0};", id));

            dataGridView.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
