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
}