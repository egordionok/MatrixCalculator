namespace MatrixCalculator
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
            this.lhsMatrixBox = new System.Windows.Forms.TextBox();
            this.SumButton = new System.Windows.Forms.Button();
            this.SubButton = new System.Windows.Forms.Button();
            this.MultButton = new System.Windows.Forms.Button();
            this.TransButton = new System.Windows.Forms.Button();
            this.rhsMatrixBox = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.ForwardButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lhsMatrixBox
            // 
            this.lhsMatrixBox.Location = new System.Drawing.Point(12, 62);
            this.lhsMatrixBox.Multiline = true;
            this.lhsMatrixBox.Name = "lhsMatrixBox";
            this.lhsMatrixBox.Size = new System.Drawing.Size(230, 206);
            this.lhsMatrixBox.TabIndex = 0;
            this.lhsMatrixBox.Text = "1 1 1\r\n1 1 1\r\n1 1 1\r\n";
            // 
            // SumButton
            // 
            this.SumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumButton.Location = new System.Drawing.Point(261, 62);
            this.SumButton.Name = "SumButton";
            this.SumButton.Size = new System.Drawing.Size(75, 47);
            this.SumButton.TabIndex = 3;
            this.SumButton.Text = "+";
            this.SumButton.UseVisualStyleBackColor = true;
            this.SumButton.Click += new System.EventHandler(this.SumButton_Click);
            // 
            // SubButton
            // 
            this.SubButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubButton.Location = new System.Drawing.Point(261, 115);
            this.SubButton.Name = "SubButton";
            this.SubButton.Size = new System.Drawing.Size(75, 47);
            this.SubButton.TabIndex = 4;
            this.SubButton.Text = "-";
            this.SubButton.UseVisualStyleBackColor = true;
            this.SubButton.Click += new System.EventHandler(this.SubButton_Click);
            // 
            // MultButton
            // 
            this.MultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MultButton.Location = new System.Drawing.Point(261, 168);
            this.MultButton.Name = "MultButton";
            this.MultButton.Size = new System.Drawing.Size(75, 47);
            this.MultButton.TabIndex = 5;
            this.MultButton.Text = "*";
            this.MultButton.UseVisualStyleBackColor = true;
            this.MultButton.Click += new System.EventHandler(this.MultButton_Click);
            // 
            // TransButton
            // 
            this.TransButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransButton.Location = new System.Drawing.Point(261, 221);
            this.TransButton.Name = "TransButton";
            this.TransButton.Size = new System.Drawing.Size(75, 47);
            this.TransButton.TabIndex = 6;
            this.TransButton.Text = "T";
            this.TransButton.UseVisualStyleBackColor = true;
            this.TransButton.Click += new System.EventHandler(this.TransButton_Click);
            // 
            // rhsMatrixBox
            // 
            this.rhsMatrixBox.Location = new System.Drawing.Point(342, 62);
            this.rhsMatrixBox.Multiline = true;
            this.rhsMatrixBox.Name = "rhsMatrixBox";
            this.rhsMatrixBox.Size = new System.Drawing.Size(230, 206);
            this.rhsMatrixBox.TabIndex = 1;
            this.rhsMatrixBox.Text = "1 1 1\r\n1 1 1\r\n1 1 1";
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(222, 274);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 47);
            this.BackButton.TabIndex = 8;
            this.BackButton.Text = "<";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ChangeButton
            // 
            this.ChangeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeButton.Location = new System.Drawing.Point(261, 332);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(75, 47);
            this.ChangeButton.TabIndex = 9;
            this.ChangeButton.Text = "<>";
            this.ChangeButton.UseVisualStyleBackColor = false;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // ForwardButton
            // 
            this.ForwardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForwardButton.Location = new System.Drawing.Point(303, 274);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(75, 47);
            this.ForwardButton.TabIndex = 10;
            this.ForwardButton.Text = ">";
            this.ForwardButton.UseVisualStyleBackColor = false;
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 391);
            this.Controls.Add(this.ForwardButton);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.TransButton);
            this.Controls.Add(this.MultButton);
            this.Controls.Add(this.SubButton);
            this.Controls.Add(this.SumButton);
            this.Controls.Add(this.rhsMatrixBox);
            this.Controls.Add(this.lhsMatrixBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lhsMatrixBox;
        private System.Windows.Forms.Button SumButton;
        private System.Windows.Forms.Button SubButton;
        private System.Windows.Forms.Button MultButton;
        private System.Windows.Forms.Button TransButton;
        private System.Windows.Forms.TextBox rhsMatrixBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Button ForwardButton;
    }
}

