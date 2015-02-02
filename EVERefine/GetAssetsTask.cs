using System;
using System.Collections.Generic;
using System.Xml;
using EveAI.Live;
using EveAI.Live.Utility;

namespace EVERefine
{
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

        //public void GetAssets()
        //{
        //    try
        //    {
        //        EveApi api = new EveApi("EVERefine", _keyId, _vCode, _character);
        //        List<Asset> assets = api.GetCharacterAssets();
        //        foreach (var asset in assets)
        //        {
        //            asset.LocationID = 0;
        //        }

        //    }
        //    catch (Exception)
        //    {
                
        //        throw;
        //    }

        //}

        public XmlDocument GetAssets()
        {
            string url = "http://api.eve-online.com/char/AssetList.xml.aspx?keyID=" + _keyId + "&vCode=" + _vCode + "&characterID=" + _character;
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(url);
            return xmldoc;
        }
    }
}