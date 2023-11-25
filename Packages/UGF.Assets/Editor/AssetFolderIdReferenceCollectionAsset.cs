using System.Collections.Generic;
using UGF.EditorTools.Runtime.Assets;
using UGF.EditorTools.Runtime.Ids;
using UnityEditor;
using UnityEngine;

namespace UGF.Assets.Editor
{
    public abstract class AssetFolderIdReferenceCollectionAsset<TCollection, TAsset> : AssetFolderAsset<TCollection, TAsset>
        where TCollection : Object
        where TAsset : Object
    {
        protected override void OnUpdate()
        {
            IList<AssetIdReference<TAsset>> collection = OnGetCollection();

            collection.Clear();

            string[] guids = FindAssetsAsGuids();

            for (int i = 0; i < guids.Length; i++)
            {
                string guid = guids[i];
                string path = AssetDatabase.GUIDToAssetPath(guid);

                var id = new GlobalId(guid);
                var asset = AssetDatabase.LoadAssetAtPath<TAsset>(path);

                collection.Add(new AssetIdReference<TAsset>(id, asset));
            }

            EditorUtility.SetDirty(Collection);
        }

        protected abstract IList<AssetIdReference<TAsset>> OnGetCollection();
    }
}
