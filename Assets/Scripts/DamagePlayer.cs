using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DamagePlayer : DamageBasic
{
	[Header("血條")]
	public Image Imghp;
	[Header("血條文字")]
	public TextMeshProUGUI HpText;
	public ControlSystem controlSystem;
	public override void Damage(float damage)
	{
		if (hp <= 0) return;
		base.Damage(damage);
		HpText.text = $"{hp} / {Maxhp}" ;
		Imghp.fillAmount = hp / Maxhp ;
	}

	protected override void Dead()
	{
		base.Dead();
		Imghp.fillAmount = 0 / Maxhp;
		controlSystem.enabled = false;

	}

}
