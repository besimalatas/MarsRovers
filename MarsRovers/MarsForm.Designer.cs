namespace MarsRovers
{
    partial class MarsForm
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
            this.outputLabel = new System.Windows.Forms.Label();
            this.inputLabel = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.runCommandButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.outputLabel.Location = new System.Drawing.Point(376, 11);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(66, 20);
            this.outputLabel.TabIndex = 9;
            this.outputLabel.Text = "Outputs";
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.inputLabel.Location = new System.Drawing.Point(100, 11);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(54, 20);
            this.inputLabel.TabIndex = 8;
            this.inputLabel.Text = "İnputs";
            // 
            // outputTextBox
            // 
            this.outputTextBox.AcceptsReturn = true;
            this.outputTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.outputTextBox.Location = new System.Drawing.Point(278, 40);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(260, 356);
            this.outputTextBox.TabIndex = 7;
            // 
            // runCommandButton
            // 
            this.runCommandButton.Location = new System.Drawing.Point(12, 402);
            this.runCommandButton.Name = "runCommandButton";
            this.runCommandButton.Size = new System.Drawing.Size(260, 23);
            this.runCommandButton.TabIndex = 6;
            this.runCommandButton.Text = "Komutları Gönder";
            this.runCommandButton.UseVisualStyleBackColor = true;
            this.runCommandButton.Click += new System.EventHandler(this.runCommandButton_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.AcceptsReturn = true;
            this.inputTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.inputTextBox.Location = new System.Drawing.Point(12, 40);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(260, 356);
            this.inputTextBox.TabIndex = 5;
            // 
            // MarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 450);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.runCommandButton);
            this.Controls.Add(this.inputTextBox);
            this.Name = "MarsForm";
            this.Text = "MarsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button runCommandButton;
        private System.Windows.Forms.TextBox inputTextBox;
    }
}

