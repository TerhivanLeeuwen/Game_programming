using UnityEngine;
namespace AG2298
{
	public abstract class Weapon : MonoBehaviour
	{

		public string Name { get; protected set; }

		public Weapon(string name)
		{
			Name=name;
		}


		public abstract void Attack();
	
	}
   
}


