using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp65
{
    public partial class Form1 : Form
    {
        DataSet data = new DataSet();
        private SqlConnection _connection;
        SqlDataAdapter adapter;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}