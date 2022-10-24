namespace WindowsFormsApp4
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
            this.nameTexrBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.greetButton = new System.Windows.Forms.Button();
            this.greetinglabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameTexrBox
            // 
            this.nameTexrBox.Location = new System.Drawing.Point(138, 67);
            this.nameTexrBox.Margin = new System.Windows.Forms.Padding(11, 6, 11, 6);
            this.nameTexrBox.Name = "nameTexrBox";
            this.nameTexrBox.Size = new System.Drawing.Size(163, 32);
            this.nameTexrBox.TabIndex = 0;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(33, 70);
            this.label.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(68, 25);
            this.label.TabIndex = 1;
            this.label.Text = "姓名:";
            // 
            // greetButton
            // 
            this.greetButton.Location = new System.Drawing.Point(187, 197);
            this.greetButton.Margin = new System.Windows.Forms.Padding(11, 6, 11, 6);
            this.greetButton.Name = "greetButton";
            this.greetButton.Size = new System.Drawing.Size(114, 35);
            this.greetButton.TabIndex = 2;
            this.greetButton.Text = "greet";
            this.greetButton.UseVisualStyleBackColor = true;
            this.greetButton.Click += new System.EventHandler(this.greetButton_Click);
            // 
            // greetinglabel
            // 
            this.greetinglabel.AutoSize = true;
            this.greetinglabel.Location = new System.Drawing.Point(53, 128);
            this.greetinglabel.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.greetinglabel.Name = "greetinglabel";
            this.greetinglabel.Size = new System.Drawing.Size(35, 25);
            this.greetinglabel.TabIndex = 3;
            this.greetinglabel.Text = "嗨";
            this.greetinglabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(347, 273);
            this.Controls.Add(this.greetinglabel);
            this.Controls.Add(this.greetButton);
            this.Controls.Add(this.label);
            this.Controls.Add(this.nameTexrBox);
            this.Font = new System.Drawing.Font("Engravers MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(11, 6, 11, 6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(367, 316);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "問候";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTexrBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button greetButton;
        private System.Windows.Forms.Label greetinglabel;
    }
}

