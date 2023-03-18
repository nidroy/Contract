using System.Data;

namespace Contract
{
    public partial class AddRoadWork : Form
    {
        public AddRoadWork()
        {
            InitializeComponent();
            SelectMaterial();
            SelectRoadWork();
        }

        private void addMaterialButton_Click(object sender, EventArgs e)
        {
            DatabaseContext.ExecuteQuery(string.Format("INSERT INTO [Material] " +
                "([name], [unit], [price]) " +
                "VALUES ('{0}', '{1}', '{2}')",
                materialName.Text, materialUnit.Text, materialPrice.Text));

            SelectMaterial();
        }

        private void SelectMaterial()
        {
            DataSet ds = DatabaseContext.ExecuteQuery(
                "SELECT " +
                "[id] as [Идентификатор], " +
                "[name] as [Название], " +
                "[unit] as [Единица измерения], " +
                "[price] as [Цена] " +
                "FROM [Material];");

            dataGridViewMaterial.DataSource = ds.Tables[0].DefaultView;
        }

        private void SelectRoadWork()
        {
            DataSet ds = DatabaseContext.ExecuteQuery(
                "SELECT " +
                "[id] as [Идентификатор], " +
                "[name] as [Название], " +
                "[price] as [Стоимость] " +
                "FROM [Road_work];");

            dataGridViewRoadWork.DataSource = ds.Tables[0].DefaultView;
        }

        private void dataGridViewMaterial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(dataGridViewMaterial.CurrentRow.Cells[0].Value.ToString());
        }
    }
}
