namespace Sidera.Utilities.KeywordParsing.UnitTest
{
    partial class TesterForm
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
            this.txtExpression = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblExpression = new System.Windows.Forms.Label();
            this.tpnlLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblSample = new System.Windows.Forms.Label();
            this.txtSample = new System.Windows.Forms.TextBox();
            this.btnOptions = new System.Windows.Forms.Button();
            this.mnuStatusbar = new System.Windows.Forms.StatusStrip();
            this.lblVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tpnlLayout.SuspendLayout();
            this.mnuStatusbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtExpression
            // 
            this.txtExpression.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtExpression.Location = new System.Drawing.Point(67, 5);
            this.txtExpression.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.txtExpression.MaxLength = 0;
            this.txtExpression.Name = "txtExpression";
            this.txtExpression.Size = new System.Drawing.Size(352, 20);
            this.txtExpression.TabIndex = 1;
            this.txtExpression.TextChanged += new System.EventHandler(this.txtExpression_TextChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(425, 3);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "&Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblExpression
            // 
            this.lblExpression.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblExpression.AutoSize = true;
            this.lblExpression.Location = new System.Drawing.Point(3, 8);
            this.lblExpression.Name = "lblExpression";
            this.lblExpression.Size = new System.Drawing.Size(58, 13);
            this.lblExpression.TabIndex = 0;
            this.lblExpression.Text = "Expression";
            // 
            // tpnlLayout
            // 
            this.tpnlLayout.AutoSize = true;
            this.tpnlLayout.ColumnCount = 4;
            this.tpnlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tpnlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tpnlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tpnlLayout.Controls.Add(this.lblExpression, 0, 0);
            this.tpnlLayout.Controls.Add(this.txtExpression, 1, 0);
            this.tpnlLayout.Controls.Add(this.btnBrowse, 2, 0);
            this.tpnlLayout.Controls.Add(this.lblSample, 0, 1);
            this.tpnlLayout.Controls.Add(this.txtSample, 1, 1);
            this.tpnlLayout.Controls.Add(this.btnOptions, 3, 0);
            this.tpnlLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlLayout.Location = new System.Drawing.Point(0, 0);
            this.tpnlLayout.Name = "tpnlLayout";
            this.tpnlLayout.RowCount = 2;
            this.tpnlLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tpnlLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlLayout.Size = new System.Drawing.Size(584, 139);
            this.tpnlLayout.TabIndex = 0;
            // 
            // lblSample
            // 
            this.lblSample.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSample.AutoSize = true;
            this.lblSample.Location = new System.Drawing.Point(19, 77);
            this.lblSample.Name = "lblSample";
            this.lblSample.Size = new System.Drawing.Size(42, 13);
            this.lblSample.TabIndex = 3;
            this.lblSample.Text = "Sample";
            // 
            // txtSample
            // 
            this.txtSample.BackColor = System.Drawing.SystemColors.Window;
            this.tpnlLayout.SetColumnSpan(this.txtSample, 2);
            this.txtSample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSample.Location = new System.Drawing.Point(67, 32);
            this.txtSample.MaxLength = 0;
            this.txtSample.Multiline = true;
            this.txtSample.Name = "txtSample";
            this.txtSample.ReadOnly = true;
            this.txtSample.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSample.Size = new System.Drawing.Size(433, 104);
            this.txtSample.TabIndex = 4;
            // 
            // btnOptions
            // 
            this.btnOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOptions.Location = new System.Drawing.Point(506, 3);
            this.btnOptions.Name = "btnOptions";
            this.tpnlLayout.SetRowSpan(this.btnOptions, 2);
            this.btnOptions.Size = new System.Drawing.Size(75, 133);
            this.btnOptions.TabIndex = 6;
            this.btnOptions.Text = "&Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // mnuStatusbar
            // 
            this.mnuStatusbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblVersion});
            this.mnuStatusbar.Location = new System.Drawing.Point(0, 139);
            this.mnuStatusbar.Name = "mnuStatusbar";
            this.mnuStatusbar.Size = new System.Drawing.Size(584, 22);
            this.mnuStatusbar.SizingGrip = false;
            this.mnuStatusbar.TabIndex = 2;
            this.mnuStatusbar.Text = "Status bar";
            // 
            // lblVersion
            // 
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(569, 17);
            this.lblVersion.Spring = true;
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            // 
            // TesterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 161);
            this.Controls.Add(this.tpnlLayout);
            this.Controls.Add(this.mnuStatusbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TesterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sidera Keyword Parser Unit Test";
            this.tpnlLayout.ResumeLayout(false);
            this.tpnlLayout.PerformLayout();
            this.mnuStatusbar.ResumeLayout(false);
            this.mnuStatusbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtExpression;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblExpression;
        private System.Windows.Forms.TableLayoutPanel tpnlLayout;
        private System.Windows.Forms.Label lblSample;
        private System.Windows.Forms.TextBox txtSample;
        private System.Windows.Forms.StatusStrip mnuStatusbar;
        private System.Windows.Forms.ToolStripStatusLabel lblVersion;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnOptions;
    }
}

