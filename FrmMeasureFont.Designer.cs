namespace MeasureAndChangeFontWidth
{
    partial class FrmMeasureFont
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
            this.BtnTest = new System.Windows.Forms.Button();
            this.TxtFontSize = new System.Windows.Forms.TextBox();
            this.LblFontSize = new System.Windows.Forms.Label();
            this.TxtTextInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnTest
            // 
            this.BtnTest.Location = new System.Drawing.Point(20, 12);
            this.BtnTest.Name = "BtnTest";
            this.BtnTest.Size = new System.Drawing.Size(103, 44);
            this.BtnTest.TabIndex = 0;
            this.BtnTest.Text = "Test";
            this.BtnTest.UseVisualStyleBackColor = true;
            this.BtnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // TxtFontSize
            // 
            this.TxtFontSize.Location = new System.Drawing.Point(21, 118);
            this.TxtFontSize.Name = "TxtFontSize";
            this.TxtFontSize.Size = new System.Drawing.Size(100, 29);
            this.TxtFontSize.TabIndex = 1;
            this.TxtFontSize.Text = "36";
            this.TxtFontSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblFontSize
            // 
            this.LblFontSize.AutoSize = true;
            this.LblFontSize.Location = new System.Drawing.Point(27, 91);
            this.LblFontSize.Name = "LblFontSize";
            this.LblFontSize.Size = new System.Drawing.Size(89, 24);
            this.LblFontSize.TabIndex = 2;
            this.LblFontSize.Text = "Font Size";
            // 
            // TxtTextInput
            // 
            this.TxtTextInput.Location = new System.Drawing.Point(20, 209);
            this.TxtTextInput.Name = "TxtTextInput";
            this.TxtTextInput.Size = new System.Drawing.Size(100, 29);
            this.TxtTextInput.TabIndex = 3;
            // 
            // FrmMeasureFont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 304);
            this.Controls.Add(this.TxtTextInput);
            this.Controls.Add(this.LblFontSize);
            this.Controls.Add(this.TxtFontSize);
            this.Controls.Add(this.BtnTest);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmMeasureFont";
            this.ShowIcon = false;
            this.Text = "Measure and Change Font Width";
            this.Load += new System.EventHandler(this.FrmMeasureFont_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnTest;
        private System.Windows.Forms.TextBox TxtFontSize;
        private System.Windows.Forms.Label LblFontSize;
        private System.Windows.Forms.TextBox TxtTextInput;
    }
}

