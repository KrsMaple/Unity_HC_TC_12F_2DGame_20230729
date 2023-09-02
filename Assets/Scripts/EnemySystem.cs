using UnityEngine;

public class EnemySystem : MonoBehaviour
{
    [Header("敵人生成間隔"), Range(0, 5)]
    public float insterval = 3;
    [Header("敵人物件")]
    public GameObject prefabEmemy;

	private void Awake()
	{
		InvokeRepeating("SpawnEmemy", 0, insterval);
	}

	private void SpawnEmemy()
	{
		Instantiate(prefabEmemy, transform.position, transform.rotation);
	}
}
