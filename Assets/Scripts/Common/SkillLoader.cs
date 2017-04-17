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
	public static List<Skill> LoadSkill(string filepath, bool forceLoad = false) {
		if (isLoaded && !forceLoad) {
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

				// init tmp skill with info
				Skill tmpSkill = new Skill (id, name, baseCost, baseTime, baseMoney, upgradeCost, factor);

				// add to skill cache
				skillCache.Add (tmpSkill);

				// set loaded to flag to true
				isLoaded = true;
			}

            Debug.Log("===End of loading skill===");
			// return list of skill
			return skillCache;
		}
	}

	public static int GetSkillLen(string filepath, bool forceLoad = false) {
		if (isLoaded && !forceLoad) {
			// return cache length
			return skillCache.Count;
		} else {
			// not a first load or is a force load
			LoadSkill(filepath, true);
			return skillCache.Count;
		}
	}

	public static bool isSkillLoaded() {
		return isLoaded;
	}
}