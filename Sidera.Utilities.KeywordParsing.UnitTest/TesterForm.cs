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
    public partial class TesterForm : Form
    {
        private KeywordParser _kwparser;
        private KeywordParseOptions _kpoption;

        public TesterForm()
        {
            InitializeComponent();

            _kwparser = new KeywordParser();
            _kpoption = KeywordParseOptions.None;
        }

        private void txtExpression_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtSample.ForeColor = SystemColors.WindowText;
                txtSample.Text = _kwparser.Parse(txtExpression.Text, _kpoption);
            }
            catch (Exception ex)
            {
                txtSample.ForeColor = Color.Red;
                txtSample.Text = ex.Message;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            KeywordSelectionDialog ksd = new KeywordSelectionDialog(_kwparser, txtExpression.Text);
            DialogResult dr = ksd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                txtExpression.Text = ksd.Expression;
            }
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            OptionsDialog od = new OptionsDialog(_kwparser, _kpoption);
            DialogResult dr = od.ShowDialog();
            if (dr == DialogResult.OK)
            {
                _kwparser = od.KeywordParser;
                _kpoption = od.ParseOption;
            }
        }
    }
}
