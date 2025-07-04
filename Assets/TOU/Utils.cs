#if UNITY_EDITOR
    using UnityEditor.AddressableAssets.Settings;
    using UnityEditor.AddressableAssets;
    using UnityEditor;
    using UnityEngine.AddressableAssets;
    using System.IO;
    using UnityEditor.AddressableAssets.Settings.GroupSchemas;
    using System.Text.RegularExpressions;
    public static class Utils
    {
        public const string here = "./Assets/TOU/";
        public const string assethere = "Assets/TOU/";

        public static AssetReference AddAssetToAddressables(this UnityEngine.Object asset)
        {
            AddressableAssetSettings settings = AddressableAssetSettingsDefaultObject.Settings;
            string assetPath = AssetDatabase.GetAssetPath(asset);
            string assetGUID = AssetDatabase.AssetPathToGUID(assetPath);
            return settings.CreateAssetReference(assetGUID);
        }

        public static void AssignLabel(this AssetReference assetReference, string label)
        {
            AddressableAssetSettings settings = AddressableAssetSettingsDefaultObject.Settings;
            if (!settings.GetLabels().Contains(label)) settings.AddLabel(label);
            var assetEntry = settings.FindAssetEntry(assetReference.AssetGUID);
            assetEntry.SetLabel(label, true, true);
        }

        public static void ShowInExplorer(string itemPath)
        {
            itemPath = itemPath.Replace(@"/", @"\");
            System.Diagnostics.Process.Start("explorer.exe", "/select," + itemPath);
        }

        public static void Build(string group, string output_name)
        {
            var settings = AddressableAssetSettingsDefaultObject.Settings;
            foreach (var sg in settings.groups)
            {
                if (sg.ReadOnly) continue;

                var groupSchema = sg.GetSchema<BundledAssetGroupSchema>();
                groupSchema.IncludeInBuild = (sg.Name == group);
                EditorUtility.SetDirty(sg);
            }

            AddressableAssetSettings.BuildPlayerContent();

            var f1 = Directory.GetFiles("./Library/com.unity.addressables/aa/Windows/StandaloneWindows64/")[0];
            var f = File.ReadAllText("./Library/com.unity.addressables/aa/Windows/catalog.json");
            var o = Regex.Replace(f, "{UnityEngine.AddressableAssets.Addressables.RuntimePath}.*.bundle", $"{{UnityEngine.AddressableAssets.Addressables.RuntimePath}}/../../../BepInEx/plugins/{output_name}.bundle");
            File.WriteAllText($"./Library/com.unity.addressables/aa/Windows/StandaloneWindows64/{output_name}.catalog", o);
            File.Copy(f1, $"./Library/com.unity.addressables/aa/Windows/StandaloneWindows64/{output_name}.bundle");

            if (!EditorUtility.DisplayDialog("Build", group + " AddressableGroup has successfully built.", "Ok", "Show Me"))
            {
                ShowInExplorer(Path.GetFullPath($"./Library/com.unity.addressables/aa/Windows/StandaloneWindows64"));
            }
        }
    }
#endif