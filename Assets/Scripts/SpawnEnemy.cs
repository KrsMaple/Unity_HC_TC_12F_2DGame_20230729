using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [Header("敵人生成間隔"), Range(0, 5)]
    public float insterval = 3;
    [Header("敵人物件")]
    public GameObject prefabEmemy;

	private void Awake()
	{
		InvokeRepeating("SpawnEmemyFunction", 0, insterval);
	}

	private void SpawnEmemyFunction()
	{
		Instantiate(prefabEmemy, transform.position, transform.rotation);
	}
}
