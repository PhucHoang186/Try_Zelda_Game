using UnityEngine;

namespace StateMachine
{
    public class StateMachine : MonoBehaviour
    {
        protected BaseState currentState;

        public void OnChangeState(BaseState newState)
        {
            if(currentState == newState)
                return;

            if(currentState != null)
                currentState.ExitState(this);
            
            currentState = newState;
            currentState.EnterState(this);
        }

        public virtual void Update()
        {
            currentState?.UpdateState(this);
            currentState?.CheckSwitchState(this);
        }
    }
}
