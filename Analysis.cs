using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ExpenseTracker
{
    public partial class Analysis : Form
    {
        public Analysis()
        {
            InitializeComponent();
        }

        private void Analysis_load(object sender, EventArgs e)
        {
            // Read CSV data
            List<Expense> expenses = new List<Expense>();
            using (StreamReader reader = new StreamReader("D:/! Kalash/Extras/Data/casepoint expenses.csv"))
            {
                string line;
                while ((line = reader.ReadLine()!) != null)
                {
                    string[] parts = line.Split(',');
                    // MessageBox.Show("parts = " + parts[0]);
                    if (parts.Length >= 4)
                    {
                        double amount;
                        if (double.TryParse(parts[0], out amount))
                        {
                            DateTime date;
                            if (DateTime.TryParseExact(parts[3], "dd-MM-yy", null, System.Globalization.DateTimeStyles.None, out date))
                            {
                                expenses.Add(new Expense
                                {
                                    Amount = amount,
                                    Purpose = parts[1],
                                    Category = parts[2],
                                    Date = date
                                });
                            }
                        }
                    }
                }

                // Calculate statistics
                double totalExpenses = expenses.Sum(e => e.Amount);
                // MessageBox.Show(totalExpenses.ToString());
                double averageExpenses = expenses.Average(e => e.Amount);
                double highestExpense = expenses.Max(e => e.Amount);
                double lowestExpense = expenses.Min(e => e.Amount);

                // Calculate statistics by category (if needed)
                var expensesByCategory = expenses.GroupBy(e => e.Category);
                foreach (var group in expensesByCategory)
                {
                    double totalCategoryExpenses = group.Sum(e => e.Amount);
                }

                // Display statistics
                lblTotalExpenses.Text = "Total Expenses: " + totalExpenses.ToString("C2");
                lblAverageExpenses.Text = "Average Expenses: " + averageExpenses.ToString("C2");
                lblHighestExpense.Text = "Highest Expense: " + highestExpense.ToString("C2");
                lblLowestExpense.Text = "Lowest Expense: " + lowestExpense.ToString("C2");
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