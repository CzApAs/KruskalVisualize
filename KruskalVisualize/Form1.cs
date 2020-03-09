using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KruskalVisualize
{
    public partial class Form1 : Form
    {
        Pen bluePen = new Pen(Color.Blue);
        Pen kruskalPen = new Pen(Color.Yellow);

        Point anchor = new Point(220, 180);
        Point[] points;
        List<Edge> allEdges;
        List<Edge> kruskalEdges;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveButton1_Click(object sender, EventArgs e)
        {
            KruskalTextParser.SaveFileText(Constants.FILE_PATH_1, kruskalTextBox.Text);
        }

        private void LoadButton1_Click(object sender, EventArgs e)
        {
            kruskalTextBox.Text = KruskalTextParser.LoadFileText(Constants.FILE_PATH_1);
        }

        private void SaveButton2_Click(object sender, EventArgs e)
        {
            KruskalTextParser.SaveFileText(Constants.FILE_PATH_2, kruskalTextBox.Text);
        }

        private void LoadButton2_Click(object sender, EventArgs e)
        {
            kruskalTextBox.Text = KruskalTextParser.LoadFileText(Constants.FILE_PATH_2);
        }

        private void SaveButton3_Click(object sender, EventArgs e)
        {
            KruskalTextParser.SaveFileText(Constants.FILE_PATH_3, kruskalTextBox.Text);
        }

        private void LoadButton3_Click(object sender, EventArgs e)
        {
            kruskalTextBox.Text = KruskalTextParser.LoadFileText(Constants.FILE_PATH_3);
        }

        private void Visualize_Click(object sender, EventArgs e)
        {
            kruskalTextLabel.Text = "";
            ParseResults parsedResult = KruskalTextParser.ParseText(kruskalTextBox.Text);
            points = new Point[parsedResult.numberOfVertices];
            if (parsedResult.numberOfVertices > 0)
            {
                double angle = 360 / parsedResult.numberOfVertices;
                points[0] = new Point(60, anchor.Y);

                for (int i = 1; i < parsedResult.numberOfVertices; i++)
                {
                    points[i] = RotatePoint(points[0], anchor, angle * i);
                }
            }
            allEdges = parsedResult.allEdges;

            try
            {
                Graph graph = new Graph(parsedResult.numberOfVertices);
                foreach (Edge edge in allEdges)
                {
                    graph.AddEdge(edge.from, edge.to, edge.weight);
                }
                kruskalEdges = KruskalNode.Kruskal(graph);
                foreach (Edge edge in kruskalEdges)
                {
                    kruskalTextLabel.Text += "" + edge.from + " -> " + edge.to + " = " + edge.weight + "\n";
                }
            }
            catch
            {
                kruskalTextLabel.Text = "Couldn't execute Kruskal algorithm.";
            }

            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                SolidBrush drawBrush = new SolidBrush(Color.Black);
                SolidBrush kruskalDrawBrush = new SolidBrush(Color.Brown);
                StringFormat drawFormat = new StringFormat();
                drawFormat.FormatFlags = StringFormatFlags.DirectionVertical;
                if (points != null)
                {
                    int pointNumber = 0;
                    foreach (Point point in points)
                    {
                        e.Graphics.DrawEllipse(bluePen, point.X - Constants.ELLIPSE_OFFSET_X, point.Y - Constants.ELLIPSE_OFFSET_Y, 30, 30);
                        e.Graphics.DrawString("" + pointNumber, new Font("Arial", 24), drawBrush, point.X - Constants.ELLIPSE_OFFSET_X, point.Y - Constants.ELLIPSE_OFFSET_Y);
                        pointNumber++;
                    }
                }
                if (allEdges != null)
                {
                    foreach (Edge edge in allEdges)
                    {
                        e.Graphics.DrawLine(bluePen, points[edge.from].X, points[edge.from].Y, points[edge.to].X, points[edge.to].Y);
                        double differenceX = (points[edge.to].X - Constants.ELLIPSE_OFFSET_X) - (points[edge.from].X - Constants.ELLIPSE_OFFSET_X);
                        double differenceY = (points[edge.to].Y - Constants.ELLIPSE_OFFSET_Y) - (points[edge.from].Y - Constants.ELLIPSE_OFFSET_Y);

                        double weightTextX = points[edge.from].X + (Constants.EDGE_WEIGHT_OFFSET_MULTIPLIER * differenceX);
                        double weightTextY = points[edge.from].Y + (Constants.EDGE_WEIGHT_OFFSET_MULTIPLIER * differenceY);
                        e.Graphics.DrawString("" + edge.weight, new Font("Arial", Constants.WEIGHT_TEXT_SIZE), drawBrush, (float)weightTextX - Constants.WEIGHT_TEXT_OFFSET, (float)weightTextY - Constants.WEIGHT_TEXT_OFFSET);
                    }
                }

                if (kruskalEdges != null)
                {
                    foreach (Edge edge in kruskalEdges)
                    {
                        e.Graphics.DrawLine(kruskalPen, points[edge.from].X, points[edge.from].Y, points[edge.to].X, points[edge.to].Y);
                        double differenceX = (points[edge.to].X - Constants.ELLIPSE_OFFSET_X) - (points[edge.from].X - Constants.ELLIPSE_OFFSET_X);
                        double differenceY = (points[edge.to].Y - Constants.ELLIPSE_OFFSET_Y) - (points[edge.from].Y - Constants.ELLIPSE_OFFSET_Y);

                        double weightTextX = points[edge.from].X + (Constants.EDGE_WEIGHT_OFFSET_MULTIPLIER * differenceX);
                        double weightTextY = points[edge.from].Y + (Constants.EDGE_WEIGHT_OFFSET_MULTIPLIER * differenceY);
                        e.Graphics.DrawString("" + edge.weight, new Font("Arial", Constants.WEIGHT_TEXT_SIZE), kruskalDrawBrush, (float)weightTextX - Constants.WEIGHT_TEXT_OFFSET, (float)weightTextY - Constants.WEIGHT_TEXT_OFFSET);
                    }
                }

            }
            catch
            {
                kruskalTextLabel.Text = "Error. Input might be incorrect.";
            }
        }

        public Point RotatePoint(Point pointToRotate, Point centerPoint, double angleInDegrees)
        {
            double angleInRadians = angleInDegrees * (Math.PI / 180);
            double cosTheta = Math.Cos(angleInRadians);
            double sinTheta = Math.Sin(angleInRadians);
            return new Point
            {
                X =
                    (int)
                    (cosTheta * (pointToRotate.X - centerPoint.X) -
                    sinTheta * (pointToRotate.Y - centerPoint.Y) + centerPoint.X),
                Y =
                    (int)
                    (sinTheta * (pointToRotate.X - centerPoint.X) +
                    cosTheta * (pointToRotate.Y - centerPoint.Y) + centerPoint.Y)
            };
        }
    }
}
