using UnityEngine;

public class TrackPlayer : MonoBehaviour
{
	private Transform Player_transfrom;

	private void Awake()
	{
		Player_transfrom = GameObject.Find("黑貓").transform;
	}
	// Update is called once per frame
	void Update()
    {
		Trank();

	}

	public void Trank()
	{
		transform.position = Player_transfrom.position;
	}
}
