namespace coursework.Forms
{
    partial class DisplayMatrix
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
            this.CalculatedMatrix_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CalculatedMatrix_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CalculatedMatrix_dataGridView
            // 
            this.CalculatedMatrix_dataGridView.AllowUserToAddRows = false;
            this.CalculatedMatrix_dataGridView.AllowUserToDeleteRows = false;
            this.CalculatedMatrix_dataGridView.AllowUserToResizeColumns = false;
            this.CalculatedMatrix_dataGridView.AllowUserToResizeRows = false;
            this.CalculatedMatrix_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CalculatedMatrix_dataGridView.Location = new System.Drawing.Point(13, 13);
            this.CalculatedMatrix_dataGridView.Name = "CalculatedMatrix_dataGridView";
            this.CalculatedMatrix_dataGridView.ReadOnly = true;
            this.CalculatedMatrix_dataGridView.RowHeadersVisible = false;
            this.CalculatedMatrix_dataGridView.RowHeadersWidth = 82;
            this.CalculatedMatrix_dataGridView.RowTemplate.Height = 33;
            this.CalculatedMatrix_dataGridView.Size = new System.Drawing.Size(775, 425);
            this.CalculatedMatrix_dataGridView.TabIndex = 0;
            // 
            // DisplayMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CalculatedMatrix_dataGridView);
            this.MaximizeBox = false;
            this.Name = "DisplayMatrix";
            this.ShowIcon = false;
            this.Text = "DisplayMatrix";
            this.Load += new System.EventHandler(this.DisplayMatrix_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CalculatedMatrix_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CalculatedMatrix_dataGridView;
    }
}