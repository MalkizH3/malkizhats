/// <copyright file="AddressableAssetExtensions.cs" company="Innersloth">
/// Copyright (c) 2024 All Rights Reserved
/// </copyright>
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Innersloth.Assets
{
	public static class AddressableAssetExtensions
	{
		public static IEnumerator CoLoadAssetAsync(this MonoBehaviour behavior, AddressableAsset asset, Action onFinished)
		{
			return null;
		}

		public static IEnumerator CoLoadAssetAsync(this GameObject gameObject, AddressableAsset asset, Action onFinished)
		{
			return null;
		}

		public static IEnumerator CoLoadAssetAsync<T>(this MonoBehaviour behavior, AssetReference reference, Action<T> onFinished) where T : UnityEngine.Object
		{
			return null;
		}

		public static IEnumerator CoLoadAssetAsync<T>(this GameObject gameObject, AssetReference reference, Action<T> onFinished) where T : UnityEngine.Object
		{
			return null;
		}

		public static IEnumerator CoLoadAssetAsync<T>(this MonoBehaviour behavior, IAddressableAssetProvider<T> provider, Action<T> onFinished) where T : UnityEngine.Object
		{
			return null;
		}

		public static IEnumerator CoLoadAssetAsync<T>(this GameObject gameObject, IAddressableAssetProvider<T> provider, Action<T> onFinished) where T : UnityEngine.Object
		{
			return null;
		}

		public static void UnloadAddressableAsset(this MonoBehaviour behavior, AddressableAsset asset)
		{
		}

		public static void UnloadAddressableAsset<T>(this MonoBehaviour behavior, IAddressableAssetProvider<T> provider) where T : UnityEngine.Object
		{
		}

		public static void LoadAssetAsync(this MonoBehaviour behavior, AddressableAsset asset, Action onSuccess, Action onError = null)
		{
		}

		public static void LoadAssetAsync(this GameObject gameObject, AddressableAsset asset, Action onSuccess, Action onError = null)
		{
		}

		public static void LoadAssetAsync<T>(this MonoBehaviour behavior, AssetReference reference, Action<T> onSuccess, Action onError = null) where T : UnityEngine.Object
		{
		}

		public static void LoadAssetAsync<T>(this GameObject gameObject, AssetReference reference, Action<T> onSuccess, Action onError = null) where T : UnityEngine.Object
		{
		}

		public static void LoadAssetAsync<T>(this MonoBehaviour behavior, IAddressableAssetProvider<T> provider, Action<T> onSuccess, Action onError = null) where T : UnityEngine.Object
		{
		}

		public static void LoadAssetAsync<T>(this GameObject gameObject, IAddressableAssetProvider<T> provider, Action<T> onSuccess, Action onError = null) where T : UnityEngine.Object
		{
		}

		public static AddressableAssetGroup GetAssetGroup(this MonoBehaviour behaviour)
		{
			return null;
		}
	}
}
