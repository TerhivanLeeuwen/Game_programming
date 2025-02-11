using UnityEngine;

public class MoveObject : MonoBehaviour
{
	public Vector3 targetLocation;
	public float speed = 5f;

	void Update()
	{
		transform.position = Vector3.MoveTowards(transform.position, targetLocation, speed * Time.deltaTime);
	}

	public void SetTarget(Vector3 newTarget)
	{
		targetLocation = newTarget;
	}
}