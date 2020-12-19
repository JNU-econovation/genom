    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockMoveNode : Node
{
    private GameObject rock;
    private GameObject rockPivot;
    private RockTreeAi ai;
    public RockMoveNode(GameObject rock, GameObject rockPivot, float duration, RockTreeAi ai)
    {
        this.rock = rock;
        this.rockPivot = rockPivot;
        this.ai = ai;


    }

    public override NodeState Evaluate()
    {
        

        ai.StartLerpCoroutine(this);
   
        
        return NodeState.SUCCESS;
    }


}
