namespace TimeTrackHelper
{
	partial class TimeTrackDialog
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
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node4");
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node5");
			System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node6");
			System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node3", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
			System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode4});
			System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node8");
			System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node9");
			System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node1", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
			System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Node12");
			System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Node10", new System.Windows.Forms.TreeNode[] {
            treeNode9});
			System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Node13");
			System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Node14");
			System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Node11", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
			System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Node2", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode13});
			System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Node7");
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeTrackDialog));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.timeEventsTabPage = new System.Windows.Forms.TabPage();
			this.timeTrackTabPage = new System.Windows.Forms.TabPage();
			this.activeEventGroupBox = new System.Windows.Forms.GroupBox();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.tabControl1.SuspendLayout();
			this.timeEventsTabPage.SuspendLayout();
			this.timeTrackTabPage.SuspendLayout();
			this.activeEventGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.timeEventsTabPage);
			this.tabControl1.Controls.Add(this.timeTrackTabPage);
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(387, 414);
			this.tabControl1.TabIndex = 0;
			// 
			// timeEventsTabPage
			// 
			this.timeEventsTabPage.Controls.Add(this.button3);
			this.timeEventsTabPage.Controls.Add(this.button2);
			this.timeEventsTabPage.Controls.Add(this.button1);
			this.timeEventsTabPage.Controls.Add(this.treeView1);
			this.timeEventsTabPage.Controls.Add(this.activeEventGroupBox);
			this.timeEventsTabPage.Location = new System.Drawing.Point(4, 22);
			this.timeEventsTabPage.Name = "timeEventsTabPage";
			this.timeEventsTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.timeEventsTabPage.Size = new System.Drawing.Size(379, 388);
			this.timeEventsTabPage.TabIndex = 0;
			this.timeEventsTabPage.Text = "Time Events";
			this.timeEventsTabPage.UseVisualStyleBackColor = true;
			// 
			// timeTrackTabPage
			// 
			this.timeTrackTabPage.Controls.Add(this.listBox1);
			this.timeTrackTabPage.Controls.Add(this.label5);
			this.timeTrackTabPage.Controls.Add(this.label4);
			this.timeTrackTabPage.Controls.Add(this.dateTimePicker2);
			this.timeTrackTabPage.Controls.Add(this.dateTimePicker1);
			this.timeTrackTabPage.Location = new System.Drawing.Point(4, 22);
			this.timeTrackTabPage.Name = "timeTrackTabPage";
			this.timeTrackTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.timeTrackTabPage.Size = new System.Drawing.Size(379, 388);
			this.timeTrackTabPage.TabIndex = 1;
			this.timeTrackTabPage.Text = "Time Track";
			this.timeTrackTabPage.UseVisualStyleBackColor = true;
			// 
			// activeEventGroupBox
			// 
			this.activeEventGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.activeEventGroupBox.Controls.Add(this.label3);
			this.activeEventGroupBox.Controls.Add(this.textBox2);
			this.activeEventGroupBox.Controls.Add(this.label2);
			this.activeEventGroupBox.Controls.Add(this.label1);
			this.activeEventGroupBox.Location = new System.Drawing.Point(8, 6);
			this.activeEventGroupBox.Name = "activeEventGroupBox";
			this.activeEventGroupBox.Size = new System.Drawing.Size(360, 124);
			this.activeEventGroupBox.TabIndex = 1;
			this.activeEventGroupBox.TabStop = false;
			this.activeEventGroupBox.Text = "Active event";
			// 
			// treeView1
			// 
			this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.treeView1.Location = new System.Drawing.Point(8, 136);
			this.treeView1.Name = "treeView1";
			treeNode1.Name = "Node4";
			treeNode1.Text = "Node4";
			treeNode2.Name = "Node5";
			treeNode2.Text = "Node5";
			treeNode3.Name = "Node6";
			treeNode3.Text = "Node6";
			treeNode4.Name = "Node3";
			treeNode4.Text = "Node3";
			treeNode5.Name = "Node0";
			treeNode5.Text = "Node0";
			treeNode6.Name = "Node8";
			treeNode6.Text = "Node8";
			treeNode7.Name = "Node9";
			treeNode7.Text = "Node9";
			treeNode8.Name = "Node1";
			treeNode8.Text = "Node1";
			treeNode9.Name = "Node12";
			treeNode9.Text = "Node12";
			treeNode10.Name = "Node10";
			treeNode10.Text = "Node10";
			treeNode11.Name = "Node13";
			treeNode11.Text = "Node13";
			treeNode12.Name = "Node14";
			treeNode12.Text = "Node14";
			treeNode13.Name = "Node11";
			treeNode13.Text = "Node11";
			treeNode14.Name = "Node2";
			treeNode14.Text = "Node2";
			treeNode15.Name = "Node7";
			treeNode15.Text = "Node7";
			this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode8,
            treeNode14,
            treeNode15});
			this.treeView1.Size = new System.Drawing.Size(360, 205);
			this.treeView1.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(10, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(344, 27);
			this.label1.TabIndex = 1;
			this.label1.Text = "Idle";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.Location = new System.Drawing.Point(7, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(347, 18);
			this.label2.TabIndex = 2;
			this.label2.Text = "Started at";
			// 
			// textBox2
			// 
			this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox2.Location = new System.Drawing.Point(10, 86);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox2.Size = new System.Drawing.Size(344, 32);
			this.textBox2.TabIndex = 3;
			this.textBox2.Text = "asd\r\nasd\r\nasd";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.Location = new System.Drawing.Point(7, 70);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(347, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Comment";
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(8, 355);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(116, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "New Event";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.Location = new System.Drawing.Point(130, 355);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(116, 23);
			this.button2.TabIndex = 4;
			this.button2.Text = "Rename";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(252, 355);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(116, 23);
			this.button3.TabIndex = 5;
			this.button3.Text = "Delete";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dateTimePicker1.Location = new System.Drawing.Point(168, 6);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 0;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dateTimePicker2.Location = new System.Drawing.Point(168, 32);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker2.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 6);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(156, 20);
			this.label4.TabIndex = 2;
			this.label4.Text = "Filtering start date";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 32);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(156, 20);
			this.label5.TabIndex = 3;
			this.label5.Text = "Filtering end date";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// listBox1
			// 
			this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(11, 55);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(357, 329);
			this.listBox1.TabIndex = 4;
			// 
			// TimeTrackDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 412);
			this.Controls.Add(this.tabControl1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(400, 450);
			this.Name = "TimeTrackDialog";
			this.Text = "Time Track Helper";
			this.tabControl1.ResumeLayout(false);
			this.timeEventsTabPage.ResumeLayout(false);
			this.timeTrackTabPage.ResumeLayout(false);
			this.activeEventGroupBox.ResumeLayout(false);
			this.activeEventGroupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage timeEventsTabPage;
		private System.Windows.Forms.GroupBox activeEventGroupBox;
		private System.Windows.Forms.TabPage timeTrackTabPage;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
	}
}

