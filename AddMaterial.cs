using System.Data;

namespace Contract
{
    public partial class AddMaterial : Form
    {
        public AddMaterial()
        {
            InitializeComponent();
            SelectMaterial();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DatabaseContext.ExecuteQuery(string.Format("INSERT INTO [Material] " +
                "([name], [unit], [price]) " +
                "VALUES ('{0}', '{1}', '{2}')",
                name.Text, unit.Text, price.Text));

            SelectMaterial();
        }

        private void SelectMaterial()
        {
            DataSet ds = DatabaseContext.ExecuteQuery(
                "SELECT " +
                "[name] as [Название], " +
                "[unit] as [Единица измерения], " +
                "[price] as [Цена] " +
                "FROM [Material];");

            dataGridView.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
