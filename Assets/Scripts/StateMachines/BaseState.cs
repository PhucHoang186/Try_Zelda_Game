using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StateMachine
{
    public abstract class BaseState
    {
        public abstract void EnterState(StateMachine stateMachine);
        public abstract void UpdateState(StateMachine stateMachine);
        public abstract void ExitState(StateMachine stateMachine);
        public abstract void CheckSwitchState(StateMachine stateMachine);
    }
}
