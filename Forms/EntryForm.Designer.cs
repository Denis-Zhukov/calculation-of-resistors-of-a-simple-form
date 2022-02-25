namespace Raschet {
    partial class EntryForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.numberResistorsTextbox = new System.Windows.Forms.TextBox();
            this.next = new System.Windows.Forms.Button();
            this.numberResistorsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numberResistorsTextbox
            // 
            this.numberResistorsTextbox.Location = new System.Drawing.Point(149, 6);
            this.numberResistorsTextbox.Name = "numberResistorsTextbox";
            this.numberResistorsTextbox.Size = new System.Drawing.Size(100, 22);
            this.numberResistorsTextbox.TabIndex = 0;
            this.numberResistorsTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numberResistorsTextbox_KeyDown);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(255, 6);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 1;
            this.next.Text = "Далее";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // numberResistorsLabel
            // 
            this.numberResistorsLabel.AutoSize = true;
            this.numberResistorsLabel.Location = new System.Drawing.Point(12, 10);
            this.numberResistorsLabel.Name = "numberResistorsLabel";
            this.numberResistorsLabel.Size = new System.Drawing.Size(131, 13);
            this.numberResistorsLabel.TabIndex = 2;
            this.numberResistorsLabel.Text = "Количество резисторов:";
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 34);
            this.Controls.Add(this.numberResistorsLabel);
            this.Controls.Add(this.next);
            this.Controls.Add(this.numberResistorsTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EntryForm";
            this.Text = "Количество резисторов";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numberResistorsTextbox_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox numberResistorsTextbox;
        private Button next;
        private Label numberResistorsLabel;
    }
}