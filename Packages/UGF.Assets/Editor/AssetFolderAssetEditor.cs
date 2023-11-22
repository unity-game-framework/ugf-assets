using UGF.EditorTools.Editor.IMGUI;
using UGF.EditorTools.Editor.IMGUI.Scopes;
using UnityEditor;

namespace UGF.Assets.Editor
{
    [CustomEditor(typeof(AssetFolderAsset<,>), true)]
    internal class AssetFolderAssetEditor : UnityEditor.Editor
    {
        private SerializedProperty m_propertyFolder;
        private SerializedProperty m_propertyCollection;
        private EditorObjectReferenceDrawer m_drawerCollection;

        private void OnEnable()
        {
            m_propertyFolder = serializedObject.FindProperty("m_folder");
            m_propertyCollection = serializedObject.FindProperty("m_collection");

            m_drawerCollection = new EditorObjectReferenceDrawer(m_propertyCollection)
            {
                Drawer = { DisplayTitlebar = true }
            };

            m_drawerCollection.Enable();
        }

        private void OnDisable()
        {
            m_drawerCollection.Disable();
        }

        public override void OnInspectorGUI()
        {
            using (new SerializedObjectUpdateScope(serializedObject))
            {
                EditorIMGUIUtility.DrawScriptProperty(serializedObject);

                EditorGUILayout.PropertyField(m_propertyFolder);
                EditorGUILayout.PropertyField(m_propertyCollection);
            }

            AssetFolderEditorGUIUtility.DrawControlsGUILayout(serializedObject);

            m_drawerCollection.DrawGUILayout();
        }
    }
}
