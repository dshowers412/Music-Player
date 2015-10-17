using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class FilterDialog : Form
    {
        public FilterDialog()
        {
            InitializeComponent();
        }

        private void filterResultsButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Get text box value and make it public for other forms to see.
        public string filterDialogValue
        {
            get { return filterTextBox.Text; }
        }

        // Get drop down category selection and make it public for other forms to see.
        public string dropDownCategory
        {
            get { return filterCategoryDropDown.SelectedItem.ToString(); }
        }

        // Get drop down comparison method selection and make it public for other forms to see.
        public string dropDownComparisonMethod
        {
            get { return restrictionDropDown.SelectedItem.ToString(); }
        }
    }
}
