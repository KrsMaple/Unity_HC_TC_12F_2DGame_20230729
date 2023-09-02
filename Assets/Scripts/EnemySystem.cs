using UnityEngine;

public class EnemySystem : MonoBehaviour
{
	[Header("敵人資料")]
	public DataEnemy data;

	public Transform playerPoint;

	private void Awake()
	{
		playerPoint = GameObject.Find("黑貓").transform;
	}

	private void Update()
	{
		TrackPlayer();
	}

	private void TrackPlayer()
	{
		if (Vector2.Distance(transform.position, playerPoint.position) > 3) 
		{ 
		float moveSpeed = data.speed * Time.deltaTime;
		//取得怪物座標往玩家座標以一個數值計算後的座標(實作為怪物追蹤玩家)
		transform.position = Vector2.MoveTowards(transform.position, playerPoint.position, moveSpeed);
		}

		if (transform.position.x > playerPoint.position.x) transform.eulerAngles = new Vector2(0, 180);
		if (transform.position.x < playerPoint.position.x) transform.eulerAngles = new Vector2(0, 0);
	}
}
