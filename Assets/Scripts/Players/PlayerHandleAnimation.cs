using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public enum PlayerAnimName
    {
        Idle,
        Walk,
    }

    public class PlayerHandleAnimation : MonoBehaviour
    {
        protected Animator anim;

        void Start()
        {
            anim = GetComponent<Animator>();
        }

        public void PlayAnim(PlayerAnimName animName, float transitionTime = 0.1f)
        {
            anim?.CrossFade(animName.ToString(), transitionTime);
        }
    }
}
