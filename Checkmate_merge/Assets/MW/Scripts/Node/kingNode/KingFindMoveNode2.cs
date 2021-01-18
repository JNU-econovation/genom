﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingFindMoveNode2 : Node
{
    private GameObject pon;
    private GameObject player;
    private GameObject findPivot2;
    private KingTreeAi ai;




    public KingFindMoveNode2(GameObject pon, GameObject player, GameObject findPivot2, KingTreeAi ai)
    {
        this.pon = pon;
        this.player = player;
        this.findPivot2 = findPivot2;
        this.ai = ai;
    }




    public override NodeState Evaluate()
    {
        if (Mathf.Abs(player.transform.position.x - findPivot2.transform.position.x) < 0.1f && Mathf.Abs(player.transform.position.y - findPivot2.transform.position.y) < 0.1f)
        {
            ai.StartLerpCoroutine3(this);
            return NodeState.SUCCESS;
        }
        else
            return NodeState.FAILURE;
    }


}
