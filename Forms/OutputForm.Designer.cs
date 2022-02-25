namespace Raschet {
    partial class OutputForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.table = new System.Windows.Forms.DataGridView();
            this.numResistor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nominal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Len = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Square = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exit = new System.Windows.Forms.Button();
            this.anew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.AllowUserToResizeColumns = false;
            this.table.AllowUserToResizeRows = false;
            this.table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table.BackgroundColor = System.Drawing.SystemColors.Control;
            this.table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.table.ColumnHeadersHeight = 35;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numResistor,
            this.nominal,
            this.Len,
            this.Width,
            this.Square});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.table.DefaultCellStyle = dataGridViewCellStyle2;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Margin = new System.Windows.Forms.Padding(2);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.table.RowHeadersVisible = false;
            this.table.RowHeadersWidth = 51;
            this.table.RowTemplate.Height = 29;
            this.table.Size = new System.Drawing.Size(784, 366);
            this.table.TabIndex = 0;
            // 
            // numResistor
            // 
            this.numResistor.FillWeight = 15F;
            this.numResistor.HeaderText = "Номер резистора";
            this.numResistor.Name = "numResistor";
            this.numResistor.ReadOnly = true;
            this.numResistor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // nominal
            // 
            this.nominal.FillWeight = 30.11487F;
            this.nominal.HeaderText = "Номинал (Ом)";
            this.nominal.Name = "nominal";
            this.nominal.ReadOnly = true;
            this.nominal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Len
            // 
            this.Len.FillWeight = 30.11487F;
            this.Len.HeaderText = "Длина (мм)";
            this.Len.Name = "Len";
            this.Len.ReadOnly = true;
            this.Len.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Width
            // 
            this.Width.FillWeight = 30.11487F;
            this.Width.HeaderText = "Ширина (мм)";
            this.Width.Name = "Width";
            this.Width.ReadOnly = true;
            this.Width.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Square
            // 
            this.Square.FillWeight = 30.11487F;
            this.Square.HeaderText = "Площадь (мм^2)";
            this.Square.Name = "Square";
            this.Square.ReadOnly = true;
            this.Square.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(697, 376);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 11;
            this.exit.Text = "Выйти";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // anew
            // 
            this.anew.Location = new System.Drawing.Point(616, 376);
            this.anew.Name = "anew";
            this.anew.Size = new System.Drawing.Size(75, 23);
            this.anew.TabIndex = 10;
            this.anew.Text = "Заново";
            this.anew.UseVisualStyleBackColor = true;
            this.anew.Click += new System.EventHandler(this.anew_Click);
            // 
            // OutputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.anew);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.table);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OutputForm";
            this.Text = "Вывод";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView table;
        private Button exit;
        private Button anew;
        private DataGridViewTextBoxColumn numResistor;
        private DataGridViewTextBoxColumn nominal;
        private DataGridViewTextBoxColumn Len;
        private DataGridViewTextBoxColumn Width;
        private DataGridViewTextBoxColumn Square;
    }
}