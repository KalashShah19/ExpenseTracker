using System.Globalization;

namespace ExpenseTracker
{
    public partial class Analysis : Form
    {
        public Analysis()
        {
            InitializeComponent();
            Analysis_load();
        }

        private string convertDate(string date)
        {
            DateTime parsedDate = DateTime.ParseExact(date, "dd/MM/yy", CultureInfo.InvariantCulture);
            string standardDate = parsedDate.ToString("yyyy-MM-dd");
            return standardDate;
        }

        private void Analysis_load()
        {
            List<Expense> expenses = new List<Expense>();
            try
            {
                using (StreamReader reader = new StreamReader("D:/! Kalash/Extras/Data/casepoint expenses.csv"))
                {
                    string line;
                    while ((line = reader.ReadLine()!) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length >= 4)
                        {
                            double amount;
                            if (double.TryParse(parts[0], out amount))
                            {
                                string date = convertDate(parts[3]);
                                expenses.Add(new Expense
                                {
                                    Amount = amount,
                                    Purpose = parts[1],
                                    Category = parts[2],
                                    Date = Convert.ToDateTime(date)
                                });
                            }
                        }
                    }

                    for (int i = 0; i < expenses.Count; i++)
                    {
                        Console.WriteLine(i + " - " + expenses[i]);
                    }

                    double totalExpenses = expenses.Sum(e => e.Amount);
                    double averageExpenses = expenses.Average(e => e.Amount);
                    double highestExpense = expenses.Max(e => e.Amount);
                    double lowestExpense = expenses.Min(e => e.Amount);
                    var expensesByCategory = expenses.GroupBy(e => e.Category);
                    foreach (var group in expensesByCategory)
                    {
                        double totalCategoryExpenses = group.Sum(e => e.Amount);
                    }

                    lblTotalExpenses.Text = "Total Expenses: " + totalExpenses.ToString("C2");
                    lblAverageExpenses.Text = "Average Expenses: " + averageExpenses.ToString("C2");
                    lblHighestExpense.Text = "Highest Expense: " + highestExpense.ToString("C2");
                    lblLowestExpense.Text = "Lowest Expense: " + lowestExpense.ToString("C2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

public class Expense
{
    public double Amount { get; set; }
    public DateTime Date { get; set; }
    public string? Purpose { get; set; }
    public string? Category { get; set; }
}