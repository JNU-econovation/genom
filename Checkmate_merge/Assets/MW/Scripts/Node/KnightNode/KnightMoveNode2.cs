    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightMoveNode2 : Node
{
    private GameObject knight;
    private GameObject knightPivot2;
    private KnightTreeAi ai;
    public KnightMoveNode2(GameObject knight, GameObject knightPivot2, float duration, KnightTreeAi ai)
    {
        this.knight = knight;
        this.knightPivot2 = knightPivot2;
        this.ai = ai;


    }

    public override NodeState Evaluate()
    {


        ai.StartLerpCoroutine2(this);


        return NodeState.SUCCESS;
    }

}