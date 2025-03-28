namespace LobotomyInjector
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.richTextBox_ScriptInput = new System.Windows.Forms.RichTextBox();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.buttonClearRichTextBox = new System.Windows.Forms.Button();
            this.buttonInject = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelProgramName = new System.Windows.Forms.Label();
            this.buttonMinimaze = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.contextMenuStripMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.processKillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.listBoxSaveScripts = new System.Windows.Forms.ListBox();
            this.buttonAddScript = new System.Windows.Forms.Button();
            this.buttonRemoveScript = new System.Windows.Forms.Button();
            this.textBoxScriptNameInput = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.contextMenuStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox_ScriptInput
            // 
            this.richTextBox_ScriptInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.richTextBox_ScriptInput.Font = new System.Drawing.Font("Fira Code", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_ScriptInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.richTextBox_ScriptInput.Location = new System.Drawing.Point(12, 31);
            this.richTextBox_ScriptInput.Name = "richTextBox_ScriptInput";
            this.richTextBox_ScriptInput.Size = new System.Drawing.Size(484, 251);
            this.richTextBox_ScriptInput.TabIndex = 0;
            this.richTextBox_ScriptInput.Text = "";
            // 
            // buttonExecute
            // 
            this.buttonExecute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(114)))), ((int)(((byte)(164)))));
            this.buttonExecute.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.buttonExecute.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(89)))), ((int)(((byte)(128)))));
            this.buttonExecute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(131)))), ((int)(((byte)(182)))));
            this.buttonExecute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExecute.Font = new System.Drawing.Font("Fira Code", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExecute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.buttonExecute.Location = new System.Drawing.Point(12, 315);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(100, 25);
            this.buttonExecute.TabIndex = 1;
            this.buttonExecute.Text = "Execute";
            this.buttonExecute.UseVisualStyleBackColor = false;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // buttonClearRichTextBox
            // 
            this.buttonClearRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(114)))), ((int)(((byte)(164)))));
            this.buttonClearRichTextBox.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.buttonClearRichTextBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(89)))), ((int)(((byte)(128)))));
            this.buttonClearRichTextBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(131)))), ((int)(((byte)(182)))));
            this.buttonClearRichTextBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearRichTextBox.Font = new System.Drawing.Font("Fira Code", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearRichTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.buttonClearRichTextBox.Location = new System.Drawing.Point(119, 315);
            this.buttonClearRichTextBox.Name = "buttonClearRichTextBox";
            this.buttonClearRichTextBox.Size = new System.Drawing.Size(100, 25);
            this.buttonClearRichTextBox.TabIndex = 2;
            this.buttonClearRichTextBox.Text = "Clear";
            this.buttonClearRichTextBox.UseVisualStyleBackColor = false;
            this.buttonClearRichTextBox.Click += new System.EventHandler(this.buttonClearRichTextBox_Click);
            // 
            // buttonInject
            // 
            this.buttonInject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(114)))), ((int)(((byte)(164)))));
            this.buttonInject.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.buttonInject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(89)))), ((int)(((byte)(128)))));
            this.buttonInject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(131)))), ((int)(((byte)(182)))));
            this.buttonInject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInject.Font = new System.Drawing.Font("Fira Code", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.buttonInject.Location = new System.Drawing.Point(396, 315);
            this.buttonInject.Name = "buttonInject";
            this.buttonInject.Size = new System.Drawing.Size(100, 25);
            this.buttonInject.TabIndex = 3;
            this.buttonInject.Text = "Inject";
            this.buttonInject.UseVisualStyleBackColor = false;
            this.buttonInject.Click += new System.EventHandler(this.buttonInject_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelProgramName);
            this.panel1.Controls.Add(this.buttonMinimaze);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 25);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // labelProgramName
            // 
            this.labelProgramName.AutoSize = true;
            this.labelProgramName.Font = new System.Drawing.Font("Fira Code", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgramName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.labelProgramName.Location = new System.Drawing.Point(12, 5);
            this.labelProgramName.Name = "labelProgramName";
            this.labelProgramName.Size = new System.Drawing.Size(84, 13);
            this.labelProgramName.TabIndex = 2;
            this.labelProgramName.Text = "ProgramName";
            // 
            // buttonMinimaze
            // 
            this.buttonMinimaze.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(114)))), ((int)(((byte)(164)))));
            this.buttonMinimaze.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.buttonMinimaze.FlatAppearance.BorderSize = 0;
            this.buttonMinimaze.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(89)))), ((int)(((byte)(128)))));
            this.buttonMinimaze.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(131)))), ((int)(((byte)(182)))));
            this.buttonMinimaze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimaze.Font = new System.Drawing.Font("Fira Code", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinimaze.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.buttonMinimaze.Location = new System.Drawing.Point(569, 2);
            this.buttonMinimaze.Name = "buttonMinimaze";
            this.buttonMinimaze.Size = new System.Drawing.Size(70, 20);
            this.buttonMinimaze.TabIndex = 1;
            this.buttonMinimaze.Text = "-";
            this.buttonMinimaze.UseVisualStyleBackColor = false;
            this.buttonMinimaze.Click += new System.EventHandler(this.buttonMinimaze_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Fira Code", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.buttonClose.Location = new System.Drawing.Point(645, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(70, 20);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // contextMenuStripMenu
            // 
            this.contextMenuStripMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(114)))), ((int)(((byte)(164)))));
            this.contextMenuStripMenu.Font = new System.Drawing.Font("Fira Code", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processKillToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripMenuItem1});
            this.contextMenuStripMenu.Name = "contextMenuStripMenu";
            this.contextMenuStripMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStripMenu.ShowImageMargin = false;
            this.contextMenuStripMenu.Size = new System.Drawing.Size(134, 54);
            // 
            // processKillToolStripMenuItem
            // 
            this.processKillToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.processKillToolStripMenuItem.Name = "processKillToolStripMenuItem";
            this.processKillToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.processKillToolStripMenuItem.Text = "Process Kill";
            this.processKillToolStripMenuItem.Click += new System.EventHandler(this.processKillToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(130, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItem1.Text = "About";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(114)))), ((int)(((byte)(164)))));
            this.buttonMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.buttonMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(89)))), ((int)(((byte)(128)))));
            this.buttonMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(131)))), ((int)(((byte)(182)))));
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenu.Font = new System.Drawing.Font("Fira Code", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.buttonMenu.Location = new System.Drawing.Point(290, 315);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(100, 25);
            this.buttonMenu.TabIndex = 6;
            this.buttonMenu.Text = "...";
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // listBoxSaveScripts
            // 
            this.listBoxSaveScripts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.listBoxSaveScripts.Font = new System.Drawing.Font("Fira Code", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSaveScripts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.listBoxSaveScripts.FormattingEnabled = true;
            this.listBoxSaveScripts.Location = new System.Drawing.Point(502, 31);
            this.listBoxSaveScripts.Name = "listBoxSaveScripts";
            this.listBoxSaveScripts.Size = new System.Drawing.Size(205, 251);
            this.listBoxSaveScripts.TabIndex = 7;
            this.listBoxSaveScripts.SelectedIndexChanged += new System.EventHandler(this.listBoxSaveScripts_SelectedIndexChanged);
            // 
            // buttonAddScript
            // 
            this.buttonAddScript.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(114)))), ((int)(((byte)(164)))));
            this.buttonAddScript.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.buttonAddScript.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(89)))), ((int)(((byte)(128)))));
            this.buttonAddScript.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(131)))), ((int)(((byte)(182)))));
            this.buttonAddScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddScript.Font = new System.Drawing.Font("Fira Code", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddScript.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.buttonAddScript.Location = new System.Drawing.Point(502, 315);
            this.buttonAddScript.Name = "buttonAddScript";
            this.buttonAddScript.Size = new System.Drawing.Size(100, 25);
            this.buttonAddScript.TabIndex = 8;
            this.buttonAddScript.Text = "Add";
            this.buttonAddScript.UseVisualStyleBackColor = false;
            this.buttonAddScript.Click += new System.EventHandler(this.buttonAddScript_Click);
            // 
            // buttonRemoveScript
            // 
            this.buttonRemoveScript.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(114)))), ((int)(((byte)(164)))));
            this.buttonRemoveScript.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.buttonRemoveScript.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(89)))), ((int)(((byte)(128)))));
            this.buttonRemoveScript.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(131)))), ((int)(((byte)(182)))));
            this.buttonRemoveScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveScript.Font = new System.Drawing.Font("Fira Code", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveScript.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.buttonRemoveScript.Location = new System.Drawing.Point(607, 315);
            this.buttonRemoveScript.Name = "buttonRemoveScript";
            this.buttonRemoveScript.Size = new System.Drawing.Size(100, 25);
            this.buttonRemoveScript.TabIndex = 9;
            this.buttonRemoveScript.Text = "Remove";
            this.buttonRemoveScript.UseVisualStyleBackColor = false;
            this.buttonRemoveScript.Click += new System.EventHandler(this.buttonRemoveScript_Click);
            // 
            // textBoxScriptNameInput
            // 
            this.textBoxScriptNameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.textBoxScriptNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxScriptNameInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxScriptNameInput.Font = new System.Drawing.Font("Fira Code", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxScriptNameInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.textBoxScriptNameInput.Location = new System.Drawing.Point(502, 288);
            this.textBoxScriptNameInput.Name = "textBoxScriptNameInput";
            this.textBoxScriptNameInput.Size = new System.Drawing.Size(205, 21);
            this.textBoxScriptNameInput.TabIndex = 10;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(720, 350);
            this.Controls.Add(this.textBoxScriptNameInput);
            this.Controls.Add(this.buttonRemoveScript);
            this.Controls.Add(this.buttonAddScript);
            this.Controls.Add(this.listBoxSaveScripts);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonInject);
            this.Controls.Add(this.buttonClearRichTextBox);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.richTextBox_ScriptInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LobotomyInjector";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStripMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_ScriptInput;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.Button buttonClearRichTextBox;
        private System.Windows.Forms.Button buttonInject;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonMinimaze;
        private System.Windows.Forms.Label labelProgramName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.ListBox listBoxSaveScripts;
        private System.Windows.Forms.Button buttonAddScript;
        private System.Windows.Forms.Button buttonRemoveScript;
        private System.Windows.Forms.ToolStripMenuItem processKillToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TextBox textBoxScriptNameInput;
    }
}

