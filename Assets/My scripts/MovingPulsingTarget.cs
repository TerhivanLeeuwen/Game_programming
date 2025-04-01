using UnityEngine;
using UnityEngine.UIElements;
namespace AG2298
{
	public class MovingPulsingTarget : MovingTarget
	{
		public float pulsingSpeed;
		public Vector3 pulsingScale = new Vector3(1, 1, 1);
		public Vector3 pulsingScale2 = new Vector3(1, 1, 1);
		private bool size;

		void Update()
		{
			if (transform.localScale == pulsingScale)
			{
				size = true;
			}
			if (transform.localScale == pulsingScale2)
			{
				size = false;
			}
			switch (size)
			{
				case true:
					transform.localScale = Vector3.MoveTowards(transform.localScale, pulsingScale2, pulsingSpeed*Time.deltaTime);
					break;
				case false:
					transform.localScale = Vector3.MoveTowards(transform.localScale, pulsingScale, pulsingSpeed*Time.deltaTime);
					break;
			}
			Moving();
		}
	}
}