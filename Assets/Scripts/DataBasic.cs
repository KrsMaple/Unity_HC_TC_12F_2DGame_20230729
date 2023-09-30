using UnityEngine;

[CreateAssetMenu(menuName = "Maple/DataBasic", fileName = "DataBasic")]
public class DataBasic : ScriptableObject
{
	[Header("生命值"), Range(0, 10000)]
	public float hp = 100f;
	[Header("速度"), Range(0, 30)]
	public float speed = 2.5f;
}