using UnityEngine;
namespace AG2298
{
    public class MovingPulsingTarget : MovingTarget
    {
        public float pulsingSpeed;
        public Vector3 pulsingScale = new Vector3(1,1,1);
        public Vector3 pulsingScale2 = new Vector3(0,0,0);
        private bool size;

        void Update()
        {
            transform.localScale = Vector3.Scale(pulsingScale, pulsingScale2);
        }
    }
}