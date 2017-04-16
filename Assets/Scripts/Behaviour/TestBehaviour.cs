using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TestBehaviour : MonoBehaviour {

    Player player;

    public TextAsset text;

	// Use this for initialization
	void Start ()
    {
        player = new Player();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void DebugPlayerObject()
    {
        Debug.Log("Skill len: " + player.GetSkillLen());
        player.DebugSkill();
    }
}
