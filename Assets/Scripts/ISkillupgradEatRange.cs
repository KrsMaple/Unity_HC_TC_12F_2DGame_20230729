﻿using UnityEngine;

public class ISkillupgradEatRange : MonoBehaviour, ISkillupgrad
{
	[SerializeField, Header("玩家資料")]
	private DataPlayer dataPlayer;
	[SerializeField, Header("技能資料")]
	private DataSkill dataSkill;

	private void Awake()
	{
		dataSkill.SkillLevel = 1;
		dataPlayer.speed = dataSkill.SkillScore[0];
	}

	public void Skillupgrad()
	{
		print("升級拾取範圍"); 
	}
}
