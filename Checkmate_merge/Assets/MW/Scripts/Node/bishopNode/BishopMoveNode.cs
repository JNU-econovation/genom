    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BishopMoveNode : Node
{
    private GameObject bishop;
    private GameObject bishopPivot;
    private BishopTreeAi ai;
    public BishopMoveNode(GameObject bishop, GameObject bishopPivot, float duration, BishopTreeAi ai)
    {
        this.bishop = bishop;
        this.bishopPivot = bishopPivot;
        this.ai = ai;


    }

    public override NodeState Evaluate()
    {
        

        ai.StartLerpCoroutine(this);
   
        
        return NodeState.SUCCESS;
    }


}
