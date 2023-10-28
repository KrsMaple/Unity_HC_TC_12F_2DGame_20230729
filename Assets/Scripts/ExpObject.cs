
using UnityEngine;

public class ExpObject : MonoBehaviour
{
    private string PlayerName = "黑貓";
    private Transform Player_transform;

	private void Awake()
	{
		Player_transform = GameObject.Find(PlayerName).transform;
	}

	// Update is called once per frame
	void Update()
    {
        
    }
}
