/// <copyright file="AddressableAsset.cs" company="Innersloth">
/// Copyright (c) 2024 All Rights Reserved
/// </copyright>
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace Innersloth.Assets
{
	public abstract class AddressableAsset : IDisposable, ISerializationCallbackReceiver
	{
		public enum AssetLoadState
		{
			Null = 0,
			Unloaded = 1,
			Loading = 2,
			Success = 3,
			Error = 4
		}

		protected static readonly Logger logger;

		private void System_002EIDisposable_002EDispose()
		{
		}

		private void UnityEngine_002EISerializationCallbackReceiver_002EOnBeforeSerialize()
		{
		}

		private void UnityEngine_002EISerializationCallbackReceiver_002EOnAfterDeserialize()
		{
		}

		public bool IsLoading()
		{
			return false;
		}

		public bool IsCompleted()
		{
			return false;
		}

		public bool IsLoaded()
		{
			return false;
		}

		protected virtual void OnSerialize()
		{
		}

		protected virtual void OnDeserialize()
		{
		}

		public virtual void Dispose() {

		}

		public virtual void OnBeforeSerialize()
		{
		}

		public virtual void OnAfterDeserialize()
		{
		}

		public abstract AssetLoadState GetState();

		public abstract void LoadAsync(Action onSuccessCb = null, Action onErrorcb = null, Action onFinishedcb = null);

		public abstract IEnumerator CoLoadAsync(Action onFinished = null);

		public abstract void Unload();

		public abstract void Destroy();

		public abstract bool ReferenceEquals(AddressableAsset asset);

		public abstract bool ReferenceEquals(AssetReference asset);
	}
	[Serializable]
	public class AddressableAsset<T> : AddressableAsset where T : UnityEngine.Object
	{
		[SerializeField]
		protected AssetReference assetRef;

		private CallbackResultGroup onLoadedCallbackGroup;

		private AsyncOperationHandle handle;

		public CallbackResultGroup OnLoaded => null;

		public AddressableAsset()
		{
		}

		public AddressableAsset(AssetReference assetRef)
		{
		}

		~AddressableAsset()
		{
		}

		protected override void OnDeserialize()
		{
		}

		public AddressableAsset<T> Clone()
		{
			return null;
		}

		public virtual T GetAsset()
		{
			return null;
		}

		public override IEnumerator CoLoadAsync(Action onFinished = null)
		{
			return null;
		}

		public override void LoadAsync(Action onSuccessCb = null, Action onErrorcb = null, Action onFinishedcb = null)
		{
		}

		public IEnumerator CoWaitUntilFinished()
		{
			return null;
		}

		public override void Unload()
		{
		}

		public override void Destroy()
		{
		}

		public override bool ReferenceEquals(AddressableAsset asset)
		{
			return false;
		}

		public override bool ReferenceEquals(AssetReference asset)
		{
			return false;
		}

		public override AssetLoadState GetState()
		{
			return default(AssetLoadState);
		}

		private void AttachOnCompleteCallback()
		{
		}

		private void HandleOnCompleted(AsyncOperationHandle obj)
		{
		}
	}
}
