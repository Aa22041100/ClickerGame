using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player {

	// Player status
	List<Skill> skillList;

	public Player() {
		skillList = SkillLoader.LoadSkill (Constants.SKILL_DATA_PATH);
	}

    public void DebugSkill()
    {
        foreach(Skill s in skillList)
        {
            s.PrintSkillData();
        }
    }

    public int GetSkillLen()
    {
        return skillList.ToArray().Length;
    }
}