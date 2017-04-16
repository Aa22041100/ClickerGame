using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISkill : MonoBehaviour {

	// view columns
	public Text name;
	public Text desc;
	public Button lvupBtn;
	public Image icon;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SetupSkill(string name, string desc) {
		this.name.text = name;
		this.desc.text = desc;
	}
}
