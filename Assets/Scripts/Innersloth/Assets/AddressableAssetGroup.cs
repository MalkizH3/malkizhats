/// <copyright file="AddressableAssetGroup.cs" company="Innersloth">
/// Copyright (c) 2024 All Rights Reserved
/// </copyright>
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.AddressableAssets;

namespace Innersloth.Assets
{
    public class AddressableAssetGroup : AddressableAsset
	{
		public readonly CallbackResultGroup OnLoaded;

		private List<AddressableAsset> Assets;

		public AddressableAssetGroup()
		{
		}

		public AddressableAssetGroup(IEnumerable<AddressableAsset> assetList)
		{
		}

		~AddressableAssetGroup()
		{
		}

		public void Add(AddressableAsset asset)
		{
		}

		public void Add(IEnumerable<AddressableAsset> list)
		{
		}

		public AddressableAsset<T> AddReference<T>(AssetReference assetRef) where T : UnityEngine.Object
		{
			return null;
		}

		public AddressableAsset<T> GetFromReference<T>(AssetReference assetRef) where T : UnityEngine.Object
		{
			return null;
		}

		public AddressableAsset<T> GetFromReferenceRecur<T>(AssetReference assetRef) where T : UnityEngine.Object
		{
			return null;
		}

		public bool Remove(AddressableAsset asset)
		{
			return false;
		}

		public void Clear()
		{
		}

		public override AssetLoadState GetState()
		{
			return default(AssetLoadState);
		}

		public override void LoadAsync(Action onSuccessCb = null, Action onErrorcb = null, Action onFinishedcb = null)
		{
		}

		private void OnAssetLoadedInternal()
		{
		}

		public override IEnumerator CoLoadAsync(Action onFinished = null)
		{
			return null;
		}

		public IEnumerator CoWaitUntilFinished()
		{
			return null;
		}

		public bool AnyAssetsLoading()
		{
			return false;
		}

		public int NumAssetsLoading()
		{
			return 0;
		}

		public bool AllAssetsLoaded()
		{
			return false;
		}

		public override void Unload()
		{
		}

		public override void Destroy()
		{
		}

		public List<AddressableAsset> GetAssets()
		{
			return null;
		}

		public override bool ReferenceEquals(AddressableAsset asset)
		{
			return false;
		}

		public override bool ReferenceEquals(AssetReference asset)
		{
			return false;
		}
	}
}
