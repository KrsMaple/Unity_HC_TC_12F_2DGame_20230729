using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SkillManager : MonoBehaviour
{
    [SerializeField, Header("技能面板")]
    private CanvasGroup groupSkill;
    [SerializeField, Header("技能物件")]
    private Transform[] objectSkill;
    [SerializeField, Header("技能資料")]
    private DataSkill[] dataSkill;
    [SerializeField, Header("技能資料")]
    private List<DataSkill> randomSkill = new List<DataSkill>();
    [SerializeField, Header("技能按鈕")]
    private Button[] butSkill;
    [SerializeField, Header("升級技能系統")]
    private GameObject[] updateSkill;

    /// <summary>
    /// 偵測按了哪顆技能按鈕
    /// </summary>
    private void Awake()
	{
        
        for (int i = 0; i < butSkill.Length; i++)
        {
            int index = i;
            butSkill[i].onClick.AddListener(() =>
            {
                print("按下按鈕");
                print(randomSkill[index].SkillName);

                for (int j = 0; j < dataSkill.Length; j++) 
                {
                    if (randomSkill[index] == dataSkill[j])
                    {
                        print(dataSkill[j].SkillName);
                        dataSkill[j].SkillLevel++;
                        updateSkill[j].GetComponent<ISkillupgrad>().Skillupgrad();
                        StartCoroutine(SkillLevelUp());
                    }
                }
            });
        }
	}

    private IEnumerator SkillLevelUp()
    {
        groupSkill.interactable = false;
        groupSkill.blocksRaycasts = false;
        yield return new WaitForSecondsRealtime(0.035f);
        UpdateSkill();
        yield return new WaitForSecondsRealtime(1f);
        groupSkill.alpha = 0f;
        Time.timeScale = 1;
    }

	/// <summary>
	/// 升級後技能面板顯示
	/// </summary>
	/// <returns></returns>
	public void levelUpShowSkillUI()
    {
        //顯示技能面板
        //print("開啟技能面板");
        Time.timeScale = 0;
        RandomSkill();
        StartCoroutine(FadeInSkillUI());
    }

    /// <summary>
    /// 技能面板淡入
    /// </summary>
    /// <returns></returns>
    private IEnumerator FadeInSkillUI()
    {
        for (int i = 1; i < 15; i++)
        {
            groupSkill.alpha += 0.1f;
            yield return new WaitForSecondsRealtime(0.033f);

            groupSkill.interactable = true;
            groupSkill.blocksRaycasts = true;
        }
    }

    /// <summary>
    /// 打亂技能順序
    /// </summary>
    private void RandomSkill()
    {
        randomSkill = dataSkill.Where(x => x.SkillLevel < 5).ToList();
        randomSkill = randomSkill.OrderBy(x => Random.Range(0, 999)).ToList();

        UpdateSkill();
    }

    /// <summary>
    /// 更新技能介面
    /// </summary>
    private void UpdateSkill()
    {
        for (int i = 0; i < objectSkill.Length; i++)
        {
            DataSkill dataSkill = randomSkill[i];
            int skillLv = dataSkill.SkillLevel;
            objectSkill[i].Find("技能名稱").GetComponent<TextMeshProUGUI>().text = dataSkill.SkillName;
            objectSkill[i].Find("技能敘述").GetComponent<TextMeshProUGUI>().text = dataSkill.SkillDesc;
            objectSkill[i].Find("技能圖示").GetComponent<Image>().sprite = dataSkill.SkillImage;

            for (int j = 0; j < skillLv; j++)
            {
                print($"星星{j}");
                objectSkill[i].Find($"星星{j}").GetComponent<Image>().enabled = true;
            }
        }
    }
}
