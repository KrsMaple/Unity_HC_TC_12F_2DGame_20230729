using TMPro;
using UnityEngine;

public class DamageBasic : MonoBehaviour
{
	[Header("角色資料")]
	public DataBasic data;
	[Header("傷害值")]
	public GameObject DamageObject;
	protected float hp;
	protected float Maxhp;

	//一開始將角色資料讀出來獨立使用
	private void Awake()
	{
		hp = data.hp;
		Maxhp = hp;
	}

	//定義受傷
	public virtual void Damage(float damage)
	{
		GameObject insDamageObject = Instantiate(DamageObject, transform.position, Quaternion.identity);
		insDamageObject.transform.GetChild(0).GetComponent<TextMeshPro>().text = damage.ToString();
		Destroy(insDamageObject, 1);

		//每次執行血量都會扣除傳入的傷害直
		hp -= damage;
		print($"{gameObject.name}受到傷害：{damage}，剩餘血量：{hp}");

		//如果血量小於等於0，執行死亡的方法
		if (hp <= 0) Dead();


	}

	//protected：允許類別和子類別可以存取
	//virtual：讓子類別可以使用override去複寫
	//定義死亡
	protected virtual void Dead()
	{
		print($"{gameObject.name}死亡");

	}
}
