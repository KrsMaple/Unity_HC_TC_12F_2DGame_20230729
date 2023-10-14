using UnityEngine;

[CreateAssetMenu(menuName = "Maple/DataEnemy", fileName = "DataEnemy")]
public class DataEnemy : DataBasic
{
	[Header("攻擊力"), Range(0, 1000)]
	public float attack = 25f;
	[Header("傷害延遲"), Range(0, 5)]
	public float attackDelay = 0.1f;
	[Header("攻擊頻率"), Range(0, 5)]
	public float attackInterver = 3f;
	[Header("攻擊距離"), Range(2, 5)]
	public float attackDistance = 2f;
	[Header("掉落經驗機率"), Range(0, 1)]
	public float expProbability = 1f;
	[Header("經驗物物件")]
	public GameObject expObject;
}
