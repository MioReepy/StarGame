using UnityEngine;
using WeaponSpace;

namespace PlayerSpace
{
    public class PlayerController : MonoBehaviour
    {
        internal float moveHorizontal;
        internal float moveVertical;
        
        private void FixedUpdate()
        {
            moveHorizontal = Input.GetAxis("Horizontal");
            moveVertical = Input.GetAxis("Vertical");
        }
        
        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Bolt._isPoof = true;
            }
        }
    }
}
