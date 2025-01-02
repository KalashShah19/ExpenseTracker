using System.Globalization;

namespace ExpenseTracker
{
    public partial class Analytics : Form
    {
        public Analytics()
        {
            InitializeComponent();
            Analytics_load();
        }

        private string convertDate(string date)
        {
            DateTime parsedDate = DateTime.ParseExact(date, "dd/MM/yy", CultureInfo.InvariantCulture);
            string standardDate = parsedDate.ToString("yyyy-MM-dd");
            return standardDate;
        }

        private void Analytics_load()
        {
            List<Expense> expenses = new List<Expense>();
            // try
            // {
            using (StreamReader reader = new StreamReader("Data/expenses.csv"))
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
                            string date = convertDate(parts[2]);
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
                var expensesByCategory = expenses.GroupBy(e => e.Purpose);
                double totalCategoryExpenses = 0;
                foreach (var group in expensesByCategory)
                {
                    totalCategoryExpenses = group.Sum(e => e.Amount);
                }
                double totalTravelingExpenses = expensesByCategory.Where(g => g.Key == "icecream").Sum(g => g.Sum(e => e.Amount));

                lblTravel.Text = "Ice Cream : " + totalTravelingExpenses.ToString("C2");
                lblTotalExpenses.Text = "Total : " + totalExpenses.ToString("C2");
                lblAverageExpenses.Text = "Average : " + averageExpenses.ToString("C2");
                lblHighestExpense.Text = "Highest : " + highestExpense.ToString("C2");
                lblLowestExpense.Text = "Lowest : " + lowestExpense.ToString("C2");
            }
            // }
            // catch (Exception ex)
            // {

            //     // MessageBox.Show("inside load");
            //     MessageBox.Show(ex.Message);
            // }
        }
    }
}
