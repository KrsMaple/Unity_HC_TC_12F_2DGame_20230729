using UnityEngine;

// 第一次套用腳本時添加元件
[RequireComponent(typeof(AudioSource))]
public class SoundManager : MonoBehaviour
{
	private AudioSource aud;

	private void Awake()
	{
		aud = this.GetComponent<AudioSource>();
	}

	public void playSound(AudioClip sound, float minVolume, float maxVolume) 
	{
		//隨機音量 = 最小值 ~ 最大值
		float randVolume = Random.Range(minVolume, maxVolume);

		//播放音效(音效檔, 隨機音量)
		aud.PlayOneShot(sound, randVolume);

	}
}
