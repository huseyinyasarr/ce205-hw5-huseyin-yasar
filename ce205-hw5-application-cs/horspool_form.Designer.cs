namespace ce205_hw4_application_cs
{
    partial class horspool_form
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
            this.randomButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.resultRichTextBox = new System.Windows.Forms.RichTextBox();
            this.patternRichTextBox = new System.Windows.Forms.RichTextBox();
            this.inputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // randomButton
            // 
            this.randomButton.BackColor = System.Drawing.Color.Yellow;
            this.randomButton.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.randomButton.ForeColor = System.Drawing.Color.Black;
            this.randomButton.Location = new System.Drawing.Point(27, 316);
            this.randomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(199, 31);
            this.randomButton.TabIndex = 11;
            this.randomButton.Text = "Random Text";
            this.randomButton.UseVisualStyleBackColor = false;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(278, 326);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 13);
            this.resultLabel.TabIndex = 10;
            this.resultLabel.Click += new System.EventHandler(this.resultLabel_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Yellow;
            this.searchButton.Font = new System.Drawing.Font("Open Sans", 12F);
            this.searchButton.ForeColor = System.Drawing.Color.Black;
            this.searchButton.Location = new System.Drawing.Point(633, 316);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(199, 31);
            this.searchButton.TabIndex = 9;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // resultRichTextBox
            // 
            this.resultRichTextBox.Location = new System.Drawing.Point(569, 139);
            this.resultRichTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.resultRichTextBox.Name = "resultRichTextBox";
            this.resultRichTextBox.Size = new System.Drawing.Size(305, 159);
            this.resultRichTextBox.TabIndex = 8;
            this.resultRichTextBox.Text = "";
            this.resultRichTextBox.TextChanged += new System.EventHandler(this.resultRichTextBox_TextChanged);
            // 
            // patternRichTextBox
            // 
            this.patternRichTextBox.Location = new System.Drawing.Point(274, 139);
            this.patternRichTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.patternRichTextBox.Name = "patternRichTextBox";
            this.patternRichTextBox.Size = new System.Drawing.Size(263, 159);
            this.patternRichTextBox.TabIndex = 7;
            this.patternRichTextBox.Text = "";
            this.patternRichTextBox.TextChanged += new System.EventHandler(this.patternRichTextBox_TextChanged);
            // 
            // inputRichTextBox
            // 
            this.inputRichTextBox.Location = new System.Drawing.Point(11, 139);
            this.inputRichTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputRichTextBox.Name = "inputRichTextBox";
            this.inputRichTextBox.Size = new System.Drawing.Size(240, 159);
            this.inputRichTextBox.TabIndex = 6;
            this.inputRichTextBox.Text = "";
            this.inputRichTextBox.TextChanged += new System.EventHandler(this.inputRichTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(353, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "PATTERN";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(86, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "INPUT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(353, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = "HORSPOOL";
            // 
            // horspool_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 488);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.randomButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.resultRichTextBox);
            this.Controls.Add(this.patternRichTextBox);
            this.Controls.Add(this.inputRichTextBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "horspool_form";
            this.Text = "horspool_form";
            this.Load += new System.EventHandler(this.horspool_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button randomButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.RichTextBox resultRichTextBox;
        private System.Windows.Forms.RichTextBox patternRichTextBox;
        private System.Windows.Forms.RichTextBox inputRichTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}