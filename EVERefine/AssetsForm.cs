using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using EveAI.Live.Utility;

namespace EVERefine
{
    public partial class AssetsForm : Form
    {
        public AssetsForm()
        {
            InitializeComponent();
        }

        private void GetAssetsBtn_Click(object sender, EventArgs e)
        {
          var getAssetsTask = new GetAssetsTask(Convert.ToInt64(KeyIDTxt.Text), vCodeTxt.Text, Convert.ToInt64(characterTxt.Text));
          List<Asset> assets = getAssetsTask.GetAssets();
          var bindingList = new BindingList<Asset>(assets);
          var source = new BindingSource(bindingList, null);
          dataGridView1.DataSource = source;
        }
    }
}
