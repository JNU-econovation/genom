using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueenSetDirNode : Node
{
    private GameObject queen;
    private GameObject player;
    private GameObject queenPivot;
    private LayerMask playerMask;


    public QueenSetDirNode(GameObject queen, GameObject player, GameObject queenPivot, LayerMask playerMask)
    {
        this.queen = queen;
        this.player = player;
        this.queenPivot = queenPivot;
        this.playerMask = playerMask;
    }

    public override NodeState Evaluate()
    {
        if ( Mathf.Abs(player.transform.position.y - queen.transform.position.y) < 0.1f)
        {
            queenPivot.transform.position = player.transform.position;
            return NodeState.SUCCESS;
        }

        else if (Mathf.Abs(player.transform.position.x - queen.transform.position.x) < 0.1f)
        {
            queenPivot.transform.position = player.transform.position;
            return NodeState.SUCCESS;
        }

        else if ((Mathf.Abs(player.transform.position.x - queen.transform.position.x) / Mathf.Abs(player.transform.position.y - queen.transform.position.y) ) <
            1.1f && (Mathf.Abs(player.transform.position.x - queen.transform.position.x) / Mathf.Abs(player.transform.position.y - queen.transform.position.y)) > 0.9)
        {
            queenPivot.transform.position = player.transform.position;
            return NodeState.SUCCESS;
        }




        else
        {
            Debug.Log("setdir fal");
            return NodeState.FAILURE;
        }

    }

    
}
