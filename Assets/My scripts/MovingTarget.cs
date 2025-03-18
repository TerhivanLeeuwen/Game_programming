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

		void Update()
		{

			while (true)
			{
				transform.position = Vector3.MoveTowards(transform.position, move, speed * Time.deltaTime);
				transform.position = Vector3.MoveTowards(transform.position, move2, speed * Time.deltaTime);
			}

		}
	}
}
