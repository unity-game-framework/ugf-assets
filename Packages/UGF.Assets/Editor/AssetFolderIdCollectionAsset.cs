using System.Collections.Generic;
using UGF.EditorTools.Runtime.Ids;
using UnityEditor;
using UnityEngine;

namespace UGF.Assets.Editor
{
    public abstract class AssetFolderIdCollectionAsset<TCollection, TAsset> : AssetFolderAsset<TCollection, TAsset>
        where TCollection : Object
        where TAsset : Object
    {
        protected override void OnUpdate()
        {
            IList<GlobalId> collection = OnGetCollection();

            collection.Clear();

            string[] guids = FindAssetsAsGuids();

            for (int i = 0; i < guids.Length; i++)
            {
                string guid = guids[i];

                collection.Add(new GlobalId(guid));
            }

            EditorUtility.SetDirty(Collection);
        }

        protected abstract IList<GlobalId> OnGetCollection();
    }
}
