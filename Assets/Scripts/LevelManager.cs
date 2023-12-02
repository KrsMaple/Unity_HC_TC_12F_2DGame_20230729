
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    [Header("經驗值圖片")]
    public Image ExpImage;
    [Header("等級文字")]
    public TextMeshProUGUI textLv;
    [Header("等級經驗需求")]
    public float[] ExpNeeds;

    private int Lv = 1;
    private int MaxLv;
    private float ExpCurrent = 0;
    private float ExpNeed = 100;

    private SkillManager skillManager;
	private void Awake()
	{
        //找到技能管理器
        skillManager = FindObjectOfType<SkillManager>();
	}

	[ContextMenu("建立經驗值需求資料")]
    public void CreateExpData()
    {
        MaxLv = 100;
        ExpNeeds = new float[MaxLv];

        for (int i = 0; i < MaxLv; i++)
		{
            ExpNeeds[i] = (1 + i) * 100;

        }
    }

    public void AddExp(float Exp)
    {
        ExpCurrent += Exp;
        ExpImage.fillAmount = ExpCurrent / ExpNeed;
        if (ExpCurrent > ExpNeed) LevelUp();
    }

    public void LevelUp() 
    {
        ExpCurrent -= ExpNeed;
        Lv++;
        ExpNeed = ExpNeeds[Lv - 1];
        ExpImage.fillAmount = ExpCurrent / ExpNeed;
        textLv.text = $"Lv.{Lv}";

        //呼叫技能面板
        skillManager.levelUpShowSkillUI();
    }
}
