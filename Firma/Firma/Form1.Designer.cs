namespace Firma
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DodajGałąźToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmieńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button3 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(460, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(460, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Zamknij";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DodajGałąźToolStripMenuItem,
            this.dodajToolStripMenuItem,
            this.usuńToolStripMenuItem,
            this.zmieńToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(157, 92);
            // 
            // DodajGałąźToolStripMenuItem
            // 
            this.DodajGałąźToolStripMenuItem.Name = "DodajGałąźToolStripMenuItem";
            this.DodajGałąźToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.DodajGałąźToolStripMenuItem.Text = "Dodaj gałąź";
            this.DodajGałąźToolStripMenuItem.Click += new System.EventHandler(this.DodajGałąźToolStripMenuItem_Click);
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.dodajToolStripMenuItem.Text = "Dodaj podgałąź";
            this.dodajToolStripMenuItem.Click += new System.EventHandler(this.dodajToolStripMenuItem_Click);
            // 
            // usuńToolStripMenuItem
            // 
            this.usuńToolStripMenuItem.Name = "usuńToolStripMenuItem";
            this.usuńToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.usuńToolStripMenuItem.Text = "Usuń";
            this.usuńToolStripMenuItem.Click += new System.EventHandler(this.usuńToolStripMenuItem_Click);
            // 
            // zmieńToolStripMenuItem
            // 
            this.zmieńToolStripMenuItem.Name = "zmieńToolStripMenuItem";
            this.zmieńToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.zmieńToolStripMenuItem.Text = "Zmień";
            this.zmieńToolStripMenuItem.Click += new System.EventHandler(this.zmieńToolStripMenuItem_Click);
            // 
            // treeView1
            // 
            this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
            this.treeView1.Location = new System.Drawing.Point(32, 28);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(400, 387);
            this.treeView1.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(460, 323);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Odczytaj z pliku";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Schemat organizacyjny";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button button1;
        private Button button2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem DodajGałąźToolStripMenuItem;
        private ToolStripMenuItem dodajToolStripMenuItem;
        private ToolStripMenuItem usuńToolStripMenuItem;
        private ToolStripMenuItem zmieńToolStripMenuItem;
        private TreeView treeView1;
        private Button button3;
    }
}