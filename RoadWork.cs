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
                "[material_id] as [Материал], " +
                "[count] as [Количество], " +
                "[price] as [Стоимость] " +
                "FROM [Work-Material] " +
                "WHERE [road_work_id] = {0};", id));

            dataGridView.DataSource = ds.Tables[0].DefaultView;
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.CurrentCell.ColumnIndex == 0)
            {
                string str = dataGridView.CurrentCell.Value.ToString();
                int id;

                if (int.TryParse(str, out id))
                {
                    Material material = new Material(id);
                    material.ShowDialog();
                }
            }
        }
    }
}
