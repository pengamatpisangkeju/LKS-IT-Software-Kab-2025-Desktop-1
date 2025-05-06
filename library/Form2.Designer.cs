namespace library
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            tbTitle = new TextBox();
            btnSearch = new Button();
            dgvBook = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvBook).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(267, 38);
            label1.Name = "label1";
            label1.Size = new Size(206, 37);
            label1.TabIndex = 0;
            label1.Text = "New Borrowing";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 116);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 1;
            label2.Text = "Title";
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(168, 113);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(407, 23);
            tbTitle.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(581, 113);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvBook
            // 
            dgvBook.AllowUserToAddRows = false;
            dgvBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBook.Location = new Point(94, 142);
            dgvBook.Name = "dgvBook";
            dgvBook.ReadOnly = true;
            dgvBook.Size = new Size(562, 272);
            dgvBook.TabIndex = 4;
            dgvBook.CellFormatting += dgvBook_CellFormatting;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvBook);
            Controls.Add(btnSearch);
            Controls.Add(tbTitle);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dgvBook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbTitle;
        private Button btnSearch;
        private DataGridView dgvBook;
    }
}