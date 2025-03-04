using UnityEngine;
namespace AG2298
{
	public class FindGameObject : MonoBehaviour
	{
		private GameObject foundObject;

		void Start()
		{
			// Find the GameObject named "TargetObject" in the scene
			foundObject = GameObject.Find("TargetObject");

			// Check if the object was found before trying to use it
			if (foundObject != null)
			{
				Debug.Log("Found GameObject: " + foundObject.name);
			}
			else
			{
				Debug.Log("GameObject not found! Make sure it exists in the scene.");
			}
		}
	}
}