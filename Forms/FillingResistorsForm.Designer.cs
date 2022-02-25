namespace Raschet {
    partial class FillingResistorsForm {
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
            this.resistorNumberTextbox = new System.Windows.Forms.Label();
            this.nominalTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.powerLabel = new System.Windows.Forms.Label();
            this.powerTextbox = new System.Windows.Forms.TextBox();
            this.admittanceLabel = new System.Windows.Forms.Label();
            this.admittanceTextbox = new System.Windows.Forms.TextBox();
            this.next = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resistorNumberTextbox
            // 
            this.resistorNumberTextbox.AutoSize = true;
            this.resistorNumberTextbox.Location = new System.Drawing.Point(12, 29);
            this.resistorNumberTextbox.Name = "resistorNumberTextbox";
            this.resistorNumberTextbox.Size = new System.Drawing.Size(66, 13);
            this.resistorNumberTextbox.TabIndex = 0;
            this.resistorNumberTextbox.Text = "1 резистор:";
            // 
            // nominalTextbox
            // 
            this.nominalTextbox.Location = new System.Drawing.Point(153, 24);
            this.nominalTextbox.Name = "nominalTextbox";
            this.nominalTextbox.Size = new System.Drawing.Size(100, 22);
            this.nominalTextbox.TabIndex = 0;
            this.nominalTextbox.TextChanged += new System.EventHandler(this.InputNumbers);
            this.nominalTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Номинал (Ом)";
            // 
            // powerLabel
            // 
            this.powerLabel.AutoSize = true;
            this.powerLabel.Location = new System.Drawing.Point(264, 9);
            this.powerLabel.Name = "powerLabel";
            this.powerLabel.Size = new System.Drawing.Size(89, 13);
            this.powerLabel.TabIndex = 0;
            this.powerLabel.Text = "Мощность (мВт)";
            // 
            // powerTextbox
            // 
            this.powerTextbox.Location = new System.Drawing.Point(259, 24);
            this.powerTextbox.Name = "powerTextbox";
            this.powerTextbox.Size = new System.Drawing.Size(100, 22);
            this.powerTextbox.TabIndex = 1;
            this.powerTextbox.TextChanged += new System.EventHandler(this.InputNumbers);
            this.powerTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
            // 
            // admittanceLabel
            // 
            this.admittanceLabel.AutoSize = true;
            this.admittanceLabel.Location = new System.Drawing.Point(387, 8);
            this.admittanceLabel.Name = "admittanceLabel";
            this.admittanceLabel.Size = new System.Drawing.Size(62, 13);
            this.admittanceLabel.TabIndex = 0;
            this.admittanceLabel.Text = "Допуск (%)";
            // 
            // admittanceTextbox
            // 
            this.admittanceTextbox.Location = new System.Drawing.Point(365, 24);
            this.admittanceTextbox.Name = "admittanceTextbox";
            this.admittanceTextbox.Size = new System.Drawing.Size(100, 22);
            this.admittanceTextbox.TabIndex = 2;
            this.admittanceTextbox.TextChanged += new System.EventHandler(this.InputNumbers);
            this.admittanceTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(390, 61);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 3;
            this.next.Text = "Далее";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(309, 61);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 4;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // FillingResistorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 96);
            this.Controls.Add(this.back);
            this.Controls.Add(this.next);
            this.Controls.Add(this.admittanceTextbox);
            this.Controls.Add(this.powerTextbox);
            this.Controls.Add(this.admittanceLabel);
            this.Controls.Add(this.nominalTextbox);
            this.Controls.Add(this.powerLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resistorNumberTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FillingResistorsForm";
            this.Text = "Заполнение резисторов";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label resistorNumberTextbox;
        private TextBox nominalTextbox;
        private Label label2;
        private Label powerLabel;
        private TextBox powerTextbox;
        private Label admittanceLabel;
        private TextBox admittanceTextbox;
        private Button next;
        private Button back;
    }
}