namespace WindowsFormsApp6
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Guess01button = new System.Windows.Forms.Button();
            this.guess02button = new System.Windows.Forms.Button();
            this.answerlabel = new System.Windows.Forms.Label();
            this.guess03button = new System.Windows.Forms.Button();
            this.newgamebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Guess01button
            // 
            this.Guess01button.Location = new System.Drawing.Point(36, 92);
            this.Guess01button.Margin = new System.Windows.Forms.Padding(4);
            this.Guess01button.Name = "Guess01button";
            this.Guess01button.Size = new System.Drawing.Size(107, 90);
            this.Guess01button.TabIndex = 0;
            this.Guess01button.Tag = "1";
            this.Guess01button.Text = "01";
            this.Guess01button.UseVisualStyleBackColor = true;
            this.Guess01button.Click += new System.EventHandler(this.Guess01button_Click);
            // 
            // guess02button
            // 
            this.guess02button.Location = new System.Drawing.Point(179, 92);
            this.guess02button.Margin = new System.Windows.Forms.Padding(4);
            this.guess02button.Name = "guess02button";
            this.guess02button.Size = new System.Drawing.Size(107, 90);
            this.guess02button.TabIndex = 1;
            this.guess02button.Tag = "2";
            this.guess02button.Text = "02";
            this.guess02button.UseVisualStyleBackColor = true;
            this.guess02button.Click += new System.EventHandler(this.Guess01button_Click);
            // 
            // answerlabel
            // 
            this.answerlabel.AutoSize = true;
            this.answerlabel.Location = new System.Drawing.Point(282, 249);
            this.answerlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.answerlabel.Name = "answerlabel";
            this.answerlabel.Size = new System.Drawing.Size(59, 16);
            this.answerlabel.TabIndex = 3;
            this.answerlabel.Text = "answer";
            // 
            // guess03button
            // 
            this.guess03button.Location = new System.Drawing.Point(334, 92);
            this.guess03button.Name = "guess03button";
            this.guess03button.Size = new System.Drawing.Size(107, 90);
            this.guess03button.TabIndex = 2;
            this.guess03button.Tag = "3";
            this.guess03button.Text = "03";
            this.guess03button.UseVisualStyleBackColor = true;
            this.guess03button.Click += new System.EventHandler(this.Guess01button_Click);
            // 
            // newgamebutton
            // 
            this.newgamebutton.Location = new System.Drawing.Point(348, 246);
            this.newgamebutton.Name = "newgamebutton";
            this.newgamebutton.Size = new System.Drawing.Size(93, 23);
            this.newgamebutton.TabIndex = 4;
            this.newgamebutton.Text = "再玩一次";
            this.newgamebutton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 321);
            this.Controls.Add(this.newgamebutton);
            this.Controls.Add(this.guess03button);
            this.Controls.Add(this.answerlabel);
            this.Controls.Add(this.guess02button);
            this.Controls.Add(this.Guess01button);
            this.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Guess01button;
        private System.Windows.Forms.Button guess02button;
        private System.Windows.Forms.Label answerlabel;
        private System.Windows.Forms.Button guess03button;
        private System.Windows.Forms.Button newgamebutton;
    }
}

