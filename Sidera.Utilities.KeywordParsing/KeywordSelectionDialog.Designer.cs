namespace Sidera.Utilities.KeywordParsing
{
    partial class KeywordSelectionDialog
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
            this.grpKeywordSelector = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tpnlLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblExpression = new System.Windows.Forms.Label();
            this.txtExpression = new System.Windows.Forms.TextBox();
            this.lblSample = new System.Windows.Forms.Label();
            this.txtSample = new System.Windows.Forms.TextBox();
            this.lvwKeywords = new System.Windows.Forms.ListView();
            this.chkFormat = new System.Windows.Forms.CheckBox();
            this.txtFormat = new System.Windows.Forms.TextBox();
            this.chkSubstring = new System.Windows.Forms.CheckBox();
            this.lblSubstringStart = new System.Windows.Forms.Label();
            this.lblSubstringLength = new System.Windows.Forms.Label();
            this.nudSubstringLength = new System.Windows.Forms.NumericUpDown();
            this.chkCasing = new System.Windows.Forms.CheckBox();
            this.cbxCasing = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.nudSubstringStart = new System.Windows.Forms.NumericUpDown();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.grpKeywordSelector.SuspendLayout();
            this.tpnlLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSubstringLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSubstringStart)).BeginInit();
            this.SuspendLayout();
            // 
            // grpKeywordSelector
            // 
            this.grpKeywordSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpKeywordSelector.Controls.Add(this.tpnlLayout);
            this.grpKeywordSelector.Location = new System.Drawing.Point(13, 13);
            this.grpKeywordSelector.Name = "grpKeywordSelector";
            this.grpKeywordSelector.Size = new System.Drawing.Size(759, 707);
            this.grpKeywordSelector.TabIndex = 0;
            this.grpKeywordSelector.TabStop = false;
            this.grpKeywordSelector.Text = "Keyword selector";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(616, 726);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(697, 726);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tpnlLayout
            // 
            this.tpnlLayout.ColumnCount = 6;
            this.tpnlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tpnlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tpnlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tpnlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tpnlLayout.Controls.Add(this.lblExpression, 0, 0);
            this.tpnlLayout.Controls.Add(this.txtExpression, 1, 0);
            this.tpnlLayout.Controls.Add(this.lblSample, 0, 1);
            this.tpnlLayout.Controls.Add(this.txtSample, 1, 1);
            this.tpnlLayout.Controls.Add(this.chkFormat, 0, 3);
            this.tpnlLayout.Controls.Add(this.lvwKeywords, 0, 2);
            this.tpnlLayout.Controls.Add(this.txtFormat, 1, 3);
            this.tpnlLayout.Controls.Add(this.chkSubstring, 0, 4);
            this.tpnlLayout.Controls.Add(this.lblSubstringStart, 1, 4);
            this.tpnlLayout.Controls.Add(this.lblSubstringLength, 3, 4);
            this.tpnlLayout.Controls.Add(this.nudSubstringLength, 4, 4);
            this.tpnlLayout.Controls.Add(this.chkCasing, 0, 5);
            this.tpnlLayout.Controls.Add(this.cbxCasing, 1, 5);
            this.tpnlLayout.Controls.Add(this.btnAdd, 5, 3);
            this.tpnlLayout.Controls.Add(this.nudSubstringStart, 2, 4);
            this.tpnlLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlLayout.Location = new System.Drawing.Point(3, 16);
            this.tpnlLayout.Name = "tpnlLayout";
            this.tpnlLayout.RowCount = 6;
            this.tpnlLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tpnlLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tpnlLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tpnlLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tpnlLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tpnlLayout.Size = new System.Drawing.Size(753, 688);
            this.tpnlLayout.TabIndex = 0;
            // 
            // lblExpression
            // 
            this.lblExpression.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblExpression.AutoSize = true;
            this.lblExpression.Location = new System.Drawing.Point(15, 6);
            this.lblExpression.Name = "lblExpression";
            this.lblExpression.Size = new System.Drawing.Size(58, 13);
            this.lblExpression.TabIndex = 0;
            this.lblExpression.Text = "Expression";
            // 
            // txtExpression
            // 
            this.tpnlLayout.SetColumnSpan(this.txtExpression, 5);
            this.txtExpression.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtExpression.Location = new System.Drawing.Point(79, 3);
            this.txtExpression.MaxLength = 0;
            this.txtExpression.Name = "txtExpression";
            this.txtExpression.Size = new System.Drawing.Size(671, 20);
            this.txtExpression.TabIndex = 1;
            // 
            // lblSample
            // 
            this.lblSample.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSample.AutoSize = true;
            this.lblSample.Location = new System.Drawing.Point(31, 32);
            this.lblSample.Name = "lblSample";
            this.lblSample.Size = new System.Drawing.Size(42, 13);
            this.lblSample.TabIndex = 2;
            this.lblSample.Text = "Sample";
            // 
            // txtSample
            // 
            this.tpnlLayout.SetColumnSpan(this.txtSample, 5);
            this.txtSample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSample.Location = new System.Drawing.Point(79, 29);
            this.txtSample.MaxLength = 0;
            this.txtSample.Name = "txtSample";
            this.txtSample.ReadOnly = true;
            this.txtSample.Size = new System.Drawing.Size(671, 20);
            this.txtSample.TabIndex = 3;
            // 
            // lvwKeywords
            // 
            this.tpnlLayout.SetColumnSpan(this.lvwKeywords, 6);
            this.lvwKeywords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwKeywords.FullRowSelect = true;
            this.lvwKeywords.GridLines = true;
            this.lvwKeywords.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwKeywords.HideSelection = false;
            this.lvwKeywords.Location = new System.Drawing.Point(3, 55);
            this.lvwKeywords.MultiSelect = false;
            this.lvwKeywords.Name = "lvwKeywords";
            this.lvwKeywords.ShowItemToolTips = true;
            this.lvwKeywords.Size = new System.Drawing.Size(747, 551);
            this.lvwKeywords.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvwKeywords.TabIndex = 4;
            this.lvwKeywords.UseCompatibleStateImageBehavior = false;
            this.lvwKeywords.View = System.Windows.Forms.View.Details;
            this.lvwKeywords.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lvwKeyword_ColumnWidthChanging);
            this.lvwKeywords.SelectedIndexChanged += new System.EventHandler(this.lvwKeywords_SelectedIndexChanged);
            this.lvwKeywords.SizeChanged += new System.EventHandler(this.lvwKeyword_SizeChanged);
            this.lvwKeywords.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvwKeyword_MouseDoubleClick);
            // 
            // chkFormat
            // 
            this.chkFormat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkFormat.AutoSize = true;
            this.chkFormat.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkFormat.Location = new System.Drawing.Point(15, 613);
            this.chkFormat.Name = "chkFormat";
            this.chkFormat.Size = new System.Drawing.Size(58, 17);
            this.chkFormat.TabIndex = 5;
            this.chkFormat.Text = "&Format";
            this.chkFormat.UseVisualStyleBackColor = true;
            this.chkFormat.CheckedChanged += new System.EventHandler(this.chkFormat_CheckedChanged);
            // 
            // txtFormat
            // 
            this.tpnlLayout.SetColumnSpan(this.txtFormat, 4);
            this.txtFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFormat.Enabled = false;
            this.txtFormat.Location = new System.Drawing.Point(79, 612);
            this.txtFormat.MaxLength = 0;
            this.txtFormat.Name = "txtFormat";
            this.txtFormat.Size = new System.Drawing.Size(591, 20);
            this.txtFormat.TabIndex = 6;
            // 
            // chkSubstring
            // 
            this.chkSubstring.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkSubstring.AutoSize = true;
            this.chkSubstring.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSubstring.Location = new System.Drawing.Point(3, 639);
            this.chkSubstring.Name = "chkSubstring";
            this.chkSubstring.Size = new System.Drawing.Size(70, 17);
            this.chkSubstring.TabIndex = 7;
            this.chkSubstring.Text = "&Substring";
            this.chkSubstring.UseVisualStyleBackColor = true;
            this.chkSubstring.CheckedChanged += new System.EventHandler(this.chkSubstring_CheckedChanged);
            // 
            // lblSubstringStart
            // 
            this.lblSubstringStart.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSubstringStart.AutoSize = true;
            this.lblSubstringStart.Enabled = false;
            this.lblSubstringStart.Location = new System.Drawing.Point(79, 641);
            this.lblSubstringStart.Name = "lblSubstringStart";
            this.lblSubstringStart.Size = new System.Drawing.Size(29, 13);
            this.lblSubstringStart.TabIndex = 8;
            this.lblSubstringStart.Text = "Start";
            // 
            // lblSubstringLength
            // 
            this.lblSubstringLength.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSubstringLength.AutoSize = true;
            this.lblSubstringLength.Enabled = false;
            this.lblSubstringLength.Location = new System.Drawing.Point(372, 641);
            this.lblSubstringLength.Name = "lblSubstringLength";
            this.lblSubstringLength.Size = new System.Drawing.Size(40, 13);
            this.lblSubstringLength.TabIndex = 10;
            this.lblSubstringLength.Text = "Length";
            // 
            // nudSubstringLength
            // 
            this.nudSubstringLength.Enabled = false;
            this.nudSubstringLength.Location = new System.Drawing.Point(418, 638);
            this.nudSubstringLength.Name = "nudSubstringLength";
            this.nudSubstringLength.Size = new System.Drawing.Size(252, 20);
            this.nudSubstringLength.TabIndex = 11;
            this.nudSubstringLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chkCasing
            // 
            this.chkCasing.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkCasing.AutoSize = true;
            this.chkCasing.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkCasing.Location = new System.Drawing.Point(15, 666);
            this.chkCasing.Name = "chkCasing";
            this.chkCasing.Size = new System.Drawing.Size(58, 17);
            this.chkCasing.TabIndex = 12;
            this.chkCasing.Text = "&Casing";
            this.chkCasing.UseVisualStyleBackColor = true;
            this.chkCasing.CheckedChanged += new System.EventHandler(this.chkCasing_CheckedChanged);
            // 
            // cbxCasing
            // 
            this.tpnlLayout.SetColumnSpan(this.cbxCasing, 4);
            this.cbxCasing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxCasing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCasing.Enabled = false;
            this.cbxCasing.FormattingEnabled = true;
            this.cbxCasing.Items.AddRange(new object[] {
            "Default",
            "Uppercase",
            "Lowercase"});
            this.cbxCasing.Location = new System.Drawing.Point(79, 664);
            this.cbxCasing.Name = "cbxCasing";
            this.cbxCasing.Size = new System.Drawing.Size(591, 21);
            this.cbxCasing.TabIndex = 13;
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(676, 612);
            this.btnAdd.MaximumSize = new System.Drawing.Size(73, 73);
            this.btnAdd.MinimumSize = new System.Drawing.Size(73, 73);
            this.btnAdd.Name = "btnAdd";
            this.tpnlLayout.SetRowSpan(this.btnAdd, 3);
            this.btnAdd.Size = new System.Drawing.Size(73, 73);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // nudSubstringStart
            // 
            this.nudSubstringStart.Enabled = false;
            this.nudSubstringStart.Location = new System.Drawing.Point(114, 638);
            this.nudSubstringStart.Name = "nudSubstringStart";
            this.nudSubstringStart.Size = new System.Drawing.Size(252, 20);
            this.nudSubstringStart.TabIndex = 9;
            this.nudSubstringStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // KeywordSelectionDialog
            // 
            this.AcceptButton = this.btnOK;
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grpKeywordSelector);
            this.MinimizeBox = false;
            this.Name = "KeywordSelectionDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Keywords";
            this.Load += new System.EventHandler(this.KeywordSelectionDialog_Load);
            this.grpKeywordSelector.ResumeLayout(false);
            this.tpnlLayout.ResumeLayout(false);
            this.tpnlLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSubstringLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSubstringStart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpKeywordSelector;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TableLayoutPanel tpnlLayout;
        private System.Windows.Forms.Label lblExpression;
        private System.Windows.Forms.TextBox txtExpression;
        private System.Windows.Forms.Label lblSample;
        private System.Windows.Forms.TextBox txtSample;
        private System.Windows.Forms.CheckBox chkFormat;
        private System.Windows.Forms.ListView lvwKeywords;
        private System.Windows.Forms.TextBox txtFormat;
        private System.Windows.Forms.CheckBox chkSubstring;
        private System.Windows.Forms.Label lblSubstringStart;
        private System.Windows.Forms.Label lblSubstringLength;
        private System.Windows.Forms.NumericUpDown nudSubstringLength;
        private System.Windows.Forms.CheckBox chkCasing;
        private System.Windows.Forms.ComboBox cbxCasing;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nudSubstringStart;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolTip toolTip;
    }
}