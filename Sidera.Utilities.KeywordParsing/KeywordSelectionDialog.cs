using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sidera.Utilities.KeywordParsing
{
    /// <summary>
    ///     Provides a Windows Forms GUI for the end user to create a text expression consisting of constant text and
    ///     keyword placeholders which can be passed into the calling object's input text field.
    /// </summary>
    public partial class KeywordSelectionDialog : Form
    {
        #region Initialization
        #region Private fields
        private KeywordParser _kwparser;
        #endregion

        #region Constructors
        /// <summary>
        ///     Creates an instance of the <see cref="KeywordSelectionDialog"/> class.
        /// </summary>
        /// <param name="parser">
        ///     The <see cref="KeywordParser"/> object containing the keyword type and value definitions.
        /// </param>
        /// <param name="expression">
        ///     The string containing all constant text and keyword placeholders to be evaluated by the
        ///     <see cref="KeywordParser"/>.
        /// </param>
        public KeywordSelectionDialog(KeywordParser parser, string expression)
        {
            InitializeComponent();

            Parser = parser ?? new KeywordParser();
            Expression = expression;

            var method = typeof(Control).GetMethod("SetStyle", BindingFlags.Instance | BindingFlags.NonPublic);
            method.Invoke(lvwKeywords, new object[]
            {
                ControlStyles.OptimizedDoubleBuffer,
                true
            });

            AdjustColumnWidths();

            nudSubstringStart.Minimum = int.MinValue;
            nudSubstringStart.Maximum = int.MaxValue;

            nudSubstringLength.Minimum = 0;
            nudSubstringLength.Maximum = int.MaxValue;

            cbxCasing.SelectedIndex = 0;
        }
        #endregion
        #endregion

        #region Public properties
        /// <summary>
        ///     Gets the <see cref="KeywordParser"/> object containing the keyword type and value definitions.
        /// </summary>
        public KeywordParser Parser
        {
            get { return _kwparser; }
            internal set
            {
                _kwparser = value;

                // Populate listview with data table contents
                Assembly assembly, executable;
                assembly = Assembly.GetExecutingAssembly();
                executable = Assembly.GetEntryAssembly();

                ListViewGroup lvgExe, lvgDll;
                lvgExe = new ListViewGroup($"Application keywords");
                lvgDll = new ListViewGroup($"Reserved keywords");

                lvwKeywords.Groups.AddRange(new ListViewGroup[]
                {
                    lvgExe,
                    lvgDll
                });

                lvwKeywords.Columns.Add($"Keyword");
                lvwKeywords.Columns.Add($"Data type");
                lvwKeywords.Columns.Add($"Value");

                foreach (KeyValuePair<string, Type> kvp in value.KeywordTypes)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = $"[{kvp.Key}]";
                    lvi.SubItems.Add(kvp.Value.FullName);
                    lvi.SubItems.Add(_kwparser.Parse($"[{kvp.Key}]"));

                    lvi.Group = kvp.Key.StartsWith("@")
                        ? lvgDll
                        : lvgExe;

                    lvwKeywords.Items.Add(lvi);
                }
            }
        }

        /// <summary>
        ///     Gets or sets the string containing all constant text and keyword placeholders being evaluated by the
        ///     <see cref="KeywordParser"/>.
        /// </summary>
        public string Expression
        {
            get { return txtExpression.Text; }
            set { txtExpression.Text = value; }
        }
        #endregion

        #region Public methods

        #endregion

        #region Private methods
        private void AdjustColumnWidths()
        {
            foreach (ColumnHeader col in lvwKeywords.Columns)
            {
                col.Width = -2;
            }
        }

        private void InsertKeyword(bool useFormatting)
        {
            string keyword, format, range, casing;
            
            keyword = lvwKeywords.SelectedItems[0].Text;
            if (useFormatting)
            {
                format = txtFormat.Text;
                range = string.Join(",", nudSubstringStart.Value, nudSubstringLength.Value);
                casing = cbxCasing.Text;

                // Add format, if applicable
                if (chkFormat.Checked && !string.IsNullOrWhiteSpace(format))
                {
                    keyword = keyword.Insert(keyword.LastIndexOf("]"), $"({format})");
                }

                // Add range, if applicable
                if (chkSubstring.Checked)
                {
                    keyword = keyword.Insert(keyword.LastIndexOf("]"), $"{{{range}}}");
                }

                // Add casing, if applicable
                if (chkCasing.Checked && casing.ToUpper() != "DEFAULT")
                {
                    keyword = keyword.Insert(keyword.LastIndexOf("]"), $":{casing}");
                }

                //

                // Reset inputs
                chkFormat.Checked = false;
                txtFormat.Text = "";

                chkSubstring.Checked = false;
                nudSubstringStart.Value
                    = nudSubstringLength.Value = 0;

                chkCasing.Checked = false;
                cbxCasing.SelectedIndex = 0;
            }

            //

            // Insert keyword into textbox
            txtExpression.SelectedText = keyword;
        }
        #endregion

        #region Private event handlers
        private void KeywordSelectionDialog_Load(object sender, EventArgs e)
        {

        }

        private void lvwKeyword_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = lvwKeywords.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void lvwKeyword_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selection = lvwKeywords.SelectedItems.Count;
            if (selection == 1)
            {
                btnAdd.PerformClick();
            }
        }
        private void lvwKeywords_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selection = lvwKeywords.SelectedItems.Count;
            btnAdd.Enabled = selection == 1;
        }

        private void lvwKeyword_SizeChanged(object sender, EventArgs e)
        {
            AdjustColumnWidths();
        }

        private void chkFormat_CheckedChanged(object sender, EventArgs e)
        {
            txtFormat.Enabled = chkFormat.Checked;
        }

        private void chkSubstring_CheckedChanged(object sender, EventArgs e)
        {
            lblSubstringStart.Enabled
                = nudSubstringStart.Enabled
                = lblSubstringLength.Enabled
                = nudSubstringLength.Enabled = chkSubstring.Checked;
        }

        private void chkCasing_CheckedChanged(object sender, EventArgs e)
        {
            cbxCasing.Enabled = chkCasing.Checked;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            InsertKeyword(true);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                txtSample.ForeColor = SystemColors.WindowText;
                txtSample.Text = _kwparser.Parse(txtExpression.Text);
                toolTip.SetToolTip(txtSample, txtSample.Text);
            }
            catch (Exception ex)
            {
                txtSample.ForeColor = Color.Red;
                txtSample.Text = ex.Message;
                toolTip.SetToolTip(txtSample, ex.ToString());
            }
        }
        #endregion

    }
}
