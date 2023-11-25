using System.Collections.Generic;
using UGF.EditorTools.Runtime.Assets;
using UnityEngine;

namespace UGF.Assets.Editor.Tests
{
    [CreateAssetMenu(menuName = "Tests/TestAssetCollectionIdReferenceAsset")]
    public class TestAssetCollectionIdReferenceAsset : ScriptableObject
    {
        [SerializeField] private List<AssetIdReference<Material>> m_assets = new List<AssetIdReference<Material>>();

        public List<AssetIdReference<Material>> Assets { get { return m_assets; } }
    }
}
