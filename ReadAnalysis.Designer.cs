namespace ExpenseTracker
{
    partial class ReadAnalysis
    {
        private System.ComponentModel.IContainer components = null;

        // Dispose method
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
            this.dgvSummary = new System.Windows.Forms.DataGridView();
            this.labelTitle = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).BeginInit();
            this.SuspendLayout();

            // 
            // dgvSummary
            // 
            this.dgvSummary.AllowUserToAddRows = false;
            this.dgvSummary.AllowUserToDeleteRows = false;
            this.dgvSummary.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSummary.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSummary.Location = new System.Drawing.Point(30, 90);
            this.dgvSummary.Name = "dgvSummary";
            this.dgvSummary.ReadOnly = true;
            this.dgvSummary.RowTemplate.Height = 25;
            this.dgvSummary.Size = new System.Drawing.Size(600, 300);
            this.dgvSummary.AutoSize = true;
            this.dgvSummary.TabIndex = 1;
            this.dgvSummary.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.GraphicsUnit.Point);

            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelTitle.Location = new System.Drawing.Point(30, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(200, 30);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Reading Statistics";

            // 
            // AnalysisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(664, 600);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.dgvSummary);
            this.Name = "ReadingAnalysis";
            this.Text = "Reading Analysis";
            this.Load += new System.EventHandler(this.AnalysisForm_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSummary;
        private System.Windows.Forms.Label labelTitle;
    }
}