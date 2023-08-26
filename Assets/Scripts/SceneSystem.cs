using UnityEngine;
using UnityEngine.SceneManagement;		//unity內建場景管理方法

public class SceneSystem : MonoBehaviour
{
	public void StartGame()
	{
		//場景管理_讀取場景("場景名稱")
		SceneManager.LoadScene("遊戲場景");
	}

	public void QuitGame()
	{
		print("<i><b>離開</b>遊戲</i>");
		//應用_退出
		Application.Quit();
	}
}
