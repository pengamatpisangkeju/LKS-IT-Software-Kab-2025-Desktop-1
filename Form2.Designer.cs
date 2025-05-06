namespace Library
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
            tbBook = new TextBox();
            btnSearch = new Button();
            dgvBook = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBook).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(286, 60);
            label1.Name = "label1";
            label1.Size = new Size(206, 37);
            label1.TabIndex = 0;
            label1.Text = "New Borrowing";
            // 
            // tbBook
            // 
            tbBook.Location = new Point(135, 148);
            tbBook.Name = "tbBook";
            tbBook.Size = new Size(503, 23);
            tbBook.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(644, 146);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 24);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvBook
            // 
            dgvBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBook.Location = new Point(69, 190);
            dgvBook.Name = "dgvBook";
            dgvBook.Size = new Size(650, 248);
            dgvBook.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 151);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 4;
            label2.Text = "Book Title";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(dgvBook);
            Controls.Add(btnSearch);
            Controls.Add(tbBook);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dgvBook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbBook;
        private Button btnSearch;
        private DataGridView dgvBook;
        private Label label2;
    }
}