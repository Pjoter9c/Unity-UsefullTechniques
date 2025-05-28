StateManager - Sript attached to GameObject:
	Variables for current state and for states that can be accessed,
	Start() - Set starting state
	Update() - Do update operations only for actual state
	SwitchState(BaseState newState) - switching between 2 states

BaseState - Base abstract class for all states, Define here what object always must do or react:
	Variables used in all states
	Function activated when entering new state (EnterState)
	Function activated every frame (UpdateState)
	Other reacting function (np. OnCollision)

NameStates - One of some available states:
	What to do when entering this state (EnterState)
	What to do when in this state (UpdateState)
		Condition to switching to new state
		SwitchState