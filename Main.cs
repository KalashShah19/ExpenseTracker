namespace ExpenseTracker
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Tile_Click(object sender, EventArgs e)
        {
            PictureBox clickedTile = (PictureBox)sender;
            string title = clickedTile.Parent!.Controls[1].Text;

            switch (title)
            {
                // Casepoint
                case "Casepoint Entry":
                    OpenForm(new Entry());
                    break;
                case "Casepoint Expenses":
                    OpenForm(new Data());
                    break;
                case "Casepoint Analysis":
                    OpenForm(new Analysis());
                    break;
                // Other 
                case "Expense Entry":
                    OpenForm(new Insert());
                    break;
                case "Other Expenses":
                    OpenForm(new Expenses());
                    break;
                case "Expenses Analysis":
                    OpenForm(new Analytics());
                    break;
            }
        }

        private void OpenForm(Form form){
            form.Show();
        }
    }
}