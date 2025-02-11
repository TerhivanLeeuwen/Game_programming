using UnityEngine;

public class ChangeTarget : MonoBehaviour
{
	public MoveObject moveScript;

	void Start()
	{
		if (moveScript != null)
		{
			moveScript.SetTarget(new Vector3(5, 5, 5)); 
		}
	}
}