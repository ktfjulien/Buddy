namespace Buddy.Forms
{
    partial class MainScreen
    {
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
            this.FriendsListButton = new System.Windows.Forms.Button();
            this.AddFriendButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.SendMessageButton = new System.Windows.Forms.Button();
            this.MessagesButton = new System.Windows.Forms.Button();
            this.ConversationsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FriendsListButton
            // 
            this.FriendsListButton.Location = new System.Drawing.Point(92, 154);
            this.FriendsListButton.Name = "FriendsListButton";
            this.FriendsListButton.Size = new System.Drawing.Size(75, 23);
            this.FriendsListButton.TabIndex = 3;
            this.FriendsListButton.Text = "Friends";
            this.FriendsListButton.UseVisualStyleBackColor = true;
            this.FriendsListButton.Click += new System.EventHandler(this.FriendsListButton_Click);
            // 
            // AddFriendButton
            // 
            this.AddFriendButton.Location = new System.Drawing.Point(79, 125);
            this.AddFriendButton.Name = "AddFriendButton";
            this.AddFriendButton.Size = new System.Drawing.Size(102, 23);
            this.AddFriendButton.TabIndex = 2;
            this.AddFriendButton.Text = "Add A Friend";
            this.AddFriendButton.UseVisualStyleBackColor = true;
            this.AddFriendButton.Click += new System.EventHandler(this.AddFriendButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Who\'s logged in:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(176, 184);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 23);
            this.LogoutButton.TabIndex = 4;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SendMessageButton
            // 
            this.SendMessageButton.Location = new System.Drawing.Point(79, 21);
            this.SendMessageButton.Name = "SendMessageButton";
            this.SendMessageButton.Size = new System.Drawing.Size(102, 23);
            this.SendMessageButton.TabIndex = 5;
            this.SendMessageButton.Text = "Send Message";
            this.SendMessageButton.UseVisualStyleBackColor = true;
            this.SendMessageButton.Click += new System.EventHandler(this.MessageButton_Click);
            // 
            // MessagesButton
            // 
            this.MessagesButton.Location = new System.Drawing.Point(92, 50);
            this.MessagesButton.Name = "MessagesButton";
            this.MessagesButton.Size = new System.Drawing.Size(75, 23);
            this.MessagesButton.TabIndex = 1;
            this.MessagesButton.Text = "Messages";
            this.MessagesButton.UseVisualStyleBackColor = true;
            this.MessagesButton.Click += new System.EventHandler(this.MessagesButton_Click);
            // 
            // ConversationsButton
            // 
            this.ConversationsButton.Location = new System.Drawing.Point(92, 79);
            this.ConversationsButton.Name = "ConversationsButton";
            this.ConversationsButton.Size = new System.Drawing.Size(124, 40);
            this.ConversationsButton.TabIndex = 6;
            this.ConversationsButton.Text = "Conversations";
            this.ConversationsButton.UseVisualStyleBackColor = true;
            this.ConversationsButton.Click += new System.EventHandler(this.ConversationsButton_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(263, 216);
            this.Controls.Add(this.ConversationsButton);
            this.Controls.Add(this.MessagesButton);
            this.Controls.Add(this.SendMessageButton);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddFriendButton);
            this.Controls.Add(this.FriendsListButton);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FriendsListButton;
        private System.Windows.Forms.Button AddFriendButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button SendMessageButton;
        private System.Windows.Forms.Button MessagesButton;
        private System.Windows.Forms.Button ConversationsButton;
    }
}