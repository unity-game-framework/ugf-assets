using UnityEditor;
using UnityEngine;

namespace UGF.Assets.Editor.Tests
{
    [CreateAssetMenu(menuName = "Tests/TestAssetCollectionFolderAsset")]
    public class TestAssetCollectionFolderAsset : AssetFolderAsset<TestAssetCollectionAsset, Object>
    {
        protected override void OnUpdate()
        {
            Collection.Assets.Clear();

            string[] guids = FindAssetsAsGuids();

            for (int i = 0; i < guids.Length; i++)
            {
                string guid = guids[i];
                string path = AssetDatabase.GUIDToAssetPath(guid);

                var asset = AssetDatabase.LoadAssetAtPath<Object>(path);

                Collection.Assets.Add(asset);
            }

            EditorUtility.SetDirty(Collection);
        }
    }
}
