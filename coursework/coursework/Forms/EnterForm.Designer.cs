namespace coursework
{
    partial class EnterForm
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
            this.Parametr_Label = new System.Windows.Forms.Label();
            this.Enter_TextBox = new System.Windows.Forms.TextBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Parametr_Label
            // 
            this.Parametr_Label.AutoSize = true;
            this.Parametr_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Parametr_Label.Location = new System.Drawing.Point(12, 9);
            this.Parametr_Label.Name = "Parametr_Label";
            this.Parametr_Label.Size = new System.Drawing.Size(228, 31);
            this.Parametr_Label.TabIndex = 0;
            this.Parametr_Label.Text = "Ввод параметра:";
            // 
            // Enter_TextBox
            // 
            this.Enter_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Enter_TextBox.Location = new System.Drawing.Point(12, 99);
            this.Enter_TextBox.Name = "Enter_TextBox";
            this.Enter_TextBox.Size = new System.Drawing.Size(502, 38);
            this.Enter_TextBox.TabIndex = 1;
            // 
            // EnterButton
            // 
            this.EnterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterButton.Location = new System.Drawing.Point(12, 163);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(216, 56);
            this.EnterButton.TabIndex = 2;
            this.EnterButton.Text = "Ввести";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.Location = new System.Drawing.Point(305, 163);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(216, 52);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Отмена";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // EnterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(533, 229);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.Enter_TextBox);
            this.Controls.Add(this.Parametr_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EnterForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно ввода";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Parametr_Label;
        private System.Windows.Forms.TextBox Enter_TextBox;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Button CloseButton;
    }
}