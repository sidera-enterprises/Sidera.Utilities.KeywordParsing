using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sidera.Utilities.KeywordParsing.UnitTest
{
    public partial class OptionsDialog : Form
    {
        private KeywordParser _kwparser;

        public OptionsDialog(KeywordParser parser, KeywordParseOptions options)
        {
            InitializeComponent();

            _kwparser = parser;
            
            for (int i = 0; i < _kwparser.Keys.Length; i++)
            {
                string key = _kwparser.Keys[i];
                if (!key.StartsWith("@"))
                {
                    object value = _kwparser.Values[i];
                    Type type = value.GetType();

                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = key;
                    lvi.SubItems.Add(type.FullName);
                    lvi.SubItems.Add(value.ToString());

                    lvwKeywords.Items.Add(lvi);
                }
            }

            cbxDataType.DataSource = LegalTypes.Types;

            AdjustColumnWidths();
            ResetKeywordInputs();

            switch (options)
            {
                case KeywordParseOptions.None:
                    radKPO_None.Checked = true;
                    break;
                case KeywordParseOptions.RemovePlaceholders:
                    radKPO_RemovePlaceholders.Checked = true;
                    break;
                case KeywordParseOptions.ThrowError:
                    radKPO_ThrowException.Checked = true;
                    break;
            }
        }

        public KeywordParser KeywordParser
        {
            get { return _kwparser; }
        }

        public KeywordParseOptions ParseOption
        {
            get
            {
                if (radKPO_RemovePlaceholders.Checked)
                    return KeywordParseOptions.RemovePlaceholders;
                else if (radKPO_ThrowException.Checked)
                    return KeywordParseOptions.ThrowError;

                return KeywordParseOptions.None;
            }
        }

        private void AdjustColumnWidths()
        {
            foreach (ColumnHeader col in lvwKeywords.Columns)
            {
                col.Width = -2;
            }
        }

        private void ResetKeywordInputs()
        {
            txtKey.Text = "";
            cbxDataType.Text = typeof(object).FullName;
            txtValue.Text = "";
        }

        private void OptionsDialog_Load(object sender, EventArgs e)
        {
            
        }

        private void lvwKeywords_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemove.Enabled = lvwKeywords.SelectedItems.Count > 0;
        }

        private void lvwKeywords_SizeChanged(object sender, EventArgs e)
        {
            AdjustColumnWidths();
        }

        private void txtKey_TextChanged(object sender, EventArgs e)
        {
            btnSet.Enabled = !string.IsNullOrWhiteSpace(txtKey.Text);
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            try
            {
                string key = txtKey.Text;
                Type type = Type.GetType(cbxDataType.Text);
                object value = Convert.ChangeType(txtValue.Text, type);

                _kwparser.SetKeyword(key, value);

                for (int i = 0; i < lvwKeywords.Items.Count; i++)
                {
                    ListViewItem lvi = lvwKeywords.Items[i];
                    if (lvi.Text == key)
                    {
                        lvi.SubItems[1].Text = cbxDataType.Text;
                        lvi.SubItems[2].Text = txtValue.Text;

                        //

                        AdjustColumnWidths();
                        ResetKeywordInputs();

                        return;
                    }
                }

                ListViewItem lviNew = new ListViewItem();
                lviNew.Text = txtKey.Text;
                lviNew.SubItems.Add(cbxDataType.Text);
                lviNew.SubItems.Add(txtValue.Text);

                lvwKeywords.Items.Add(lviNew);

                //

                AdjustColumnWidths();
                ResetKeywordInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    ex.GetType().Name,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lvwKeywords.SelectedItems.Count > 0)
            {
                foreach (ListViewItem lvi in lvwKeywords.SelectedItems)
                {
                    string key = lvi.Text;

                    _kwparser.RemoveKeyword(key);
                    lvwKeywords.Items.Remove(lvi);
                }
            }

            //

            AdjustColumnWidths();
            ResetKeywordInputs();
        }
    }
}
