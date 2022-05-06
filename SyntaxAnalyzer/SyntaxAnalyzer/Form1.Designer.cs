
namespace SyntaxAnalyzer
{
    partial class Form1
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
            this.CodeInput = new System.Windows.Forms.TextBox();
            this.ParseButton = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // CodeInput
            // 
            this.CodeInput.Location = new System.Drawing.Point(13, 13);
            this.CodeInput.Name = "CodeInput";
            this.CodeInput.Size = new System.Drawing.Size(327, 20);
            this.CodeInput.TabIndex = 0;
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(13, 40);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(327, 23);
            this.ParseButton.TabIndex = 1;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // Log
            // 
            this.Log.Location = new System.Drawing.Point(13, 70);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(775, 368);
            this.Log.TabIndex = 2;
            this.Log.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.ParseButton);
            this.Controls.Add(this.CodeInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CodeInput;
        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.RichTextBox Log;
    }
}

