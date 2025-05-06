using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace library
{
    public partial class Form2 : Form
    {
        private readonly DatabaseHelper dbHelper = DatabaseHelper.Instance;
        private int memberId;

        public Form2(string memberName)
        {
            InitializeComponent();
            LoadMemberData(memberName);
        }

        private void LoadMemberData(string memberName)
        {
            string query = "SELECT id FROM Member WHERE name = @name";

            SqlParameter[] sp = [
                new("@name", memberName)
            ];

            DataTable dt = dbHelper.ExecuteQuery(query, sp);

            if (dt.Rows.Count > 0)
            {
                memberId = (int)dt.Rows[0]["id"];
            }
            else
            {
                MessageBox.Show("Member not found");
            }
        }

        private void GetBookData()
        {
            string query = @"SELECT
a.id,
a.title,
STRING_AGG(c.name, ', ') as genre,
a.author,
a.publish_date,
a.stock
FROM
    Book a
JOIN
    BookGenre b ON a.id = b.book_id
JOIN
    Genre c ON c.id = b.genre_id
WHERE
    a.title LIKE '%' + @title + '%'
GROUP BY
    a.id, a.title, a.author, a.publish_date, a.stock";

            SqlParameter[] sp = [
                new("@title", tbTitle.Text.Trim())
            ];

            DataTable dt = dbHelper.ExecuteQuery(query, sp);

            if (dt.Rows.Count > 0)
            {
                dgvBook.DataSource = dt;

                if (!dgvBook.Columns.Contains("action"))
                {
                    DataGridViewLinkColumn action = new();
                    action.Name = "action";
                    action.Text = "borrow";
                    action.UseColumnTextForLinkValue = true;
                    dgvBook.Columns.Add(action);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbTitle.Text))
            {
                GetBookData();
            }
        }

        private void dgvBook_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvBook.Columns["action"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBook.Rows[e.RowIndex];

                int stock = (int)row.Cells["stock"].Value;

                if (stock <= 0)
                {
                    row.Cells["action"].Value = string.Empty;
                    row.Cells["action"].ReadOnly = true;
                }
            }
        }
    }
}
