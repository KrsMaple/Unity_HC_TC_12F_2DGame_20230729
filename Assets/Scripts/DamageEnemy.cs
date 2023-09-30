using UnityEngine;

public class DamageEnemy : DamageBasic
{
	#region //碰撞事件
	//碰到collision物件的瞬間
	private void OnCollisionEnter2D(Collision2D collision)
	{
		print($"碰觸到的物件：{collision.gameObject.name}");
		if (collision.gameObject.name.Contains("武器")) Damage(50);

	}

	//離開collision物件的瞬間
	private void OnCollisionExit2D(Collision2D collision)
	{

	}

	//碰到collision物件的時候(每60FPS觸發一次)
	private void OnCollisionStay2D(Collision2D collision)
	{

	}
	#endregion

	//取得敵人資料裡面的內容
	private DataEnemy DataEnemy;

	private void Start()
	{
		//在遊戲開始時，轉換成敵人的資料
		DataEnemy = (DataEnemy)data;
	}

	//繼承
	protected override void Dead()
	{
		//base：表示繼承父類別的內容
		base.Dead();

		float random = Random.value;
		print(random);

		//如果亂數小於機率，表示觸發成功
		if(random <= DataEnemy.expProbability)
		{
			//產生敵人資料中的經驗物於死亡敵人的座標
			Instantiate(DataEnemy.expObject, transform.position, Quaternion.identity);
		}

		Destroy(gameObject);
	}
}
