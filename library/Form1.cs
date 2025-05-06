using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;

namespace library
{
    public partial class Form1 : Form
    {
        private readonly DatabaseHelper dbHelper = DatabaseHelper.Instance;

        public Form1()
        {
            InitializeComponent();
            timer.Start();
        }

        private void GetBorrowingData()
        {
            string query = @"SELECT
b.id,
a.title,
b.borrow_date,
DATEADD(day, 7, b.borrow_date) as due_date,
CASE
    WHEN GETDATE() > DATEADD(day, 7, b.borrow_date)
    THEN DATEDIFF(day, DATEADD(day, 7, b.borrow_date), GETDATE())
    ELSE 0
END as overdue_days
FROM
    Borrowing b
JOIN
    Book a ON b.book_id = a.id
JOIN
    Member c ON b.member_id = c.id
WHERE
    c.name = @name AND
    b.return_date IS NULL";

            SqlParameter[] sp = [
                new("@name", tbMember.Text.Trim())
            ];

            DataTable dt = dbHelper.ExecuteQuery(query, sp);

            if (dt.Rows.Count > 0)
            {
                dgvBorrow.DataSource = dt;

                if (!dgvBorrow.Columns.Contains("action"))
                {
                    DataGridViewLinkColumn action = new();
                    action.Name = "action";
                    action.Text = "return";
                    action.UseColumnTextForLinkValue = true;
                    dgvBorrow.Columns.Add(action);
                }

                if (dt.Rows.Count < 3)
                {
                    btnBorrow.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("No borrow data");
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbMember.Text))
            {
                GetBorrowingData();
            }
        }

        private void dgvBorrow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvBorrow.Columns["action"].Index && e.RowIndex >= 0)
            {
                string query = "UPDATE Borrowing SET return_date = GETDATE() WHERE id = @id";

                DataGridViewRow row = dgvBorrow.Rows[e.RowIndex];

                SqlParameter[] sp = [
                    new("@id", (int)row.Cells["id"].Value)
                ];

                if (dbHelper.ExecuteNonQuery(query, sp) > 0)
                {
                    string book = (String)row.Cells["title"].Value;
                    int fine = (int)row.Cells["overdue_days"].Value * 2000;

                    MessageBox.Show($"Success Return \"{book}\"\nMember needs to pay fine: {fine} IDR.");
                    GetBorrowingData();
                }
            }
        }

        private void dgvBorrow_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DateTime dueDate = (DateTime)dgvBorrow.Rows[e.RowIndex].Cells["due_date"].Value;
            DateTime today = DateTime.Today;

            if (dueDate > today)
            {
                e.CellStyle.BackColor = Color.White;
            }
            else if (dueDate == today)
            {
                e.CellStyle.BackColor = Color.Yellow;
            }
            else
            {
                e.CellStyle.BackColor = Color.Red;
            }
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            Form2 form2 = new(tbMember.Text.Trim());
            form2.ShowDialog();
            GetBorrowingData();
        }
    }
}
