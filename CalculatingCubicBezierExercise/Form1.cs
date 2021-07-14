using System;
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
            // Create black pen
            Pen blackPen = new Pen(Color.Black, 3);

            //For t values between 0 and 1, control points 1 and 2 are calculated before the line is drawn
            float t = 0;
            do
            {
                PointF p1 = CalculatePoint(StartPoint, ControlPoint1, ControlPoint2, EndPoint, t);
                t += 0.01f;
                PointF p2 = CalculatePoint(StartPoint, ControlPoint1, ControlPoint2, EndPoint, t);
                e.Graphics.DrawLine(blackPen, p1, p2);
            } while (t < 1.0);
        }

        /// <summary>
        /// This method gets the points by creating them using the x and y values.
        /// </summary>
        private void GetPoints(object sender, EventArgs e)
        {
            StartPoint = CreatePoint(point0_X, point0_Y);
            ControlPoint1 = CreatePoint(point1_X, point1_Y);
            ControlPoint2 = CreatePoint(point2_X, point2_Y);
            EndPoint = CreatePoint(point3_X, point3_Y);

            Refresh();
        }

        /// <summary>
        /// This method creates a new point.
        /// </summary>
        private PointF CreatePoint(TextBox textBox_X, TextBox textBox_Y)
        {
            int x = Convert.ToInt32(textBox_X.Text);
            int y = Convert.ToInt32(textBox_Y.Text);

            PointF p = new PointF(x, y);
            return p;
        }

        /// <summary>
        /// This method calculates a point. Returns the X and Y coordenates of
        /// a position on the curve for a given time (t)
        /// and the four points that define the cubic Bezier curve.
        /// </summary>
        private PointF CalculatePoint(PointF p0, PointF p1, PointF p2, PointF p3, float t)
        {
            float cx = 3 * (p1.X - p0.X);
            float cy = 3 * (p1.Y - p0.Y);
            float bx = 3 * (p2.X - p1.X) - cx;
            float by = 3 * (p2.Y - p1.Y) - cy;
            float ax = p3.X - p0.X - cx - bx;
            float ay = p3.Y - p0.Y - cy - by;
            float Cube = t * t * t;
            float Square = t * t;

            float resX = (ax * Cube) + (bx * Square) + (cx * t) + p0.X;
            float resY = (ay * Cube) + (by * Square) + (cy * t) + p0.Y;

            return new PointF (resX, resY);
        }
    }
}