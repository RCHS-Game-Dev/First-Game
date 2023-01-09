using System;
using System.Collections.Generic;

public class PlayerState
{
    //the actions the player has collected, swapable at any time.
    private List<IPlayerAction> actions = new List<IPlayerAction>();
    private int currentActionIndex = 0;
    public void AddAction(IPlayerAction action)
    {
        this.actions.Add(action);
    }
    internal IPlayerAction GetAction()
    {
       return actions[currentActionIndex];
    }
    internal IPlayerAction GetAction(int index)
    {
        currentActionIndex  = index;
       return actions[index];
    }
    public int ChangeAction()//basic behaviour
    {
        return ++currentActionIndex;
    }

    internal void UpdateWithNewModifier(IModifier mod)
    {
        //! add in code to add action, change jump, whatevers
      
    }
}