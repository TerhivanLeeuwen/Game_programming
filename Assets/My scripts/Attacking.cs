using UnityEngine;
namespace AG2298
{

    public class Attacking : MonoBehaviour
    {
        Weapon sword = new Sword();
        Weapon bow = new Bow();
        void Start()
        {
            sword.Attack();
            bow.Attack();
        }

        
    }
}