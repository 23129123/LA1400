namespace LA1400
{
    partial class LA1400
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
            this.buttonRectangle = new System.Windows.Forms.RadioButton();
            this.buttonSquare = new System.Windows.Forms.RadioButton();
            this.buttonTriangle = new System.Windows.Forms.RadioButton();
            this.buttonCircle = new System.Windows.Forms.RadioButton();
            this.buttonArea = new System.Windows.Forms.RadioButton();
            this.buttonPerimeter = new System.Windows.Forms.RadioButton();
            this.buttonAreaPerimeter = new System.Windows.Forms.RadioButton();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.grpShapes = new System.Windows.Forms.GroupBox();
            this.grpAreaPerimeter = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureShape = new System.Windows.Forms.PictureBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.grpShapes.SuspendLayout();
            this.grpAreaPerimeter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureShape)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.AutoSize = true;
            this.buttonRectangle.Checked = true;
            this.buttonRectangle.Location = new System.Drawing.Point(7, 24);
            this.buttonRectangle.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(72, 17);
            this.buttonRectangle.TabIndex = 0;
            this.buttonRectangle.TabStop = true;
            this.buttonRectangle.Text = "Rechteck";
            this.buttonRectangle.UseVisualStyleBackColor = true;
            this.buttonRectangle.CheckedChanged += new System.EventHandler(this.buttonShape_CheckedChanged);
            // 
            // buttonSquare
            // 
            this.buttonSquare.AutoSize = true;
            this.buttonSquare.Location = new System.Drawing.Point(7, 45);
            this.buttonSquare.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Size = new System.Drawing.Size(63, 17);
            this.buttonSquare.TabIndex = 1;
            this.buttonSquare.Text = "Quadrat";
            this.buttonSquare.UseVisualStyleBackColor = true;
            this.buttonSquare.CheckedChanged += new System.EventHandler(this.buttonShape_CheckedChanged);
            // 
            // buttonTriangle
            // 
            this.buttonTriangle.AutoSize = true;
            this.buttonTriangle.Location = new System.Drawing.Point(7, 65);
            this.buttonTriangle.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTriangle.Name = "buttonTriangle";
            this.buttonTriangle.Size = new System.Drawing.Size(62, 17);
            this.buttonTriangle.TabIndex = 4;
            this.buttonTriangle.Text = "Dreieck";
            this.buttonTriangle.UseVisualStyleBackColor = true;
            this.buttonTriangle.CheckedChanged += new System.EventHandler(this.buttonShape_CheckedChanged);
            // 
            // buttonCircle
            // 
            this.buttonCircle.AutoSize = true;
            this.buttonCircle.Location = new System.Drawing.Point(7, 84);
            this.buttonCircle.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(48, 17);
            this.buttonCircle.TabIndex = 6;
            this.buttonCircle.Text = "Kreis";
            this.buttonCircle.UseVisualStyleBackColor = true;
            this.buttonCircle.CheckedChanged += new System.EventHandler(this.buttonShape_CheckedChanged);
            // 
            // buttonArea
            // 
            this.buttonArea.AutoSize = true;
            this.buttonArea.Checked = true;
            this.buttonArea.Location = new System.Drawing.Point(4, 17);
            this.buttonArea.Margin = new System.Windows.Forms.Padding(2);
            this.buttonArea.Name = "buttonArea";
            this.buttonArea.Size = new System.Drawing.Size(57, 17);
            this.buttonArea.TabIndex = 0;
            this.buttonArea.TabStop = true;
            this.buttonArea.Text = "Fläche";
            this.buttonArea.UseVisualStyleBackColor = true;
            this.buttonArea.CheckedChanged += new System.EventHandler(this.buttonArea_CheckedChanged);
            // 
            // buttonPerimeter
            // 
            this.buttonPerimeter.AutoSize = true;
            this.buttonPerimeter.Location = new System.Drawing.Point(74, 17);
            this.buttonPerimeter.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPerimeter.Name = "buttonPerimeter";
            this.buttonPerimeter.Size = new System.Drawing.Size(62, 17);
            this.buttonPerimeter.TabIndex = 1;
            this.buttonPerimeter.Text = "Umfang";
            this.buttonPerimeter.UseVisualStyleBackColor = true;
            this.buttonPerimeter.CheckedChanged += new System.EventHandler(this.buttonPerimeter_CheckedChanged);
            // 
            // buttonAreaPerimeter
            // 
            this.buttonAreaPerimeter.AutoSize = true;
            this.buttonAreaPerimeter.Location = new System.Drawing.Point(159, 17);
            this.buttonAreaPerimeter.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAreaPerimeter.Name = "buttonAreaPerimeter";
            this.buttonAreaPerimeter.Size = new System.Drawing.Size(118, 17);
            this.buttonAreaPerimeter.TabIndex = 2;
            this.buttonAreaPerimeter.Text = "Fläche und Umfang";
            this.buttonAreaPerimeter.UseVisualStyleBackColor = true;
            this.buttonAreaPerimeter.CheckedChanged += new System.EventHandler(this.buttonAreaPerimeter_CheckedChanged);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(5, 252);
            this.buttonCalculate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(74, 23);
            this.buttonCalculate.TabIndex = 15;
            this.buttonCalculate.Text = "Bestätigen";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.calculatorButton_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(217, 252);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(74, 23);
            this.buttonClear.TabIndex = 0;
            this.buttonClear.Text = "Löschen";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 11);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(46, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(148, 35);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(46, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(148, 59);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(46, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(148, 83);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(46, 20);
            this.textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(148, 111);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(46, 20);
            this.textBox5.TabIndex = 14;
            // 
            // grpShapes
            // 
            this.grpShapes.Controls.Add(this.buttonRectangle);
            this.grpShapes.Controls.Add(this.buttonSquare);
            this.grpShapes.Controls.Add(this.buttonTriangle);
            this.grpShapes.Controls.Add(this.buttonCircle);
            this.grpShapes.Location = new System.Drawing.Point(9, 5);
            this.grpShapes.Margin = new System.Windows.Forms.Padding(2);
            this.grpShapes.Name = "grpShapes";
            this.grpShapes.Padding = new System.Windows.Forms.Padding(2);
            this.grpShapes.Size = new System.Drawing.Size(122, 163);
            this.grpShapes.TabIndex = 1;
            this.grpShapes.TabStop = false;
            this.grpShapes.Text = "Form:";
            // 
            // grpAreaPerimeter
            // 
            this.grpAreaPerimeter.Controls.Add(this.buttonPerimeter);
            this.grpAreaPerimeter.Controls.Add(this.buttonArea);
            this.grpAreaPerimeter.Controls.Add(this.buttonAreaPerimeter);
            this.grpAreaPerimeter.Location = new System.Drawing.Point(9, 172);
            this.grpAreaPerimeter.Margin = new System.Windows.Forms.Padding(2);
            this.grpAreaPerimeter.Name = "grpAreaPerimeter";
            this.grpAreaPerimeter.Padding = new System.Windows.Forms.Padding(2);
            this.grpAreaPerimeter.Size = new System.Drawing.Size(282, 76);
            this.grpAreaPerimeter.TabIndex = 2;
            this.grpAreaPerimeter.TabStop = false;
            this.grpAreaPerimeter.Text = "Rechnung:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // pictureShape
            // 
            this.pictureShape.Location = new System.Drawing.Point(302, 5);
            this.pictureShape.Name = "pictureShape";
            this.pictureShape.Size = new System.Drawing.Size(175, 119);
            this.pictureShape.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureShape.TabIndex = 21;
            this.pictureShape.TabStop = false;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(299, 134);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 13);
            this.labelResult.TabIndex = 23;
            // 
            // LA1400
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 440);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.pictureShape);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpAreaPerimeter);
            this.Controls.Add(this.grpShapes);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCalculate);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LA1400";
            this.Text = "LA1400";
            this.Load += new System.EventHandler(this.LA1400_Load);
            this.grpShapes.ResumeLayout(false);
            this.grpShapes.PerformLayout();
            this.grpAreaPerimeter.ResumeLayout(false);
            this.grpAreaPerimeter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureShape)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton buttonRectangle;
        private System.Windows.Forms.RadioButton buttonSquare;
        private System.Windows.Forms.RadioButton buttonTriangle;
        private System.Windows.Forms.RadioButton buttonCircle;
        private System.Windows.Forms.RadioButton buttonArea;
        private System.Windows.Forms.RadioButton buttonPerimeter;
        private System.Windows.Forms.RadioButton buttonAreaPerimeter;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox grpShapes;
        private System.Windows.Forms.GroupBox grpAreaPerimeter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureShape;
        private System.Windows.Forms.Label labelResult;
    }
}

