/// <copyright file="AddressableSpriteBehaviour.cs" company="Innersloth">
/// Copyright (c) 2024 All Rights Reserved
/// </copyright>
using UnityEngine;

namespace Innersloth.Assets
{
	public class AddressableSpriteBehavior : MonoBehaviour
	{
		public bool unloadOnDisable;

		private AddressableAsset<Sprite> asset;

		private SpriteRenderer spriteRenderer;

		public void ReplaceAsset(AddressableAsset<Sprite> newAsset)
		{
		}

		public static AddressableSpriteBehavior AddToSpriteRenderer(SpriteRenderer pSpriteRenderer, AddressableAsset<Sprite> asset)
		{
			return null;
		}

		private void Start()
		{
		}

		private void Awake()
		{
		}

		private void OnDisable()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDestroy()
		{
		}

		private void Load()
		{
		}

		private void Unload()
		{
		}

		private void OnAssetLoaded()
		{
		}
	}
}
