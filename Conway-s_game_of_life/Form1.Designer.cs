namespace Conway_s_game_of_life
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tbSaveLoad = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ndWidth = new System.Windows.Forms.NumericUpDown();
            this.ndHeight = new System.Windows.Forms.NumericUpDown();
            this.cbBordered = new System.Windows.Forms.CheckBox();
            this.lGenCounter = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbSelecting = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lSelectedBrush = new System.Windows.Forms.Label();
            this.tbBrushSaveLoad = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.bLoadTxt = new System.Windows.Forms.Button();
            this.tbLoadTxt = new System.Windows.Forms.TextBox();
            this.bTurnLeft = new System.Windows.Forms.Button();
            this.bTurnRight = new System.Windows.Forms.Button();
            this.bMirrorHorizontal = new System.Windows.Forms.Button();
            this.bMirrorVertical = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.bMirrorVertical);
            this.splitContainer1.Panel1.Controls.Add(this.bMirrorHorizontal);
            this.splitContainer1.Panel1.Controls.Add(this.bTurnRight);
            this.splitContainer1.Panel1.Controls.Add(this.bTurnLeft);
            this.splitContainer1.Panel1.Controls.Add(this.tbLoadTxt);
            this.splitContainer1.Panel1.Controls.Add(this.bLoadTxt);
            this.splitContainer1.Panel1.Controls.Add(this.tbBrushSaveLoad);
            this.splitContainer1.Panel1.Controls.Add(this.button8);
            this.splitContainer1.Panel1.Controls.Add(this.button9);
            this.splitContainer1.Panel1.Controls.Add(this.lSelectedBrush);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel1.Controls.Add(this.cbSelecting);
            this.splitContainer1.Panel1.Controls.Add(this.tbSaveLoad);
            this.splitContainer1.Panel1.Controls.Add(this.button7);
            this.splitContainer1.Panel1.Controls.Add(this.button6);
            this.splitContainer1.Panel1.Controls.Add(this.button5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.ndWidth);
            this.splitContainer1.Panel1.Controls.Add(this.ndHeight);
            this.splitContainer1.Panel1.Controls.Add(this.cbBordered);
            this.splitContainer1.Panel1.Controls.Add(this.lGenCounter);
            this.splitContainer1.Panel1.Controls.Add(this.button4);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.numericUpDown2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.numericUpDown1);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.bStart);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1042, 507);
            this.splitContainer1.SplitterDistance = 261;
            this.splitContainer1.TabIndex = 0;
            // 
            // tbSaveLoad
            // 
            this.tbSaveLoad.Location = new System.Drawing.Point(154, 451);
            this.tbSaveLoad.Name = "tbSaveLoad";
            this.tbSaveLoad.Size = new System.Drawing.Size(100, 20);
            this.tbSaveLoad.TabIndex = 19;
            this.tbSaveLoad.Text = "qwicksave.w";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(164, 158);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 18;
            this.button7.Text = "Get Brush";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(154, 478);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(45, 23);
            this.button6.TabIndex = 17;
            this.button6.Text = "load";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(209, 478);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "save";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Height";
            // 
            // ndWidth
            // 
            this.ndWidth.Location = new System.Drawing.Point(10, 169);
            this.ndWidth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ndWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ndWidth.Name = "ndWidth";
            this.ndWidth.Size = new System.Drawing.Size(120, 20);
            this.ndWidth.TabIndex = 13;
            this.ndWidth.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // ndHeight
            // 
            this.ndHeight.Location = new System.Drawing.Point(10, 135);
            this.ndHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ndHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ndHeight.Name = "ndHeight";
            this.ndHeight.Size = new System.Drawing.Size(120, 20);
            this.ndHeight.TabIndex = 12;
            this.ndHeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // cbBordered
            // 
            this.cbBordered.AutoSize = true;
            this.cbBordered.Checked = true;
            this.cbBordered.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBordered.Location = new System.Drawing.Point(13, 99);
            this.cbBordered.Name = "cbBordered";
            this.cbBordered.Size = new System.Drawing.Size(69, 17);
            this.cbBordered.TabIndex = 11;
            this.cbBordered.Text = "Bordered";
            this.cbBordered.UseVisualStyleBackColor = true;
            // 
            // lGenCounter
            // 
            this.lGenCounter.AutoSize = true;
            this.lGenCounter.Location = new System.Drawing.Point(13, 253);
            this.lGenCounter.Name = "lGenCounter";
            this.lGenCounter.Size = new System.Drawing.Size(65, 13);
            this.lGenCounter.TabIndex = 10;
            this.lGenCounter.Text = "Generation: ";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 281);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 339);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Reload position";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Density";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(11, 72);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 6;
            this.numericUpDown2.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Resolution";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(11, 24);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Step";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Reload";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(13, 198);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(75, 23);
            this.bStart.TabIndex = 0;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(773, 503);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cbSelecting
            // 
            this.cbSelecting.AutoSize = true;
            this.cbSelecting.Location = new System.Drawing.Point(169, 209);
            this.cbSelecting.Name = "cbSelecting";
            this.cbSelecting.Size = new System.Drawing.Size(70, 17);
            this.cbSelecting.TabIndex = 20;
            this.cbSelecting.Text = "Selecting";
            this.cbSelecting.UseVisualStyleBackColor = true;
            this.cbSelecting.CheckedChanged += new System.EventHandler(this.cbSelecting_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(159, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 76);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // lSelectedBrush
            // 
            this.lSelectedBrush.AutoSize = true;
            this.lSelectedBrush.Location = new System.Drawing.Point(159, 8);
            this.lSelectedBrush.Name = "lSelectedBrush";
            this.lSelectedBrush.Size = new System.Drawing.Size(80, 26);
            this.lSelectedBrush.TabIndex = 22;
            this.lSelectedBrush.Text = "Selected brush\r\n\"Default brush\"";
            // 
            // tbBrushSaveLoad
            // 
            this.tbBrushSaveLoad.Location = new System.Drawing.Point(154, 227);
            this.tbBrushSaveLoad.Name = "tbBrushSaveLoad";
            this.tbBrushSaveLoad.Size = new System.Drawing.Size(100, 20);
            this.tbBrushSaveLoad.TabIndex = 25;
            this.tbBrushSaveLoad.Text = "brush1.w";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(154, 254);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(45, 23);
            this.button8.TabIndex = 24;
            this.button8.Text = "load";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(209, 254);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(45, 23);
            this.button9.TabIndex = 23;
            this.button9.Text = "save";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // bLoadTxt
            // 
            this.bLoadTxt.Location = new System.Drawing.Point(3, 478);
            this.bLoadTxt.Name = "bLoadTxt";
            this.bLoadTxt.Size = new System.Drawing.Size(49, 23);
            this.bLoadTxt.TabIndex = 26;
            this.bLoadTxt.Text = "load txt";
            this.bLoadTxt.UseVisualStyleBackColor = true;
            this.bLoadTxt.Click += new System.EventHandler(this.bLoadTxt_Click);
            // 
            // tbLoadTxt
            // 
            this.tbLoadTxt.Location = new System.Drawing.Point(3, 452);
            this.tbLoadTxt.Name = "tbLoadTxt";
            this.tbLoadTxt.Size = new System.Drawing.Size(100, 20);
            this.tbLoadTxt.TabIndex = 27;
            // 
            // bTurnLeft
            // 
            this.bTurnLeft.Location = new System.Drawing.Point(154, 115);
            this.bTurnLeft.Name = "bTurnLeft";
            this.bTurnLeft.Size = new System.Drawing.Size(23, 23);
            this.bTurnLeft.TabIndex = 28;
            this.bTurnLeft.Text = "⟲";
            this.bTurnLeft.UseVisualStyleBackColor = true;
            this.bTurnLeft.Click += new System.EventHandler(this.bTurnLeft_Click);
            // 
            // bTurnRight
            // 
            this.bTurnRight.Location = new System.Drawing.Point(223, 115);
            this.bTurnRight.Name = "bTurnRight";
            this.bTurnRight.Size = new System.Drawing.Size(23, 23);
            this.bTurnRight.TabIndex = 29;
            this.bTurnRight.Text = "⟳";
            this.bTurnRight.UseVisualStyleBackColor = true;
            this.bTurnRight.Click += new System.EventHandler(this.bTurnRight_Click);
            // 
            // bMirrorHorizontal
            // 
            this.bMirrorHorizontal.Location = new System.Drawing.Point(177, 115);
            this.bMirrorHorizontal.Name = "bMirrorHorizontal";
            this.bMirrorHorizontal.Size = new System.Drawing.Size(23, 23);
            this.bMirrorHorizontal.TabIndex = 30;
            this.bMirrorHorizontal.Text = "↔";
            this.bMirrorHorizontal.UseVisualStyleBackColor = true;
            this.bMirrorHorizontal.Click += new System.EventHandler(this.bMirrorHorizontal_Click);
            // 
            // bMirrorVertical
            // 
            this.bMirrorVertical.Location = new System.Drawing.Point(200, 115);
            this.bMirrorVertical.Name = "bMirrorVertical";
            this.bMirrorVertical.Size = new System.Drawing.Size(23, 23);
            this.bMirrorVertical.TabIndex = 31;
            this.bMirrorVertical.Text = "↕";
            this.bMirrorVertical.UseVisualStyleBackColor = true;
            this.bMirrorVertical.Click += new System.EventHandler(this.bMirrorVertical_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 507);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Conway\'s game of life";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ndWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lGenCounter;
        private System.Windows.Forms.CheckBox cbBordered;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown ndWidth;
        private System.Windows.Forms.NumericUpDown ndHeight;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox tbSaveLoad;
        private System.Windows.Forms.CheckBox cbSelecting;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lSelectedBrush;
        private System.Windows.Forms.TextBox tbBrushSaveLoad;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox tbLoadTxt;
        private System.Windows.Forms.Button bLoadTxt;
        private System.Windows.Forms.Button bMirrorVertical;
        private System.Windows.Forms.Button bMirrorHorizontal;
        private System.Windows.Forms.Button bTurnRight;
        private System.Windows.Forms.Button bTurnLeft;
    }
}

