namespace MessageFiltering
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
            this.components = new System.ComponentModel.Container();
            this.MessageListView = new System.Windows.Forms.ListView();
            this.User = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Message = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SrchMsgtextBox = new System.Windows.Forms.TextBox();
            this.startDateTime = new System.Windows.Forms.DateTimePicker();
            this.endDateTime = new System.Windows.Forms.DateTimePicker();
            this.AndCondcheckBox = new System.Windows.Forms.CheckBox();
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.GenerateSmsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MessageListView
            // 
            this.MessageListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.User,
            this.Message});
            this.MessageListView.Location = new System.Drawing.Point(12, 150);
            this.MessageListView.Name = "MessageListView";
            this.MessageListView.Size = new System.Drawing.Size(490, 245);
            this.MessageListView.TabIndex = 0;
            this.MessageListView.TileSize = new System.Drawing.Size(400, 30);
            this.MessageListView.UseCompatibleStateImageBehavior = false;
            this.MessageListView.View = System.Windows.Forms.View.Tile;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(245, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(256, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.Search_Changed);
            // 
            // SrchMsgtextBox
            // 
            this.SrchMsgtextBox.Location = new System.Drawing.Point(245, 54);
            this.SrchMsgtextBox.Name = "SrchMsgtextBox";
            this.SrchMsgtextBox.Size = new System.Drawing.Size(255, 20);
            this.SrchMsgtextBox.TabIndex = 2;
            this.SrchMsgtextBox.TextChanged += new System.EventHandler(this.Search_Changed);
            // 
            // startDateTime
            // 
            this.startDateTime.Location = new System.Drawing.Point(247, 100);
            this.startDateTime.Name = "startDateTime";
            this.startDateTime.ShowCheckBox = true;
            this.startDateTime.Size = new System.Drawing.Size(110, 20);
            this.startDateTime.TabIndex = 3;
            this.startDateTime.ValueChanged += new System.EventHandler(this.Search_Changed);
            // 
            // endDateTime
            // 
            this.endDateTime.Location = new System.Drawing.Point(373, 100);
            this.endDateTime.Name = "endDateTime";
            this.endDateTime.ShowCheckBox = true;
            this.endDateTime.Size = new System.Drawing.Size(126, 20);
            this.endDateTime.TabIndex = 4;
            this.endDateTime.ValueChanged += new System.EventHandler(this.Search_Changed);
            // 
            // AndCondcheckBox
            // 
            this.AndCondcheckBox.AutoSize = true;
            this.AndCondcheckBox.Location = new System.Drawing.Point(247, 127);
            this.AndCondcheckBox.Name = "AndCondcheckBox";
            this.AndCondcheckBox.Size = new System.Drawing.Size(94, 17);
            this.AndCondcheckBox.TabIndex = 5;
            this.AndCondcheckBox.Text = "Use And cond";
            this.AndCondcheckBox.UseVisualStyleBackColor = true;
            this.AndCondcheckBox.CheckedChanged += new System.EventHandler(this.Search_Changed);
            // 
            // RefreshTimer
            // 
            this.RefreshTimer.Enabled = true;
            this.RefreshTimer.Interval = 1000;
            this.RefreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 15);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(213, 21);
            this.progressBar1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Charge";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(124, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 32);
            this.button2.TabIndex = 8;
            this.button2.Text = "Discharge";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GenerateSmsBtn
            // 
            this.GenerateSmsBtn.Location = new System.Drawing.Point(28, 118);
            this.GenerateSmsBtn.Name = "GenerateSmsBtn";
            this.GenerateSmsBtn.Size = new System.Drawing.Size(75, 23);
            this.GenerateSmsBtn.TabIndex = 9;
            this.GenerateSmsBtn.Text = "Start genarate SMS";
            this.GenerateSmsBtn.UseVisualStyleBackColor = true;
            this.GenerateSmsBtn.Click += new System.EventHandler(this.GenerateSmsBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 407);
            this.Controls.Add(this.GenerateSmsBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.AndCondcheckBox);
            this.Controls.Add(this.endDateTime);
            this.Controls.Add(this.startDateTime);
            this.Controls.Add(this.SrchMsgtextBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.MessageListView);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message Filtering";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView MessageListView;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox SrchMsgtextBox;
        private System.Windows.Forms.DateTimePicker startDateTime;
        private System.Windows.Forms.DateTimePicker endDateTime;
        private System.Windows.Forms.CheckBox AndCondcheckBox;
        private System.Windows.Forms.ColumnHeader User;
        private System.Windows.Forms.ColumnHeader Message;
        private System.Windows.Forms.Timer RefreshTimer;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button GenerateSmsBtn;
    }
}

