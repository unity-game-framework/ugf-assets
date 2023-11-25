using System.Collections.Generic;
using UGF.EditorTools.Runtime.Assets;
using UnityEngine;

namespace UGF.Assets.Editor.Tests
{
    [CreateAssetMenu(menuName = "Tests/TestAssetCollectionIdReferenceFolderAsset")]
    public class TestAssetCollectionIdReferenceFolderAsset : AssetFolderIdReferenceCollectionAsset<TestAssetCollectionIdReferenceAsset, Material>
    {
        protected override IList<AssetIdReference<Material>> OnGetCollection()
        {
            return Collection.Assets;
        }
    }
}
