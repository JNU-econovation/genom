    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueenMoveNode : Node
{
    private GameObject queen;
    private GameObject queenPivot;
    private QueenTreeAi ai;
    public QueenMoveNode(GameObject queen, GameObject queenPivot, float duration, QueenTreeAi ai)
    {
        this.queen = queen;
        this.queenPivot = queenPivot;
        this.ai = ai;


    }

    public override NodeState Evaluate()
    {


        ai.StartLerpCoroutine(this);


        return NodeState.SUCCESS;
    }

}