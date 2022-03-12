using Godot;
using System;

public class StateMachine : Node
{
    [Signal]
    delegate void Transitioned(string stateName);

    [Export]
    private NodePath initialState;

    public State state;
    
    public override void _Ready()
    {
        state = GetNode<State>(initialState);
        // Theres meant to be a yield statement here and I have no idea how to do this in C#
        foreach(State child in GetChildren()){
            child.stateMachine = this;
        }
        state.Enter();
    }    

    public override void _UnhandledInput(InputEvent @event)
    {
        state.handleInput(@event);
    }

    public override void _Process(float delta)
    {
        state.Update(delta);
    }

    public override void _PhysicsProcess(float delta)
    {
        state.physicsUpdate(delta);
    }

    public void TransitionTo(string targetStateName){
        if(!HasNode(targetStateName)){
            return ;
        }

        state.Exit();
        state.GetNode(targetStateName);
        EmitSignal("transitioned", state.Name);
    }


}
