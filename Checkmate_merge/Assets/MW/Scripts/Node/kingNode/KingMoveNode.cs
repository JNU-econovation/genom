﻿    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingMoveNode : Node
{
    private GameObject pon;
    private GameObject ponPivot;
    private KingTreeAi ai;
    public KingMoveNode(GameObject pon, GameObject ponPivot, float duration, KingTreeAi ai)
    {
        this.pon = pon;
        this.ponPivot = ponPivot;
        this.ai = ai;


    }

    public override NodeState Evaluate()
    {
        

        ai.StartLerpCoroutine(this);
   
        
        return NodeState.SUCCESS;
    }

    public void SetPos(Vector3 pos)
    {
        pon.transform.position = pos;
    }

    public Vector3 GetPos() => pon.transform.position;

    public Vector3 GetEndPos() => ponPivot.transform.position;
}
