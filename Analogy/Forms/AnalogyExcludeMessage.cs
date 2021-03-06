﻿using System;
using System.Windows.Forms;
using Analogy.Interfaces;
using Syncfusion.Windows.Forms;

namespace Analogy
{
    public partial class AnalogyExcludeMessage : MetroForm
    {
        public string Exclude { get; set; }
        public AnalogyExcludeMessage()
        {
            InitializeComponent();
        }

        public AnalogyExcludeMessage(AnalogyLogMessage m) : this()
        {
            txtbMessage.Text = m.Text;
        }
        private void sBtnOk_Click(object sender, EventArgs e)
        {
            Exclude = FilterCriteriaObject.EscapeLikeValue(txtbMessage.Text);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void sBtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
