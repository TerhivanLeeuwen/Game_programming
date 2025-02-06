using UnityEngine;
namespace Ag2298
{
    public class Objectpawner1 : MonoBehaviour
    {
        public class MyObject
        {
            public string name;
            public int value;

            public MyObject(string name, int value)
            {
                this.name = name;
                this.value = value;

            }
        }
        void Start()
        {
            MyObject obj1 = new MyObject("duck", 10);
            Debug.Log("objectSpawner created: "+obj1.name + " with value "+obj1.value);
        }
    }
}
