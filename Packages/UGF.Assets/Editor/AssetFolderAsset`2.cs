using UnityEngine;

namespace UGF.Assets.Editor
{
    public abstract class AssetFolderAsset<TCollectionAsset, TAsset> : AssetFolderAsset<TAsset>
        where TCollectionAsset : Object
        where TAsset : Object
    {
        [SerializeField] private TCollectionAsset m_collection;

        public TCollectionAsset Collection { get { return m_collection; } set { m_collection = value; } }

        protected override bool OnIsValid()
        {
            return m_collection != null;
        }
    }
}
