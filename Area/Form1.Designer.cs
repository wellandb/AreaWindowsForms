using System;

namespace Area
{
    partial class Form1
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Menu = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Circle = new System.Windows.Forms.TabPage();
            this.pctCirc = new System.Windows.Forms.PictureBox();
            this.btnCircCalc = new System.Windows.Forms.Button();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.lblCircAns = new System.Windows.Forms.Label();
            this.lblRadius = new System.Windows.Forms.Label();
            this.Rectangle = new System.Windows.Forms.TabPage();
            this.pctRec = new System.Windows.Forms.PictureBox();
            this.txtRecSideB = new System.Windows.Forms.TextBox();
            this.lblRecSideB = new System.Windows.Forms.Label();
            this.btnRecCalc = new System.Windows.Forms.Button();
            this.txtRecSideA = new System.Windows.Forms.TextBox();
            this.lblRecAns = new System.Windows.Forms.Label();
            this.lblRecSideA = new System.Windows.Forms.Label();
            this.Triangle = new System.Windows.Forms.TabPage();
            this.pctTri = new System.Windows.Forms.PictureBox();
            this.txtTriSideB = new System.Windows.Forms.TextBox();
            this.lblTriSideB = new System.Windows.Forms.Label();
            this.txtTriSideC = new System.Windows.Forms.TextBox();
            this.lblTriSideC = new System.Windows.Forms.Label();
            this.btnTriCalc = new System.Windows.Forms.Button();
            this.txtTriSideA = new System.Windows.Forms.TextBox();
            this.lblTriAns = new System.Windows.Forms.Label();
            this.lblTriSideA = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Menu.SuspendLayout();
            this.Circle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCirc)).BeginInit();
            this.Rectangle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctRec)).BeginInit();
            this.Triangle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctTri)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Menu);
            this.tabControl1.Controls.Add(this.Circle);
            this.tabControl1.Controls.Add(this.Rectangle);
            this.tabControl1.Controls.Add(this.Triangle);
            this.tabControl1.Location = new System.Drawing.Point(185, 68);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1303, 833);
            this.tabControl1.TabIndex = 0;
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.textBox1);
            this.Menu.Controls.Add(this.label1);
            this.Menu.Location = new System.Drawing.Point(4, 29);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(3);
            this.Menu.Size = new System.Drawing.Size(1295, 800);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "Menu";
            this.Menu.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(241, 106);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(824, 489);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Circle
            // 
            this.Circle.Controls.Add(this.pctCirc);
            this.Circle.Controls.Add(this.btnCircCalc);
            this.Circle.Controls.Add(this.txtRadius);
            this.Circle.Controls.Add(this.lblCircAns);
            this.Circle.Controls.Add(this.lblRadius);
            this.Circle.Location = new System.Drawing.Point(4, 29);
            this.Circle.Name = "Circle";
            this.Circle.Padding = new System.Windows.Forms.Padding(3);
            this.Circle.Size = new System.Drawing.Size(1295, 800);
            this.Circle.TabIndex = 1;
            this.Circle.Text = "Circle";
            this.Circle.UseVisualStyleBackColor = true;
            // 
            // pctCirc
            // 
            this.pctCirc.Location = new System.Drawing.Point(0, 550);
            this.pctCirc.Name = "pctCirc";
            this.pctCirc.Size = new System.Drawing.Size(1289, 250);
            this.pctCirc.TabIndex = 19;
            this.pctCirc.TabStop = false;
            // 
            // btnCircCalc
            // 
            this.btnCircCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnCircCalc.Location = new System.Drawing.Point(550, 400);
            this.btnCircCalc.Name = "btnCircCalc";
            this.btnCircCalc.Size = new System.Drawing.Size(200, 50);
            this.btnCircCalc.TabIndex = 3;
            this.btnCircCalc.Text = "Calculate";
            this.btnCircCalc.UseVisualStyleBackColor = true;
            this.btnCircCalc.Click += new System.EventHandler(this.btnCircCalc_Click);
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(600, 300);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 26);
            this.txtRadius.TabIndex = 2;
            this.txtRadius.TextChanged += new System.EventHandler(this.txtRadius_TextChanged);
            // 
            // lblCircAns
            // 
            this.lblCircAns.AutoSize = true;
            this.lblCircAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblCircAns.Location = new System.Drawing.Point(600, 500);
            this.lblCircAns.Name = "lblCircAns";
            this.lblCircAns.Size = new System.Drawing.Size(82, 32);
            this.lblCircAns.TabIndex = 1;
            this.lblCircAns.Text = "Area:";
            this.lblCircAns.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblRadius.Location = new System.Drawing.Point(400, 300);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(111, 32);
            this.lblRadius.TabIndex = 0;
            this.lblRadius.Text = "Radius:";
            // 
            // Rectangle
            // 
            this.Rectangle.Controls.Add(this.pctRec);
            this.Rectangle.Controls.Add(this.txtRecSideB);
            this.Rectangle.Controls.Add(this.lblRecSideB);
            this.Rectangle.Controls.Add(this.btnRecCalc);
            this.Rectangle.Controls.Add(this.txtRecSideA);
            this.Rectangle.Controls.Add(this.lblRecAns);
            this.Rectangle.Controls.Add(this.lblRecSideA);
            this.Rectangle.Location = new System.Drawing.Point(4, 29);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Padding = new System.Windows.Forms.Padding(3);
            this.Rectangle.Size = new System.Drawing.Size(1295, 800);
            this.Rectangle.TabIndex = 3;
            this.Rectangle.Text = "Rectangle";
            this.Rectangle.UseVisualStyleBackColor = true;
            // 
            // pctRec
            // 
            this.pctRec.Location = new System.Drawing.Point(0, 550);
            this.pctRec.Name = "pctRec";
            this.pctRec.Size = new System.Drawing.Size(1289, 250);
            this.pctRec.TabIndex = 18;
            this.pctRec.TabStop = false;
            // 
            // txtRecSideB
            // 
            this.txtRecSideB.Location = new System.Drawing.Point(700, 300);
            this.txtRecSideB.Name = "txtRecSideB";
            this.txtRecSideB.Size = new System.Drawing.Size(100, 26);
            this.txtRecSideB.TabIndex = 17;
            // 
            // lblRecSideB
            // 
            this.lblRecSideB.AutoSize = true;
            this.lblRecSideB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblRecSideB.Location = new System.Drawing.Point(400, 300);
            this.lblRecSideB.Name = "lblRecSideB";
            this.lblRecSideB.Size = new System.Drawing.Size(106, 32);
            this.lblRecSideB.TabIndex = 16;
            this.lblRecSideB.Text = "Side B:";
            // 
            // btnRecCalc
            // 
            this.btnRecCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnRecCalc.Location = new System.Drawing.Point(550, 400);
            this.btnRecCalc.Name = "btnRecCalc";
            this.btnRecCalc.Size = new System.Drawing.Size(200, 50);
            this.btnRecCalc.TabIndex = 15;
            this.btnRecCalc.Text = "Calculate";
            this.btnRecCalc.UseVisualStyleBackColor = true;
            this.btnRecCalc.Click += new System.EventHandler(this.btnRecCalc_Click);
            // 
            // txtRecSideA
            // 
            this.txtRecSideA.Location = new System.Drawing.Point(700, 250);
            this.txtRecSideA.Name = "txtRecSideA";
            this.txtRecSideA.Size = new System.Drawing.Size(100, 26);
            this.txtRecSideA.TabIndex = 14;
            // 
            // lblRecAns
            // 
            this.lblRecAns.AutoSize = true;
            this.lblRecAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblRecAns.Location = new System.Drawing.Point(600, 500);
            this.lblRecAns.Name = "lblRecAns";
            this.lblRecAns.Size = new System.Drawing.Size(82, 32);
            this.lblRecAns.TabIndex = 13;
            this.lblRecAns.Text = "Area:";
            // 
            // lblRecSideA
            // 
            this.lblRecSideA.AutoSize = true;
            this.lblRecSideA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblRecSideA.Location = new System.Drawing.Point(400, 250);
            this.lblRecSideA.Name = "lblRecSideA";
            this.lblRecSideA.Size = new System.Drawing.Size(106, 32);
            this.lblRecSideA.TabIndex = 12;
            this.lblRecSideA.Text = "Side A:";
            // 
            // Triangle
            // 
            this.Triangle.Controls.Add(this.pctTri);
            this.Triangle.Controls.Add(this.txtTriSideB);
            this.Triangle.Controls.Add(this.lblTriSideB);
            this.Triangle.Controls.Add(this.txtTriSideC);
            this.Triangle.Controls.Add(this.lblTriSideC);
            this.Triangle.Controls.Add(this.btnTriCalc);
            this.Triangle.Controls.Add(this.txtTriSideA);
            this.Triangle.Controls.Add(this.lblTriAns);
            this.Triangle.Controls.Add(this.lblTriSideA);
            this.Triangle.Location = new System.Drawing.Point(4, 29);
            this.Triangle.Name = "Triangle";
            this.Triangle.Padding = new System.Windows.Forms.Padding(3);
            this.Triangle.Size = new System.Drawing.Size(1295, 800);
            this.Triangle.TabIndex = 2;
            this.Triangle.Text = "Triangle";
            this.Triangle.UseVisualStyleBackColor = true;
            // 
            // pctTri
            // 
            this.pctTri.Location = new System.Drawing.Point(0, 550);
            this.pctTri.Name = "pctTri";
            this.pctTri.Size = new System.Drawing.Size(1289, 250);
            this.pctTri.TabIndex = 19;
            this.pctTri.TabStop = false;
            // 
            // txtTriSideB
            // 
            this.txtTriSideB.Location = new System.Drawing.Point(700, 250);
            this.txtTriSideB.Name = "txtTriSideB";
            this.txtTriSideB.Size = new System.Drawing.Size(100, 26);
            this.txtTriSideB.TabIndex = 11;
            // 
            // lblTriSideB
            // 
            this.lblTriSideB.AutoSize = true;
            this.lblTriSideB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTriSideB.Location = new System.Drawing.Point(400, 250);
            this.lblTriSideB.Name = "lblTriSideB";
            this.lblTriSideB.Size = new System.Drawing.Size(106, 32);
            this.lblTriSideB.TabIndex = 10;
            this.lblTriSideB.Text = "Side B:";
            // 
            // txtTriSideC
            // 
            this.txtTriSideC.Location = new System.Drawing.Point(700, 300);
            this.txtTriSideC.Name = "txtTriSideC";
            this.txtTriSideC.Size = new System.Drawing.Size(100, 26);
            this.txtTriSideC.TabIndex = 9;
            // 
            // lblTriSideC
            // 
            this.lblTriSideC.AutoSize = true;
            this.lblTriSideC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTriSideC.Location = new System.Drawing.Point(400, 300);
            this.lblTriSideC.Name = "lblTriSideC";
            this.lblTriSideC.Size = new System.Drawing.Size(107, 32);
            this.lblTriSideC.TabIndex = 8;
            this.lblTriSideC.Text = "Side C:";
            // 
            // btnTriCalc
            // 
            this.btnTriCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTriCalc.Location = new System.Drawing.Point(550, 400);
            this.btnTriCalc.Name = "btnTriCalc";
            this.btnTriCalc.Size = new System.Drawing.Size(200, 50);
            this.btnTriCalc.TabIndex = 7;
            this.btnTriCalc.Text = "Calculate";
            this.btnTriCalc.UseVisualStyleBackColor = true;
            this.btnTriCalc.Click += new System.EventHandler(this.btnTriCalc_Click);
            // 
            // txtTriSideA
            // 
            this.txtTriSideA.Location = new System.Drawing.Point(700, 200);
            this.txtTriSideA.Name = "txtTriSideA";
            this.txtTriSideA.Size = new System.Drawing.Size(100, 26);
            this.txtTriSideA.TabIndex = 6;
            // 
            // lblTriAns
            // 
            this.lblTriAns.AutoSize = true;
            this.lblTriAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTriAns.Location = new System.Drawing.Point(600, 500);
            this.lblTriAns.Name = "lblTriAns";
            this.lblTriAns.Size = new System.Drawing.Size(82, 32);
            this.lblTriAns.TabIndex = 5;
            this.lblTriAns.Text = "Area:";
            // 
            // lblTriSideA
            // 
            this.lblTriSideA.AutoSize = true;
            this.lblTriSideA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTriSideA.Location = new System.Drawing.Point(400, 200);
            this.lblTriSideA.Name = "lblTriSideA";
            this.lblTriSideA.Size = new System.Drawing.Size(106, 32);
            this.lblTriSideA.TabIndex = 4;
            this.lblTriSideA.Text = "Side A:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1611, 977);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.Circle.ResumeLayout(false);
            this.Circle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCirc)).EndInit();
            this.Rectangle.ResumeLayout(false);
            this.Rectangle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctRec)).EndInit();
            this.Triangle.ResumeLayout(false);
            this.Triangle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctTri)).EndInit();
            this.ResumeLayout(false);

        }

        private void txtRadius_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Circle;
        private System.Windows.Forms.TabPage Triangle;
        private System.Windows.Forms.TabPage Rectangle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCircCalc;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Label lblCircAns;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.TextBox txtTriSideB;
        private System.Windows.Forms.Label lblTriSideB;
        private System.Windows.Forms.TextBox txtTriSideC;
        private System.Windows.Forms.Label lblTriSideC;
        private System.Windows.Forms.Button btnTriCalc;
        private System.Windows.Forms.TextBox txtTriSideA;
        private System.Windows.Forms.Label lblTriAns;
        private System.Windows.Forms.Label lblTriSideA;
        private System.Windows.Forms.TextBox txtRecSideB;
        private System.Windows.Forms.Label lblRecSideB;
        private System.Windows.Forms.Button btnRecCalc;
        private System.Windows.Forms.TextBox txtRecSideA;
        private System.Windows.Forms.Label lblRecAns;
        private System.Windows.Forms.Label lblRecSideA;
        private System.Windows.Forms.PictureBox pctRec;
        private System.Windows.Forms.PictureBox pctCirc;
        private System.Windows.Forms.PictureBox pctTri;
    }
}

