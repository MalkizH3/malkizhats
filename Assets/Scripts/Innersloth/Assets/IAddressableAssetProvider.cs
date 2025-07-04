/// <copyright file="IAddressableAssetProvider.cs" company="Innersloth">
/// Copyright (c) 2024 All Rights Reserved
/// </copyright>
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Innersloth.Assets
{
	public interface IAddressableAssetProvider<T> where T : Object
	{
		AddressableAsset<T> CreateAddressableAsset();

		AssetReference GetAssetReference();
	}
}
