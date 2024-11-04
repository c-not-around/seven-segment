namespace _7_Segment
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SegmentsBindingBox = new System.Windows.Forms.GroupBox();
            this.BindSegmentDp = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BindSegmentG = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BindSegmentF = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BindSegmentE = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BindSegmentD = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BindSegmentC = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BindSegmentB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BindSegmentA = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CommonBox = new System.Windows.Forms.GroupBox();
            this.CommonCathode = new System.Windows.Forms.RadioButton();
            this.CommonAnode = new System.Windows.Forms.RadioButton();
            this.SystemValueBox = new System.Windows.Forms.GroupBox();
            this.Hex = new System.Windows.Forms.RadioButton();
            this.Oct = new System.Windows.Forms.RadioButton();
            this.Dec = new System.Windows.Forms.RadioButton();
            this.Bin = new System.Windows.Forms.RadioButton();
            this.FillUnsedBitsBox = new System.Windows.Forms.GroupBox();
            this.FillUnusedBitsOne = new System.Windows.Forms.RadioButton();
            this.FillUnusedBitsZero = new System.Windows.Forms.RadioButton();
            this.Value = new System.Windows.Forms.TextBox();
            this.CopyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ArrayGenerate = new System.Windows.Forms.Button();
            this.Indikator = new _7_Segment.SegmentIndikator();
            this.SegmentsBindingBox.SuspendLayout();
            this.CommonBox.SuspendLayout();
            this.SystemValueBox.SuspendLayout();
            this.FillUnsedBitsBox.SuspendLayout();
            this.CopyMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // SegmentsBindingBox
            // 
            this.SegmentsBindingBox.Controls.Add(this.BindSegmentDp);
            this.SegmentsBindingBox.Controls.Add(this.label5);
            this.SegmentsBindingBox.Controls.Add(this.BindSegmentG);
            this.SegmentsBindingBox.Controls.Add(this.label6);
            this.SegmentsBindingBox.Controls.Add(this.BindSegmentF);
            this.SegmentsBindingBox.Controls.Add(this.label7);
            this.SegmentsBindingBox.Controls.Add(this.BindSegmentE);
            this.SegmentsBindingBox.Controls.Add(this.label8);
            this.SegmentsBindingBox.Controls.Add(this.BindSegmentD);
            this.SegmentsBindingBox.Controls.Add(this.label4);
            this.SegmentsBindingBox.Controls.Add(this.BindSegmentC);
            this.SegmentsBindingBox.Controls.Add(this.label3);
            this.SegmentsBindingBox.Controls.Add(this.BindSegmentB);
            this.SegmentsBindingBox.Controls.Add(this.label2);
            this.SegmentsBindingBox.Controls.Add(this.BindSegmentA);
            this.SegmentsBindingBox.Controls.Add(this.label1);
            this.SegmentsBindingBox.Location = new System.Drawing.Point(198, 12);
            this.SegmentsBindingBox.Name = "SegmentsBindingBox";
            this.SegmentsBindingBox.Size = new System.Drawing.Size(184, 103);
            this.SegmentsBindingBox.TabIndex = 1;
            this.SegmentsBindingBox.TabStop = false;
            this.SegmentsBindingBox.Text = "Segments Binding";
            // 
            // BindSegmentDp
            // 
            this.BindSegmentDp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BindSegmentDp.FormattingEnabled = true;
            this.BindSegmentDp.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "off"});
            this.BindSegmentDp.Location = new System.Drawing.Point(138, 73);
            this.BindSegmentDp.Name = "BindSegmentDp";
            this.BindSegmentDp.Size = new System.Drawing.Size(37, 21);
            this.BindSegmentDp.TabIndex = 15;
            this.BindSegmentDp.Tag = LedSegment.DP;
            this.BindSegmentDp.SelectedIndexChanged += new System.EventHandler(this.OnChange);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "dp:";
            // 
            // BindSegmentG
            // 
            this.BindSegmentG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BindSegmentG.FormattingEnabled = true;
            this.BindSegmentG.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "off"});
            this.BindSegmentG.Location = new System.Drawing.Point(95, 73);
            this.BindSegmentG.Name = "BindSegmentG";
            this.BindSegmentG.Size = new System.Drawing.Size(37, 21);
            this.BindSegmentG.TabIndex = 13;
            this.BindSegmentG.Tag = LedSegment.G;
            this.BindSegmentG.SelectedIndexChanged += new System.EventHandler(this.OnChange);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "G:";
            // 
            // BindSegmentF
            // 
            this.BindSegmentF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BindSegmentF.FormattingEnabled = true;
            this.BindSegmentF.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "off"});
            this.BindSegmentF.Location = new System.Drawing.Point(52, 73);
            this.BindSegmentF.Name = "BindSegmentF";
            this.BindSegmentF.Size = new System.Drawing.Size(37, 21);
            this.BindSegmentF.TabIndex = 11;
            this.BindSegmentF.Tag = LedSegment.F;
            this.BindSegmentF.SelectedIndexChanged += new System.EventHandler(this.OnChange);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "F:";
            // 
            // BindSegmentE
            // 
            this.BindSegmentE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BindSegmentE.FormattingEnabled = true;
            this.BindSegmentE.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "off"});
            this.BindSegmentE.Location = new System.Drawing.Point(9, 73);
            this.BindSegmentE.Name = "BindSegmentE";
            this.BindSegmentE.Size = new System.Drawing.Size(37, 21);
            this.BindSegmentE.TabIndex = 9;
            this.BindSegmentE.Tag = LedSegment.E;
            this.BindSegmentE.SelectedIndexChanged += new System.EventHandler(this.OnChange);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "E:";
            // 
            // BindSegmentD
            // 
            this.BindSegmentD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BindSegmentD.FormattingEnabled = true;
            this.BindSegmentD.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "off"});
            this.BindSegmentD.Location = new System.Drawing.Point(138, 30);
            this.BindSegmentD.Name = "BindSegmentD";
            this.BindSegmentD.Size = new System.Drawing.Size(37, 21);
            this.BindSegmentD.TabIndex = 7;
            this.BindSegmentD.Tag = LedSegment.D;
            this.BindSegmentD.SelectedIndexChanged += new System.EventHandler(this.OnChange);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "D:";
            // 
            // BindSegmentC
            // 
            this.BindSegmentC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BindSegmentC.FormattingEnabled = true;
            this.BindSegmentC.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "off"});
            this.BindSegmentC.Location = new System.Drawing.Point(95, 30);
            this.BindSegmentC.Name = "BindSegmentC";
            this.BindSegmentC.Size = new System.Drawing.Size(37, 21);
            this.BindSegmentC.TabIndex = 5;
            this.BindSegmentC.Tag = LedSegment.C;
            this.BindSegmentC.SelectedIndexChanged += new System.EventHandler(this.OnChange);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "C:";
            // 
            // BindSegmentB
            // 
            this.BindSegmentB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BindSegmentB.FormattingEnabled = true;
            this.BindSegmentB.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "off"});
            this.BindSegmentB.Location = new System.Drawing.Point(52, 30);
            this.BindSegmentB.Name = "BindSegmentB";
            this.BindSegmentB.Size = new System.Drawing.Size(37, 21);
            this.BindSegmentB.TabIndex = 3;
            this.BindSegmentB.Tag = LedSegment.B;
            this.BindSegmentB.SelectedIndexChanged += new System.EventHandler(this.OnChange);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "B:";
            // 
            // BindSegmentA
            // 
            this.BindSegmentA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BindSegmentA.FormattingEnabled = true;
            this.BindSegmentA.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "off"});
            this.BindSegmentA.Location = new System.Drawing.Point(9, 30);
            this.BindSegmentA.Name = "BindSegmentA";
            this.BindSegmentA.Size = new System.Drawing.Size(37, 21);
            this.BindSegmentA.TabIndex = 1;
            this.BindSegmentA.Tag = LedSegment.A;
            this.BindSegmentA.SelectedIndexChanged += new System.EventHandler(this.OnChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "A:";
            // 
            // CommonBox
            // 
            this.CommonBox.Controls.Add(this.CommonCathode);
            this.CommonBox.Controls.Add(this.CommonAnode);
            this.CommonBox.Location = new System.Drawing.Point(198, 121);
            this.CommonBox.Name = "CommonBox";
            this.CommonBox.Size = new System.Drawing.Size(77, 55);
            this.CommonBox.TabIndex = 2;
            this.CommonBox.TabStop = false;
            this.CommonBox.Text = "Common";
            // 
            // CommonCathode
            // 
            this.CommonCathode.Checked = true;
            this.CommonCathode.Location = new System.Drawing.Point(6, 34);
            this.CommonCathode.Name = "CommonCathode";
            this.CommonCathode.Size = new System.Drawing.Size(65, 15);
            this.CommonCathode.TabIndex = 1;
            this.CommonCathode.TabStop = true;
            this.CommonCathode.Text = "Cathode";
            this.CommonCathode.UseVisualStyleBackColor = true;
            this.CommonCathode.CheckedChanged += new System.EventHandler(this.OnChange);
            // 
            // CommonAnode
            // 
            this.CommonAnode.BackColor = System.Drawing.SystemColors.Control;
            this.CommonAnode.Location = new System.Drawing.Point(6, 16);
            this.CommonAnode.Name = "CommonAnode";
            this.CommonAnode.Size = new System.Drawing.Size(60, 15);
            this.CommonAnode.TabIndex = 0;
            this.CommonAnode.Text = "Anode";
            this.CommonAnode.UseVisualStyleBackColor = false;
            this.CommonAnode.CheckedChanged += new System.EventHandler(this.OnChange);
            // 
            // SystemValueBox
            // 
            this.SystemValueBox.Controls.Add(this.Hex);
            this.SystemValueBox.Controls.Add(this.Oct);
            this.SystemValueBox.Controls.Add(this.Dec);
            this.SystemValueBox.Controls.Add(this.Bin);
            this.SystemValueBox.Location = new System.Drawing.Point(281, 121);
            this.SystemValueBox.Name = "SystemValueBox";
            this.SystemValueBox.Size = new System.Drawing.Size(101, 55);
            this.SystemValueBox.TabIndex = 3;
            this.SystemValueBox.TabStop = false;
            this.SystemValueBox.Text = "System Value";
            // 
            // Hex
            // 
            this.Hex.BackColor = System.Drawing.SystemColors.Control;
            this.Hex.Location = new System.Drawing.Point(50, 34);
            this.Hex.Name = "Hex";
            this.Hex.Size = new System.Drawing.Size(45, 15);
            this.Hex.TabIndex = 5;
            this.Hex.Text = "Hex";
            this.Hex.UseVisualStyleBackColor = false;
            this.Hex.CheckedChanged += new System.EventHandler(this.OnChange);
            // 
            // Oct
            // 
            this.Oct.BackColor = System.Drawing.SystemColors.Control;
            this.Oct.Location = new System.Drawing.Point(50, 16);
            this.Oct.Name = "Oct";
            this.Oct.Size = new System.Drawing.Size(43, 15);
            this.Oct.TabIndex = 6;
            this.Oct.Text = "Oct";
            this.Oct.UseVisualStyleBackColor = false;
            this.Oct.CheckedChanged += new System.EventHandler(this.OnChange);
            // 
            // Dec
            // 
            this.Dec.BackColor = System.Drawing.SystemColors.Control;
            this.Dec.Checked = true;
            this.Dec.Location = new System.Drawing.Point(6, 34);
            this.Dec.Name = "Dec";
            this.Dec.Size = new System.Drawing.Size(45, 15);
            this.Dec.TabIndex = 4;
            this.Dec.TabStop = true;
            this.Dec.Text = "Dec";
            this.Dec.UseVisualStyleBackColor = false;
            this.Dec.CheckedChanged += new System.EventHandler(this.OnChange);
            // 
            // Bin
            // 
            this.Bin.BackColor = System.Drawing.SystemColors.Control;
            this.Bin.Location = new System.Drawing.Point(6, 16);
            this.Bin.Name = "Bin";
            this.Bin.Size = new System.Drawing.Size(43, 15);
            this.Bin.TabIndex = 4;
            this.Bin.Text = "Bin";
            this.Bin.UseVisualStyleBackColor = false;
            this.Bin.CheckedChanged += new System.EventHandler(this.OnChange);
            // 
            // FillUnsedBitsBox
            // 
            this.FillUnsedBitsBox.Controls.Add(this.FillUnusedBitsOne);
            this.FillUnsedBitsBox.Controls.Add(this.FillUnusedBitsZero);
            this.FillUnsedBitsBox.Location = new System.Drawing.Point(198, 182);
            this.FillUnsedBitsBox.Name = "FillUnsedBitsBox";
            this.FillUnsedBitsBox.Size = new System.Drawing.Size(184, 42);
            this.FillUnsedBitsBox.TabIndex = 4;
            this.FillUnsedBitsBox.TabStop = false;
            this.FillUnsedBitsBox.Text = "Fill Unsed Bits";
            // 
            // FillUnusedBitsOne
            // 
            this.FillUnusedBitsOne.Location = new System.Drawing.Point(89, 19);
            this.FillUnusedBitsOne.Name = "FillUnusedBitsOne";
            this.FillUnusedBitsOne.Size = new System.Drawing.Size(65, 15);
            this.FillUnusedBitsOne.TabIndex = 6;
            this.FillUnusedBitsOne.Text = "One";
            this.FillUnusedBitsOne.UseVisualStyleBackColor = true;
            this.FillUnusedBitsOne.CheckedChanged += new System.EventHandler(this.OnChange);
            // 
            // FillUnusedBitsZero
            // 
            this.FillUnusedBitsZero.Checked = true;
            this.FillUnusedBitsZero.Location = new System.Drawing.Point(6, 19);
            this.FillUnusedBitsZero.Name = "FillUnusedBitsZero";
            this.FillUnusedBitsZero.Size = new System.Drawing.Size(65, 15);
            this.FillUnusedBitsZero.TabIndex = 5;
            this.FillUnusedBitsZero.TabStop = true;
            this.FillUnusedBitsZero.Text = "Zero";
            this.FillUnusedBitsZero.UseVisualStyleBackColor = true;
            this.FillUnusedBitsZero.CheckedChanged += new System.EventHandler(this.OnChange);
            // 
            // Value
            // 
            this.Value.BackColor = System.Drawing.Color.White;
            this.Value.ContextMenuStrip = this.CopyMenu;
            this.Value.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Value.Location = new System.Drawing.Point(198, 249);
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            this.Value.Size = new System.Drawing.Size(114, 23);
            this.Value.TabIndex = 5;
            this.Value.Text = "0";
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
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.ValueCopyClick);
            // 
            // ArrayGenerate
            // 
            this.ArrayGenerate.Location = new System.Drawing.Point(318, 248);
            this.ArrayGenerate.Name = "ArrayGenerate";
            this.ArrayGenerate.Size = new System.Drawing.Size(63, 24);
            this.ArrayGenerate.TabIndex = 6;
            this.ArrayGenerate.Text = "Array";
            this.ArrayGenerate.UseVisualStyleBackColor = true;
            this.ArrayGenerate.Click += new System.EventHandler(this.ArrayClick);
            // 
            // Indikator
            // 
            this.Indikator.Location = new System.Drawing.Point(12, 12);
            this.Indikator.Name = "Indikator";
            this.Indikator.Size = new System.Drawing.Size(172, 260);
            this.Indikator.TabIndex = 0;
            this.Indikator.Text = "segmentIndikator1";
            this.Indikator.SegmentsChanged += new System.EventHandler(this.OnChange);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 284);
            this.Controls.Add(this.ArrayGenerate);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.FillUnsedBitsBox);
            this.Controls.Add(this.SystemValueBox);
            this.Controls.Add(this.CommonBox);
            this.Controls.Add(this.SegmentsBindingBox);
            this.Controls.Add(this.Indikator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = global::_7_Segment.Properties.Resources.icon;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "7 Segment Indikator";
            this.SegmentsBindingBox.ResumeLayout(false);
            this.SegmentsBindingBox.PerformLayout();
            this.CommonBox.ResumeLayout(false);
            this.SystemValueBox.ResumeLayout(false);
            this.FillUnsedBitsBox.ResumeLayout(false);
            this.CopyMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SegmentIndikator Indikator;
        private System.Windows.Forms.GroupBox SegmentsBindingBox;
        private System.Windows.Forms.ComboBox BindSegmentA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BindSegmentDp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox BindSegmentG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox BindSegmentF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox BindSegmentE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox BindSegmentD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox BindSegmentC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox BindSegmentB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox CommonBox;
        private System.Windows.Forms.RadioButton CommonCathode;
        private System.Windows.Forms.RadioButton CommonAnode;
        private System.Windows.Forms.GroupBox SystemValueBox;
        private System.Windows.Forms.RadioButton Hex;
        private System.Windows.Forms.RadioButton Oct;
        private System.Windows.Forms.RadioButton Dec;
        private System.Windows.Forms.RadioButton Bin;
        private System.Windows.Forms.GroupBox FillUnsedBitsBox;
        private System.Windows.Forms.RadioButton FillUnusedBitsOne;
        private System.Windows.Forms.RadioButton FillUnusedBitsZero;
        private System.Windows.Forms.TextBox Value;
        private System.Windows.Forms.Button ArrayGenerate;
        private System.Windows.Forms.ContextMenuStrip CopyMenu;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
    }
}

