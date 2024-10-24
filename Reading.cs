using System.Data;
using System.Globalization;

namespace ExpenseTracker
{
    public partial class Reading : Form
    {
        public Reading()
        {
            InitializeComponent();
        }

        private void DataDisplayForm_Load(object sender, EventArgs e)
        {
            string csvFilePath = "Data/reading records.csv";
            DataTable dataTable = LoadCsvData(csvFilePath);

            dataGridView.DataSource = dataTable;
            dataGridView.AllowUserToAddRows = true;
            dataGridView.ReadOnly = false;

            ShowStatistics(dataTable);
        }

        private string convertDate(string date)
        {
            DateTime parsedDate = DateTime.ParseExact(date, "dd/MM/yy", CultureInfo.InvariantCulture);
            string standardDate = parsedDate.ToString("yyyy-MM-dd");
            return standardDate;
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
            var totalReadingTime = dataTable.AsEnumerable().Sum(row =>
            {
                DateTime startTime = DateTime.Parse(row["Start Time"].ToString()!);
                DateTime endTime = DateTime.Parse(row["End Time"].ToString()!);

                if (endTime < startTime)
                {
                    endTime = endTime.AddDays(1);
                }

                return (endTime - startTime).TotalMinutes;
            });

            var hours = totalReadingTime / 60;
            var minutes = (int)totalReadingTime;
            lblTotalReadingTime.Text = $"Total Reading Time = {minutes.ToString()} Minutes OR  {hours.ToString("N2")}";
        }
    }
}