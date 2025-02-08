namespace _1_CompGraphEllipse
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
            this.rotating1 = new System.Windows.Forms.NumericUpDown();
            this.rotating2 = new System.Windows.Forms.NumericUpDown();
            this.travelling2 = new System.Windows.Forms.NumericUpDown();
            this.rotating3 = new System.Windows.Forms.NumericUpDown();
            this.travelling3 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rotating1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotating2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelling2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotating3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelling3)).BeginInit();
            this.SuspendLayout();
            // 
            // rotating1
            // 
            this.rotating1.Location = new System.Drawing.Point(745, 12);
            this.rotating1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.rotating1.Name = "rotating1";
            this.rotating1.Size = new System.Drawing.Size(43, 20);
            this.rotating1.TabIndex = 0;
            this.rotating1.ValueChanged += new System.EventHandler(this.rotating1_ValueChanged);
            // 
            // rotating2
            // 
            this.rotating2.Location = new System.Drawing.Point(745, 38);
            this.rotating2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.rotating2.Name = "rotating2";
            this.rotating2.Size = new System.Drawing.Size(43, 20);
            this.rotating2.TabIndex = 1;
            this.rotating2.ValueChanged += new System.EventHandler(this.rotating2_ValueChanged);
            // 
            // travelling2
            // 
            this.travelling2.Location = new System.Drawing.Point(745, 64);
            this.travelling2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.travelling2.Name = "travelling2";
            this.travelling2.Size = new System.Drawing.Size(43, 20);
            this.travelling2.TabIndex = 2;
            this.travelling2.ValueChanged += new System.EventHandler(this.travelling2_ValueChanged);
            // 
            // rotating3
            // 
            this.rotating3.Location = new System.Drawing.Point(745, 90);
            this.rotating3.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.rotating3.Name = "rotating3";
            this.rotating3.Size = new System.Drawing.Size(43, 20);
            this.rotating3.TabIndex = 3;
            this.rotating3.ValueChanged += new System.EventHandler(this.rotating3_ValueChanged);
            // 
            // travelling3
            // 
            this.travelling3.Location = new System.Drawing.Point(745, 116);
            this.travelling3.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.travelling3.Name = "travelling3";
            this.travelling3.Size = new System.Drawing.Size(43, 20);
            this.travelling3.TabIndex = 4;
            this.travelling3.ValueChanged += new System.EventHandler(this.travelling3_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(680, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Поворот 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(680, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Поворот 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(680, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Поворот 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(680, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Путь 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(680, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Путь 3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.travelling3);
            this.Controls.Add(this.rotating3);
            this.Controls.Add(this.travelling2);
            this.Controls.Add(this.rotating2);
            this.Controls.Add(this.rotating1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.rotating1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotating2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelling2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotating3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelling3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown rotating1;
        private System.Windows.Forms.NumericUpDown rotating2;
        private System.Windows.Forms.NumericUpDown travelling2;
        private System.Windows.Forms.NumericUpDown rotating3;
        private System.Windows.Forms.NumericUpDown travelling3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

