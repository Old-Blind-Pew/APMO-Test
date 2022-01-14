using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace АРМО_test.Controls
{
    public partial class SearchFilter : UserControl
    {
        public SearchFilter()
        {
            InitializeComponent();
        }

        public void Init(string s_filter)
        {
            SearchFilterText.Text = string.IsNullOrWhiteSpace(s_filter) ? "" : s_filter;
        }
    }
}
