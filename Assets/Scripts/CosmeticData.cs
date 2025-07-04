/// <copyright file="CosmeticData.cs" company="Innersloth">
/// Copyright (c) 2024 All Rights Reserved
/// </copyright>
using System;
using System.Collections;
using System.Collections.Generic;
using Innersloth.Assets;
using UnityEngine;

public class CosmeticData : ScriptableObject
{
	public const string TranslationPrefix = "Cosmetic.";

	public List<object> unlockOnSelectPlatforms;

	public bool freeRedeemableCosmetic;

	public int redeemPopUpColor;

	public string epicId;

	public string BundleId;

	public string ProductId;

	public Vector2 ChipOffset;

	public int beanCost;

	public int starCost;

	public bool paidOnMobile;

	public object limitedTime;

	public int displayOrder;

	public bool NotInStore;

	public bool Free;

	public Sprite SpritePreview;

	public bool PreviewCrewmateColor;

	public string ProdId => null;

	public int BeanCost => 0;

	public int StarCost => 0;

	public string EpicId => null;

	public bool PaidOnMobile => false;

	public object LimitedTimeAvailable => default(object);

	public virtual void PreviewOnPlayer(object p, int colorId)
	{
	}

	public string GetItemName()
	{
		return null;
	}

	public virtual string GetItemCategory()
	{
		return null;
	}

	public virtual void SetProdId()
	{
	}

	public virtual IEnumerator CoLoadIcon(Action<Sprite, AddressableAsset> onLoaded)
	{
		return null;
	}

	public void SetPreview(SpriteRenderer renderer, int color)
	{
	}
}
