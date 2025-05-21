namespace coursework
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.ExitButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.WordMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExcelMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.PowerPointMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Matrix_DataGridView = new System.Windows.Forms.DataGridView();
            this.indexColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClearButton = new System.Windows.Forms.Button();
            this.MainLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.NumberMatrix_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportToWord_ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportToExcel_ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Calculate_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit_ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpFile_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Presentation_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgram_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дкмонстрацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DefinedSystem_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IndefiniteSystem_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MatrixSize_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EnterMatrix_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Graph_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeColor_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BaseColor_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вычисленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MatrixDeterminant_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InverseMatrix_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MatrixTransporation_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Result_ListBox = new System.Windows.Forms.ListBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Matrix_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberMatrix_NumericUpDown)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Location = new System.Drawing.Point(1014, 566);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(181, 75);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WordMenu,
            this.ExcelMenu,
            this.PowerPointMenu,
            this.HelpMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 42);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1207, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // WordMenu
            // 
            this.WordMenu.Image = global::coursework.Properties.Resources.WordIcon;
            this.WordMenu.Name = "WordMenu";
            this.WordMenu.Size = new System.Drawing.Size(52, 36);
            this.WordMenu.Click += new System.EventHandler(this.ReportToWord_ToolStripMenuItem1_Click);
            // 
            // ExcelMenu
            // 
            this.ExcelMenu.Image = global::coursework.Properties.Resources.ExcelIcon;
            this.ExcelMenu.Name = "ExcelMenu";
            this.ExcelMenu.Size = new System.Drawing.Size(52, 36);
            this.ExcelMenu.Click += new System.EventHandler(this.ReportToExcel_ToolStripMenuItem1_Click);
            // 
            // PowerPointMenu
            // 
            this.PowerPointMenu.Image = global::coursework.Properties.Resources.PowerPointIcon;
            this.PowerPointMenu.Name = "PowerPointMenu";
            this.PowerPointMenu.Size = new System.Drawing.Size(52, 36);
            this.PowerPointMenu.Click += new System.EventHandler(this.Presentation_ToolStripMenuItem_Click);
            // 
            // HelpMenu
            // 
            this.HelpMenu.Image = global::coursework.Properties.Resources.HelpIcon;
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(52, 36);
            this.HelpMenu.Click += new System.EventHandler(this.HelpFile_ToolStripMenuItem_Click);
            // 
            // Matrix_DataGridView
            // 
            this.Matrix_DataGridView.AllowUserToAddRows = false;
            this.Matrix_DataGridView.AllowUserToDeleteRows = false;
            this.Matrix_DataGridView.AllowUserToResizeColumns = false;
            this.Matrix_DataGridView.AllowUserToResizeRows = false;
            this.Matrix_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Matrix_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.indexColumn});
            this.Matrix_DataGridView.Location = new System.Drawing.Point(12, 250);
            this.Matrix_DataGridView.Name = "Matrix_DataGridView";
            this.Matrix_DataGridView.RowHeadersVisible = false;
            this.Matrix_DataGridView.RowHeadersWidth = 82;
            this.Matrix_DataGridView.RowTemplate.Height = 33;
            this.Matrix_DataGridView.Size = new System.Drawing.Size(654, 306);
            this.Matrix_DataGridView.TabIndex = 2;
            // 
            // indexColumn
            // 
            this.indexColumn.HeaderText = "";
            this.indexColumn.MinimumWidth = 10;
            this.indexColumn.Name = "indexColumn";
            this.indexColumn.Width = 70;
            // 
            // ClearButton
            // 
            this.ClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearButton.Location = new System.Drawing.Point(12, 562);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(216, 83);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(130)))), ((int)(((byte)(6)))));
            this.MainLabel.Location = new System.Drawing.Point(0, 133);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(498, 51);
            this.MainLabel.TabIndex = 8;
            this.MainLabel.Text = "Метод Жордана-Гаусса";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(2, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(518, 37);
            this.label2.TabIndex = 9;
            this.label2.Text = "Выберите количество неизвестных ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(761, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 37);
            this.label3.TabIndex = 10;
            this.label3.Text = "Результат:";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CalculateButton.Location = new System.Drawing.Point(234, 562);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(432, 83);
            this.CalculateButton.TabIndex = 12;
            this.CalculateButton.Text = "Рассчитать";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // NumberMatrix_NumericUpDown
            // 
            this.NumberMatrix_NumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberMatrix_NumericUpDown.Location = new System.Drawing.Point(570, 197);
            this.NumberMatrix_NumericUpDown.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.NumberMatrix_NumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumberMatrix_NumericUpDown.Name = "NumberMatrix_NumericUpDown";
            this.NumberMatrix_NumericUpDown.Size = new System.Drawing.Size(96, 38);
            this.NumberMatrix_NumericUpDown.TabIndex = 14;
            this.NumberMatrix_NumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumberMatrix_NumericUpDown.ValueChanged += new System.EventHandler(this.NumberMatrix_NumericUpDown_ValueChanged);
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem1,
            this.помощьToolStripMenuItem1,
            this.параметрыToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.вычисленияToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1207, 42);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // файлToolStripMenuItem1
            // 
            this.файлToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчётToolStripMenuItem1,
            this.Calculate_ToolStripMenuItem,
            this.Exit_ToolStripMenuItem1});
            this.файлToolStripMenuItem1.Name = "файлToolStripMenuItem1";
            this.файлToolStripMenuItem1.Size = new System.Drawing.Size(90, 38);
            this.файлToolStripMenuItem1.Text = "Файл";
            // 
            // отчётToolStripMenuItem1
            // 
            this.отчётToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReportToWord_ToolStripMenuItem1,
            this.ReportToExcel_ToolStripMenuItem1});
            this.отчётToolStripMenuItem1.Name = "отчётToolStripMenuItem1";
            this.отчётToolStripMenuItem1.Size = new System.Drawing.Size(359, 44);
            this.отчётToolStripMenuItem1.Text = "Отчёт";
            // 
            // ReportToWord_ToolStripMenuItem1
            // 
            this.ReportToWord_ToolStripMenuItem1.Name = "ReportToWord_ToolStripMenuItem1";
            this.ReportToWord_ToolStripMenuItem1.Size = new System.Drawing.Size(204, 44);
            this.ReportToWord_ToolStripMenuItem1.Text = "Word";
            this.ReportToWord_ToolStripMenuItem1.Click += new System.EventHandler(this.ReportToWord_ToolStripMenuItem1_Click);
            // 
            // ReportToExcel_ToolStripMenuItem1
            // 
            this.ReportToExcel_ToolStripMenuItem1.Name = "ReportToExcel_ToolStripMenuItem1";
            this.ReportToExcel_ToolStripMenuItem1.Size = new System.Drawing.Size(204, 44);
            this.ReportToExcel_ToolStripMenuItem1.Text = "Excel";
            this.ReportToExcel_ToolStripMenuItem1.Click += new System.EventHandler(this.ReportToExcel_ToolStripMenuItem1_Click);
            // 
            // Calculate_ToolStripMenuItem
            // 
            this.Calculate_ToolStripMenuItem.Name = "Calculate_ToolStripMenuItem";
            this.Calculate_ToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.Calculate_ToolStripMenuItem.Text = "Рассчитать";
            this.Calculate_ToolStripMenuItem.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // Exit_ToolStripMenuItem1
            // 
            this.Exit_ToolStripMenuItem1.Name = "Exit_ToolStripMenuItem1";
            this.Exit_ToolStripMenuItem1.Size = new System.Drawing.Size(359, 44);
            this.Exit_ToolStripMenuItem1.Text = "Выход";
            this.Exit_ToolStripMenuItem1.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // помощьToolStripMenuItem1
            // 
            this.помощьToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpFile_ToolStripMenuItem,
            this.Presentation_ToolStripMenuItem,
            this.AboutProgram_ToolStripMenuItem,
            this.дкмонстрацияToolStripMenuItem});
            this.помощьToolStripMenuItem1.Name = "помощьToolStripMenuItem1";
            this.помощьToolStripMenuItem1.Size = new System.Drawing.Size(128, 38);
            this.помощьToolStripMenuItem1.Text = "Помощь";
            // 
            // HelpFile_ToolStripMenuItem
            // 
            this.HelpFile_ToolStripMenuItem.Name = "HelpFile_ToolStripMenuItem";
            this.HelpFile_ToolStripMenuItem.Size = new System.Drawing.Size(309, 44);
            this.HelpFile_ToolStripMenuItem.Text = "Справка";
            this.HelpFile_ToolStripMenuItem.Click += new System.EventHandler(this.HelpFile_ToolStripMenuItem_Click);
            // 
            // Presentation_ToolStripMenuItem
            // 
            this.Presentation_ToolStripMenuItem.Name = "Presentation_ToolStripMenuItem";
            this.Presentation_ToolStripMenuItem.Size = new System.Drawing.Size(309, 44);
            this.Presentation_ToolStripMenuItem.Text = "Презентация";
            this.Presentation_ToolStripMenuItem.Click += new System.EventHandler(this.Presentation_ToolStripMenuItem_Click);
            // 
            // AboutProgram_ToolStripMenuItem
            // 
            this.AboutProgram_ToolStripMenuItem.Name = "AboutProgram_ToolStripMenuItem";
            this.AboutProgram_ToolStripMenuItem.Size = new System.Drawing.Size(309, 44);
            this.AboutProgram_ToolStripMenuItem.Text = "О программе";
            this.AboutProgram_ToolStripMenuItem.Click += new System.EventHandler(this.AboutProgram_ToolStripMenuItem_Click);
            // 
            // дкмонстрацияToolStripMenuItem
            // 
            this.дкмонстрацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DefinedSystem_ToolStripMenuItem,
            this.IndefiniteSystem_ToolStripMenuItem});
            this.дкмонстрацияToolStripMenuItem.Name = "дкмонстрацияToolStripMenuItem";
            this.дкмонстрацияToolStripMenuItem.Size = new System.Drawing.Size(309, 44);
            this.дкмонстрацияToolStripMenuItem.Text = "Демонстрация";
            // 
            // DefinedSystem_ToolStripMenuItem
            // 
            this.DefinedSystem_ToolStripMenuItem.Name = "DefinedSystem_ToolStripMenuItem";
            this.DefinedSystem_ToolStripMenuItem.Size = new System.Drawing.Size(431, 44);
            this.DefinedSystem_ToolStripMenuItem.Text = "Определённая система";
            this.DefinedSystem_ToolStripMenuItem.Click += new System.EventHandler(this.DefinedSystem_ToolStripMenuItem_Click);
            // 
            // IndefiniteSystem_ToolStripMenuItem
            // 
            this.IndefiniteSystem_ToolStripMenuItem.Name = "IndefiniteSystem_ToolStripMenuItem";
            this.IndefiniteSystem_ToolStripMenuItem.Size = new System.Drawing.Size(431, 44);
            this.IndefiniteSystem_ToolStripMenuItem.Text = "Неопределённая система";
            this.IndefiniteSystem_ToolStripMenuItem.Click += new System.EventHandler(this.IndefiniteSystem_ToolStripMenuItem_Click);
            // 
            // параметрыToolStripMenuItem
            // 
            this.параметрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MatrixSize_ToolStripMenuItem,
            this.EnterMatrix_ToolStripMenuItem,
            this.Graph_ToolStripMenuItem});
            this.параметрыToolStripMenuItem.Name = "параметрыToolStripMenuItem";
            this.параметрыToolStripMenuItem.Size = new System.Drawing.Size(160, 38);
            this.параметрыToolStripMenuItem.Text = "Параметры";
            // 
            // MatrixSize_ToolStripMenuItem
            // 
            this.MatrixSize_ToolStripMenuItem.Name = "MatrixSize_ToolStripMenuItem";
            this.MatrixSize_ToolStripMenuItem.Size = new System.Drawing.Size(425, 44);
            this.MatrixSize_ToolStripMenuItem.Text = "Количество неизвестных";
            this.MatrixSize_ToolStripMenuItem.Click += new System.EventHandler(this.MatrixSize_ToolStripMenuItem_Click);
            // 
            // EnterMatrix_ToolStripMenuItem
            // 
            this.EnterMatrix_ToolStripMenuItem.Name = "EnterMatrix_ToolStripMenuItem";
            this.EnterMatrix_ToolStripMenuItem.Size = new System.Drawing.Size(425, 44);
            this.EnterMatrix_ToolStripMenuItem.Text = "Ввод матрицы";
            this.EnterMatrix_ToolStripMenuItem.Click += new System.EventHandler(this.EnterMatrix_ToolStripMenuItem_Click);
            // 
            // Graph_ToolStripMenuItem
            // 
            this.Graph_ToolStripMenuItem.Name = "Graph_ToolStripMenuItem";
            this.Graph_ToolStripMenuItem.Size = new System.Drawing.Size(425, 44);
            this.Graph_ToolStripMenuItem.Text = "График";
            this.Graph_ToolStripMenuItem.Click += new System.EventHandler(this.Graph_ToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeColor_ToolStripMenuItem,
            this.BaseColor_ToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(152, 38);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // ChangeColor_ToolStripMenuItem
            // 
            this.ChangeColor_ToolStripMenuItem.Name = "ChangeColor_ToolStripMenuItem";
            this.ChangeColor_ToolStripMenuItem.Size = new System.Drawing.Size(373, 44);
            this.ChangeColor_ToolStripMenuItem.Text = "Изменить цвет";
            this.ChangeColor_ToolStripMenuItem.Click += new System.EventHandler(this.ChangeColor_ToolStripMenuItem_Click);
            // 
            // BaseColor_ToolStripMenuItem
            // 
            this.BaseColor_ToolStripMenuItem.Name = "BaseColor_ToolStripMenuItem";
            this.BaseColor_ToolStripMenuItem.Size = new System.Drawing.Size(373, 44);
            this.BaseColor_ToolStripMenuItem.Text = "Цвет по умолчанию";
            this.BaseColor_ToolStripMenuItem.Click += new System.EventHandler(this.BaseColor_ToolStripMenuItem_Click);
            // 
            // вычисленияToolStripMenuItem
            // 
            this.вычисленияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MatrixDeterminant_ToolStripMenuItem,
            this.InverseMatrix_ToolStripMenuItem,
            this.MatrixTransporation_ToolStripMenuItem});
            this.вычисленияToolStripMenuItem.Name = "вычисленияToolStripMenuItem";
            this.вычисленияToolStripMenuItem.Size = new System.Drawing.Size(170, 38);
            this.вычисленияToolStripMenuItem.Text = "Вычисления";
            // 
            // MatrixDeterminant_ToolStripMenuItem
            // 
            this.MatrixDeterminant_ToolStripMenuItem.Name = "MatrixDeterminant_ToolStripMenuItem";
            this.MatrixDeterminant_ToolStripMenuItem.Size = new System.Drawing.Size(472, 44);
            this.MatrixDeterminant_ToolStripMenuItem.Text = "Определитель матрицы";
            this.MatrixDeterminant_ToolStripMenuItem.Click += new System.EventHandler(this.MatrixDeterminant_ToolStripMenuItem_Click);
            // 
            // InverseMatrix_ToolStripMenuItem
            // 
            this.InverseMatrix_ToolStripMenuItem.Name = "InverseMatrix_ToolStripMenuItem";
            this.InverseMatrix_ToolStripMenuItem.Size = new System.Drawing.Size(472, 44);
            this.InverseMatrix_ToolStripMenuItem.Text = "Обратная матрица";
            this.InverseMatrix_ToolStripMenuItem.Click += new System.EventHandler(this.InverseMatrix_ToolStripMenuItem_Click);
            // 
            // MatrixTransporation_ToolStripMenuItem
            // 
            this.MatrixTransporation_ToolStripMenuItem.Name = "MatrixTransporation_ToolStripMenuItem";
            this.MatrixTransporation_ToolStripMenuItem.Size = new System.Drawing.Size(472, 44);
            this.MatrixTransporation_ToolStripMenuItem.Text = "Транспонированная матрица";
            this.MatrixTransporation_ToolStripMenuItem.Click += new System.EventHandler(this.MatrixTransporation_ToolStripMenuItem_Click);
            // 
            // Result_ListBox
            // 
            this.Result_ListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result_ListBox.FormattingEnabled = true;
            this.Result_ListBox.ItemHeight = 31;
            this.Result_ListBox.Location = new System.Drawing.Point(768, 250);
            this.Result_ListBox.Name = "Result_ListBox";
            this.Result_ListBox.Size = new System.Drawing.Size(428, 314);
            this.Result_ListBox.TabIndex = 15;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1207, 664);
            this.Controls.Add(this.Result_ListBox);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.Matrix_DataGridView);
            this.Controls.Add(this.NumberMatrix_NumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matrix Solver";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Matrix_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberMatrix_NumericUpDown)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView Matrix_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn indexColumn;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.NumericUpDown NumberMatrix_NumericUpDown;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem отчётToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ReportToWord_ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ReportToExcel_ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Calculate_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Exit_ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem HelpFile_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Presentation_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WordMenu;
        private System.Windows.Forms.ToolStripMenuItem ExcelMenu;
        private System.Windows.Forms.ToolStripMenuItem PowerPointMenu;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.ToolStripMenuItem параметрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MatrixSize_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EnterMatrix_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutProgram_ToolStripMenuItem;
        private System.Windows.Forms.ListBox Result_ListBox;
        private System.Windows.Forms.ToolStripMenuItem Graph_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeColor_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BaseColor_ToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem дкмонстрацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DefinedSystem_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IndefiniteSystem_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вычисленияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MatrixDeterminant_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InverseMatrix_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MatrixTransporation_ToolStripMenuItem;
    }
}