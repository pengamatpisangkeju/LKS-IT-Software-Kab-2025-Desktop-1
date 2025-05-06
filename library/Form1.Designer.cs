namespace library
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnSearch = new Button();
            tbMember = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            dgvBorrow = new DataGridView();
            btnBorrow = new Button();
            lblTime = new Label();
            timer = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorrow).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(152, 37);
            label1.Name = "label1";
            label1.Size = new Size(477, 37);
            label1.TabIndex = 0;
            label1.Text = "ESEMKA Library Management System";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(tbMember);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(73, 112);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(630, 69);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Member Data";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(549, 25);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // tbMember
            // 
            tbMember.Location = new Point(79, 25);
            tbMember.Name = "tbMember";
            tbMember.Size = new Size(464, 23);
            tbMember.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 28);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 0;
            label2.Text = "Name";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvBorrow);
            groupBox2.Location = new Point(73, 203);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(630, 160);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Borrowing Data";
            // 
            // dgvBorrow
            // 
            dgvBorrow.AllowUserToAddRows = false;
            dgvBorrow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrow.Location = new Point(6, 22);
            dgvBorrow.Name = "dgvBorrow";
            dgvBorrow.ReadOnly = true;
            dgvBorrow.Size = new Size(618, 132);
            dgvBorrow.TabIndex = 0;
            dgvBorrow.CellContentClick += dgvBorrow_CellContentClick;
            dgvBorrow.CellFormatting += dgvBorrow_CellFormatting;
            // 
            // btnBorrow
            // 
            btnBorrow.Enabled = false;
            btnBorrow.Location = new Point(73, 398);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(112, 23);
            btnBorrow.TabIndex = 3;
            btnBorrow.Text = "New Borrowing";
            btnBorrow.UseVisualStyleBackColor = true;
            btnBorrow.Click += btnBorrow_Click;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(539, 406);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(164, 15);
            lblTime.TabIndex = 4;
            lblTime.Text = "Sunday, 21 April 2024 14:55:31";
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTime);
            Controls.Add(btnBorrow);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBorrow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button btnSearch;
        private TextBox tbMember;
        private Label label2;
        private GroupBox groupBox2;
        private DataGridView dgvBorrow;
        private Button btnBorrow;
        private Label lblTime;
        private System.Windows.Forms.Timer timer;
    }
}
