#if UNITY_EDITOR
    using System;
    using System.IO;
    using System.Linq;
    using UnityEditor;
    using UnityEngine;
    using UnityEngine.AddressableAssets;

    public abstract class create_data : EditorWindow
    {
        public abstract string ViewDataFolder { get; }
        public abstract string DataFolder { get; }
        public abstract string TypeName { get; }
        public abstract string ResourcesName { get; }
        public abstract string DataTagName { get; }
        public abstract string ViewDataTagName { get; }
        public abstract Func<Sprite, string, string, AssetReference> GenerateViewData { get; }
        public abstract Action<Sprite, string, string, AssetReference> GenerateData { get; }

        const string here = Utils.here;

        private void OnGUI()
        {
            maxSize = new Vector2(250f, 110f);
            minSize = maxSize;
            GUILayout.Label($"Manage {TypeName} Data:");
            if (GUILayout.Button("Clear"))
            {
                Directory.Delete(here + $"generated/{ViewDataFolder}/ ", true);
                Directory.CreateDirectory(here + $"generated/{ViewDataFolder}/ ");

                Directory.Delete(here + $"generated/{DataFolder}/ ", true);
                Directory.CreateDirectory(here + $"generated/{DataFolder}/");
                AssetDatabase.Refresh();
            }
            if (GUILayout.Button("Generate New"))
            {
                Debug.ClearDeveloperConsole();

                var authors = Directory.GetDirectories(here + $"resources/{ResourcesName}/");
                authors = authors.Select(x =>
                {
                    var y = x.Split('/');
                    return y[y.Length - 1];
                }).ToArray();
                foreach (var author in authors)
                {
                    var sprites = Resources.LoadAll<Sprite>($"{ResourcesName}/{author}/");
                    foreach (var sprite in sprites)
                    {
                        if (File.Exists($"{here}generated/{ViewDataFolder}/{sprite.name}.asset")) continue;
                        Debug.Log($"Identified new hat: {author}/{sprite.name}. Calling {GenerateViewData.Method.Name}, {GenerateData.Method.Name}");
                        var name = sprite.name;
                        var hvd = GenerateViewData(sprite, name, author);
                        hvd.AssignLabel(ViewDataTagName);
                        GenerateData(sprite, name, author, hvd);
                    }
                }
                AssetDatabase.SaveAssets();
            }
            if (GUILayout.Button("Build"))
            {
                Utils.Build("Default Local Group", "malkizhats");
            }
        }
    }
#endif