using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingFindMoveNode : Node
{
    private GameObject pon;
    private GameObject player;
    private GameObject findPivot1;
    private KingTreeAi ai;




    public KingFindMoveNode(GameObject pon, GameObject player, GameObject findPivot1, KingTreeAi ai)
    {
        this.pon = pon;
        this.player = player;
        this.findPivot1 = findPivot1;
        this.ai = ai;
    }




    public override NodeState Evaluate()
    {
        if (Mathf.Abs(player.transform.position.x - findPivot1.transform.position.x) < 0.1f && Mathf.Abs(player.transform.position.y - findPivot1.transform.position.y) < 0.1f)
        {
            ai.StartLerpCoroutine2(this);


            return NodeState.SUCCESS;
        }
        else
            return NodeState.FAILURE;
    }


}
