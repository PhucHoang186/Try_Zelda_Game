using System.Collections;
using System.Collections.Generic;
using Player;
using UnityEngine;

namespace StateMachine
{
    [RequireComponent(typeof(PlayerHandleAnimation))]
    public class PlayerStateMachine : StateMachine
    {
        public PlayerHandleAnimation Anim;
        public PlayerHandleInput Input;

        void Start()
        {
            OnChangeState(new PlayerIdleState());
        }

        public override void Update()
        {
            Input.GetInput();
            base.Update();
        }
    }
}
