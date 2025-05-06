namespace Library
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            gbMember = new GroupBox();
            btnSearch = new Button();
            tbMember = new TextBox();
            label1 = new Label();
            label2 = new Label();
            gbBorrow = new GroupBox();
            dgvBorrowing = new DataGridView();
            btnNewBorrowing = new Button();
            lblClock = new Label();
            tClock = new System.Windows.Forms.Timer(components);
            gbMember.SuspendLayout();
            gbBorrow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowing).BeginInit();
            SuspendLayout();
            // 
            // gbMember
            // 
            gbMember.Controls.Add(btnSearch);
            gbMember.Controls.Add(tbMember);
            gbMember.Controls.Add(label1);
            gbMember.Location = new Point(44, 117);
            gbMember.Name = "gbMember";
            gbMember.Size = new Size(697, 71);
            gbMember.TabIndex = 0;
            gbMember.TabStop = false;
            gbMember.Text = "Member Data";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(599, 31);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // tbMember
            // 
            tbMember.Location = new Point(75, 32);
            tbMember.Name = "tbMember";
            tbMember.Size = new Size(518, 23);
            tbMember.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 35);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(345, 41);
            label2.Name = "label2";
            label2.Size = new Size(102, 37);
            label2.TabIndex = 1;
            label2.Text = "Library";
            // 
            // gbBorrow
            // 
            gbBorrow.Controls.Add(dgvBorrowing);
            gbBorrow.Location = new Point(44, 212);
            gbBorrow.Name = "gbBorrow";
            gbBorrow.Size = new Size(697, 137);
            gbBorrow.TabIndex = 2;
            gbBorrow.TabStop = false;
            gbBorrow.Text = "Borrowing Data";
            // 
            // dgvBorrowing
            // 
            dgvBorrowing.AllowUserToAddRows = false;
            dgvBorrowing.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBorrowing.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dgvBorrowing.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowing.Location = new Point(6, 22);
            dgvBorrowing.MultiSelect = false;
            dgvBorrowing.Name = "dgvBorrowing";
            dgvBorrowing.ReadOnly = true;
            dgvBorrowing.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvBorrowing.Size = new Size(685, 108);
            dgvBorrowing.TabIndex = 0;
            dgvBorrowing.CellContentClick += dgvBorrowing_CellContentClick;
            dgvBorrowing.CellFormatting += dgvBorrowing_CellFormatting;
            // 
            // btnNewBorrowing
            // 
            btnNewBorrowing.Enabled = false;
            btnNewBorrowing.Location = new Point(50, 387);
            btnNewBorrowing.Name = "btnNewBorrowing";
            btnNewBorrowing.Size = new Size(121, 36);
            btnNewBorrowing.TabIndex = 3;
            btnNewBorrowing.Text = "New Borrowing";
            btnNewBorrowing.UseVisualStyleBackColor = true;
            btnNewBorrowing.Click += btnNewBorrowing_Click;
            // 
            // lblClock
            // 
            lblClock.AutoSize = true;
            lblClock.Location = new Point(574, 398);
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(167, 15);
            lblClock.TabIndex = 4;
            lblClock.Text = "Sunday, 21 April 2025, 14:55:21";
            // 
            // tClock
            // 
            tClock.Interval = 1000;
            tClock.Tick += tClock_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblClock);
            Controls.Add(btnNewBorrowing);
            Controls.Add(gbBorrow);
            Controls.Add(label2);
            Controls.Add(gbMember);
            Name = "Form1";
            Text = "Library";
            gbMember.ResumeLayout(false);
            gbMember.PerformLayout();
            gbBorrow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBorrowing).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbMember;
        private Button btnSearch;
        private TextBox tbMember;
        private Label label1;
        private Label label2;
        private GroupBox gbBorrow;
        private DataGridView dgvBorrowing;
        private Button btnNewBorrowing;
        private Label lblClock;
        private System.Windows.Forms.Timer tClock;
    }
}
