using AG2298;
using UnityEngine;

public class Sword : Weapon 

{
	public Sword() : base ("Sword") {}

		public override void Attack()
	{
		Debug.Log(name + " slashes the enemy");
	}

	private void Start()
	{
		Attack();
	}
}
