namespace get_selector_app
{
    partial class GetSelectorMainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.getNameButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.feedbackLabel = new System.Windows.Forms.Label();
            this.namesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // getNameButton
            // 
            this.getNameButton.Location = new System.Drawing.Point(279, 149);
            this.getNameButton.Name = "getNameButton";
            this.getNameButton.Size = new System.Drawing.Size(204, 23);
            this.getNameButton.TabIndex = 0;
            this.getNameButton.Text = "Request name to API";
            this.getNameButton.UseVisualStyleBackColor = true;
            this.getNameButton.Click += new System.EventHandler(this.getNameButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Dubai", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(187, 22);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(383, 54);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Get Selector C# Native App";
            // 
            // feedbackLabel
            // 
            this.feedbackLabel.AutoSize = true;
            this.feedbackLabel.Location = new System.Drawing.Point(197, 96);
            this.feedbackLabel.Name = "feedbackLabel";
            this.feedbackLabel.Size = new System.Drawing.Size(0, 15);
            this.feedbackLabel.TabIndex = 3;
            // 
            // namesListBox
            // 
            this.namesListBox.FormattingEnabled = true;
            this.namesListBox.ItemHeight = 15;
            this.namesListBox.Location = new System.Drawing.Point(12, 181);
            this.namesListBox.Name = "namesListBox";
            this.namesListBox.Size = new System.Drawing.Size(776, 259);
            this.namesListBox.TabIndex = 4;
            // 
            // GetSelectorMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.namesListBox);
            this.Controls.Add(this.feedbackLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.getNameButton);
            this.Name = "GetSelectorMainForm";
            this.Text = "Get Selector C# Native App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button getNameButton;
        private Label titleLabel;
        private Label feedbackLabel;
        private ListBox namesListBox;
    }
}