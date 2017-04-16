using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player {

	// Player status
	List<Skill> skillList;

	public Player() {
		skillList = SkillLoader.LoadSkill ("FILEPATH_HERE");
	}

}
