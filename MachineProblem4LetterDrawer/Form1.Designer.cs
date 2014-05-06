using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
namespace MachineProblem4LetterDrawer
{
    partial class LetterDrawer
    {
        const int RowCount = 8;
        const int ColumnCount = 8;
        
        private string GenerateArray()
        {
            var subArrays = new List<string>();
            string array = "double[] letter = {";
            string line = "{";

            int index = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Label lbl = this.Controls.Find(i + "," + j, true).FirstOrDefault() as Label;
                    if (index != 0 && index % 8 == 0)
                    {
                        line += "}";
                        subArrays.Add(line);
                        line = "{";
                        index = 0;
                    }
                    else
                    {
                        line += ",";
                    }
                    if (lbl.BackColor == Color.Black)
                    {
                        line += i+","+j;
                    }
                    else
                    {
                        line += i+","+j;
                    }
                    index++;
                }
            }
            subArrays.Reverse();
            index = 0;
            foreach (string s in subArrays)
            {
                array += s;
                index++;
                if (index < 7)
                {
                    array += ",";
                }
            }
            array += "};";
            return array;
        }

        private void lbl_Click(object sender, System.EventArgs e)
        {
            Label lbl = (Label)sender;
            Color color = lbl.BackColor;
            if (color == System.Drawing.Color.Black)
            {
                color = System.Drawing.Color.White;
            }
            else
            {
                color = System.Drawing.Color.Black;
            }
            lbl.BackColor = color;
        }

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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 280);
            this.panel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 338);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Panel panel1;
    }
}

