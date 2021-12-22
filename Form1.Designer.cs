namespace lab_01_Fedorova02
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
            this.cbChooseFigure = new System.Windows.Forms.ComboBox();
            this.bAddFig = new System.Windows.Forms.Button();
            this.lblChoseFig = new System.Windows.Forms.Label();
            this.bDelFig = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbFigs = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbChooseFigure
            // 
            this.cbChooseFigure.FormattingEnabled = true;
            this.cbChooseFigure.Items.AddRange(new object[] {
            "Circle",
            "Square",
            "Triangle"});
            this.cbChooseFigure.Location = new System.Drawing.Point(107, 10);
            this.cbChooseFigure.Name = "cbChooseFigure";
            this.cbChooseFigure.Size = new System.Drawing.Size(75, 21);
            this.cbChooseFigure.TabIndex = 0;
            // 
            // bAddFig
            // 
            this.bAddFig.Location = new System.Drawing.Point(107, 37);
            this.bAddFig.Name = "bAddFig";
            this.bAddFig.Size = new System.Drawing.Size(75, 23);
            this.bAddFig.TabIndex = 1;
            this.bAddFig.Text = "Добавить";
            this.bAddFig.UseVisualStyleBackColor = true;
            this.bAddFig.Click += new System.EventHandler(this.bAddFig_Click);
            // 
            // lblChoseFig
            // 
            this.lblChoseFig.AutoSize = true;
            this.lblChoseFig.Location = new System.Drawing.Point(12, 13);
            this.lblChoseFig.Name = "lblChoseFig";
            this.lblChoseFig.Size = new System.Drawing.Size(89, 13);
            this.lblChoseFig.TabIndex = 2;
            this.lblChoseFig.Text = "Выбрать фигуру";
            // 
            // bDelFig
            // 
            this.bDelFig.Location = new System.Drawing.Point(107, 66);
            this.bDelFig.Name = "bDelFig";
            this.bDelFig.Size = new System.Drawing.Size(75, 23);
            this.bDelFig.TabIndex = 3;
            this.bDelFig.Text = "Удалить";
            this.bDelFig.UseVisualStyleBackColor = true;
            this.bDelFig.Click += new System.EventHandler(this.bDelFig_Click);
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.White;
            this.picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture.Location = new System.Drawing.Point(0, 97);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(434, 327);
            this.picture.TabIndex = 4;
            this.picture.TabStop = false;
            this.picture.Paint += new System.Windows.Forms.PaintEventHandler(this.picture_Paint);
            this.picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picture_MouseDown);
            this.picture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picture_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbFigs);
            this.panel1.Controls.Add(this.bAddFig);
            this.panel1.Controls.Add(this.bDelFig);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 97);
            this.panel1.TabIndex = 5;
            // 
            // lbFigs
            // 
            this.lbFigs.FormattingEnabled = true;
            this.lbFigs.HorizontalScrollbar = true;
            this.lbFigs.Location = new System.Drawing.Point(198, 10);
            this.lbFigs.Name = "lbFigs";
            this.lbFigs.ScrollAlwaysVisible = true;
            this.lbFigs.Size = new System.Drawing.Size(225, 82);
            this.lbFigs.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 424);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.lblChoseFig);
            this.Controls.Add(this.cbChooseFigure);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Рисование фигур";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbChooseFigure;
        private System.Windows.Forms.Button bAddFig;
        private System.Windows.Forms.Label lblChoseFig;
        private System.Windows.Forms.Button bDelFig;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbFigs;
    }
}

