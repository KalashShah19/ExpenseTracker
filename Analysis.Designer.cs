
namespace ExpenseTracker
{
    partial class Analysis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTotalExpenses = new System.Windows.Forms.Label();
            this.lblAverageExpenses = new System.Windows.Forms.Label();
            this.lblHighestExpense = new System.Windows.Forms.Label();
            this.lblLowestExpense = new System.Windows.Forms.Label();
            this.lblTravel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTotalExpenses
            // 
            this.lblTotalExpenses.AutoSize = true;
            this.lblTotalExpenses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalExpenses.Location = new System.Drawing.Point(12, 166);
            this.lblTotalExpenses.Name = "lblTotalExpenses";
            this.lblTotalExpenses.Size = new System.Drawing.Size(123, 21);
            this.lblTotalExpenses.TabIndex = 2;
            this.lblTotalExpenses.Text = "Total Expenses:";
            // 
            // lblAverageExpenses
            // 
            this.lblAverageExpenses.AutoSize = true;
            this.lblAverageExpenses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAverageExpenses.Location = new System.Drawing.Point(12, 73);
            this.lblAverageExpenses.Name = "lblAverageExpenses";
            this.lblAverageExpenses.Size = new System.Drawing.Size(158, 21);
            this.lblAverageExpenses.TabIndex = 3;
            this.lblAverageExpenses.Text = "Average Expenses:";
            // 
            // lblHighestExpense
            // 
            this.lblHighestExpense.AutoSize = true;
            this.lblHighestExpense.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHighestExpense.Location = new System.Drawing.Point(12, 104);
            this.lblHighestExpense.Name = "lblHighestExpense";
            this.lblHighestExpense.Size = new System.Drawing.Size(149, 21);
            this.lblHighestExpense.TabIndex = 4;
            this.lblHighestExpense.Text = "Highest Expense:";
            // 
            // lblLowestExpense
            // 
            this.lblLowestExpense.AutoSize = true;
            this.lblLowestExpense.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLowestExpense.Location = new System.Drawing.Point(12, 135);
            this.lblLowestExpense.Name = "lblLowestExpense";
            this.lblLowestExpense.Size = new System.Drawing.Size(147, 21);
            this.lblLowestExpense.TabIndex = 5;
            this.lblLowestExpense.Text = "Lowest Expense:";
            // 
            // lblTravel
            // 
            this.lblTravel.AutoSize = true;
            this.lblTravel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTravel.Location = new System.Drawing.Point(12, 42);
            this.lblTravel.Name = "lblTravel";
            this.lblTravel.Size = new System.Drawing.Size(147, 21);
            this.lblTravel.TabIndex = 5;
            this.lblTravel.Text = "Travel Expense:";
            // 
            // Analysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.lblLowestExpense);
            this.Controls.Add(this.lblHighestExpense);
            this.Controls.Add(this.lblAverageExpenses);
            this.Controls.Add(this.lblTotalExpenses);
            this.Controls.Add(this.lblTravel);
            this.Name = "Casepoint Analysis";
            this.Text = "Casepoint Expense Statistics";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTotalExpenses;
        private System.Windows.Forms.Label lblAverageExpenses;
        private System.Windows.Forms.Label lblHighestExpense;
        private System.Windows.Forms.Label lblLowestExpense;
        private System.Windows.Forms.Label lblTravel;
    }
}