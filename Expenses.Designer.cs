namespace ExpenseTracker
{
    partial class Expenses
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lblTotalExpenses;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.lblTotalExpenses = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(600, 300);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.ColorTranslator.FromHtml("#f7f9fc");
            this.dataGridView.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 10F);
            this.dataGridView.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView.DefaultCellStyle.SelectionBackColor = System.Drawing.ColorTranslator.FromHtml("#cce5ff");
            this.dataGridView.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#f0f4f7");
            this.dataGridView.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#007bff");
            this.dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.dataGridView.EnableHeadersVisualStyles = false;
            // 
            // lblTotalExpenses
            // 
            this.lblTotalExpenses.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTotalExpenses.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalExpenses.ForeColor = System.Drawing.ColorTranslator.FromHtml("#333333");
            this.lblTotalExpenses.Location = new System.Drawing.Point(0, 300);
            this.lblTotalExpenses.Name = "lblTotalExpenses";
            this.lblTotalExpenses.Size = new System.Drawing.Size(600, 50);
            this.lblTotalExpenses.TabIndex = 1;
            this.lblTotalExpenses.Text = "Total Expenses: ₹0";
            this.lblTotalExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DataDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.lblTotalExpenses);
            this.Controls.Add(this.dataGridView);
            this.Name = "Data";
            this.Text = "Data";
            this.Load += new System.EventHandler(this.ExpensesDisplayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
        }
    }
}