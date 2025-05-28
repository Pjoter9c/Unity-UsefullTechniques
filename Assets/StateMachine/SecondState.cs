using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/*
    One of some available states
*/


public class SecondState : BaseState
{
    public override void EnterState(StateManager state)
    {
        Debug.Log("SecondState");
        t = 0;
    }

    // What to do when in this state
    public override void UpdateState(StateManager state)
    {
        t += Time.deltaTime;


        // Condition to switching to new state
        if (t > 5f)
        {
            state.SwitchState(state.ThirdState);
        }
    }

    public override void OnCollisionEnter2D(StateManager state, Collision2D coll)
    {
        base.OnCollisionEnter2D(state, coll);
    }
}
