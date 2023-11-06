using NhapHang.Utils;
using System.Data;
using System.Data.SqlClient;


namespace NhapHang
{
    public partial class NhapHangView : Form
    {

        public NhapHangView()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HANGHOA", conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;

                DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
                comboBoxColumn.DataSource = dt;
                comboBoxColumn.DataPropertyName = "ID";
                comboBoxColumn.HeaderText = "MaHang";
                comboBoxColumn.Name = "Column1";

                dataGridView1.Columns.Insert(1, comboBoxColumn);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand myCmd = conn.CreateCommand();

                myCmd.CommandText = "SELECT FirstName, LastName FROM Employees";

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HANGHOA", conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }
    }
}