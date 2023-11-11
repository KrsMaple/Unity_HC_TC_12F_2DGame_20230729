
using Fungus;
using JetBrains.Annotations;
using UnityEngine;

public class ExpObject : MonoBehaviour
{
	#region 資料區
	[SerializeField, Header("飛行速度"), Range(0, 100)]
	public float Speed = 10f;
	[SerializeField, Header("拾取距離"), Range(0, 5)]
	public float EatDistance = 1f;
	[SerializeField, Header("經驗值"), Range(0, 10000)]
	public float Exp = 30f;
	private string PlayerName = "黑貓";
	private Transform Player_transform;
	private LevelManager levelManager;
	#endregion

	#region 事件
	private void Awake()
	{
		//找尋場景上的這個物件，此物件是唯一的才可使用
		levelManager = FindObjectOfType<LevelManager>();
		Player_transform = GameObject.Find(PlayerName).transform;
	}

	// Update is called once per frame
	void Update()
	{
		GoToPlayer();
		EatExp();
	}
	#endregion

	#region 方法
	public void GoToPlayer()
	{
		transform.position = Vector3.MoveTowards(transform.position, Player_transform.position, Speed * Time.deltaTime);
	}

	public void EatExp()
	{
		float Eat = Vector3.Distance(transform.position, Player_transform.position);
		//print($"距離：{Eat}");
		if (Eat <= EatDistance)
		{
			levelManager.AddExp(Exp);
			Destroy(gameObject);
		}
	} 

	#endregion
}
