
namespace Satellite_Tracking_Proj
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1_earth = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel2_controls = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2_DelSat = new System.Windows.Forms.Button();
            this.button1_addSat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel3_grid = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.panel4_graph = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            this.panel2_grid = new System.Windows.Forms.Panel();
            this.pictureBox2_grid = new System.Windows.Forms.PictureBox();
            this.panel1_earth.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2_controls.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel3_grid.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel4_graph.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2_grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1_earth
            // 
            this.panel1_earth.Controls.Add(this.groupBox4);
            this.panel1_earth.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1_earth.Location = new System.Drawing.Point(0, 0);
            this.panel1_earth.Name = "panel1_earth";
            this.panel1_earth.Size = new System.Drawing.Size(400, 476);
            this.panel1_earth.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(400, 476);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Earth";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(394, 454);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(400, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 476);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            this.splitter1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitter1_SplitterMoved);
            // 
            // panel2_controls
            // 
            this.panel2_controls.Controls.Add(this.groupBox1);
            this.panel2_controls.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2_controls.Location = new System.Drawing.Point(403, 0);
            this.panel2_controls.MinimumSize = new System.Drawing.Size(110, 300);
            this.panel2_controls.Name = "panel2_controls";
            this.panel2_controls.Size = new System.Drawing.Size(111, 476);
            this.panel2_controls.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.button2_DelSat);
            this.groupBox1.Controls.Add(this.button1_addSat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 476);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // trackBar1
            // 
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBar1.Location = new System.Drawing.Point(3, 176);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(105, 45);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Orbital Speed";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 37);
            this.panel1.TabIndex = 3;
            // 
            // button2_DelSat
            // 
            this.button2_DelSat.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2_DelSat.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2_DelSat.Location = new System.Drawing.Point(3, 78);
            this.button2_DelSat.Name = "button2_DelSat";
            this.button2_DelSat.Size = new System.Drawing.Size(105, 38);
            this.button2_DelSat.TabIndex = 2;
            this.button2_DelSat.Text = "-";
            this.button2_DelSat.UseVisualStyleBackColor = true;
            this.button2_DelSat.Click += new System.EventHandler(this.button2_DelSat_Click);
            // 
            // button1_addSat
            // 
            this.button1_addSat.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1_addSat.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1_addSat.Location = new System.Drawing.Point(3, 40);
            this.button1_addSat.Name = "button1_addSat";
            this.button1_addSat.Size = new System.Drawing.Size(105, 38);
            this.button1_addSat.TabIndex = 1;
            this.button1_addSat.Text = "+";
            this.button1_addSat.UseVisualStyleBackColor = true;
            this.button1_addSat.Click += new System.EventHandler(this.button1_addSat_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD SAT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(514, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 476);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
            // 
            // panel3_grid
            // 
            this.panel3_grid.Controls.Add(this.groupBox2);
            this.panel3_grid.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3_grid.Location = new System.Drawing.Point(517, 0);
            this.panel3_grid.MinimumSize = new System.Drawing.Size(500, 250);
            this.panel3_grid.Name = "panel3_grid";
            this.panel3_grid.Size = new System.Drawing.Size(769, 300);
            this.panel3_grid.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2_grid);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(769, 300);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grid";
            // 
            // splitter3
            // 
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter3.Location = new System.Drawing.Point(517, 300);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(769, 3);
            this.splitter3.TabIndex = 5;
            this.splitter3.TabStop = false;
            // 
            // panel4_graph
            // 
            this.panel4_graph.Controls.Add(this.groupBox3);
            this.panel4_graph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4_graph.Location = new System.Drawing.Point(517, 303);
            this.panel4_graph.MinimumSize = new System.Drawing.Size(500, 100);
            this.panel4_graph.Name = "panel4_graph";
            this.panel4_graph.Size = new System.Drawing.Size(769, 173);
            this.panel4_graph.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cartesianChart1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(769, 173);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Graph";
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartesianChart1.Location = new System.Drawing.Point(3, 19);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(763, 151);
            this.cartesianChart1.TabIndex = 0;
            // 
            // panel2_grid
            // 
            this.panel2_grid.Controls.Add(this.pictureBox2_grid);
            this.panel2_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2_grid.Location = new System.Drawing.Point(3, 19);
            this.panel2_grid.Name = "panel2_grid";
            this.panel2_grid.Size = new System.Drawing.Size(763, 278);
            this.panel2_grid.TabIndex = 0;
            // 
            // pictureBox2_grid
            // 
            this.pictureBox2_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2_grid.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2_grid.Name = "pictureBox2_grid";
            this.pictureBox2_grid.Size = new System.Drawing.Size(763, 278);
            this.pictureBox2_grid.TabIndex = 0;
            this.pictureBox2_grid.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1286, 476);
            this.Controls.Add(this.panel4_graph);
            this.Controls.Add(this.splitter3);
            this.Controls.Add(this.panel3_grid);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.panel2_controls);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1_earth);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Satellite Tracking";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.panel1_earth.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2_controls.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel3_grid.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel4_graph.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel2_grid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1_earth;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel2_controls;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel panel3_grid;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Panel panel4_graph;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1_addSat;
        private System.Windows.Forms.Button button2_DelSat;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.Panel panel2_grid;
        private System.Windows.Forms.PictureBox pictureBox2_grid;
    }
}

