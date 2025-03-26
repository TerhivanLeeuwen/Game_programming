using AG2298;
using UnityEngine;

public class Bow : Weapon

{
	public Bow() : base("Bow") { }

	public override void Attack()
	{
		Debug.Log(name + " shoots the enemy");
	}

	private void Start()
	{
		Attack();
	}
}
