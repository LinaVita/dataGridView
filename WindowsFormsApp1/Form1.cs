using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();

        }

        private void InitializeDataGridView()
        {
            dataGridView2.RowCount = 10;
            dataGridView2.ColumnCount = 10;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
        }
        private void ColorArea(Func<int, int, bool> condition, Color color)
        {
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                {
                    if (condition(i, j))
                    {
                        dataGridView2.Rows[i].Cells[j].Style.BackColor = color;
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ColorArea((i, j) => i == j, Color.Red);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorArea((i, j) => i < j, Color.Green);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorArea((i, j) => i > j, Color.Blue);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ColorArea((i, j) => i + j == dataGridView2.RowCount - 1, Color.Yellow);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorArea((i, j) => i + j < dataGridView2.RowCount - 1, Color.Orange);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ColorArea((i, j) => i + j > dataGridView2.RowCount - 1, Color.Purple);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ColorArea((i, j) => i < dataGridView2.RowCount / 2, Color.Pink);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ColorArea((i, j) => i >= dataGridView2.RowCount / 2, Color.Brown);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ColorArea((i, j) => j < dataGridView2.ColumnCount / 2, Color.Cyan);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ColorArea((i, j) => j >= dataGridView2.ColumnCount / 2, Color.Magenta);
        }
    }

}