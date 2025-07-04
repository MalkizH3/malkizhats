/// <copyright file="HatViewData.cs" company="Innersloth">
/// Copyright (c) 2024 All Rights Reserved
/// </copyright>
using UnityEngine;

[CreateAssetMenu]
public class HatViewData : ScriptableObject
{
	public Sprite MainImage;

	public Sprite BackImage;

	public Sprite LeftMainImage;

	public Sprite LeftBackImage;

	public Sprite ClimbImage;

	public Sprite FloorImage;

	public Sprite LeftClimbImage;

	public Sprite LeftFloorImage;

	public bool MatchPlayerColor;
}
