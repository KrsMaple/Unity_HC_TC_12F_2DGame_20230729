using UnityEngine;

public class WeaponSystem : MonoBehaviour
{
	[Header("武器發射間隔"), Range(0, 5)]
	public float interval = 3;
	[Header("發射物件")]
	public GameObject prefabWeapon;
	[Header("武器發射力道")]
	public Vector2 v2Value = new Vector2(0, 100);

	private void Awake()
	{
		//呼叫武器產生
		//SpawnWeapon();

		InvokeRepeating("SpawnWeapon", 0, interval);

	}

	private void SpawnWeapon()
	{
		GameObject temp = Instantiate(prefabWeapon, transform.position, transform.rotation);

		temp.GetComponent<Rigidbody2D>().AddForce(v2Value * transform.right + new Vector2(0, v2Value.y));

		Destroy(temp, 20);
	}
}
