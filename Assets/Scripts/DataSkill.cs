using UnityEngine;

[CreateAssetMenu(menuName = "Maple/DataSkill", fileName = "DataSkill")]
public class DataSkill : ScriptableObject
{
	[Header("�ޯ�W��")]
	public string SkillName;
	[Header("�ޯ�Ϯ�")]
	public Sprite SkillImage;
	[Header("�ޯ໡��")]
	public string SkillDesc;
	[Header("�ޯ൥��")]
	public float SkillLevel;
	[Header("�ޯ��O")]
	public float[] SkillScore;
}
