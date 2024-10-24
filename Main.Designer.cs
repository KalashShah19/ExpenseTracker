namespace ExpenseTracker
{
    partial class Main
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // MainForm
            // 
            this.Text = "Expense Tracker Dashboard";
            this.Size = new System.Drawing.Size(600, 550);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#e6f2ff");

            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
            this.tableLayoutPanel.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));

            AddGridTile(this.tableLayoutPanel, "Casepoint Entry", "images/expense.png", Tile_Click);
            AddGridTile(this.tableLayoutPanel, "Casepoint Expenses", "images/data.png", Tile_Click);
            AddGridTile(this.tableLayoutPanel, "Casepoint Analysis", "images/analysis.jpg", Tile_Click);
            AddGridTile(this.tableLayoutPanel, "Expense Entry", "images/expense.png", Tile_Click);
            AddGridTile(this.tableLayoutPanel, "Other Expenses", "images/data.png", Tile_Click);
            AddGridTile(this.tableLayoutPanel, "Expenses Analysis", "images/analysis.jpg", Tile_Click);
            AddGridTile(this.tableLayoutPanel, "Reading Data", "images/analysis.jpg", Tile_Click);
            this.Controls.Add(this.tableLayoutPanel);
            this.ResumeLayout(false);
        }

        private void AddGridTile(System.Windows.Forms.TableLayoutPanel panel, string title, string imagePath, System.EventHandler clickHandler)
        {
            System.Windows.Forms.Panel tilePanel = new System.Windows.Forms.Panel();
            tilePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            tilePanel.BackColor = System.Drawing.ColorTranslator.FromHtml("#f0f8ff");
            tilePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tilePanel.Padding = new System.Windows.Forms.Padding(5);

            System.Windows.Forms.PictureBox pictureBox = new System.Windows.Forms.PictureBox();
            pictureBox.Image = System.Drawing.Image.FromFile(imagePath);
            pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            pictureBox.Click += clickHandler;

            System.Windows.Forms.Label label = new System.Windows.Forms.Label();
            label.Text = title;
            label.Dock = System.Windows.Forms.DockStyle.Bottom;
            label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label.ForeColor = System.Drawing.ColorTranslator.FromHtml("#333333");
            label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);

            tilePanel.Controls.Add(pictureBox);
            tilePanel.Controls.Add(label);
            panel.Controls.Add(tilePanel);
        }

        #endregion

    }
}