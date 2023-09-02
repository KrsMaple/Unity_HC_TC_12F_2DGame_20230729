using UnityEngine;

[CreateAssetMenu(menuName = "Maple/DataEnemy", fileName = "DataEnemy")]
public class DataEnemy : ScriptableObject
{
	[Header("生命值"), Range(0, 10000)]
	public float hp = 100f;
	[Header("速度"), Range(0, 30)]
	public float speed = 2.5f;
	[Header("攻擊力"), Range(0, 1000)]
	public float attack = 25f;
	[Header("掉落經驗機率"), Range(0, 1)]
	public float expProbability = 1f;
	[Header("經驗物物件")]
	public float expObject = 2.5f;

}
