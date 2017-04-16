using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SkillLoader {

	private static List<Skill> skillCache = new List<Skill> ();
	private static bool isLoaded = false;

	/// <summary>
	/// Used to load skill from INI config file.
	/// </summary>
	/// <returns>List of skill and cache the skill info.</returns>
	/// <param name="filepath">The filepath which locate to the skill ini config file.</param>
	public static List<Skill> LoadSkill(string filepath) {
		if (isLoaded) {
			return skillCache;
		} else {
            Debug.Log("===Start to load skill===");
			INIParser iniReader = new INIParser ();
			iniReader.Open (filepath);

			// get config info
			// get skill length
			int skillLen = int.Parse (iniReader.ReadValue ("info", "length", "0"));

			// clean cache
			skillCache.Clear ();

			// load skill from config file
			for (int i = 0; i < skillLen; i++) {
				// read data from ini file
				int id = int.Parse(iniReader.ReadValue ("" + i, "id", ""));
				string name = iniReader.ReadValue ("" + i, "name", "");
				float baseCost = float.Parse(iniReader.ReadValue ("" + i, "baseCost", ""));
				float baseTime = float.Parse (iniReader.ReadValue ("" + i, "baseTime", ""));
				float baseMoney = float.Parse (iniReader.ReadValue ("" + i, "baseMoney", ""));
				float upgradeCost = float.Parse (iniReader.ReadValue ("" + i, "upgradeCost", ""));
				float factor = float.Parse (iniReader.ReadValue ("" + i, "factor", ""));
                Debug.Log("id: " + id + " ; name: " + name + " ; base cost: " + baseCost);
				// init tmp skill with info
				Skill tmpSkill = new Skill (id, name, baseCost, baseTime, baseMoney, upgradeCost, factor);

				// add to skill cache
				skillCache.Add (tmpSkill);
			}

            Debug.Log("===End of loading skill===");
			// return list of skill
			return skillCache;
		}
	}

	public static bool isSkillLoaded() {
		return isLoaded;
	}
}