using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueenSetDirNode2 : Node
{
    private GameObject queen;
    private GameObject player;
    private GameObject queenPivot;
    private LayerMask playerMask;


    public QueenSetDirNode2(GameObject queen, GameObject player, GameObject queenPivot, LayerMask playerMask)
    {
        this.queen = queen;
        this.player = player;
        this.queenPivot = queenPivot;
        this.playerMask = playerMask;
    }

    public override NodeState Evaluate()
    {
        if ( Mathf.Abs(player.transform.position.x - queen.transform.position.x) > Mathf.Abs(player.transform.position.y - queen.transform.position.y))
        {
            queenPivot.transform.position = new Vector2(player.transform.position.x, queen.transform.position.y);
            return NodeState.SUCCESS;
        }

        if (Mathf.Abs(player.transform.position.x - queen.transform.position.x) < Mathf.Abs(player.transform.position.y - queen.transform.position.y))
        {
            queenPivot.transform.position = new Vector2(queen.transform.position.x, player.transform.position.y);
            return NodeState.SUCCESS;
        }



        else
        {
            Debug.Log("setdir fal");
            return NodeState.FAILURE;
        }

    }

    
}
