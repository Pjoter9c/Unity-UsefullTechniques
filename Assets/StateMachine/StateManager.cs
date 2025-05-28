using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/*
    Sript attached to GameObject
*/


public class StateManager : MonoBehaviour
{


    // Variables for current state and for states that can be accessed
    public BaseState CurrentState;
    public FirstState FirstState = new FirstState();
    public SecondState SecondState = new SecondState();
    public ThirdState ThirdState = new ThirdState();
    public FourthState FourthState = new FourthState();
   
    
    
    // Set starting state
    void Start()
    {
        CurrentState = FirstState;
        CurrentState.EnterState(this);
    }

    // Do update operations only for actual state
    void Update()
    {
        CurrentState.UpdateState(this);
    }

    // Switching between two states
    public void SwitchState(BaseState state) // state to switch to
    {
        CurrentState = state; // new state
        state.EnterState(this); // do enters functions
    }
}
