namespace Raschet {
    partial class resistivityErrorForm {
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
            this.YPSlabel = new System.Windows.Forms.Label();
            this.YPSTextbox = new System.Windows.Forms.TextBox();
            this.anew = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.YRKTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // YPSlabel
            // 
            this.YPSlabel.AutoSize = true;
            this.YPSlabel.Location = new System.Drawing.Point(11, 19);
            this.YPSlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.YPSlabel.Name = "YPSlabel";
            this.YPSlabel.Size = new System.Drawing.Size(414, 13);
            this.YPSlabel.TabIndex = 0;
            this.YPSlabel.Text = "Введите погрешность воспроизведения величены ps резистивной плёнки (Yps):";
            // 
            // YPSTextbox
            // 
            this.YPSTextbox.Location = new System.Drawing.Point(429, 16);
            this.YPSTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.YPSTextbox.Name = "YPSTextbox";
            this.YPSTextbox.Size = new System.Drawing.Size(95, 22);
            this.YPSTextbox.TabIndex = 0;
            this.YPSTextbox.TextChanged += new System.EventHandler(this.InputNumbers);
            this.YPSTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
            // 
            // anew
            // 
            this.anew.Location = new System.Drawing.Point(368, 76);
            this.anew.Name = "anew";
            this.anew.Size = new System.Drawing.Size(75, 23);
            this.anew.TabIndex = 4;
            this.anew.Text = "Заново";
            this.anew.UseVisualStyleBackColor = true;
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(448, 76);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 3;
            this.next.Text = "Далее";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Введите погрешность переходных сопротивлений контактов (Yrk):";
            // 
            // YRKTextbox
            // 
            this.YRKTextbox.Location = new System.Drawing.Point(429, 44);
            this.YRKTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.YRKTextbox.Name = "YRKTextbox";
            this.YRKTextbox.Size = new System.Drawing.Size(95, 22);
            this.YRKTextbox.TabIndex = 1;
            this.YRKTextbox.TextChanged += new System.EventHandler(this.InputNumbers);
            this.YRKTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
            // 
            // resistivityErrorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 111);
            this.Controls.Add(this.YRKTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.anew);
            this.Controls.Add(this.next);
            this.Controls.Add(this.YPSTextbox);
            this.Controls.Add(this.YPSlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "resistivityErrorForm";
            this.Text = "Погрешности";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label YPSlabel;
        private TextBox YPSTextbox;
        private Button anew;
        private Button next;
        private Label label1;
        private TextBox YRKTextbox;
    }
}