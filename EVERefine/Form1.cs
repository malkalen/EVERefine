using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EveAI.Live;
using EveAI.Live.Utility;

namespace EVERefine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetAssetsBtn_Click(object sender, EventArgs e)
        {
            GetAssetsTask getAssetsTask = new GetAssetsTask(Convert.ToInt64(KeyIDTxt.Text), vCodeTxt.Text, Convert.ToInt64(characterTxt.Text));
            getAssetsTask.GetAssets();
        }

        private void vCodeTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class GetAssetsTask
    {
        private readonly long _keyId;
        private readonly string _vCode;
        private readonly long _character;

        public GetAssetsTask(long keyId, string vCode, long character)
        {
            _keyId = keyId;
            _vCode = vCode;
            _character = character;
        }

        public void GetAssets()
        {
            try
            {
                EveApi api = new EveApi("EVERefine", _keyId, _vCode, _character);
                List<Asset> assets = api.GetCharacterAssets();
                foreach (var asset in assets)
                {
                    asset.LocationID = 0;
                }

            }
            catch (Exception)
            {
                
                throw;
            }

        }
    }
}
