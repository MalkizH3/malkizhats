/// <copyright file="AddressableAssetHandler.cs" company="Innersloth">
/// Copyright (c) 2024 All Rights Reserved
/// </copyright>
using UnityEngine;

namespace Innersloth.Assets
{
	public class AddressableAssetHandler : MonoBehaviour
	{
		private AddressableAssetGroup assetGroup;

		public static (AddressableAssetHandler, AddressableAssetGroup) AddToGameObject(GameObject obj, AddressableAsset asset = null)
		{
			return default((AddressableAssetHandler, AddressableAssetGroup));
		}

		public static (AddressableAssetHandler, AddressableAssetGroup) GetOrCreate(GameObject obj)
		{
			return default((AddressableAssetHandler, AddressableAssetGroup));
		}

		private void OnDestroy()
		{
		}
	}
}
