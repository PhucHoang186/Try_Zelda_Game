using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StateMachine
{
    public class PlayerWalkState : BaseState
    {
        protected PlayerStateMachine playerSM;

        public override void CheckSwitchState(StateMachine stateMachine)
        {
            Vector3 movementDir = playerSM.Input.MovementDir;
            if (movementDir == Vector3.zero)
                playerSM.OnChangeState(new PlayerIdleState());
        }

        public override void EnterState(StateMachine stateMachine)
        {
            playerSM = stateMachine as PlayerStateMachine;
            playerSM.Anim.PlayAnim(Player.PlayerAnimName.Walk);
        }

        public override void ExitState(StateMachine stateMachine)
        {
            playerSM.Anim.PlayAnim(Player.PlayerAnimName.Idle);
        }

        public override void UpdateState(StateMachine stateMachine)
        {
        }
    }
}
