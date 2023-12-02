using UnityEngine;

[CreateAssetMenu(menuName = "Maple/DataSkill", fileName = "DataSkill")]
public class DataSkill : ScriptableObject
{
	[Header("技能名稱")]
	public string SkillName;
	[Header("技能圖案")]
	public Sprite SkillImage;
	[Header("技能說明")]
	public string SkillDesc;
	[Header("技能等級")]
	public int SkillLevel;
	[Header("技能能力")]
	public float[] SkillScore;
	[Header("對應升級物件")]
	public string nameSkillupgrad;
}
