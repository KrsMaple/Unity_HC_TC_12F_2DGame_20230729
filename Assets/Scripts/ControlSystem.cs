using UnityEngine;

public class ControlSystem : MonoBehaviour
{
	[Header("玩家資料")]
	public DataPlayer dataPlayer;
	[SerializeField] private string praWalk = "開關走路";
	[Header("剛體")]
	public Rigidbody2D rig;
	[Header("動畫元件")]
	public Animator ani;

	private void Awake()
	{
		//print("喚醒事件");
	}

	private void Start()
	{
		//print("開始事件");
	}

	private void Update()
	{
		//print("更新事件");
		Move();
	}

	private void Move()
	{
		//print("移動中");
		//取得玩家輸入A、D或左、右方向鍵
		float xMove = Input.GetAxis("Horizontal");
		float yMove = Input.GetAxis("Vertical");

		rig.velocity = new Vector2(xMove, yMove) * dataPlayer.speed;

		ani.SetBool(praWalk, xMove != 0 || yMove != 0);

		if(xMove > 0)
		{
			//右邊
			transform.eulerAngles = new Vector2(0, 0);
		}
		else if(xMove < 0)
		{
			//左邊
			transform.eulerAngles = new Vector2(0, 180);
		}
	}
}
	