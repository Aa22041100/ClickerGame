using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SkillManager {

	// list of skill level
	public static Dictionary<int, int> skillLevel = new Dictionary<int, int>();

	/// <summary>
	/// Used to save data to local.
	/// </summary>
	public static void SaveData() {
		
	}

	/// <summary>
	/// Used to first load save from local.
	/// </summary>
	public static void LoadData() {

	}

	/// <summary>
	/// Used to level up the skill.
	/// </summary>
	/// <param name="key">Skill Id</param>
	public static void SkillLevelUp(int key) {
		if (skillLevel.ContainsKey (key)) {
			// if contain key, level++
			skillLevel [key]++;
		} else {
			// if dict doesn't have the key, add the new one.
			skillLevel.Add (key, 1);
		}
	}

	/// <summary>
	/// Gets the skill level.
	/// </summary>
	/// <returns>The skill level.</returns>
	/// <param name="key">Skill Id</param>
	public static int GetSkillLevel(int key) {
		if (skillLevel.ContainsKey (key)) {
			// direct return target value if the dictionary contains the key.
			return skillLevel[key];
		} else {
			// add the key pair value to dictionary first if the dictionary doesn't contain the key.
			skillLevel.Add (key, 1);
			return skillLevel[key];
		}
	}
}
