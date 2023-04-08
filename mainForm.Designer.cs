namespace QuestEditor
{
    partial class mainForm
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
            this.searchBox = new System.Windows.Forms.TextBox();
            this.questBox = new System.Windows.Forms.GroupBox();
            this.bCheckQuests = new System.Windows.Forms.Button();
            this.bCheckActiveQuests = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.activeQuestsList = new System.Windows.Forms.ListBox();
            this.activeQuestsBox = new System.Windows.Forms.Panel();
            this.questOptionsBox = new System.Windows.Forms.GroupBox();
            this.questStatusBox = new System.Windows.Forms.Panel();
            this.questStatusTitle = new System.Windows.Forms.Label();
            this.questStatusValue = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.questFinishOptionBox = new System.Windows.Forms.Panel();
            this.bQuestFinishOption = new System.Windows.Forms.Button();
            this.questBox.SuspendLayout();
            this.activeQuestsBox.SuspendLayout();
            this.questOptionsBox.SuspendLayout();
            this.questStatusBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questStatusValue)).BeginInit();
            this.panel2.SuspendLayout();
            this.questFinishOptionBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBox.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.searchBox.ForeColor = System.Drawing.Color.LightGray;
            this.searchBox.Location = new System.Drawing.Point(12, 25);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(529, 20);
            this.searchBox.TabIndex = 0;
            // 
            // questBox
            // 
            this.questBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.questBox.Controls.Add(this.searchBox);
            this.questBox.Controls.Add(this.bCheckQuests);
            this.questBox.ForeColor = System.Drawing.Color.LightGray;
            this.questBox.Location = new System.Drawing.Point(12, 12);
            this.questBox.Name = "questBox";
            this.questBox.Size = new System.Drawing.Size(700, 60);
            this.questBox.TabIndex = 1;
            this.questBox.TabStop = false;
            this.questBox.Text = "Quest name (can contain partials)";
            // 
            // bCheckQuests
            // 
            this.bCheckQuests.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bCheckQuests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCheckQuests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCheckQuests.Location = new System.Drawing.Point(547, 16);
            this.bCheckQuests.Name = "bCheckQuests";
            this.bCheckQuests.Size = new System.Drawing.Size(146, 35);
            this.bCheckQuests.TabIndex = 2;
            this.bCheckQuests.Text = "Check for quest";
            this.bCheckQuests.UseVisualStyleBackColor = true;
            this.bCheckQuests.Click += new System.EventHandler(this.button1_Click);
            // 
            // bCheckActiveQuests
            // 
            this.bCheckActiveQuests.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bCheckActiveQuests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCheckActiveQuests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCheckActiveQuests.Location = new System.Drawing.Point(394, 123);
            this.bCheckActiveQuests.Name = "bCheckActiveQuests";
            this.bCheckActiveQuests.Size = new System.Drawing.Size(318, 45);
            this.bCheckActiveQuests.TabIndex = 3;
            this.bCheckActiveQuests.Text = "Check active quests";
            this.bCheckActiveQuests.UseVisualStyleBackColor = true;
            this.bCheckActiveQuests.Click += new System.EventHandler(this.bCheckActiveQuests_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 1);
            this.panel1.TabIndex = 4;
            // 
            // activeQuestsList
            // 
            this.activeQuestsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.activeQuestsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.activeQuestsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.activeQuestsList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.activeQuestsList.Font = new System.Drawing.Font("Bahnschrift Light", 9F);
            this.activeQuestsList.ForeColor = System.Drawing.Color.LightGray;
            this.activeQuestsList.FormattingEnabled = true;
            this.activeQuestsList.ItemHeight = 14;
            this.activeQuestsList.Location = new System.Drawing.Point(3, 3);
            this.activeQuestsList.Name = "activeQuestsList";
            this.activeQuestsList.Size = new System.Drawing.Size(358, 336);
            this.activeQuestsList.TabIndex = 5;
            this.activeQuestsList.SelectedIndexChanged += new System.EventHandler(this.activeQuestsList_SelectedIndexChanged);
            // 
            // activeQuestsBox
            // 
            this.activeQuestsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.activeQuestsBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.activeQuestsBox.Controls.Add(this.activeQuestsList);
            this.activeQuestsBox.Location = new System.Drawing.Point(12, 123);
            this.activeQuestsBox.Name = "activeQuestsBox";
            this.activeQuestsBox.Size = new System.Drawing.Size(366, 364);
            this.activeQuestsBox.TabIndex = 6;
            // 
            // questOptionsBox
            // 
            this.questOptionsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.questOptionsBox.Controls.Add(this.questFinishOptionBox);
            this.questOptionsBox.Controls.Add(this.panel2);
            this.questOptionsBox.Controls.Add(this.questStatusBox);
            this.questOptionsBox.ForeColor = System.Drawing.Color.LightGray;
            this.questOptionsBox.Location = new System.Drawing.Point(394, 184);
            this.questOptionsBox.Name = "questOptionsBox";
            this.questOptionsBox.Size = new System.Drawing.Size(318, 303);
            this.questOptionsBox.TabIndex = 7;
            this.questOptionsBox.TabStop = false;
            this.questOptionsBox.Text = "Quest options";
            this.questOptionsBox.Visible = false;
            // 
            // questStatusBox
            // 
            this.questStatusBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.questStatusBox.Controls.Add(this.questStatusValue);
            this.questStatusBox.Controls.Add(this.questStatusTitle);
            this.questStatusBox.Location = new System.Drawing.Point(6, 33);
            this.questStatusBox.Name = "questStatusBox";
            this.questStatusBox.Size = new System.Drawing.Size(306, 30);
            this.questStatusBox.TabIndex = 0;
            // 
            // questStatusTitle
            // 
            this.questStatusTitle.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.questStatusTitle.Location = new System.Drawing.Point(3, 1);
            this.questStatusTitle.Name = "questStatusTitle";
            this.questStatusTitle.Size = new System.Drawing.Size(228, 28);
            this.questStatusTitle.TabIndex = 0;
            this.questStatusTitle.Text = "STATUS";
            this.questStatusTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // questStatusValue
            // 
            this.questStatusValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.questStatusValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.questStatusValue.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.questStatusValue.ForeColor = System.Drawing.Color.LightGray;
            this.questStatusValue.Location = new System.Drawing.Point(249, 4);
            this.questStatusValue.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.questStatusValue.Name = "questStatusValue";
            this.questStatusValue.Size = new System.Drawing.Size(54, 23);
            this.questStatusValue.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(6, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 103);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 9F);
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 98);
            this.label1.TabIndex = 0;
            this.label1.Text = "STATUS TYPES:\r\n\r\n1 = Quest available to start\r\n2 = Quest in progress\r\n3 = Quest f" +
    "inished and awaiting confirmation\r\n4 = Quest finished and confirmed (no rewards)" +
    "\r\n5 = Quest failed";
            // 
            // questFinishOptionBox
            // 
            this.questFinishOptionBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.questFinishOptionBox.Controls.Add(this.bQuestFinishOption);
            this.questFinishOptionBox.Location = new System.Drawing.Point(6, 196);
            this.questFinishOptionBox.Name = "questFinishOptionBox";
            this.questFinishOptionBox.Size = new System.Drawing.Size(306, 42);
            this.questFinishOptionBox.TabIndex = 2;
            // 
            // bQuestFinishOption
            // 
            this.bQuestFinishOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bQuestFinishOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bQuestFinishOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bQuestFinishOption.Location = new System.Drawing.Point(3, 3);
            this.bQuestFinishOption.Name = "bQuestFinishOption";
            this.bQuestFinishOption.Size = new System.Drawing.Size(300, 35);
            this.bQuestFinishOption.TabIndex = 3;
            this.bQuestFinishOption.Text = "Finish quest to get rewards";
            this.bQuestFinishOption.UseVisualStyleBackColor = true;
            this.bQuestFinishOption.Click += new System.EventHandler(this.bQuestFinishOption_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(724, 499);
            this.Controls.Add(this.questOptionsBox);
            this.Controls.Add(this.activeQuestsBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bCheckActiveQuests);
            this.Controls.Add(this.questBox);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(740, 538);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quest Editor";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.questBox.ResumeLayout(false);
            this.questBox.PerformLayout();
            this.activeQuestsBox.ResumeLayout(false);
            this.questOptionsBox.ResumeLayout(false);
            this.questStatusBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.questStatusValue)).EndInit();
            this.panel2.ResumeLayout(false);
            this.questFinishOptionBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.GroupBox questBox;
        private System.Windows.Forms.Button bCheckQuests;
        private System.Windows.Forms.Button bCheckActiveQuests;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox activeQuestsList;
        private System.Windows.Forms.Panel activeQuestsBox;
        private System.Windows.Forms.GroupBox questOptionsBox;
        private System.Windows.Forms.Panel questStatusBox;
        private System.Windows.Forms.Label questStatusTitle;
        private System.Windows.Forms.NumericUpDown questStatusValue;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel questFinishOptionBox;
        private System.Windows.Forms.Button bQuestFinishOption;
    }
}

