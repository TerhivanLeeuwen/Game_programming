using UnityEngine;

namespace AG2298
{
	public class targetmove : MonoBehaviour
	{
		[SerializeField] private Transform[] targetEndPoints;
		private Transform target;
		private int currentEndPointIndex = 0;
		public float speed = 1.0f;

		void Start()
		{
			target = targetEndPoints[0];
		}

		void Update()
		{
			var step = speed * Time.deltaTime; 
			transform.position = Vector3.MoveTowards(transform.position, target.position, step);

			if (Vector3.Distance(transform.position, target.position) < 0.001f)
			{
				SwapEndPointTarget();
			}
		}
		public void SwapEndPointTarget()
		{
			currentEndPointIndex++;
			currentEndPointIndex %= targetEndPoints.Length;
			target = targetEndPoints[currentEndPointIndex];
		}
	}
}