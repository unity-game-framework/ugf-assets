using System.Collections.Generic;
using UGF.EditorTools.Runtime.Ids;
using UnityEngine;

namespace UGF.Assets.Editor.Tests
{
    [CreateAssetMenu(menuName = "Tests/TestAssetCollectionIdFolderAsset")]
    public class TestAssetCollectionIdFolderAsset : AssetFolderIdCollectionAsset<TestAssetCollectionIdAsset, Material>
    {
        protected override IList<GlobalId> OnGetCollection()
        {
            return Collection.Assets;
        }
    }
}
