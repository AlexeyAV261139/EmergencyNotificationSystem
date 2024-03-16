namespace ENS.View
{
    partial class SendTemplateForm
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
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            SendButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 33);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 5;
            label1.Text = "Шаблон сообщения";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(34, 51);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(260, 221);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // SendButton
            // 
            SendButton.Location = new Point(336, 107);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(95, 93);
            SendButton.TabIndex = 3;
            SendButton.Text = "Отправить";
            SendButton.UseVisualStyleBackColor = true;
            // 
            // SendTampleteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 362);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(SendButton);
            Name = "SendTampleteForm";
            Text = "SendTampleteForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox richTextBox1;
        private Button SendButton;
    }
}