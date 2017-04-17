using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISkillController : MonoBehaviour {

	public UISkill skillTemplate;

	// cache reference list
	public List<UISkill> cache;

	// Use this for initialization
	void Start () {
		StartCoroutine (InitSkillPanel ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	/// <summary>
	/// Initialize the UI skill panel.
	/// </summary>
	/// <returns>Async method to clone template to the UISkillPanel parent.</returns>
	IEnumerator InitSkillPanel() {
		List<Skill> tmp = SkillLoader.LoadSkill (Constants.SKILL_DATA_PATH);
		for (int i = 0; i < tmp.Count; i++) {
			GameObject go = Instantiate (skillTemplate.gameObject, this.transform);
			go.GetComponent<UISkill> ().SetupSkill (tmp [i].GetSkillName (), tmp [i].GetSkillDesc (), SkillManager.GetSkillLevel(i).ToString(), i);
			go.SetActive (true);

			// added to cache
			cache.Add (go.GetComponent<UISkill> ());
		}
		yield return null;
	}

	/// <summary>
	/// Update the UISkillPanel elements
	/// </summary>
	/// <param name="id">Skill ID</param>
	public void UpdateSkillInfo(int id) {
		if (cache.Count < id) {
			// avoid array out of range
			return;
		} else {
			cache [id].UpdateSkillLevel (SkillManager.GetSkillLevel (id).ToString());
		}
	}

	/// <summary>
	/// Updates all the UISkillPanel level elements
	/// </summary>
	public void UpdateSkillInfo() {
		for (int i = 0; i < cache.Count; i++) {
			cache [i].UpdateSkillLevel (SkillManager.GetSkillLevel (i).ToString());
		}
	}

	/// <summary>
	/// Reciever for level up message
	/// </summary>
	/// <param name="id">Skill Id</param>
	public void _SkillLevelUp (int id) {
		SkillManager.SkillLevelUp (id);
		UpdateSkillInfo (id);
	}
}
