namespace mydo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NewFile = new System.Windows.Forms.ToolStripButton();
            this.OpenFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CopyText = new System.Windows.Forms.ToolStripButton();
            this.PasteText = new System.Windows.Forms.ToolStripButton();
            this.Delete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.UndoText = new System.Windows.Forms.ToolStripButton();
            this.RedoText = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ZoomIn = new System.Windows.Forms.ToolStripButton();
            this.ZoomOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.Help = new System.Windows.Forms.ToolStripButton();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.txtsource = new System.Windows.Forms.RichTextBox();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.autocompleteMenu1 = new AutocompleteMenuNS.AutocompleteMenu();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(1215, 480);
            this.splitContainer1.SplitterDistance = 74;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitter1);
            this.splitContainer2.Panel2.Controls.Add(this.button2);
            this.splitContainer2.Panel2.Controls.Add(this.button1);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Size = new System.Drawing.Size(1215, 74);
            this.splitContainer2.SplitterDistance = 33;
            this.splitContainer2.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewFile,
            this.OpenFile,
            this.toolStripSeparator1,
            this.CopyText,
            this.PasteText,
            this.Delete,
            this.toolStripSeparator2,
            this.UndoText,
            this.RedoText,
            this.toolStripSeparator4,
            this.toolStripSeparator5,
            this.ZoomIn,
            this.ZoomOut,
            this.toolStripSeparator6,
            this.Help});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1215, 35);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // NewFile
            // 
            this.NewFile.AutoSize = false;
            this.NewFile.BackColor = System.Drawing.Color.Transparent;
            this.NewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewFile.Image = ((System.Drawing.Image)(resources.GetObject("NewFile.Image")));
            this.NewFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NewFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewFile.Name = "NewFile";
            this.NewFile.Size = new System.Drawing.Size(28, 35);
            this.NewFile.Text = "New File";
            // 
            // OpenFile
            // 
            this.OpenFile.AutoSize = false;
            this.OpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenFile.Image = ((System.Drawing.Image)(resources.GetObject("OpenFile.Image")));
            this.OpenFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.OpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(28, 35);
            this.OpenFile.Text = "Open File...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // CopyText
            // 
            this.CopyText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CopyText.Image = ((System.Drawing.Image)(resources.GetObject("CopyText.Image")));
            this.CopyText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CopyText.Name = "CopyText";
            this.CopyText.Size = new System.Drawing.Size(23, 32);
            this.CopyText.Text = "Copy";
            this.CopyText.Click += new System.EventHandler(this.CopyText_Click_1);
            // 
            // PasteText
            // 
            this.PasteText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PasteText.Image = ((System.Drawing.Image)(resources.GetObject("PasteText.Image")));
            this.PasteText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PasteText.Name = "PasteText";
            this.PasteText.Size = new System.Drawing.Size(23, 32);
            this.PasteText.Text = "Paste";
            this.PasteText.Click += new System.EventHandler(this.PasteText_Click_1);
            // 
            // Delete
            // 
            this.Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(23, 32);
            this.Delete.Text = "Clear all data";
            this.Delete.Click += new System.EventHandler(this.Delete_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // UndoText
            // 
            this.UndoText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UndoText.Image = ((System.Drawing.Image)(resources.GetObject("UndoText.Image")));
            this.UndoText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UndoText.Name = "UndoText";
            this.UndoText.Size = new System.Drawing.Size(23, 32);
            this.UndoText.Text = "Undo";
            this.UndoText.Click += new System.EventHandler(this.UndoText_Click_1);
            // 
            // RedoText
            // 
            this.RedoText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RedoText.Image = ((System.Drawing.Image)(resources.GetObject("RedoText.Image")));
            this.RedoText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RedoText.Name = "RedoText";
            this.RedoText.Size = new System.Drawing.Size(23, 32);
            this.RedoText.Text = "Redo";
            this.RedoText.Click += new System.EventHandler(this.RedoText_Click_1);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 35);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 35);
            // 
            // ZoomIn
            // 
            this.ZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("ZoomIn.Image")));
            this.ZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ZoomIn.Name = "ZoomIn";
            this.ZoomIn.Size = new System.Drawing.Size(23, 32);
            this.ZoomIn.Text = "Zoom In";
            this.ZoomIn.Click += new System.EventHandler(this.ZoomIn_Click_1);
            // 
            // ZoomOut
            // 
            this.ZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("ZoomOut.Image")));
            this.ZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ZoomOut.Name = "ZoomOut";
            this.ZoomOut.Size = new System.Drawing.Size(23, 32);
            this.ZoomOut.Text = "Zoom Out";
            this.ZoomOut.Click += new System.EventHandler(this.ZoomOut_Click_1);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 35);
            // 
            // Help
            // 
            this.Help.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Help.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(34, 32);
            this.Help.Text = "help";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 37);
            this.splitter1.TabIndex = 19;
            this.splitter1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(1007, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 31);
            this.button2.TabIndex = 18;
            this.button2.Text = "JAVA OUT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.ForeColor = System.Drawing.Color.Aqua;
            this.button1.Location = new System.Drawing.Point(50, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "C++";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(973, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "click the button to export  java code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "click the button to import c++ code";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.txtsource);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.txtresult);
            this.splitContainer3.Size = new System.Drawing.Size(1215, 402);
            this.splitContainer3.SplitterDistance = 606;
            this.splitContainer3.TabIndex = 0;
            // 
            // txtsource
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.txtsource, this.autocompleteMenu1);
            this.txtsource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtsource.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsource.Location = new System.Drawing.Point(0, 0);
            this.txtsource.Name = "txtsource";
            this.txtsource.Size = new System.Drawing.Size(606, 402);
            this.txtsource.TabIndex = 9;
            this.txtsource.Text = "";
            this.txtsource.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtsource_MouseClick);
            this.txtsource.HideSelectionChanged += new System.EventHandler(this.txtsource_HideSelectionChanged);
            this.txtsource.TextChanged += new System.EventHandler(this.txtsource_TextChanged);
            this.txtsource.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsource_KeyPress_1);
            // 
            // txtresult
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.txtresult, null);
            this.txtresult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtresult.Location = new System.Drawing.Point(0, 0);
            this.txtresult.Multiline = true;
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(605, 402);
            this.txtresult.TabIndex = 8;
            // 
            // autocompleteMenu1
            // 
            this.autocompleteMenu1.Colors = ((AutocompleteMenuNS.Colors)(resources.GetObject("autocompleteMenu1.Colors")));
            this.autocompleteMenu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.autocompleteMenu1.ImageList = null;
            this.autocompleteMenu1.Items = new string[] {
        "/* */",
        "// ",
        "::",
        "break",
        "case",
        "for()",
        "class",
        "cin ",
        "cout",
        "new",
        "#",
        "continue",
        "char",
        "default",
        "double ",
        "do",
        "else",
        "enum ",
        "FILE ",
        "extern",
        "float",
        "delete",
        "ifstream",
        "goto",
        "if ",
        "inline",
        "int",
        "long ",
        "auto",
        "mutable ",
        "namespace",
        "const ",
        "fstream ",
        "private",
        "protected",
        "public",
        "register",
        "fclose ",
        "return",
        "short ",
        "sizeof ",
        "static",
        "ofstream",
        "struct",
        "switch() ",
        "template",
        "this ",
        "throw ",
        "++",
        "--",
        "try ",
        "typedef ",
        "typeid ",
        "typename ",
        "union ",
        "using",
        "virtual ",
        "void ",
        "volatile ",
        "?",
        "while()",
        "catch",
        "bool",
        "} ",
        "=",
        "->",
        "bool",
        ". ",
        ">>",
        "exit",
        "iostream",
        "include ",
        "<<",
        "() ",
        ";",
        ":",
        "do",
        "\"\"",
        "string"};
            this.autocompleteMenu1.TargetControlWrapper = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1215, 480);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox txtsource;
        private System.Windows.Forms.TextBox txtresult;
        private AutocompleteMenuNS.AutocompleteMenu autocompleteMenu1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NewFile;
        private System.Windows.Forms.ToolStripButton OpenFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton CopyText;
        private System.Windows.Forms.ToolStripButton PasteText;
        private System.Windows.Forms.ToolStripButton Delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton UndoText;
        private System.Windows.Forms.ToolStripButton RedoText;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton ZoomIn;
        private System.Windows.Forms.ToolStripButton ZoomOut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStripButton Help;
    }
}

