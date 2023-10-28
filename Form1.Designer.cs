namespace Triangles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.resultButton = new System.Windows.Forms.Button();
            this.resultLable = new System.Windows.Forms.Label();
            this.oneBox = new System.Windows.Forms.TextBox();
            this.twoBox = new System.Windows.Forms.TextBox();
            this.threeBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultButton
            // 
            this.resultButton.BackColor = System.Drawing.Color.Thistle;
            this.resultButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resultButton.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultButton.ForeColor = System.Drawing.Color.Indigo;
            this.resultButton.Location = new System.Drawing.Point(283, 358);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(221, 53);
            this.resultButton.TabIndex = 0;
            this.resultButton.Text = "Проверить";
            this.resultButton.UseVisualStyleBackColor = false;
            this.resultButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultLable
            // 
            this.resultLable.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLable.ForeColor = System.Drawing.Color.Indigo;
            this.resultLable.Image = ((System.Drawing.Image)(resources.GetObject("resultLable.Image")));
            this.resultLable.Location = new System.Drawing.Point(45, 291);
            this.resultLable.Name = "resultLable";
            this.resultLable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.resultLable.Size = new System.Drawing.Size(700, 30);
            this.resultLable.TabIndex = 1;
            this.resultLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oneBox
            // 
            this.oneBox.BackColor = System.Drawing.Color.Thistle;
            this.oneBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oneBox.Location = new System.Drawing.Point(74, 200);
            this.oneBox.Name = "oneBox";
            this.oneBox.Size = new System.Drawing.Size(140, 22);
            this.oneBox.TabIndex = 2;
            this.oneBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // twoBox
            // 
            this.twoBox.BackColor = System.Drawing.Color.Thistle;
            this.twoBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.twoBox.Location = new System.Drawing.Point(327, 200);
            this.twoBox.Name = "twoBox";
            this.twoBox.Size = new System.Drawing.Size(140, 22);
            this.twoBox.TabIndex = 3;
            this.twoBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // threeBox
            // 
            this.threeBox.BackColor = System.Drawing.Color.Thistle;
            this.threeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.threeBox.Location = new System.Drawing.Point(586, 200);
            this.threeBox.Name = "threeBox";
            this.threeBox.Size = new System.Drawing.Size(140, 22);
            this.threeBox.TabIndex = 4;
            this.threeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(127, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(558, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введите длины сторон треугольника";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.threeBox);
            this.Controls.Add(this.twoBox);
            this.Controls.Add(this.oneBox);
            this.Controls.Add(this.resultLable);
            this.Controls.Add(this.resultButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "треугольники";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resultButton;
        private System.Windows.Forms.Label resultLable;
        private System.Windows.Forms.TextBox oneBox;
        private System.Windows.Forms.TextBox twoBox;
        private System.Windows.Forms.TextBox threeBox;
        private System.Windows.Forms.Label label2;
    }
}

