using System.Collections.Generic;
using UnityEngine;

namespace UGF.Assets.Editor.Tests
{
    [CreateAssetMenu(menuName = "Tests/TestAssetCollectionAsset")]
    public class TestAssetCollectionAsset : ScriptableObject
    {
        [SerializeField] private List<Object> m_assets = new List<Object>();

        public List<Object> Assets { get { return m_assets; } }
    }
}
