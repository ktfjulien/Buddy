namespace Buddy.Forms {
    partial class ConversationsForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.MessagesBox = new System.Windows.Forms.RichTextBox();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 39);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(248, 484);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // MessagesBox
            // 
            this.MessagesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessagesBox.Location = new System.Drawing.Point(266, 11);
            this.MessagesBox.Name = "MessagesBox";
            this.MessagesBox.Size = new System.Drawing.Size(632, 485);
            this.MessagesBox.TabIndex = 1;
            this.MessagesBox.Text = "";
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(266, 503);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MessageTextBox.Size = new System.Drawing.Size(632, 20);
            this.MessageTextBox.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Search friends";
            // 
            // ConversationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 533);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.MessagesBox);
            this.Controls.Add(this.listBox1);
            this.Name = "ConversationsForm";
            this.Text = "ConversationsForm";
            this.Load += new System.EventHandler(this.ConversationsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox MessagesBox;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.TextBox textBox1;
    }
}