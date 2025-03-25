using UnityEngine;
namespace AG2298
{
    public class MovingRotatingTarget : MovingTarget
    {
        public float rotationspeed;
        public Vector3 rotation = new Vector3 (0,0,0);

        


        
        void Update()
        {
            transform.Rotate(rotation, rotationspeed * Time.deltaTime);
        }
    }
}
