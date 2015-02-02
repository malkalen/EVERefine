using System.Collections.Generic;
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

        public List<Asset> GetAssets()
        {
          var api = new EveApi("EVERefine", _keyId, _vCode, _character);
          return api.GetCharacterAssets();
        }
    }
}