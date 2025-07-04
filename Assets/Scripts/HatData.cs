/// <copyright file="HatData.cs" company="Innersloth">
/// Copyright (c) 2024 All Rights Reserved
/// </copyright>
using System;
using System.Collections;
using Innersloth.Assets;
using UnityEngine;
using UnityEngine.AddressableAssets;

[CreateAssetMenu]
public class HatData : CosmeticData, IAddressableAssetProvider<HatViewData>
{
	public const string EmptyId = "hat_NoHat";

	public AssetReference ViewDataRef;

	public bool InFront;

	public bool NoBounce;

	public bool BlocksVisors;

	public string StoreName;

	public object RelatedSkin;

    public bool IsEmpty => false;

	public AddressableAsset<HatViewData> CreateAddressableAsset()
	{
		return null;
	}

	public AssetReference GetAssetReference()
	{
		return null;
	}

	public override void PreviewOnPlayer(object p, int colorId)
	{
	}

	public override string GetItemCategory()
	{
		return null;
	}

	public override IEnumerator CoLoadIcon(Action<Sprite, AddressableAsset> onLoaded)
	{
		return null;
	}
}
