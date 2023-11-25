using System.Collections.Generic;
using UGF.EditorTools.Runtime.Assets;
using UGF.EditorTools.Runtime.Ids;
using UnityEngine;

namespace UGF.Assets.Editor.Tests
{
    [CreateAssetMenu(menuName = "Tests/TestAssetCollectionIdAsset")]
    public class TestAssetCollectionIdAsset : ScriptableObject
    {
        [AssetId(typeof(Material))]
        [SerializeField] private List<GlobalId> m_assets = new List<GlobalId>();

        public List<GlobalId> Assets { get { return m_assets; } }
    }
}
