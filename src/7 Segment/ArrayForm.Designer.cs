namespace _7_Segment
{
    partial class ArrayForm
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
            this.ArrayValue = new System.Windows.Forms.TextBox();
            this.CopyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.CharSetSelect = new System.Windows.Forms.ComboBox();
            this.SystemValueSelect = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.CopyMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ArrayValue
            // 
            this.ArrayValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArrayValue.BackColor = System.Drawing.Color.White;
            this.ArrayValue.ContextMenuStrip = this.CopyMenu;
            this.ArrayValue.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ArrayValue.Location = new System.Drawing.Point(0, 0);
            this.ArrayValue.Multiline = true;
            this.ArrayValue.Name = "ArrayValue";
            this.ArrayValue.ReadOnly = true;
            this.ArrayValue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ArrayValue.Size = new System.Drawing.Size(269, 189);
            this.ArrayValue.TabIndex = 0;
            // 
            // CopyMenu
            // 
            this.CopyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.CopyMenu.Name = "CopyMenu";
            this.CopyMenu.Size = new System.Drawing.Size(103, 26);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = global::_7_Segment.Properties.Resources.Copy;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CharSet:";
            // 
            // CharSetSelect
            // 
            this.CharSetSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CharSetSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CharSetSelect.FormattingEnabled = true;
            this.CharSetSelect.Items.AddRange(new object[] {
            "0..9",
            "0..F"});
            this.CharSetSelect.Location = new System.Drawing.Point(5, 206);
            this.CharSetSelect.Name = "CharSetSelect";
            this.CharSetSelect.Size = new System.Drawing.Size(68, 21);
            this.CharSetSelect.TabIndex = 2;
            this.CharSetSelect.SelectedIndexChanged += new System.EventHandler(this.OnChange);
            // 
            // SystemValueSelect
            // 
            this.SystemValueSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SystemValueSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SystemValueSelect.FormattingEnabled = true;
            this.SystemValueSelect.Items.AddRange(new object[] {
            "binary",
            "octal",
            "decimal",
            "hexadecimal"});
            this.SystemValueSelect.Location = new System.Drawing.Point(79, 206);
            this.SystemValueSelect.Name = "SystemValueSelect";
            this.SystemValueSelect.Size = new System.Drawing.Size(103, 21);
            this.SystemValueSelect.TabIndex = 4;
            this.SystemValueSelect.SelectedIndexChanged += new System.EventHandler(this.OnChange);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "System value:";
            // 
            // ButtonClose
            // 
            this.ButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonClose.Location = new System.Drawing.Point(188, 205);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(75, 23);
            this.ButtonClose.TabIndex = 5;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonCloseClick);
            // 
            // ArrayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 234);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.SystemValueSelect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CharSetSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ArrayValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = global::_7_Segment.Properties.Resources.icon;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(284, 1000);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(284, 268);
            this.Name = "ArrayForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Array";
            this.CopyMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ArrayValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CharSetSelect;
        private System.Windows.Forms.ComboBox SystemValueSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.ContextMenuStrip CopyMenu;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
    }
}