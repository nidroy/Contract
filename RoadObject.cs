using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contract
{
    public partial class RoadObject : Form
    {
        public RoadObject(int id)
        {
            InitializeComponent();

            dataGridView.Rows.Clear();
            DataSet ds = DatabaseContext.ExecuteQuery(string.Format(
                "SELECT [name] as [Название], [passport] as [Паспорт], [status] as [Состояние], [priority] as [Приоритет], [photo] as [Фотография] FROM [Road_object] WHERE [id] = {0};", id));
            dataGridView.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
