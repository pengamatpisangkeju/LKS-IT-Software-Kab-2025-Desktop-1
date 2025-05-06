using System.Data;
using Microsoft.Data.SqlClient;

namespace Library
{
    public partial class Form1 : Form
    {
        private readonly DatabaseHelper dbHelper = DatabaseHelper.Instance;
        private DataTable borrowingData;

        const int Fine = 2000;

        public Form1()
        {
            InitializeComponent();
            tClock.Start();
        }

        private void tClock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("dddd, dd MMMM YYYY HH:mm:ss");
        }

        private void LoadBorrowing()
        {
            string query = @"
SELECT
    b.id,
    a.title,
    b.borrow_date,
    DATEADD(DAY, 7, b.borrow_date) as due_date,
    DATEDIFF(DAY, b.borrow_date, GETDATE()) as overdue_days
FROM Borrowing b
LEFT JOIN Book a ON b.book_id = a.id
LEFT JOIN Member c ON b.member_id = c.id
WHERE c.name = @memberName AND b.return_date IS NULL";

            SqlParameter[] sp =
            {
                new("@memberName", tbMember.Text),
            };

            borrowingData = dbHelper.ExecuteQuery(query, sp);

            if (dgvBorrowing.Columns.Contains("action"))
            {
                dgvBorrowing.Columns.Remove("action");
            }

            if (borrowingData.Rows.Count < 3)
            {
                btnNewBorrowing.Enabled = true;
            }

            if (borrowingData.Rows.Count > 0)
            {
                dgvBorrowing.DataSource = borrowingData;

                if (dgvBorrowing.Columns.Contains("id"))
                {
                    dgvBorrowing.Columns["id"].Visible = false;
                }

                if (!dgvBorrowing.Columns.Contains("action"))
                {
                    DataGridViewLinkColumn actionColumn = new()
                    {
                        Name = "action",
                        HeaderText = "Action",
                        Text = "Return",
                        UseColumnTextForLinkValue = true
                    };
                    dgvBorrowing.Columns.Add(actionColumn);
                }
            }
            else
            {
                MessageBox.Show("Error, borrowing or member not found.");
            }
        }

        private void ReturnBorrowing(int borrowingId, int fine, string bookTitle)
        {
            try
            {
                string query = @"
                    UPDATE Borrowing 
                    SET
                        return_date = @returnDate,
                        fine = @fine
                    WHERE id = @id";

                SqlParameter[]? sp =
                {
                    new("@returnDate", DateTime.Today),
                    new("@fine", fine),
                    new("@id", borrowingId),
                };

                dbHelper.ExecuteNonQuery(query, sp);

                MessageBox.Show($"Success Return {bookTitle}\nMember needs to pay fine: {fine} IDR.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating borrowing: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbMember.Text))
                return;

            LoadBorrowing();
        }

        private void dgvBorrowing_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvBorrowing.Rows[e.RowIndex];

            DateTime borrowDate = (DateTime)row.Cells["borrow_date"].Value;
            int overdueDays = (int)row.Cells["overdue_days"].Value;

            if (borrowDate.Date == DateTime.Today)
            {
                e.CellStyle.BackColor = Color.Yellow;
            }
            else if (overdueDays > 0)
            {
                e.CellStyle.BackColor = Color.Red;
            }
            else
            {
                e.CellStyle.BackColor = Color.White;
            }
        }

        private void dgvBorrowing_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvBorrowing.Columns[e.ColumnIndex].Name == "action")
            {
                DataGridViewRow row = dgvBorrowing.Rows[e.RowIndex];

                int overdueDays = (int)row.Cells["overdue_days"].Value;

                int borrowingId = (int)row.Cells["id"].Value;
                int fine = overdueDays * Fine;
                string bookTitle = row.Cells["title"].Value.ToString();

                ReturnBorrowing(borrowingId, fine, bookTitle);
                LoadBorrowing();
            }
        }

        private void btnNewBorrowing_Click(object sender, EventArgs e)
        {
            Form2 form2 = new(1);

            form2.Show();
            this.Hide();
        }
    }
}
