using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill {
	int id;
	string name;
	float baseCost;
	float baseTime;
	float baseMoney;
	float upgradeCost;
	float factor;

	/// <summary>
	/// Initializes a new instance of the <see cref="Skill"/> class.
	/// </summary>
	/// <param name="id">Skill ID</param>
	/// <param name="name">Skill Name</param>
	/// <param name="baseCost">Skill Base Cost</param>
	/// <param name="baseTime">Skill Base Time</param>
	/// <param name="baseMoney">Skill Base Money</param>
	/// <param name="upgradeCost">Skill Upgrade Cost</param>
	/// <param name="factor">Factor</param>
	public Skill(int id, string name, float baseCost, float baseTime, float baseMoney, float upgradeCost, float factor) {
		this.id = id;
		this.name = name;
		this.baseCost = baseCost;
		this.baseTime = baseTime;
		this.baseMoney = baseMoney;
		this.upgradeCost = upgradeCost;
		this.factor = factor;
	}

	/// <summary>
	/// Prints the skill data. (Debug usage)
	/// </summary>
    public void PrintSkillData()
    {
        Debug.Log("===Start to print skill===");
        Debug.Log("ID:" + id);
        Debug.Log("Skill Name: " + name);
        Debug.Log("Base Cost: " + baseCost);
        Debug.Log("Base Time: " + baseTime);
        Debug.Log("Base Money: " + baseMoney);
        Debug.Log("Upgrade Cost: " + upgradeCost);
        Debug.Log("Factor: " + factor);
        Debug.Log("===End to print skill===");
    }

	/// <summary>
	/// Returns skill name
	/// </summary>
	/// <returns>The skill name.</returns>
	public string GetSkillName() {
		return name;
	}

	/// <summary>
	/// Returns skill description
	/// </summary>
	/// <returns>The skill desc.</returns>
	public string GetSkillDesc() {
		return "no desc currently";
	}
}