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
                case "Expense Entry":
                    OpenForm(new Entry());
                    break;
                case "Casepoint Expenses":
                    OpenForm(new Data());
                    break;
                case "Expenses":
                    OpenForm(new Expenses());
                    break;
                case "Analysis":
                    OpenForm(new Analysis());
                    break;
            }
        }

        private void OpenForm(Form form){
            form.Show();
        }
    }
}