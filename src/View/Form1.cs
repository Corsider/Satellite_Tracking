using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.SkiaSharpView;

namespace Satellite_Tracking_Proj
{
    public partial class Form1 : Form
    {
        private Point center;
        private Point EarthPosition;
        private Point recieverDelta;
        

        Controller.Controller controller = null;
        public List<Image> gridImageList = new List<Image>();
        Graphics g;
        Graphics gd;
        Bitmap bm;
        Bitmap bd;
        //debug
        Label label6;

        public Form1()
        {
            InitializeComponent();
            bm = new Bitmap(pictureBox1.Width, pictureBox1.Height); // bitmap for drawing earth model
            _observableValues = new ObservableCollection<ObservableValue> // graph setup
            {
                new ObservableValue(0),
                new ObservableValue(0),
                new ObservableValue(0),
                new ObservableValue(0),
                new ObservableValue(0),
                new ObservableValue(0),
                new ObservableValue(0),
                new ObservableValue(0),
                new ObservableValue(0),
                new ObservableValue(0),
                new ObservableValue(0),
            };

            Series = new ObservableCollection<ISeries>
            {
                new LineSeries<ObservableValue>
                {
                    Values = _observableValues,
                    Fill = null,
                    GeometrySize = 0,
                    LineSmoothness = 0.1,
                    AnimationsSpeed = TimeSpan.FromMilliseconds(1)
                }
            };

            g = Graphics.FromImage(bm);
            center = new Point(pictureBox1.Width / 2, pictureBox1.Height / 2); // center of the earth
            EarthPosition = new Point(center.X - 50, center.Y - 50);
            pictureBox1.Image = bm;
            controller = new Controller.Controller(
                this,
                ref g,
                ref bm,
                ref center,
                ref pictureBox1,
                ref EarthPosition,
                ref label6
                );
            
            var xAxis = new Axis // graph limits
            {
                MaxLimit = 10,
                MinLimit = 0,
            };
            var yAxis = new Axis
            {
                MinLimit = -0.2
            };
            cartesianChart1.Series = Series;
            cartesianChart1.XAxes = new List<Axis> { xAxis };
            cartesianChart1.YAxes = new List<Axis> { yAxis };

            pictureBox2_grid.SizeMode = PictureBoxSizeMode.Zoom;
            InitGrid(9); // creating initial grid 9x9
        }

        private ObservableCollection<ObservableValue> _observableValues;
        public ObservableCollection<ISeries> Series { get; set; }
        
        public void UpdateChart(int signalStrength) // graph updater, fires every 200ms. adds new point and deletes outdated one.
        {
            _observableValues.Add(new ObservableValue(signalStrength));
            _observableValues.RemoveAt(0);
        }

        public void DrawGridElement(int x, int y, Image image) // used to update grid elements. draws spicified IMAGE at specified location
        {
            gd.DrawImage(image, x, y, 100, 100);
            pictureBox2_grid.Image = bd;
        }
        

        private void Form1_Load(object sender, EventArgs e) // start timers
        {
            controller.timer_init(sender, e);
            controller.timer_chart_init(sender, e);
        }

        private void UpdateCenter() // updates center and earth position variables, fires every time form size changes.
        {
            bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bm);
            controller.bm = bm;
            controller.g = g;
            controller.center = new Point(pictureBox1.Width / 2, pictureBox1.Height / 2);
            center = controller.center;
            if (controller.SetReceiverFlag == 1)
            {
                controller.ReceiverPosition.X += (center.X - controller.ReceiverPosition.X) - recieverDelta.X;
                controller.ReceiverPosition.Y += (center.Y - controller.ReceiverPosition.Y) - recieverDelta.Y;
                controller.UpdateSatellites(controller.ReceiverPosition);
            }
            
            EarthPosition = new Point(center.X - 50, center.Y - 50);
            controller.EarthPosition = EarthPosition;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            UpdateCenter();
        }

