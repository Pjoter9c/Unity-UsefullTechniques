using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;


/*
    One of some available states
*/


public class FirstState : BaseState
{
    // What to do when entering this stateœ
    public override void EnterState(StateManager state)
    {
        Debug.Log("FirstState");
        t = 0;
    }

    // What to do when in this state
    public override void UpdateState(StateManager state)
    {
        t += Time.deltaTime;

        
        // Condition to switching to new state
        if (t > 5f)
        {
            state.SwitchState(state.SecondState);
        }
    }

    public override void OnCollisionEnter2D(StateManager state, Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Player"))
        {
            state.SwitchState(state.ThirdState);
        }
    }
}
