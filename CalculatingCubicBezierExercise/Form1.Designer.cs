
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
            this.screen_panel = new System.Windows.Forms.Panel();
            this.values_panel = new System.Windows.Forms.Panel();
            this.time_textBox = new System.Windows.Forms.TextBox();
            this.time_label = new System.Windows.Forms.Label();
            this.point3_Y = new System.Windows.Forms.TextBox();
            this.point2_Y = new System.Windows.Forms.TextBox();
            this.point1_Y = new System.Windows.Forms.TextBox();
            this.point0_Y = new System.Windows.Forms.TextBox();
            this.draw_button = new System.Windows.Forms.Button();
            this.point3_X = new System.Windows.Forms.TextBox();
            this.point2_X = new System.Windows.Forms.TextBox();
            this.point1_X = new System.Windows.Forms.TextBox();
            this.point0_X = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.point1_label = new System.Windows.Forms.Label();
            this.point3_label = new System.Windows.Forms.Label();
            this.point2_label = new System.Windows.Forms.Label();
            this.point0_label = new System.Windows.Forms.Label();
            this.values_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // screen_panel
            // 
            this.screen_panel.BackColor = System.Drawing.SystemColors.Control;
            this.screen_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screen_panel.Location = new System.Drawing.Point(0, 214);
            this.screen_panel.Name = "screen_panel";
            this.screen_panel.Size = new System.Drawing.Size(1894, 992);
            this.screen_panel.TabIndex = 1;
            this.screen_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawBezierPoint);
            // 
            // values_panel
            // 
            this.values_panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.values_panel.Controls.Add(this.time_textBox);
            this.values_panel.Controls.Add(this.time_label);
            this.values_panel.Controls.Add(this.point3_Y);
            this.values_panel.Controls.Add(this.point2_Y);
            this.values_panel.Controls.Add(this.point1_Y);
            this.values_panel.Controls.Add(this.point0_Y);
            this.values_panel.Controls.Add(this.draw_button);
            this.values_panel.Controls.Add(this.point3_X);
            this.values_panel.Controls.Add(this.point2_X);
            this.values_panel.Controls.Add(this.point1_X);
            this.values_panel.Controls.Add(this.point0_X);
            this.values_panel.Controls.Add(this.textBox1);
            this.values_panel.Controls.Add(this.point1_label);
            this.values_panel.Controls.Add(this.point3_label);
            this.values_panel.Controls.Add(this.point2_label);
            this.values_panel.Controls.Add(this.point0_label);
            this.values_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.values_panel.Location = new System.Drawing.Point(0, 0);
            this.values_panel.Name = "values_panel";
            this.values_panel.Size = new System.Drawing.Size(1894, 214);
            this.values_panel.TabIndex = 0;
            // 
            // time_textBox
            // 
            this.time_textBox.Location = new System.Drawing.Point(1421, 56);
            this.time_textBox.Name = "time_textBox";
            this.time_textBox.Size = new System.Drawing.Size(157, 55);
            this.time_textBox.TabIndex = 15;
            this.time_textBox.Text = "0.01";
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.time_label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.time_label.Location = new System.Drawing.Point(1275, 46);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(140, 65);
            this.time_label.TabIndex = 14;
            this.time_label.Text = "Time";
            // 
            // point3_Y
            // 
            this.point3_Y.Location = new System.Drawing.Point(1078, 107);
            this.point3_Y.Name = "point3_Y";
            this.point3_Y.Size = new System.Drawing.Size(119, 55);
            this.point3_Y.TabIndex = 13;
            this.point3_Y.Text = "100";
            // 
            // point2_Y
            // 
            this.point2_Y.Location = new System.Drawing.Point(765, 107);
            this.point2_Y.Name = "point2_Y";
            this.point2_Y.Size = new System.Drawing.Size(119, 55);
            this.point2_Y.TabIndex = 12;
            this.point2_Y.Text = "50";
            // 
            // point1_Y
            // 
            this.point1_Y.Location = new System.Drawing.Point(468, 107);
            this.point1_Y.Name = "point1_Y";
            this.point1_Y.Size = new System.Drawing.Size(119, 55);
            this.point1_Y.TabIndex = 11;
            this.point1_Y.Text = "10";
            // 
            // point0_Y
            // 
            this.point0_Y.Location = new System.Drawing.Point(176, 107);
            this.point0_Y.Name = "point0_Y";
            this.point0_Y.Size = new System.Drawing.Size(119, 55);
            this.point0_Y.TabIndex = 10;
            this.point0_Y.Text = "100";
            // 
            // draw_button
            // 
            this.draw_button.Location = new System.Drawing.Point(1618, 56);
            this.draw_button.Name = "draw_button";
            this.draw_button.Size = new System.Drawing.Size(179, 106);
            this.draw_button.TabIndex = 9;
            this.draw_button.Text = "draw";
            this.draw_button.UseVisualStyleBackColor = true;
            this.draw_button.Click += new System.EventHandler(this.GetPoints);
            // 
            // point3_X
            // 
            this.point3_X.Location = new System.Drawing.Point(1078, 46);
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
            // point1_label
            // 
            this.point1_label.AutoSize = true;
            this.point1_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.point1_label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.point1_label.Location = new System.Drawing.Point(358, 46);
            this.point1_label.Name = "point1_label";
            this.point1_label.Size = new System.Drawing.Size(104, 65);
            this.point1_label.TabIndex = 3;
            this.point1_label.Text = "Pt1";
            // 
            // point3_label
            // 
            this.point3_label.AutoSize = true;
            this.point3_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.point3_label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.point3_label.Location = new System.Drawing.Point(968, 46);
            this.point3_label.Name = "point3_label";
            this.point3_label.Size = new System.Drawing.Size(104, 65);
            this.point3_label.TabIndex = 2;
            this.point3_label.Text = "Pt3";
            // 
            // point2_label
            // 
            this.point2_label.AutoSize = true;
            this.point2_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.point2_label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.point2_label.Location = new System.Drawing.Point(655, 46);
            this.point2_label.Name = "point2_label";
            this.point2_label.Size = new System.Drawing.Size(104, 65);
            this.point2_label.TabIndex = 1;
            this.point2_label.Text = "Pt2";
            // 
            // point0_label
            // 
            this.point0_label.AutoSize = true;
            this.point0_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.point0_label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.point0_label.Location = new System.Drawing.Point(66, 46);
            this.point0_label.Name = "point0_label";
            this.point0_label.Size = new System.Drawing.Size(104, 65);
            this.point0_label.TabIndex = 0;
            this.point0_label.Text = "Pt0";
            // 
            // BezierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1894, 1206);
            this.Controls.Add(this.screen_panel);
            this.Controls.Add(this.values_panel);
            this.Name = "BezierForm";
            this.Text = "Cubic Bezier";
            this.values_panel.ResumeLayout(false);
            this.values_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel values_panel;
        private System.Windows.Forms.TextBox point3_X;
        private System.Windows.Forms.TextBox point2_X;
        private System.Windows.Forms.TextBox point1_X;
        private System.Windows.Forms.TextBox point0_X;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label point1_label;
        private System.Windows.Forms.Label point3_label;
        private System.Windows.Forms.Label point2_label;
        private System.Windows.Forms.Label point0_label;
        private System.Windows.Forms.Button draw_button;
        private System.Windows.Forms.TextBox point3_Y;
        private System.Windows.Forms.TextBox point2_Y;
        private System.Windows.Forms.TextBox point1_Y;
        private System.Windows.Forms.TextBox point0_Y;
        private System.Windows.Forms.TextBox time_textBox;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Panel screen_panel;
    }
}

