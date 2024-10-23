namespace ExpenseTracker;

public partial class Entry : Form
{
    public Entry()
    {
        InitializeComponent();
        textBoxAmount.Text = "200";
        textBoxExpenseName.Text = "Travel";
    }

    private void buttonSubmit_Click(object sender, EventArgs e)
    {
        string expenseName = textBoxExpenseName.Text;
        string amount = textBoxAmount.Text;
        string date = dateTimePickerDate.Value.ToString("dd/MM/yy");

        string data = $"{amount} - {expenseName.ToLower()} ( {date} )";
        string csv = $"{amount},Van,{expenseName},{date}";

        string filePath = "Data/casepoint expenses.txt";
        string csvPath = "Data/casepoint expenses.csv";
        File.AppendAllText(filePath, data + Environment.NewLine);
        File.AppendAllText(csvPath, csv + Environment.NewLine);

        dateTimePickerDate.Value = DateTime.Now;
        labelMsg.Text = "Expense Added Successfully!";
    }
}