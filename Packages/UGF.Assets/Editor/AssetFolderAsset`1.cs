using System;
using Object = UnityEngine.Object;

namespace UGF.Assets.Editor
{
    public abstract class AssetFolderAsset<TAsset> : AssetFolderAsset where TAsset : Object
    {
        protected override Type OnGetAssetType()
        {
            return typeof(TAsset);
        }
    }
}
