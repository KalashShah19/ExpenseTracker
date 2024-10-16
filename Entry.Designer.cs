namespace ExpenseTracker;

partial class Entry
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.Label labelExpenseName;
    private System.Windows.Forms.TextBox textBoxExpenseName;
    private System.Windows.Forms.Label labelAmount;
    private System.Windows.Forms.TextBox textBoxAmount;
    private System.Windows.Forms.Label labelDate;
    private System.Windows.Forms.DateTimePicker dateTimePickerDate;
    private System.Windows.Forms.Button buttonSubmit;
    private System.Windows.Forms.Label labelMsg;

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
        this.labelExpenseName = new System.Windows.Forms.Label();
        this.textBoxExpenseName = new System.Windows.Forms.TextBox();
        this.labelAmount = new System.Windows.Forms.Label();
        this.textBoxAmount = new System.Windows.Forms.TextBox();
        this.labelDate = new System.Windows.Forms.Label();
        this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
        this.buttonSubmit = new System.Windows.Forms.Button();
        this.labelMsg = new System.Windows.Forms.Label();
        this.SuspendLayout();
        // 
        // labelExpenseName
        // 
        this.labelExpenseName.AutoSize = true;
        this.labelExpenseName.Location = new System.Drawing.Point(30, 30);
        this.labelExpenseName.Name = "labelExpenseName";
        this.labelExpenseName.Size = new System.Drawing.Size(95, 20);
        this.labelExpenseName.Text = "Expense Name:";
        this.labelExpenseName.ForeColor = System.Drawing.ColorTranslator.FromHtml("#333333");
        // 
        // textBoxExpenseName
        // 
        this.textBoxExpenseName.Location = new System.Drawing.Point(150, 30);
        this.textBoxExpenseName.Name = "textBoxExpenseName";
        this.textBoxExpenseName.Size = new System.Drawing.Size(200, 26);
        this.textBoxExpenseName.BackColor = System.Drawing.Color.White;
        // 
        // labelAmount
        // 
        this.labelAmount.AutoSize = true;
        this.labelAmount.Location = new System.Drawing.Point(30, 80);
        this.labelAmount.Name = "labelAmount";
        this.labelAmount.Size = new System.Drawing.Size(62, 20);
        this.labelAmount.Text = "Amount:";
        this.labelAmount.ForeColor = System.Drawing.ColorTranslator.FromHtml("#333333");
        // 
        // textBoxAmount
        // 
        this.textBoxAmount.Location = new System.Drawing.Point(150, 80);
        this.textBoxAmount.Name = "textBoxAmount";
        this.textBoxAmount.Size = new System.Drawing.Size(200, 26);
        this.textBoxAmount.BackColor = System.Drawing.Color.White;
        // 
        // labelDate
        // 
        this.labelDate.AutoSize = true;
        this.labelDate.Location = new System.Drawing.Point(30, 130);
        this.labelDate.Name = "labelDate";
        this.labelDate.Size = new System.Drawing.Size(46, 20);
        this.labelDate.Text = "Date:";
        this.labelDate.ForeColor = System.Drawing.ColorTranslator.FromHtml("#333333");
        // 
        // dateTimePickerDate
        // 
        this.dateTimePickerDate.Location = new System.Drawing.Point(150, 130);
        this.dateTimePickerDate.Name = "dateTimePickerDate";
        this.dateTimePickerDate.Size = new System.Drawing.Size(200, 26);
        // 
        // buttonSubmit
        // 
        this.buttonSubmit.Location = new System.Drawing.Point(150, 180);
        this.buttonSubmit.Name = "buttonSubmit";
        this.buttonSubmit.Size = new System.Drawing.Size(100, 30);
        this.buttonSubmit.Text = "Submit";
        this.buttonSubmit.UseVisualStyleBackColor = true;
        this.buttonSubmit.BackColor = System.Drawing.ColorTranslator.FromHtml("#5a9bd3");
        this.buttonSubmit.ForeColor = System.Drawing.Color.White;
        this.buttonSubmit.Click += buttonSubmit_Click;
        //
        // labelMsg
        //
        this.labelMsg.AutoSize = true;
        this.labelMsg.Location = new System.Drawing.Point(120, 220);
        this.labelMsg.Name = "LabelMsg";
        this.labelMsg.ForeColor = System.Drawing.Color.Green;
        this.labelMsg.Text = "";
        // 
        // ExpenseForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.ColorTranslator.FromHtml("#f0f0f5");
        this.ClientSize = new System.Drawing.Size(400, 250);
        this.Controls.Add(this.labelExpenseName);
        this.Controls.Add(this.textBoxExpenseName);
        this.Controls.Add(this.labelAmount);
        this.Controls.Add(this.textBoxAmount);
        this.Controls.Add(this.labelDate);
        this.Controls.Add(this.dateTimePickerDate);
        this.Controls.Add(this.buttonSubmit);
        this.Controls.Add(this.labelMsg);
        this.Name = "ExpenseForm";
        this.Text = "Expense Tracker";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion
}