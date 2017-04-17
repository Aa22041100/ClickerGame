using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISkill : MonoBehaviour {

	// view columns
	public Text name;
	public Text desc;
	public Text level;
	public Button lvupBtn;
	public Image icon;

	// identify usage
	protected int id;

	const string skillFormatStr = "Lv: {0}";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	/// <summary>
	/// Setup UISkill for the first load.
	/// </summary>
	/// <param name="name">Skill Name</param>
	/// <param name="desc">Skill Description</param>
	/// <param name="level">Current Skill Level</param>
	public void SetupSkill(string name, string desc, string level, int id) {
		this.name.text = name;
		this.desc.text = desc;
		this.level.text = string.Format(skillFormatStr, level);
		this.id = id;
	}

	/// <summary>
	/// Updates the skill level.
	/// </summary>
	/// <param name="level">Current Skill Level</param>
	public void UpdateSkillLevel(string level) {
		this.level.text = string.Format(skillFormatStr, level);
	}

	/// <summary>
	/// Sends the level up message to notify the controller.
	/// </summary>
	public void SendLevelUpMsg() {
		GameObject.FindObjectOfType<UISkillController> ().SendMessage ("_SkillLevelUp", id);
	}
}
