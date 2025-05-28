using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/*
    Base abstract class for all states
    Define here what object always must do or react:
*/ 

public abstract class BaseState
{
    // Variables used in all states
    protected float t;

    // Function activated when entering new state
    public virtual void EnterState(StateManager state) { }

    // Function activated every frame
    public virtual void UpdateState(StateManager state) { }

    // Other reacting function
    public virtual void OnCollisionEnter2D(StateManager state, Collision2D coll) { }
}
