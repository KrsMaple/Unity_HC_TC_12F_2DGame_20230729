using UnityEngine;

public class EnemySystem : MonoBehaviour
{
	[Header("敵人資料")]
	public DataEnemy data;
	[Header("動畫元件")]
	public Animator ani;
	private bool attackChack = true;
	private string praAttack = "觸發_攻擊";
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
		//調整方向
		if (transform.position.x > playerPoint.position.x) transform.eulerAngles = new Vector2(0, 180);
		if (transform.position.x < playerPoint.position.x) transform.eulerAngles = new Vector2(0, 0);

		//追蹤玩家
		if (Vector2.Distance(transform.position, playerPoint.position) > data.attackDistance) 
		{ 
		float moveSpeed = data.speed * Time.deltaTime;
		//取得怪物座標往玩家座標以一個數值計算後的座標(實作為怪物追蹤玩家)
		transform.position = Vector2.MoveTowards(transform.position, playerPoint.position, moveSpeed);
		}

		//攻擊玩家
		if (Vector2.Distance(transform.position, playerPoint.position) <= data.attackDistance)
		{
			if(attackChack) Attack();
		}

	}

	private void Attack()
	{
		attackChack = false;
		print("攻擊中~");
	}
}
