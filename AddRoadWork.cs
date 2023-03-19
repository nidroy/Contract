using System.Data;

namespace Contract
{
    public partial class AddRoadWork : Form
    {
        private int roadWorkID = 0;
        private int materialID = 0;

        public AddRoadWork()
        {
            InitializeComponent();
            SelectMaterial();
            SelectRoadWork();
        }

        private void addMaterialButton_Click(object sender, EventArgs e)
        {
            DatabaseContext.ExecuteQuery(string.Format(
                "INSERT INTO [Material] " +
                "([name], [unit], [price]) " +
                "VALUES ('{0}', '{1}', '{2}')",
                materialName.Text, materialUnit.Text, materialPrice.Text));

            SelectMaterial();
        }

        private void addRoadWorkButton_Click(object sender, EventArgs e)
        {
            DatabaseContext.ExecuteQuery(string.Format(
                "INSERT INTO [Road_work] " +
                "([name]) " +
                "VALUES ('{0}')",
                roadWorkName.Text));

            SelectRoadWork();
        }

        private void updateRoadWorkButton_Click(object sender, EventArgs e)
        {
            if (roadWorkID != 0 && materialID != 0)
            {
                int materialRelatedRoadWorkID = MaterialRelatedRoadWorkID();

                if (materialRelatedRoadWorkID == 0)
                {
                    DatabaseContext.ExecuteQuery(string.Format(
                        "INSERT INTO [Work-Material] " +
                        "([road_work_id], [material_id], [count], [price]) " +
                        "VALUES ('{0}', '{1}', '1', " +
                        "(SELECT [price] FROM [Material] WHERE [id] = '{1}'));",
                        roadWorkID, materialID));
                }
                else
                {
                    DatabaseContext.ExecuteQuery(string.Format(
                        "UPDATE [Work-Material] " +
                        "SET [count] = [count] + 1, " +
                        "[price] = [price] * ([count] + 1) " +
                        "WHERE [id] = '{0}';",
                        materialRelatedRoadWorkID));
                }

                DatabaseContext.ExecuteQuery(string.Format(
                        "UPDATE [Road_work] " +
                        "SET [price] = (" +
                        "SELECT SUM([price]) " +
                        "FROM [Work-Material] " +
                        "WHERE [road_work_id] = '{0}') " +
                        "WHERE [id] = '{0}';",
                        roadWorkID));

                SelectMaterial();
                SelectRoadWork();
            }
        }

        private void SelectMaterial()
        {
            materialID = 0;

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
            roadWorkID = 0;

            DataSet ds = DatabaseContext.ExecuteQuery(
                "SELECT " +
                "[id] as [Идентификатор], " +
                "[name] as [Название], " +
                "[price] as [Стоимость] " +
                "FROM [Road_work];");

            dataGridViewRoadWork.DataSource = ds.Tables[0].DefaultView;
        }

        private int MaterialRelatedRoadWorkID()
        {
            DataSet ds = DatabaseContext.ExecuteQuery(
                "SELECT " +
                "[id], " +
                "[road_work_id], " +
                "[material_id] " +
                "FROM [Work-Material];");

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                if (Convert.ToInt32(ds.Tables[0].Rows[i][1]) == roadWorkID && Convert.ToInt32(ds.Tables[0].Rows[i][2]) == materialID)
                    return Convert.ToInt32(ds.Tables[0].Rows[i][0]);

            return 0;
        }

        private void dataGridViewMaterial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            materialID = Convert.ToInt32(dataGridViewMaterial.CurrentRow.Cells[0].Value);
        }

        private void dataGridViewRoadWork_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            roadWorkID = Convert.ToInt32(dataGridViewRoadWork.CurrentRow.Cells[0].Value);
        }
    }
}
