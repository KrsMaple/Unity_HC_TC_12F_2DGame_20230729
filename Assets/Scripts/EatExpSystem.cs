using Unity.VisualScripting;
using UnityEngine;

public class EatExpSystem : MonoBehaviour
{
	private string ExpObject = "∏g≈Á≠»";
	private void OnTriggerEnter2D(Collider2D collision)
	{
		//print(collision.name);
		if (collision.name.Contains(ExpObject)) 
		{
			collision.gameObject.GetComponent<ExpObject>().enabled = true;
		}
	}
}
