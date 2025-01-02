using System.Data;

namespace ExpenseTracker
{
    public partial class Expenses : Form
    {
        public Expenses()
        {
            InitializeComponent();
        }

        private void ExpensesDisplayForm_Load(object sender, EventArgs e)
        {
            string csvFilePath = "Data/expenses.csv";
            DataTable dataTable = LoadCsvData(csvFilePath);

            dataGridView.DataSource = dataTable;
            dataGridView.AllowUserToAddRows = true;
            dataGridView.ReadOnly = false;

            ShowStatistics(dataTable);
        }

        private DataTable LoadCsvData(string filePath)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string[] headers = sr.ReadLine()!.Split(',');
                    foreach (string header in headers)
                    {
                        dataTable.Columns.Add(header);
                    }

                    while (!sr.EndOfStream)
                    {
                        string[] rows = sr.ReadLine()!.Split(',');
                        dataTable.Rows.Add(rows);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading CSV file: {ex.Message}");
            }

            return dataTable;
        }

        private void ShowStatistics(DataTable dataTable)
        {
            double totalExpenses = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                if (double.TryParse(row["Amount"].ToString(), out double amount))
                {
                    totalExpenses += amount;
                }
            }

            lblTotalExpenses.Text = $"Total Expenses: ₹{totalExpenses.ToString("N2")}";
        }
    }
}