using System.Data;
using System.Globalization;

namespace ExpenseTracker
{
    public partial class ReadAnalysis : Form
    {
        public ReadAnalysis()
        {
            InitializeComponent();
        }

        private void AnalysisForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            string csvFilePath = "Data/reading records.csv";

            try
            {
                DataTable dataTable = LoadCsvData(csvFilePath);
                if (dataTable != null)
                {
                    dgvSummary.DataSource = dataTable;
                    ShowStatistics(dataTable);
                }
                else
                {
                    MessageBox.Show("Failed to load data from CSV.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading CSV: {ex.Message}");
            }
        }

        private string convertDate(string date)
        {
            DateTime parsedDate = DateTime.ParseExact(date, "dd/MM/yy", CultureInfo.InvariantCulture);
            string standardDate = parsedDate.ToString("yyyy-MM-dd");
            return standardDate;
        }

        private DataTable LoadCsvData(string csvFilePath)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Book Name", typeof(string));
            dataTable.Columns.Add("Date", typeof(DateTime));
            dataTable.Columns.Add("Start Page", typeof(int));
            dataTable.Columns.Add("End Page", typeof(int));
            dataTable.Columns.Add("Start Time", typeof(DateTime));
            dataTable.Columns.Add("End Time", typeof(DateTime));

            try
            {
                string[] csvLines = File.ReadAllLines(csvFilePath);
                bool isHeader = true;

                foreach (string line in csvLines)
                {
                    if (isHeader)
                    {
                        isHeader = false;
                        continue;
                    }

                    string[] values = line.Split(',');

                    if (values.Length == 6)
                    {
                        DataRow row = dataTable.NewRow();
                        row["Book Name"] = values[0];
                        row["Date"] = convertDate(values[1]);
                        row["Start Page"] = int.Parse(values[2]);
                        row["End Page"] = int.Parse(values[3]);
                        row["Start Time"] = DateTime.Parse(values[4]);
                        row["End Time"] = DateTime.Parse(values[5]);

                        dataTable.Rows.Add(row);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading CSV: {ex.Message}");
                return null!;
            }

            return dataTable;
        }

        private void ShowStatistics(DataTable dataTable)
        {
            var totalReadingTime = dataTable.AsEnumerable().Sum(row =>
            {
                DateTime startTime = (DateTime)row["Start Time"];
                DateTime endTime = (DateTime)row["End Time"];

                if (endTime < startTime)
                {
                    endTime = endTime.AddDays(1);
                }

                return (endTime - startTime).TotalMinutes;
            });

            var hours = totalReadingTime / 60;

            var totalPagesRead = dataTable.AsEnumerable().Sum(row =>
            {
                int startPage = (int)row["Start Page"];
                int endPage = (int)row["End Page"];
                return endPage - startPage + 1;
            });

            var avgPagesPerSession = dataTable.AsEnumerable().Average(row =>
            {
                int startPage = (int)row["Start Page"];
                int endPage = (int)row["End Page"];
                return endPage - startPage + 1;
            });

            double readingSpeed = totalReadingTime > 0 ? totalPagesRead / totalReadingTime : 0;
            var totalSessions = dataTable.Rows.Count;
            var longestSession = dataTable.AsEnumerable().Max(row =>
                {
                    DateTime startTime = (DateTime)row["Start Time"];
                    DateTime endTime = (DateTime)row["End Time"];
                    if (endTime < startTime)
                    {
                        endTime = endTime.AddDays(1);
                    }
                    return (endTime - startTime).TotalMinutes;
                });

            var shortestSession = dataTable.AsEnumerable().Min(row =>
            {
                DateTime startTime = (DateTime)row["Start Time"];
                DateTime endTime = (DateTime)row["End Time"];
                if (endTime < startTime)
                {
                    endTime = endTime.AddDays(1);
                }
                return (endTime - startTime).TotalMinutes;
            });

            var avgTimePerSession = totalReadingTime / totalSessions;
            var avgTimePerPage = totalPagesRead > 0 ? totalReadingTime / totalPagesRead : 0;

            // Calculate the most pages read in a single session
            var mostPagesInSession = dataTable.AsEnumerable().Max(row =>
            {
                int startPage = (int)row["Start Page"];
                int endPage = (int)row["End Page"];
                return endPage - startPage + 1;
            });

            // Calculate the fewest pages read in a single session
            var fewestPagesInSession = dataTable.AsEnumerable().Min(row =>
            {
                int startPage = (int)row["Start Page"];
                int endPage = (int)row["End Page"];
                return endPage - startPage + 1;
            });

            DataTable statsTable = new DataTable();
            statsTable.Columns.Add("Statistic", typeof(string));
            statsTable.Columns.Add("Value", typeof(string));

            statsTable.Rows.Add("Total Reading Time (Minutes)", totalReadingTime.ToString("N2"));
            statsTable.Rows.Add("Total Reading Time (Hours)", hours.ToString("N2"));
            statsTable.Rows.Add("Total Pages Read", totalPagesRead.ToString());
            statsTable.Rows.Add("Average Pages Per Session", avgPagesPerSession.ToString("N2"));
            statsTable.Rows.Add("Speed of Reading (Pages Per Minute)", readingSpeed.ToString("N2"));
            statsTable.Rows.Add("Average Time to Read a page (Minutes)", avgTimePerPage.ToString("N2"));
            statsTable.Rows.Add("Total Reading Sessions", totalSessions.ToString());
            statsTable.Rows.Add("Longest Session (Minutes)", longestSession.ToString("N2"));
            statsTable.Rows.Add("Shortest Session (Minutes)", shortestSession.ToString("N2"));
            statsTable.Rows.Add("Most Pages in Single Session", mostPagesInSession.ToString());
            statsTable.Rows.Add("Fewest Pages in Single Session", fewestPagesInSession.ToString());
            statsTable.Rows.Add("Average Time Per Session (Minutes)", avgTimePerSession.ToString("N2"));

            dgvSummary.DataSource = statsTable;
        }
    }
}