using UnityEngine;

public class ControlSystem : MonoBehaviour
{
	[Header("���ʳt��"), Range(0, 100)]
	public float speed = 3.5f;
	[SerializeField] private string praWalk = "�}������";
	[Header("����")]
	public Rigidbody2D rig;
	[Header("�ʵe����")]
	public Animator ani;

	private void Awake()
	{
		//print("����ƥ�");
	}

	private void Start()
	{
		//print("�}�l�ƥ�");
	}

	private void Update()
	{
		//print("��s�ƥ�");
		Move();
	}

	private void Move()
	{
		//print("���ʤ�");
		//���o���a��JA�BD�Υ��B�k��V��
		float xMove = Input.GetAxis("Horizontal");
		float yMove = Input.GetAxis("Vertical");

		rig.velocity = new Vector2(xMove, yMove) * speed;

		ani.SetBool(praWalk, xMove != 0 || yMove != 0);
	}
}
	