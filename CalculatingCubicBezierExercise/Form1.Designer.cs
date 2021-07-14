
namespace CalculatingCubicBezierExercise
{
    partial class BezierForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.point3_X = new System.Windows.Forms.TextBox();
            this.point2_X = new System.Windows.Forms.TextBox();
            this.point1_X = new System.Windows.Forms.TextBox();
            this.point0_X = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.point0_Y = new System.Windows.Forms.TextBox();
            this.point1_Y = new System.Windows.Forms.TextBox();
            this.point2_Y = new System.Windows.Forms.TextBox();
            this.point3_Y = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 214);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1461, 889);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawBezierPoint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.point3_Y);
            this.panel1.Controls.Add(this.point2_Y);
            this.panel1.Controls.Add(this.point1_Y);
            this.panel1.Controls.Add(this.point0_Y);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.point3_X);
            this.panel1.Controls.Add(this.point2_X);
            this.panel1.Controls.Add(this.point1_X);
            this.panel1.Controls.Add(this.point0_X);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1461, 214);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1255, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 69);
            this.button1.TabIndex = 9;
            this.button1.Text = "draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GetPoints);
            // 
            // point3_X
            // 
            this.point3_X.Location = new System.Drawing.Point(1090, 46);
            this.point3_X.Name = "point3_X";
            this.point3_X.Size = new System.Drawing.Size(119, 55);
            this.point3_X.TabIndex = 8;
            this.point3_X.Text = "500";
            // 
            // point2_X
            // 
            this.point2_X.Location = new System.Drawing.Point(765, 46);
            this.point2_X.Name = "point2_X";
            this.point2_X.Size = new System.Drawing.Size(119, 55);
            this.point2_X.TabIndex = 7;
            this.point2_X.Text = "350";
            // 
            // point1_X
            // 
            this.point1_X.Location = new System.Drawing.Point(468, 46);
            this.point1_X.Name = "point1_X";
            this.point1_X.Size = new System.Drawing.Size(119, 55);
            this.point1_X.TabIndex = 6;
            this.point1_X.Text = "200";
            // 
            // point0_X
            // 
            this.point0_X.Location = new System.Drawing.Point(176, 46);
            this.point0_X.Name = "point0_X";
            this.point0_X.Size = new System.Drawing.Size(119, 55);
            this.point0_X.TabIndex = 5;
            this.point0_X.Text = "100";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(257, -55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 55);
            this.textBox1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(358, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 65);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pt1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(980, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 65);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pt3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(674, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 65);
            this.label2.TabIndex = 1;
            this.label2.Text = "P2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(66, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pt0";
            // 
            // point0_Y
            // 
            this.point0_Y.Location = new System.Drawing.Point(176, 107);
            this.point0_Y.Name = "point0_Y";
            this.point0_Y.Size = new System.Drawing.Size(119, 55);
            this.point0_Y.TabIndex = 10;
            this.point0_Y.Text = "100";
            // 
            // point1_Y
            // 
            this.point1_Y.Location = new System.Drawing.Point(468, 107);
            this.point1_Y.Name = "point1_Y";
            this.point1_Y.Size = new System.Drawing.Size(119, 55);
            this.point1_Y.TabIndex = 11;
            this.point1_Y.Text = "10";
            // 
            // point2_Y
            // 
            this.point2_Y.Location = new System.Drawing.Point(765, 107);
            this.point2_Y.Name = "point2_Y";
            this.point2_Y.Size = new System.Drawing.Size(119, 55);
            this.point2_Y.TabIndex = 12;
            this.point2_Y.Text = "50";
            // 
            // point3_Y
            // 
            this.point3_Y.Location = new System.Drawing.Point(1090, 107);
            this.point3_Y.Name = "point3_Y";
            this.point3_Y.Size = new System.Drawing.Size(119, 55);
            this.point3_Y.TabIndex = 13;
            this.point3_Y.Text = "100";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 1103);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Cubic Bezier";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox point3_X;
        private System.Windows.Forms.TextBox point2_X;
        private System.Windows.Forms.TextBox point1_X;
        private System.Windows.Forms.TextBox point0_X;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox point3_Y;
        private System.Windows.Forms.TextBox point2_Y;
        private System.Windows.Forms.TextBox point1_Y;
        private System.Windows.Forms.TextBox point0_Y;
    }
}

