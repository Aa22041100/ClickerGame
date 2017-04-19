using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIBottomPanelController : MonoBehaviour {

	public Transform skillPanel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SetSkillPanelOnTop() {
		skillPanel.SetAsLastSibling ();
	}
}
