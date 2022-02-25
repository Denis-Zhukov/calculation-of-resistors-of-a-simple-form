namespace Raschet {
    partial class StepForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && ( components != null )) {
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
            this.label1 = new System.Windows.Forms.Label();
            this.stepBox = new System.Windows.Forms.ComboBox();
            this.anew = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.scaleTextbox = new System.Windows.Forms.TextBox();
            this.TmaxLabel = new System.Windows.Forms.Label();
            this.TminLabel = new System.Windows.Forms.Label();
            this.TmaxTextbox = new System.Windows.Forms.TextBox();
            this.TminTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lifeTimeTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите шаг:";
            // 
            // stepBox
            // 
            this.stepBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stepBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.stepBox.FormattingEnabled = true;
            this.stepBox.Items.AddRange(new object[] {
            "1",
            "0.5"});
            this.stepBox.Location = new System.Drawing.Point(100, 9);
            this.stepBox.Name = "stepBox";
            this.stepBox.Size = new System.Drawing.Size(71, 21);
            this.stepBox.TabIndex = 0;
            // 
            // anew
            // 
            this.anew.Location = new System.Drawing.Point(193, 124);
            this.anew.Name = "anew";
            this.anew.Size = new System.Drawing.Size(75, 23);
            this.anew.TabIndex = 6;
            this.anew.Text = "Заново";
            this.anew.UseVisualStyleBackColor = true;
            this.anew.Click += new System.EventHandler(this.anew_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(274, 124);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 5;
            this.next.Text = "Далее";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "мм";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Масштаб ";
            // 
            // scaleTextbox
            // 
            this.scaleTextbox.Location = new System.Drawing.Point(263, 10);
            this.scaleTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.scaleTextbox.Name = "scaleTextbox";
            this.scaleTextbox.Size = new System.Drawing.Size(71, 22);
            this.scaleTextbox.TabIndex = 1;
            this.scaleTextbox.TextChanged += new System.EventHandler(this.InputNumbers);
            this.scaleTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
            // 
            // TmaxLabel
            // 
            this.TmaxLabel.AutoSize = true;
            this.TmaxLabel.Location = new System.Drawing.Point(12, 36);
            this.TmaxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TmaxLabel.Name = "TmaxLabel";
            this.TmaxLabel.Size = new System.Drawing.Size(223, 13);
            this.TmaxLabel.TabIndex = 10;
            this.TmaxLabel.Text = "Максимальное значение температуры (C):";
            // 
            // TminLabel
            // 
            this.TminLabel.AutoSize = true;
            this.TminLabel.Location = new System.Drawing.Point(18, 64);
            this.TminLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TminLabel.Name = "TminLabel";
            this.TminLabel.Size = new System.Drawing.Size(217, 13);
            this.TminLabel.TabIndex = 11;
            this.TminLabel.Text = "Минимальное значение температуры (С):";
            // 
            // TmaxTextbox
            // 
            this.TmaxTextbox.Location = new System.Drawing.Point(254, 36);
            this.TmaxTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.TmaxTextbox.Name = "TmaxTextbox";
            this.TmaxTextbox.Size = new System.Drawing.Size(95, 22);
            this.TmaxTextbox.TabIndex = 2;
            this.TmaxTextbox.TextChanged += new System.EventHandler(this.InputNumbers);
            this.TmaxTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
            // 
            // TminTextbox
            // 
            this.TminTextbox.Location = new System.Drawing.Point(254, 61);
            this.TminTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.TminTextbox.Name = "TminTextbox";
            this.TminTextbox.Size = new System.Drawing.Size(95, 22);
            this.TminTextbox.TabIndex = 3;
            this.TminTextbox.TextChanged += new System.EventHandler(this.InputNumbers);
            this.TminTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Срок службы (*10^5 часов):";
            // 
            // lifeTimeTextbox
            // 
            this.lifeTimeTextbox.Location = new System.Drawing.Point(254, 86);
            this.lifeTimeTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.lifeTimeTextbox.Name = "lifeTimeTextbox";
            this.lifeTimeTextbox.Size = new System.Drawing.Size(95, 22);
            this.lifeTimeTextbox.TabIndex = 4;
            this.lifeTimeTextbox.TextChanged += new System.EventHandler(this.InputNumbers);
            this.lifeTimeTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(334, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = ": 1";
            // 
            // StepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 156);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lifeTimeTextbox);
            this.Controls.Add(this.TminTextbox);
            this.Controls.Add(this.TmaxTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TminLabel);
            this.Controls.Add(this.TmaxLabel);
            this.Controls.Add(this.scaleTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.anew);
            this.Controls.Add(this.next);
            this.Controls.Add(this.stepBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StepForm";
            this.Text = "Условие работы";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox stepBox;
        private Button anew;
        private Button next;
        private Label label2;
        private Label label3;
        private TextBox scaleTextbox;
        private Label TmaxLabel;
        private Label TminLabel;
        private TextBox TmaxTextbox;
        private TextBox TminTextbox;
        private Label label4;
        private TextBox lifeTimeTextbox;
        private Label label5;
    }
}