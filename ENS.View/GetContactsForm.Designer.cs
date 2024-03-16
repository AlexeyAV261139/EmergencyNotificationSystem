namespace ENS.View
{
    partial class GetContactsForm
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
            selectFilePathButton = new Button();
            filePathTextBox = new TextBox();
            getContactsButton = new Button();
            userContactsDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)userContactsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // selectFilePathButton
            // 
            selectFilePathButton.Location = new Point(45, 442);
            selectFilePathButton.Name = "selectFilePathButton";
            selectFilePathButton.Size = new Size(128, 23);
            selectFilePathButton.TabIndex = 3;
            selectFilePathButton.Text = "Выбрать файл";
            selectFilePathButton.UseVisualStyleBackColor = true;
            selectFilePathButton.Click += SelectFileButton_Click;
            // 
            // filePathTextBox
            // 
            filePathTextBox.Location = new Point(179, 442);
            filePathTextBox.Name = "filePathTextBox";
            filePathTextBox.Size = new Size(386, 23);
            filePathTextBox.TabIndex = 4;
            // 
            // getContactsButton
            // 
            getContactsButton.Location = new Point(23, 146);
            getContactsButton.Name = "getContactsButton";
            getContactsButton.Size = new Size(150, 32);
            getContactsButton.TabIndex = 5;
            getContactsButton.Text = "Получить контакты";
            getContactsButton.UseVisualStyleBackColor = true;
            getContactsButton.Click += GetContactsButton_Click;
            // 
            // userContactsDataGridView
            // 
            userContactsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userContactsDataGridView.Location = new Point(219, 32);
            userContactsDataGridView.Name = "userContactsDataGridView";
            userContactsDataGridView.Size = new Size(410, 349);
            userContactsDataGridView.TabIndex = 6;
            // 
            // GetContactsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 511);
            Controls.Add(userContactsDataGridView);
            Controls.Add(getContactsButton);
            Controls.Add(filePathTextBox);
            Controls.Add(selectFilePathButton);
            Name = "GetContactsForm";
            Text = "ENS";
            ((System.ComponentModel.ISupportInitialize)userContactsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button selectFilePathButton;
        private TextBox filePathTextBox;
        private Button getContactsButton;
        private DataGridView userContactsDataGridView;
    }
}
