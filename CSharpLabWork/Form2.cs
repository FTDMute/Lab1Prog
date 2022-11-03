using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpLabWork
{
    public partial class Form2 : Form
    {
        public Form2(string p1, string p2, decimal p3, bool p4)
        {
            InitializeComponent(); 
            Random rnd = new Random();
            label1.Text = $"Студент: {p1}    Группа: {p2}";
            int n = Convert.ToInt32(p3);
            tableLayoutPanel1.RowCount = n;
            tableLayoutPanel1.ColumnCount = 3;
            for (int i = 0; i < n; i++)
            {
                if (p4)
                {
                    tableLayoutPanel1.Controls.Add(new TextBox() { Text = $"Легкое задание {i+1}", Dock = DockStyle.Fill, ReadOnly = true }, 0, i + 1);
                    tableLayoutPanel1.Controls.Add(new CheckBox() { Text = $"Ответ :{rnd.Next(12)}", Dock = DockStyle.Fill}, 1, i + 1);
                    tableLayoutPanel1.Controls.Add(new CheckBox() { Text = $"Ответ :{rnd.Next(12)}", Dock = DockStyle.Fill}, 2, i + 1);
                }
                else
                {
                    tableLayoutPanel1.Controls.Add(new TextBox() { Text = $"Сложное задание #{i}", Dock = DockStyle.Fill, ReadOnly = true }, 0, i + 1);
                    ComboBox cb = new ComboBox();
                    cb.Dock = DockStyle.Fill;
                    for (int j = 0; j < 6; j++)
                    {
                        cb.Items.Add(rnd.Next(12));
                    }
                    tableLayoutPanel1.Controls.Add(cb, 1, i + 1);
                }
            }
        }
    }
}