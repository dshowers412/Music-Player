namespace MusicPlayer
{
    partial class FilterDialog
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
            this.filterCategoryDropDown = new System.Windows.Forms.ComboBox();
            this.restrictionDropDown = new System.Windows.Forms.ComboBox();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.filterResultsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // filterCategoryDropDown
            // 
            this.filterCategoryDropDown.FormattingEnabled = true;
            this.filterCategoryDropDown.Items.AddRange(new object[] {
            "Artist",
            "Album",
            "Genre"});
            this.filterCategoryDropDown.Location = new System.Drawing.Point(13, 13);
            this.filterCategoryDropDown.Name = "filterCategoryDropDown";
            this.filterCategoryDropDown.Size = new System.Drawing.Size(259, 21);
            this.filterCategoryDropDown.TabIndex = 0;
            // 
            // restrictionDropDown
            // 
            this.restrictionDropDown.FormattingEnabled = true;
            this.restrictionDropDown.Items.AddRange(new object[] {
            "Is Equal To",
            "Contains",
            "Is Greater Than",
            "Is Less Than"});
            this.restrictionDropDown.Location = new System.Drawing.Point(13, 41);
            this.restrictionDropDown.Name = "restrictionDropDown";
            this.restrictionDropDown.Size = new System.Drawing.Size(259, 21);
            this.restrictionDropDown.TabIndex = 1;
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(13, 69);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(259, 20);
            this.filterTextBox.TabIndex = 2;
            // 
            // filterResultsButton
            // 
            this.filterResultsButton.Location = new System.Drawing.Point(62, 137);
            this.filterResultsButton.Name = "filterResultsButton";
            this.filterResultsButton.Size = new System.Drawing.Size(133, 32);
            this.filterResultsButton.TabIndex = 3;
            this.filterResultsButton.Text = "See Results";
            this.filterResultsButton.UseVisualStyleBackColor = true;
            this.filterResultsButton.Click += new System.EventHandler(this.filterResultsButton_Click);
            // 
            // FilterDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.filterResultsButton);
            this.Controls.Add(this.filterTextBox);
            this.Controls.Add(this.restrictionDropDown);
            this.Controls.Add(this.filterCategoryDropDown);
            this.Name = "FilterDialog";
            this.Text = "FilterDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox filterCategoryDropDown;
        private System.Windows.Forms.ComboBox restrictionDropDown;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.Button filterResultsButton;
    }
}