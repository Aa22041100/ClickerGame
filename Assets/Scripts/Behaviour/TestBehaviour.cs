using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TestBehaviour : MonoBehaviour {

    Player player;

	[Header("Skill Config File")]
    public TextAsset text;

	[Header("UI References")]
	public UISkillController skillController;

	// Use this for initialization
	void Start ()
    {
		// create player object
        player = new Player ();

		// load saved skill level from player prefs
		SkillManager.LoadData ();

		// init skill panel UI
		skillController.Init ();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void DebugPlayerObject()
    {
        Debug.Log("Skill len: " + player.GetSkillLen ());
        player.DebugSkill ();
    }

	public void DebugSaveSkillLevel() {
		SkillManager.SaveData ();
	}

	public void DebugLoadSkillLevel() {
		SkillManager.LoadData ();
		skillController.UpdateSkillInfo ();
	}
}