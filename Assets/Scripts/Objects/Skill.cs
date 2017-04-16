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

	public Skill(int id, string name, float baseCost, float baseTime, float baseMoney, float upgradeCost, float factor) {
		this.id = id;
		this.name = name;
		this.baseCost = baseCost;
		this.baseTime = baseTime;
		this.baseMoney = baseMoney;
		this.upgradeCost = upgradeCost;
		this.factor = factor;
	}

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

	public string GetSkillName() {
		return name;
	}

	public string GetSkillDesc() {
		return "no desc currently";
	}
}