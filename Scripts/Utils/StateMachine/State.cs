using Godot;
using System;

public class State : Node
{

    /*
    Using the GDQuest StateMachine class from their great tutorial,
    converting from GDScript to C# as a learning exercise.

    Virtual Base Class for all States
    */

    // Contains reference to StateMachine Class to call TransitionTo method
    // A bit of an unusual implementation
    public StateMachine stateMachine;
    
    // Virtual function receives events from _unhandled_input() callback
    public void handleInput(InputEvent _event){
        
    }
    
    // Virtual function corresponds with _process() callback
    public void Update(float _delta){

    }

    // Virtual function corresponds with _physics_process() callback
    public void physicsUpdate(float _delta){

    }

    // Virtual function called by the state when entering
    public void Enter(){

    }

    // Virtual function called by the state when exiting
    public void Exit(){

    }
}
