using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.Rendering;
using UnityEngine.UIElements;
namespace AG2298
{

	public class MovingTarget : MonoBehaviour
	{
		public float speed;
		public Vector3 move = new Vector3(0, 0, 0);
		public Vector3 move2 = new Vector3(0, 0, 0);
		private bool position;
		
		public void Moving()
		{
			if (transform.position == move)
			{
				position = true;
			}
			if (transform.position == move2)
			{
				position = false;
			}
			switch (position)
			{
				case true:
					transform.position = Vector3.MoveTowards(transform.position, move2, speed * Time.deltaTime);
					break;
				case false:
					transform.position = Vector3.MoveTowards(transform.position, move, speed * Time.deltaTime);
					break;
			}
		}

		void Update()
		{
			Moving();
		}
	}
}
	
