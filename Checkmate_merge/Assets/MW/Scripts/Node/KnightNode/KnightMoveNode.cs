    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightMoveNode : Node
{
    private GameObject knight;
    private GameObject knightPivot;
    private KnightTreeAi ai;
    public KnightMoveNode(GameObject knight, GameObject knightPivot, float duration, KnightTreeAi ai)
    {
        this.knight = knight;
        this.knightPivot = knightPivot;
        this.ai = ai;


    }

    public override NodeState Evaluate()
    {


        ai.StartLerpCoroutine(this);


        return NodeState.SUCCESS;
    }

}