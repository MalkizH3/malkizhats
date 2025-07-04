/// <copyright file="UnlockableCosmetic.cs" company="Innersloth">
/// Copyright (c) 2024 All Rights Reserved
/// </copyright>
using System;
using System.Collections;
using Innersloth.Assets;
using UnityEngine;

[CreateAssetMenu]
public class UnlockableCosmetic : ScriptableObject
{
	public enum UnlockableQuality
	{
		Nameplate = 1,
		Hat = 2,
		Visor = 3,
		Skin = 4,
		Pet = 5,
		Kill = 6
	}

	public UnlockableQuality quality;

	public CosmeticData unlockableCosmetic;

	public int cost;

	public string GetProdId()
	{
		return null;
	}

	public string GetBundleId()
	{
		return null;
	}

	public IEnumerator CoLoadIcon(Action<Sprite, AddressableAsset> onLoaded)
	{
		return null;
	}
}
