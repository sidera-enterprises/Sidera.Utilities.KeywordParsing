namespace Sidera.Utilities.KeywordParsing.UnitTest
{
    partial class OptionsDialog
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabKeywords = new System.Windows.Forms.TabPage();
            this.tpnlKeywords = new System.Windows.Forms.TableLayoutPanel();
            this.lvwKeywords = new System.Windows.Forms.ListView();
            this.colKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDataType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblKey = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.lblDataType = new System.Windows.Forms.Label();
            this.cbxDataType = new System.Windows.Forms.ComboBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.tabMiscellaneous = new System.Windows.Forms.TabPage();
            this.grpKPO = new System.Windows.Forms.GroupBox();
            this.radKPO_ThrowException = new System.Windows.Forms.RadioButton();
            this.radKPO_RemovePlaceholders = new System.Windows.Forms.RadioButton();
            this.radKPO_None = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabKeywords.SuspendLayout();
            this.tpnlKeywords.SuspendLayout();
            this.tabMiscellaneous.SuspendLayout();
            this.grpKPO.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabKeywords);
            this.tabControl1.Controls.Add(this.tabMiscellaneous);
            this.tabControl1.Location = new System.Drawing.Point(8, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(764, 512);
            this.tabControl1.TabIndex = 1;
            // 
            // tabKeywords
            // 
            this.tabKeywords.Controls.Add(this.tpnlKeywords);
            this.tabKeywords.Location = new System.Drawing.Point(4, 22);
            this.tabKeywords.Name = "tabKeywords";
            this.tabKeywords.Padding = new System.Windows.Forms.Padding(3);
            this.tabKeywords.Size = new System.Drawing.Size(756, 486);
            this.tabKeywords.TabIndex = 0;
            this.tabKeywords.Text = "Keywords";
            this.tabKeywords.UseVisualStyleBackColor = true;
            // 
            // tpnlKeywords
            // 
            this.tpnlKeywords.ColumnCount = 8;
            this.tpnlKeywords.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tpnlKeywords.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tpnlKeywords.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tpnlKeywords.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tpnlKeywords.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tpnlKeywords.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tpnlKeywords.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tpnlKeywords.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tpnlKeywords.Controls.Add(this.lvwKeywords, 0, 0);
            this.tpnlKeywords.Controls.Add(this.lblKey, 0, 1);
            this.tpnlKeywords.Controls.Add(this.txtKey, 1, 1);
            this.tpnlKeywords.Controls.Add(this.lblDataType, 2, 1);
            this.tpnlKeywords.Controls.Add(this.cbxDataType, 3, 1);
            this.tpnlKeywords.Controls.Add(this.lblValue, 4, 1);
            this.tpnlKeywords.Controls.Add(this.txtValue, 5, 1);
            this.tpnlKeywords.Controls.Add(this.btnRemove, 7, 1);
            this.tpnlKeywords.Controls.Add(this.btnSet, 6, 1);
            this.tpnlKeywords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlKeywords.Location = new System.Drawing.Point(3, 3);
            this.tpnlKeywords.Name = "tpnlKeywords";
            this.tpnlKeywords.RowCount = 2;
            this.tpnlKeywords.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlKeywords.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tpnlKeywords.Size = new System.Drawing.Size(750, 480);
            this.tpnlKeywords.TabIndex = 0;
            // 
            // lvwKeywords
            // 
            this.lvwKeywords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colKey,
            this.colDataType,
            this.colValue});
            this.tpnlKeywords.SetColumnSpan(this.lvwKeywords, 8);
            this.lvwKeywords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwKeywords.FullRowSelect = true;
            this.lvwKeywords.GridLines = true;
            this.lvwKeywords.HideSelection = false;
            this.lvwKeywords.Location = new System.Drawing.Point(3, 3);
            this.lvwKeywords.Name = "lvwKeywords";
            this.lvwKeywords.Size = new System.Drawing.Size(744, 445);
            this.lvwKeywords.TabIndex = 0;
            this.lvwKeywords.UseCompatibleStateImageBehavior = false;
            this.lvwKeywords.View = System.Windows.Forms.View.Details;
            this.lvwKeywords.SelectedIndexChanged += new System.EventHandler(this.lvwKeywords_SelectedIndexChanged);
            this.lvwKeywords.SizeChanged += new System.EventHandler(this.lvwKeywords_SizeChanged);
            // 
            // colKey
            // 
            this.colKey.Text = "Key";
            this.colKey.Width = 30;
            // 
            // colDataType
            // 
            this.colDataType.Text = "Data type";
            this.colDataType.Width = 58;
            // 
            // colValue
            // 
            this.colValue.Text = "Value";
            this.colValue.Width = 652;
            // 
            // lblKey
            // 
            this.lblKey.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(3, 459);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(25, 13);
            this.lblKey.TabIndex = 1;
            this.lblKey.Text = "Key";
            // 
            // txtKey
            // 
            this.txtKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtKey.Location = new System.Drawing.Point(34, 456);
            this.txtKey.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(146, 20);
            this.txtKey.TabIndex = 2;
            this.txtKey.TextChanged += new System.EventHandler(this.txtKey_TextChanged);
            // 
            // lblDataType
            // 
            this.lblDataType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDataType.AutoSize = true;
            this.lblDataType.Location = new System.Drawing.Point(186, 459);
            this.lblDataType.Name = "lblDataType";
            this.lblDataType.Size = new System.Drawing.Size(53, 13);
            this.lblDataType.TabIndex = 3;
            this.lblDataType.Text = "Data type";
            // 
            // cbxDataType
            // 
            this.cbxDataType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDataType.FormattingEnabled = true;
            this.cbxDataType.Location = new System.Drawing.Point(245, 456);
            this.cbxDataType.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.cbxDataType.Name = "cbxDataType";
            this.cbxDataType.Size = new System.Drawing.Size(146, 21);
            this.cbxDataType.TabIndex = 4;
            // 
            // lblValue
            // 
            this.lblValue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(397, 459);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(34, 13);
            this.lblValue.TabIndex = 5;
            this.lblValue.Text = "Value";
            // 
            // txtValue
            // 
            this.txtValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtValue.Location = new System.Drawing.Point(437, 456);
            this.txtValue.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(146, 20);
            this.txtValue.TabIndex = 6;
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(670, 454);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSet
            // 
            this.btnSet.Enabled = false;
            this.btnSet.Location = new System.Drawing.Point(589, 454);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 7;
            this.btnSet.Text = "&Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // tabMiscellaneous
            // 
            this.tabMiscellaneous.Controls.Add(this.grpKPO);
            this.tabMiscellaneous.Location = new System.Drawing.Point(4, 22);
            this.tabMiscellaneous.Name = "tabMiscellaneous";
            this.tabMiscellaneous.Padding = new System.Windows.Forms.Padding(3);
            this.tabMiscellaneous.Size = new System.Drawing.Size(756, 486);
            this.tabMiscellaneous.TabIndex = 1;
            this.tabMiscellaneous.Text = "Miscellaneous";
            this.tabMiscellaneous.UseVisualStyleBackColor = true;
            // 
            // grpKPO
            // 
            this.grpKPO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpKPO.AutoSize = true;
            this.grpKPO.Controls.Add(this.radKPO_ThrowException);
            this.grpKPO.Controls.Add(this.radKPO_RemovePlaceholders);
            this.grpKPO.Controls.Add(this.radKPO_None);
            this.grpKPO.Location = new System.Drawing.Point(6, 6);
            this.grpKPO.Name = "grpKPO";
            this.grpKPO.Size = new System.Drawing.Size(744, 101);
            this.grpKPO.TabIndex = 0;
            this.grpKPO.TabStop = false;
            this.grpKPO.Text = "Keyword parsing options";
            // 
            // radKPO_ThrowException
            // 
            this.radKPO_ThrowException.AutoSize = true;
            this.radKPO_ThrowException.Location = new System.Drawing.Point(6, 65);
            this.radKPO_ThrowException.Name = "radKPO_ThrowException";
            this.radKPO_ThrowException.Size = new System.Drawing.Size(290, 17);
            this.radKPO_ThrowException.TabIndex = 2;
            this.radKPO_ThrowException.Text = "Throw an exception for undefined keyword placeholders";
            this.radKPO_ThrowException.UseVisualStyleBackColor = true;
            // 
            // radKPO_RemovePlaceholders
            // 
            this.radKPO_RemovePlaceholders.AutoSize = true;
            this.radKPO_RemovePlaceholders.Location = new System.Drawing.Point(6, 42);
            this.radKPO_RemovePlaceholders.Name = "radKPO_RemovePlaceholders";
            this.radKPO_RemovePlaceholders.Size = new System.Drawing.Size(221, 17);
            this.radKPO_RemovePlaceholders.TabIndex = 1;
            this.radKPO_RemovePlaceholders.Text = "Remove undefined keyword placeholders";
            this.radKPO_RemovePlaceholders.UseVisualStyleBackColor = true;
            // 
            // radKPO_None
            // 
            this.radKPO_None.AutoSize = true;
            this.radKPO_None.Checked = true;
            this.radKPO_None.Location = new System.Drawing.Point(6, 19);
            this.radKPO_None.Name = "radKPO_None";
            this.radKPO_None.Size = new System.Drawing.Size(51, 17);
            this.radKPO_None.TabIndex = 0;
            this.radKPO_None.TabStop = true;
            this.radKPO_None.Text = "None";
            this.radKPO_None.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(616, 526);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(697, 526);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // OptionsDialog
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.OptionsDialog_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabKeywords.ResumeLayout(false);
            this.tpnlKeywords.ResumeLayout(false);
            this.tpnlKeywords.PerformLayout();
            this.tabMiscellaneous.ResumeLayout(false);
            this.tabMiscellaneous.PerformLayout();
            this.grpKPO.ResumeLayout(false);
            this.grpKPO.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabKeywords;
        private System.Windows.Forms.TabPage tabMiscellaneous;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tpnlKeywords;
        private System.Windows.Forms.ListView lvwKeywords;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label lblDataType;
        private System.Windows.Forms.ComboBox cbxDataType;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ColumnHeader colKey;
        private System.Windows.Forms.ColumnHeader colDataType;
        private System.Windows.Forms.ColumnHeader colValue;
        private System.Windows.Forms.GroupBox grpKPO;
        private System.Windows.Forms.RadioButton radKPO_ThrowException;
        private System.Windows.Forms.RadioButton radKPO_RemovePlaceholders;
        private System.Windows.Forms.RadioButton radKPO_None;
    }
}