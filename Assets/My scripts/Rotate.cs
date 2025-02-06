using UnityEngine;
namespace Ag2298
{ 
public class SpinObject : MonoBehaviour
{
	public Vector3 rotationSpeed = new Vector3(0, 100, 0); // Set rotation speed per axis

	void Update()
	{
		transform.Rotate(rotationSpeed * Time.deltaTime);
	}
}
}
