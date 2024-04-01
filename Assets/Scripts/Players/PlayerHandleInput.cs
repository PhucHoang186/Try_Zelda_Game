using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class PlayerHandleInput : MonoBehaviour
    {
        private Vector3 movementDir;
        public Vector3 MovementDir => movementDir;

        public void GetInput()
        {
            movementDir = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical")).normalized;
            if (movementDir != Vector3.zero)
            {
                return;
            }
        }
    }
}
