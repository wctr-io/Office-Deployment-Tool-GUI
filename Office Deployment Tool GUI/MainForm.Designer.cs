namespace Office_Deployment_Tool_GUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationTabControl = new System.Windows.Forms.TabControl();
            this.updatesTabPage = new System.Windows.Forms.TabPage();
            this.channelUpdatesRichTextBox = new System.Windows.Forms.TabControl();
            this.readmeUpdatesTabPage = new System.Windows.Forms.TabPage();
            this.readmeUpdatesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.enabledUpdatesTabPage = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.enabledUpdatesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.updatepathUpdatesTabPage = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.updatepathUpdatesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.targetversionUpdatesTabPage = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.targetversionUpdatesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.deadlineUpdatesTabPage = new System.Windows.Forms.TabPage();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.deadlineUpdatesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.channelUpdatesTabPage = new System.Windows.Forms.TabPage();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.readmeTabPage = new System.Windows.Forms.TabPage();
            this.mainMenuStrip.SuspendLayout();
            this.configurationTabControl.SuspendLayout();
            this.updatesTabPage.SuspendLayout();
            this.channelUpdatesRichTextBox.SuspendLayout();
            this.readmeUpdatesTabPage.SuspendLayout();
            this.enabledUpdatesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.updatepathUpdatesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.targetversionUpdatesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.deadlineUpdatesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.channelUpdatesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(584, 24);
            this.mainMenuStrip.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // configurationTabControl
            // 
            this.configurationTabControl.Controls.Add(this.readmeTabPage);
            this.configurationTabControl.Controls.Add(this.updatesTabPage);
            this.configurationTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.configurationTabControl.Location = new System.Drawing.Point(0, 24);
            this.configurationTabControl.Name = "configurationTabControl";
            this.configurationTabControl.SelectedIndex = 0;
            this.configurationTabControl.Size = new System.Drawing.Size(584, 537);
            this.configurationTabControl.TabIndex = 1;
            // 
            // updatesTabPage
            // 
            this.updatesTabPage.Controls.Add(this.channelUpdatesRichTextBox);
            this.updatesTabPage.Location = new System.Drawing.Point(4, 22);
            this.updatesTabPage.Name = "updatesTabPage";
            this.updatesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.updatesTabPage.Size = new System.Drawing.Size(576, 511);
            this.updatesTabPage.TabIndex = 0;
            this.updatesTabPage.Text = "Updates";
            this.updatesTabPage.UseVisualStyleBackColor = true;
            // 
            // channelUpdatesRichTextBox
            // 
            this.channelUpdatesRichTextBox.Controls.Add(this.readmeUpdatesTabPage);
            this.channelUpdatesRichTextBox.Controls.Add(this.enabledUpdatesTabPage);
            this.channelUpdatesRichTextBox.Controls.Add(this.updatepathUpdatesTabPage);
            this.channelUpdatesRichTextBox.Controls.Add(this.targetversionUpdatesTabPage);
            this.channelUpdatesRichTextBox.Controls.Add(this.deadlineUpdatesTabPage);
            this.channelUpdatesRichTextBox.Controls.Add(this.channelUpdatesTabPage);
            this.channelUpdatesRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.channelUpdatesRichTextBox.Location = new System.Drawing.Point(3, 3);
            this.channelUpdatesRichTextBox.Name = "channelUpdatesRichTextBox";
            this.channelUpdatesRichTextBox.SelectedIndex = 0;
            this.channelUpdatesRichTextBox.Size = new System.Drawing.Size(570, 505);
            this.channelUpdatesRichTextBox.TabIndex = 0;
            // 
            // readmeUpdatesTabPage
            // 
            this.readmeUpdatesTabPage.Controls.Add(this.readmeUpdatesRichTextBox);
            this.readmeUpdatesTabPage.Location = new System.Drawing.Point(4, 22);
            this.readmeUpdatesTabPage.Name = "readmeUpdatesTabPage";
            this.readmeUpdatesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.readmeUpdatesTabPage.Size = new System.Drawing.Size(562, 479);
            this.readmeUpdatesTabPage.TabIndex = 0;
            this.readmeUpdatesTabPage.Text = "README";
            this.readmeUpdatesTabPage.UseVisualStyleBackColor = true;
            // 
            // readmeUpdatesRichTextBox
            // 
            this.readmeUpdatesRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.readmeUpdatesRichTextBox.Location = new System.Drawing.Point(3, 3);
            this.readmeUpdatesRichTextBox.Name = "readmeUpdatesRichTextBox";
            this.readmeUpdatesRichTextBox.ReadOnly = true;
            this.readmeUpdatesRichTextBox.Size = new System.Drawing.Size(556, 473);
            this.readmeUpdatesRichTextBox.TabIndex = 1;
            this.readmeUpdatesRichTextBox.Text = "Updates element\n\nDefines how Office is updated after it\'s installed.\n\nExample\n<Up" +
    "dates Enabled=\"TRUE\" \n         UpdatePath=\"\\\\Server\\Share\\\"\n         Channel=\"De" +
    "ferred\" />\n";
            // 
            // enabledUpdatesTabPage
            // 
            this.enabledUpdatesTabPage.Controls.Add(this.splitContainer2);
            this.enabledUpdatesTabPage.Location = new System.Drawing.Point(4, 22);
            this.enabledUpdatesTabPage.Name = "enabledUpdatesTabPage";
            this.enabledUpdatesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.enabledUpdatesTabPage.Size = new System.Drawing.Size(562, 479);
            this.enabledUpdatesTabPage.TabIndex = 1;
            this.enabledUpdatesTabPage.Text = "Enabled";
            this.enabledUpdatesTabPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.enabledUpdatesRichTextBox);
            this.splitContainer2.Size = new System.Drawing.Size(556, 473);
            this.splitContainer2.SplitterDistance = 40;
            this.splitContainer2.TabIndex = 1;
            // 
            // enabledUpdatesRichTextBox
            // 
            this.enabledUpdatesRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enabledUpdatesRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.enabledUpdatesRichTextBox.Name = "enabledUpdatesRichTextBox";
            this.enabledUpdatesRichTextBox.ReadOnly = true;
            this.enabledUpdatesRichTextBox.Size = new System.Drawing.Size(556, 429);
            this.enabledUpdatesRichTextBox.TabIndex = 0;
            this.enabledUpdatesRichTextBox.Text = resources.GetString("enabledUpdatesRichTextBox.Text");
            // 
            // updatepathUpdatesTabPage
            // 
            this.updatepathUpdatesTabPage.Controls.Add(this.splitContainer3);
            this.updatepathUpdatesTabPage.Location = new System.Drawing.Point(4, 22);
            this.updatepathUpdatesTabPage.Name = "updatepathUpdatesTabPage";
            this.updatepathUpdatesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.updatepathUpdatesTabPage.Size = new System.Drawing.Size(562, 479);
            this.updatepathUpdatesTabPage.TabIndex = 2;
            this.updatepathUpdatesTabPage.Text = "Update Path";
            this.updatepathUpdatesTabPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.updatepathUpdatesRichTextBox);
            this.splitContainer3.Size = new System.Drawing.Size(556, 473);
            this.splitContainer3.SplitterDistance = 40;
            this.splitContainer3.TabIndex = 1;
            // 
            // updatepathUpdatesRichTextBox
            // 
            this.updatepathUpdatesRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updatepathUpdatesRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.updatepathUpdatesRichTextBox.Name = "updatepathUpdatesRichTextBox";
            this.updatepathUpdatesRichTextBox.ReadOnly = true;
            this.updatepathUpdatesRichTextBox.Size = new System.Drawing.Size(556, 429);
            this.updatepathUpdatesRichTextBox.TabIndex = 0;
            this.updatepathUpdatesRichTextBox.Text = resources.GetString("updatepathUpdatesRichTextBox.Text");
            // 
            // targetversionUpdatesTabPage
            // 
            this.targetversionUpdatesTabPage.Controls.Add(this.splitContainer4);
            this.targetversionUpdatesTabPage.Location = new System.Drawing.Point(4, 22);
            this.targetversionUpdatesTabPage.Name = "targetversionUpdatesTabPage";
            this.targetversionUpdatesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.targetversionUpdatesTabPage.Size = new System.Drawing.Size(562, 479);
            this.targetversionUpdatesTabPage.TabIndex = 3;
            this.targetversionUpdatesTabPage.Text = "Target Version";
            this.targetversionUpdatesTabPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(3, 3);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.targetversionUpdatesRichTextBox);
            this.splitContainer4.Size = new System.Drawing.Size(556, 473);
            this.splitContainer4.SplitterDistance = 40;
            this.splitContainer4.TabIndex = 1;
            // 
            // targetversionUpdatesRichTextBox
            // 
            this.targetversionUpdatesRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetversionUpdatesRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.targetversionUpdatesRichTextBox.Name = "targetversionUpdatesRichTextBox";
            this.targetversionUpdatesRichTextBox.ReadOnly = true;
            this.targetversionUpdatesRichTextBox.Size = new System.Drawing.Size(556, 429);
            this.targetversionUpdatesRichTextBox.TabIndex = 0;
            this.targetversionUpdatesRichTextBox.Text = resources.GetString("targetversionUpdatesRichTextBox.Text");
            // 
            // deadlineUpdatesTabPage
            // 
            this.deadlineUpdatesTabPage.Controls.Add(this.splitContainer5);
            this.deadlineUpdatesTabPage.Location = new System.Drawing.Point(4, 22);
            this.deadlineUpdatesTabPage.Name = "deadlineUpdatesTabPage";
            this.deadlineUpdatesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.deadlineUpdatesTabPage.Size = new System.Drawing.Size(562, 479);
            this.deadlineUpdatesTabPage.TabIndex = 4;
            this.deadlineUpdatesTabPage.Text = "Deadline";
            this.deadlineUpdatesTabPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(3, 3);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.deadlineUpdatesRichTextBox);
            this.splitContainer5.Size = new System.Drawing.Size(556, 473);
            this.splitContainer5.SplitterDistance = 40;
            this.splitContainer5.TabIndex = 1;
            // 
            // deadlineUpdatesRichTextBox
            // 
            this.deadlineUpdatesRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deadlineUpdatesRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.deadlineUpdatesRichTextBox.Name = "deadlineUpdatesRichTextBox";
            this.deadlineUpdatesRichTextBox.ReadOnly = true;
            this.deadlineUpdatesRichTextBox.Size = new System.Drawing.Size(556, 429);
            this.deadlineUpdatesRichTextBox.TabIndex = 0;
            this.deadlineUpdatesRichTextBox.Text = resources.GetString("deadlineUpdatesRichTextBox.Text");
            // 
            // channelUpdatesTabPage
            // 
            this.channelUpdatesTabPage.Controls.Add(this.splitContainer6);
            this.channelUpdatesTabPage.Location = new System.Drawing.Point(4, 22);
            this.channelUpdatesTabPage.Name = "channelUpdatesTabPage";
            this.channelUpdatesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.channelUpdatesTabPage.Size = new System.Drawing.Size(562, 479);
            this.channelUpdatesTabPage.TabIndex = 5;
            this.channelUpdatesTabPage.Text = "Channel";
            this.channelUpdatesTabPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.Location = new System.Drawing.Point(3, 3);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.richTextBox6);
            this.splitContainer6.Size = new System.Drawing.Size(556, 473);
            this.splitContainer6.SplitterDistance = 40;
            this.splitContainer6.TabIndex = 1;
            // 
            // richTextBox6
            // 
            this.richTextBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox6.Location = new System.Drawing.Point(0, 0);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.ReadOnly = true;
            this.richTextBox6.Size = new System.Drawing.Size(556, 429);
            this.richTextBox6.TabIndex = 0;
            this.richTextBox6.Text = resources.GetString("richTextBox6.Text");
            // 
            // readmeTabPage
            // 
            this.readmeTabPage.Location = new System.Drawing.Point(4, 22);
            this.readmeTabPage.Name = "readmeTabPage";
            this.readmeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.readmeTabPage.Size = new System.Drawing.Size(576, 511);
            this.readmeTabPage.TabIndex = 1;
            this.readmeTabPage.Text = "README";
            this.readmeTabPage.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.configurationTabControl);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Office Deployment Tool GUI";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.configurationTabControl.ResumeLayout(false);
            this.updatesTabPage.ResumeLayout(false);
            this.channelUpdatesRichTextBox.ResumeLayout(false);
            this.readmeUpdatesTabPage.ResumeLayout(false);
            this.enabledUpdatesTabPage.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.updatepathUpdatesTabPage.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.targetversionUpdatesTabPage.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.deadlineUpdatesTabPage.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.channelUpdatesTabPage.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.TabControl configurationTabControl;
        private System.Windows.Forms.TabPage updatesTabPage;
        private System.Windows.Forms.TabControl channelUpdatesRichTextBox;
        private System.Windows.Forms.TabPage readmeUpdatesTabPage;
        private System.Windows.Forms.TabPage enabledUpdatesTabPage;
        private System.Windows.Forms.TabPage updatepathUpdatesTabPage;
        private System.Windows.Forms.TabPage targetversionUpdatesTabPage;
        private System.Windows.Forms.TabPage deadlineUpdatesTabPage;
        private System.Windows.Forms.TabPage channelUpdatesTabPage;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.RichTextBox enabledUpdatesRichTextBox;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.RichTextBox updatepathUpdatesRichTextBox;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.RichTextBox targetversionUpdatesRichTextBox;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.RichTextBox deadlineUpdatesRichTextBox;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.RichTextBox readmeUpdatesRichTextBox;
        private System.Windows.Forms.TabPage readmeTabPage;
    }
}

