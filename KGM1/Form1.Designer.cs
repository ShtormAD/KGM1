namespace KGM1
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
            this.btnPnt = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnRect = new System.Windows.Forms.Button();
            this.btnSqr = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.btnClr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPnt
            // 
            this.btnPnt.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPnt.Location = new System.Drawing.Point(410, 5);
            this.btnPnt.Name = "btnPnt";
            this.btnPnt.Size = new System.Drawing.Size(120, 30);
            this.btnPnt.TabIndex = 0;
            this.btnPnt.Text = "Точка\r\n";
            this.btnPnt.UseVisualStyleBackColor = true;
            this.btnPnt.Click += new System.EventHandler(this.btnPnt_Click);
            // 
            // btnLine
            // 
            this.btnLine.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLine.Location = new System.Drawing.Point(410, 40);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(120, 30);
            this.btnLine.TabIndex = 1;
            this.btnLine.Text = "Линия";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnRect
            // 
            this.btnRect.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRect.Location = new System.Drawing.Point(410, 75);
            this.btnRect.Name = "btnRect";
            this.btnRect.Size = new System.Drawing.Size(120, 30);
            this.btnRect.TabIndex = 2;
            this.btnRect.Text = "Прямоугольник";
            this.btnRect.UseVisualStyleBackColor = true;
            this.btnRect.Click += new System.EventHandler(this.btnRect_Click);
            // 
            // btnSqr
            // 
            this.btnSqr.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSqr.Location = new System.Drawing.Point(410, 110);
            this.btnSqr.Name = "btnSqr";
            this.btnSqr.Size = new System.Drawing.Size(120, 30);
            this.btnSqr.TabIndex = 3;
            this.btnSqr.Text = "Квадрат";
            this.btnSqr.UseVisualStyleBackColor = true;
            this.btnSqr.Click += new System.EventHandler(this.btnSqr_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCircle.Location = new System.Drawing.Point(410, 145);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(120, 30);
            this.btnCircle.TabIndex = 4;
            this.btnCircle.Text = "Круг";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.Color.White;
            this.pb1.Location = new System.Drawing.Point(5, 5);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(400, 400);
            this.pb1.TabIndex = 5;
            this.pb1.TabStop = false;
            // 
            // btnClr
            // 
            this.btnClr.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClr.Location = new System.Drawing.Point(410, 180);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(120, 30);
            this.btnClr.TabIndex = 6;
            this.btnClr.Text = "Очистить";
            this.btnClr.UseVisualStyleBackColor = true;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 411);
            this.Controls.Add(this.btnClr);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.btnCircle);
            this.Controls.Add(this.btnSqr);
            this.Controls.Add(this.btnRect);
            this.Controls.Add(this.btnLine);
            this.Controls.Add(this.btnPnt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Примитивы";
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPnt;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnRect;
        private System.Windows.Forms.Button btnSqr;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Button btnClr;
    }
}

