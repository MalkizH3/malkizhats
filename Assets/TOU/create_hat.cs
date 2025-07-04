#if UNITY_EDITOR
    using UnityEngine;
    using UnityEditor;
    using UnityEngine.AddressableAssets;
    using System;

    public class create_hat : create_data
    {

        [MenuItem("TOUHATS/Main")]
        public static void MainWindow()
        {
            GetWindow<create_hat>("Main");
        }

        private const string _viewDataFolder = "hatviewdata";
        private const string _dataFolder = "hatdata";
        private static string _dataTagName
        {
            get
            {
                return "hatdata";
            }
        }
        public override string ViewDataFolder { get; } = _viewDataFolder;
        public override string DataFolder { get; } = _dataFolder;
        public override string TypeName { get; } = "Hat";
        public override string ResourcesName { get; } = "hats";
        public override string DataTagName { get; } = _dataTagName;
        public override string ViewDataTagName
        {
            get
            {
                return "hatviewdata";
            }
        }
        public override Func<Sprite, string, string, AssetReference> GenerateViewData { get; } = GenerateHatViewData;
        public override Action<Sprite, string, string, AssetReference> GenerateData { get; } = GenerateHatData;

        public static AssetReference GenerateHatViewData(Sprite sprite, string name, string author)
        {
            var hatviewdata = ScriptableObject.CreateInstance<HatViewData>();
            hatviewdata.name = name;
            hatviewdata.BackImage = sprite;
            hatviewdata.ClimbImage = sprite;
            hatviewdata.FloorImage = sprite;
            hatviewdata.MainImage = sprite;
            string safepath_hatviewdata = AssetDatabase.GenerateUniqueAssetPath($"{Utils.assethere}generated/{_viewDataFolder}/{sprite.name}.asset");
            AssetDatabase.CreateAsset(hatviewdata, safepath_hatviewdata);

            return hatviewdata.AddAssetToAddressables();
        }

        public static void GenerateHatData(Sprite sprite, string name, string author, AssetReference addressablesReference)
        {
            var hatdata = ScriptableObject.CreateInstance<HatData>();
            hatdata.name = name;
            hatdata.SpritePreview = sprite;
            hatdata.InFront = true;
            hatdata.NoBounce = true;
            hatdata.ChipOffset = new Vector2(-0.1f, 0.35f);
            hatdata.StoreName = author;
            hatdata.ProductId = sprite.name;
            hatdata.Free = true;
            hatdata.ViewDataRef = addressablesReference;
            string safepath_hatviewdata = AssetDatabase.GenerateUniqueAssetPath($"{Utils.assethere}generated/{_dataFolder}/{name}.asset");
            AssetDatabase.CreateAsset(hatdata, safepath_hatviewdata);
            hatdata.AddAssetToAddressables().AssignLabel(_dataTagName);
        }
    }
#endif