        private void button1_addSat_Click(object sender, EventArgs e) // add new satellite
        {
            DialogResult dialogResult;
            dialogResult = controller.AddSatellite();
            switch (dialogResult)
            {
                case DialogResult.OK:
                    break;
                case DialogResult.Retry:
                    MessageBox.Show(" Для начала задайте точку приемника \n Тыкните в любое место на Земле", "(!)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) // used to define reciever position at startup
        {
            var mouseEventArgs = e as MouseEventArgs;
            Point point = mouseEventArgs.Location;
            DialogResult dialogResult;
            dialogResult = controller.rece_point_set(point, bm.Width/6-15);

            recieverDelta.X = center.X - point.X;
            recieverDelta.Y = center.Y - point.Y;

            switch (dialogResult)
            {
                case DialogResult.Retry:
                    MessageBox.Show("Точка должна быть 'внутри' Земли ", "(!)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case DialogResult.OK:
                    MessageBox.Show("Точка задана успешно !", "DONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("Точка уже была задана до этого ", "(!)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e) // if earth picturebox size was changed
        {
            UpdateCenter();
        }
        private void InitGrid(int size) // creates grid grapic
        {
            Image imag = Resources.Resource1.grid1;
            bd = new Bitmap(size*100, size*100);
            gd = Graphics.FromImage(bd);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == 0)
                    {
                        //first lines
                        if (j == 0)
                        {
                            gd.DrawImage(Resources.Resource1.grid1, i * 100, j * 100, 100, 100);
                            gridImageList.Add(Resources.Resource1.grid1);
                            
                        } else if (j == size - 1)
                        {
                            gd.DrawImage(Resources.Resource1.grid7, i * 100, j * 100, 100, 100);
                            gridImageList.Add(Resources.Resource1.grid7);

                        } else
                        {
                            gd.DrawImage(Resources.Resource1.grid5, i * 100, j * 100, 100, 100);
                            gridImageList.Add(Resources.Resource1.grid5);

                        }
                    } else if (i != 0 && i != size-1)
                    {
                        if (j == 0)
                        {
                            gd.DrawImage(Resources.Resource1.grid2, i * 100, j * 100, 100, 100);
                            gridImageList.Add(Resources.Resource1.grid2);
                        } else if (j > 0 && j != size - 1)
                        {
                            gd.DrawImage(Resources.Resource1.grid4, i * 100, j * 100, 100, 100);
                            gridImageList.Add(Resources.Resource1.grid4);
                        } else
                        {
                            gd.DrawImage(Resources.Resource1.grid8, i * 100, j * 100, 100, 100);
                            gridImageList.Add(Resources.Resource1.grid8);
                        }
                    } else
                    {
                        if (j == 0)
                        {
                            gd.DrawImage(Resources.Resource1.grid3, i * 100, j * 100, 100, 100);
                            gridImageList.Add(Resources.Resource1.grid3);
                        } else if (j > 0 && j != size - 1)
                        {
                            gd.DrawImage(Resources.Resource1.grid6, i * 100, j * 100, 100, 100);
                            gridImageList.Add(Resources.Resource1.grid6);
                        } else
                        {
                            gd.DrawImage(Resources.Resource1.grid9, i * 100, j * 100, 100, 100);
                            gridImageList.Add(Resources.Resource1.grid9);
                        }
                    }
                }
            }
            pictureBox2_grid.Image = bd;
        }

        private void button2_DelSat_Click(object sender, EventArgs e) // delete satellite
        {
            DialogResult dialogResult;
            dialogResult = controller.DeleteSatellite();

            switch (dialogResult)
            {
                case DialogResult.OK:
                    break;
                case DialogResult.No:
                    MessageBox.Show(" Нет объектов в памяти! ", "(!)", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    break;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e) // update sat speed
        {
            controller.velo_coef(trackBar1.Value);
        }
    }
}
