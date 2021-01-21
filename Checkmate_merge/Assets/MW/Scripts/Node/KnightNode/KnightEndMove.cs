    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightEndMove : Node
{
    private GameObject knight;
    private GameObject knightPivot;
    private KnightTreeAi ai;
    public KnightEndMove(GameObject knight, GameObject knightPivot, float duration, KnightTreeAi ai)
    {
        this.knight = knight;
        this.knightPivot = knightPivot;
        this.ai = ai;


    }

    public override NodeState Evaluate()
    {
        knightPivot.transform.localPosition = Vector3.zero;




        return NodeState.SUCCESS;
    }

}