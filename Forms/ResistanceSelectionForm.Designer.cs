namespace Raschet {
    partial class ResistanceSelectionForm {
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
            this.tableImg = new System.Windows.Forms.PictureBox();
            this.squareResistanceLabel = new System.Windows.Forms.Label();
            this.whatDoYouDoLabel = new System.Windows.Forms.Label();
            this.specificSurfaceResistanceTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TKSTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.agingFactorTextbox = new System.Windows.Forms.TextBox();
            this.specificPowerDissipationTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Button();
            this.anew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableImg)).BeginInit();
            this.SuspendLayout();
            // 
            // tableImg
            // 
            this.tableImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableImg.Image = global::Raschet.Properties.Resources.RES;
            this.tableImg.Location = new System.Drawing.Point(12, 152);
            this.tableImg.Name = "tableImg";
            this.tableImg.Size = new System.Drawing.Size(881, 668);
            this.tableImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tableImg.TabIndex = 0;
            this.tableImg.TabStop = false;
            // 
            // squareResistanceLabel
            // 
            this.squareResistanceLabel.AutoSize = true;
            this.squareResistanceLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.squareResistanceLabel.Location = new System.Drawing.Point(12, 20);
            this.squareResistanceLabel.Name = "squareResistanceLabel";
            this.squareResistanceLabel.Size = new System.Drawing.Size(239, 25);
            this.squareResistanceLabel.TabIndex = 1;
            this.squareResistanceLabel.Text = "Сопротивление квадрата: ";
            // 
            // whatDoYouDoLabel
            // 
            this.whatDoYouDoLabel.AutoSize = true;
            this.whatDoYouDoLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.whatDoYouDoLabel.Location = new System.Drawing.Point(12, 41);
            this.whatDoYouDoLabel.Name = "whatDoYouDoLabel";
            this.whatDoYouDoLabel.Size = new System.Drawing.Size(301, 26);
            this.whatDoYouDoLabel.TabIndex = 2;
            this.whatDoYouDoLabel.Text = "Воспользуйтесь полученными данными и таблицей ниже.\r\nЗаполните соответствующие по" +
    "ля.";
            // 
            // specificSurfaceResistanceTextbox
            // 
            this.specificSurfaceResistanceTextbox.Location = new System.Drawing.Point(310, 94);
            this.specificSurfaceResistanceTextbox.Name = "specificSurfaceResistanceTextbox";
            this.specificSurfaceResistanceTextbox.Size = new System.Drawing.Size(146, 22);
            this.specificSurfaceResistanceTextbox.TabIndex = 0;
            this.specificSurfaceResistanceTextbox.TextChanged += new System.EventHandler(this.InputNumbers);
            this.specificSurfaceResistanceTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Удельное поверхностное сопротивление(Ом/квадрат):";
            // 
            // TKSTextbox
            // 
            this.TKSTextbox.Location = new System.Drawing.Point(310, 123);
            this.TKSTextbox.Name = "TKSTextbox";
            this.TKSTextbox.Size = new System.Drawing.Size(146, 22);
            this.TKSTextbox.TabIndex = 1;
            this.TKSTextbox.TextChanged += new System.EventHandler(this.InputNumbers);
            this.TKSTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ТКС * 10^-4 (1/град):";
            // 
            // agingFactorTextbox
            // 
            this.agingFactorTextbox.Location = new System.Drawing.Point(694, 97);
            this.agingFactorTextbox.Name = "agingFactorTextbox";
            this.agingFactorTextbox.Size = new System.Drawing.Size(200, 22);
            this.agingFactorTextbox.TabIndex = 2;
            this.agingFactorTextbox.TextChanged += new System.EventHandler(this.InputNumbers);
            this.agingFactorTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
            // 
            // specificPowerDissipationTextbox
            // 
            this.specificPowerDissipationTextbox.Location = new System.Drawing.Point(694, 125);
            this.specificPowerDissipationTextbox.Name = "specificPowerDissipationTextbox";
            this.specificPowerDissipationTextbox.Size = new System.Drawing.Size(200, 22);
            this.specificPowerDissipationTextbox.TabIndex = 3;
            this.specificPowerDissipationTextbox.TextChanged += new System.EventHandler(this.InputNumbers);
            this.specificPowerDissipationTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(484, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Коэффициент старения (1/час * 10^-6):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(459, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Удельная мощность рассеяния(мВт/мм^2):";
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(819, 28);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 4;
            this.next.Text = "Далее";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // anew
            // 
            this.anew.Location = new System.Drawing.Point(818, 57);
            this.anew.Name = "anew";
            this.anew.Size = new System.Drawing.Size(75, 23);
            this.anew.TabIndex = 5;
            this.anew.Text = "Заново";
            this.anew.UseVisualStyleBackColor = true;
            this.anew.Click += new System.EventHandler(this.anew_Click);
            // 
            // ResistanceSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(914, 489);
            this.Controls.Add(this.anew);
            this.Controls.Add(this.next);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.specificPowerDissipationTextbox);
            this.Controls.Add(this.TKSTextbox);
            this.Controls.Add(this.agingFactorTextbox);
            this.Controls.Add(this.specificSurfaceResistanceTextbox);
            this.Controls.Add(this.whatDoYouDoLabel);
            this.Controls.Add(this.squareResistanceLabel);
            this.Controls.Add(this.tableImg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResistanceSelectionForm";
            this.Text = "Выбор квадрата сопративления";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.tableImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox tableImg;
        private Label squareResistanceLabel;
        private Label whatDoYouDoLabel;
        private TextBox specificSurfaceResistanceTextbox;
        private Label label1;
        private TextBox TKSTextbox;
        private Label label2;
        private TextBox agingFactorTextbox;
        private TextBox specificPowerDissipationTextbox;
        private Label label3;
        private Label label4;
        private Button next;
        private Button anew;
    }
}