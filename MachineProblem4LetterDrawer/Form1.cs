using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineProblem4LetterDrawer
{
    public partial class LetterDrawer : Form
    {
        public List<List<Label>> grid = new List<List<Label>>();
        public LetterDrawer()
        {
            InitializeComponent();
            for (int j = 0; j < 8; j++)
            {
                List<Label> row = new List<Label>();
                for (int i = 0; i < 8; i++)
                {
                    Label lbl = new Label();
                    lbl.Name = i + "," + j;
                    lbl.Size = new Size(35, 35);
                    lbl.Location = new Point(i * 35, j * 35);
                    lbl.BackColor = Color.White;
                    lbl.Text = i + "," + j;
                    lbl.Click += lbl_Click;
                    //Console.WriteLine("Now adding: "+lbl.Text);
                    row.Add(lbl);
                    panel1.Controls.Add(lbl);
                }
                grid.Add(row);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            outputBox.Text = (GenerateArray());
        }
    }
}
