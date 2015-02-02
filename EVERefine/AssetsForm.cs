using System;
using System.Data;
using System.Windows.Forms;
using System.Xml;

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
            GetAssetsTask getAssetsTask = new GetAssetsTask(Convert.ToInt64(KeyIDTxt.Text), vCodeTxt.Text, Convert.ToInt64(characterTxt.Text));
            var assetsXML = getAssetsTask.GetAssets();
            string path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),"Assets.XML");
            assetsXML.Save(path);

            XmlReader reader = XmlReader.Create(path);
            while (reader.Read())
            {
                

            }

            DataSet dataSet = new DataSet();
            dataSet.ReadXml(@"C:\Users\Alan\Documents\Assets.XML");
            dataGridView1.DataSource = dataSet.Tables[0];

        }
    }
}
