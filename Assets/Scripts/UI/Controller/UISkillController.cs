using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISkillController : MonoBehaviour {

	[SerializeField]
	UISkill skillTemplate;

	// Use this for initialization
	void Start () {
		StartCoroutine (InitSkillPanel ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator InitSkillPanel() {
		List<Skill> tmp = SkillLoader.LoadSkill (Constants.SKILL_DATA_PATH);
		for (int i = 0; i < tmp.Count; i++) {
			GameObject go = Instantiate (skillTemplate.gameObject, this.transform);
			go.GetComponent<UISkill> ().SetupSkill (tmp [i].GetSkillName (), tmp [i].GetSkillDesc ());
			go.SetActive (true);
		}
		yield return null;
	}
}
