using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CalculatingCubicBezierExercise
{
    public partial class BezierForm : Form
    {
        //Declared four points
        public PointF StartPoint { get; set; }
        public PointF ControlPoint1 { get; set; }
        public PointF ControlPoint2 { get; set; }
        public PointF EndPoint { get; set; }
        public float TimeInterval { get; set; }

        private string errorMessage = "";

        private List<PointF> points = new List<PointF>();

        /// <summary>
        /// This method initialises the user interface objects on the form
        /// and calls the GetPoints method.
        /// </summary>
        public BezierForm()
        {
            InitializeComponent();
            GetPoints(null, null);
        }

        /// <summary>
        /// This method draws the cubic Bezier arc by calling the CalculatePoint method.
        /// Passing the four points and a time (t) between 0 and 1.
        /// Draws the line (cubic Bezier curve) given the pen and points.
        /// </summary>
        private void DrawBezierPoint(object sender, PaintEventArgs e)
        {
            points.Clear();
            CalculateCurve();

            // Create black pen
            Pen blackPen = new Pen(Color.Black, 3);

            for(int index = 0; index < points.Count - 1; index++)
            {
                PointF p1 = points[index];
                PointF p2 = points[index + 1];

                e.Graphics.DrawLine(blackPen, p1, p2);
            };
        }

        private void CalculateCurve()
        {
            float time = 0;

            //For t values between 0 and 1, control points 1 and 2 are calculated before the line is drawn
            do
            {
                PointF p1 = CalculatePoint(StartPoint, ControlPoint1, ControlPoint2, EndPoint, time);
                time += TimeInterval;
                PointF p2 = CalculatePoint(StartPoint, ControlPoint1, ControlPoint2, EndPoint, time);

            } while (time < 1.0);

        }

        /// <summary>
        /// This method gets the points by creating them using the x and y values.
        /// </summary>
        private void GetPoints(object sender, EventArgs e)
        {
            if(CheckValues())
            {
                StartPoint = CreatePoint(point0_X, point0_Y);
                ControlPoint1 = CreatePoint(point1_X, point1_Y);
                ControlPoint2 = CreatePoint(point2_X, point2_Y);
                EndPoint = CreatePoint(point3_X, point3_Y);
                TimeInterval = CreateTime(time_textBox);
            }
            else
            {
                MessageBox.Show(errorMessage);
            }


            Refresh();
        }

        private bool CheckValues()
        {
            errorMessage = "";
            bool noError = true;
           
            if(CheckValue(point0_X) == false)
            {
                noError = false;
            }

            if (CheckValue(point0_Y) == false)
            {
                noError = false;
            }
            
            //TODO: 6 more boxes

            return noError;
        }

        private bool CheckValue(TextBox textBox)
        {
            try
            {
                string value = textBox.Text;

                if(textBox.Name.Contains("time"))
                {
                    float realNumber = (float)Convert.ToDouble(value);
                }
                else
                {
                    int number = Convert.ToInt32(value);
                }
                return true;
            }
            catch (Exception e)
            {
                string number = "integer";
                if(textBox.Name.Contains("time"))
                {
                    number = "float";
                }
                //todo: add if for floats
                errorMessage += $"\n{textBox.Name} is not a valid {number} ";
                return false;
            }
        }

        /// <summary>
        /// This method creates a new point.
        /// </summary>
        private PointF CreatePoint(TextBox textBox_X, TextBox textBox_Y)
        {
            int x = Convert.ToInt32(textBox_X.Text);
            int y = Convert.ToInt32(textBox_Y.Text);

            PointF p = new PointF(x, y);

            if ((p.X < 0) || (p.Y < 0))
                MessageBox.Show($"{textBox_X.Name} or {textBox_Y.Name} is negative");

            if ((p.X > this.Width) || (p.Y >this.Height))
                MessageBox.Show($"{textBox_X.Name} or {textBox_Y.Name} is outside the form!");

            return p;
        }

        /// <summary>
        /// This method calculates a point. Returns the X and Y coordenates of
        /// a position on the curve for a given time (t)
        /// and the four points that define the cubic Bezier curve.
        /// </summary>
        private PointF CalculatePoint(PointF p0, PointF p1, PointF p2, PointF p3, float time)
        {
            float cx = 3 * (p1.X - p0.X);
            float cy = 3 * (p1.Y - p0.Y);
            float bx = 3 * (p2.X - p1.X) - cx;
            float by = 3 * (p2.Y - p1.Y) - cy;
            float ax = p3.X - p0.X - cx - bx;
            float ay = p3.Y - p0.Y - cy - by;
            float Cube = time * time * time;
            float Square = time * time;

            float resX = (ax * Cube) + (bx * Square) + (cx * time) + p0.X;
            float resY = (ay * Cube) + (by * Square) + (cy * time) + p0.Y;

            PointF pointF = new PointF(resX, resY);
                
            points.Add(pointF);

            return pointF;
        }

        /// <summary>
        /// This method creates the time.
        /// </summary>
        private float CreateTime(TextBox textBox_Time)
        {
            TimeInterval = (float)Convert.ToDouble(textBox_Time.Text);
            return TimeInterval;
        }
    }
}