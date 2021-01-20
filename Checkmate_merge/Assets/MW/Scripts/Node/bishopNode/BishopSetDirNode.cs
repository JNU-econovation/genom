using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BishopSetDirNode : Node
{
    private GameObject bishop;
    private GameObject player;
    private GameObject bishopPivot;




    public BishopSetDirNode(GameObject bishop, GameObject player, GameObject bishopPivot)
    {
        this.bishop = bishop;
        this.player = player;
        this.bishopPivot = bishopPivot;

    }

    public override NodeState Evaluate()
    {

        if (Mathf.Abs(bishopPivot.transform.localPosition.x) > 1)
        {
            return NodeState.SUCCESS;
        }
        if (Mathf.Abs(bishopPivot.transform.localPosition.y) > 1)
        {
            return NodeState.SUCCESS;
        }
        if ((player.transform.position.x - bishop.transform.position.x) > 0)
        {
            if ((player.transform.position.y - bishop.transform.position.y) > 0)
            {
                bishopPivot.transform.localPosition = new Vector3(1.1f, 1.1f, 0);


                return NodeState.SUCCESS;

            }
            if ((player.transform.position.y - bishop.transform.position.y) <= 0)
            {
                bishopPivot.transform.localPosition = new Vector3(1.1f, -1.1f, 0);


                return NodeState.SUCCESS;

            }
        }
        else if ((player.transform.position.x - bishop.transform.position.x) < 0)
        {
            if ((player.transform.position.y - bishop.transform.position.y) > 0)
            {
                bishopPivot.transform.localPosition = new Vector3(-1.1f, 1.1f, 0);

                //Debug.Log("좌표를 설정합니다");
                return NodeState.SUCCESS;

            }
            if ((player.transform.position.y - bishop.transform.position.y) <= 0)
            {
                bishopPivot.transform.localPosition = new Vector3(-1.1f, -1.1f, 0);

                //Debug.Log("좌표를 설정합니다");
                return NodeState.SUCCESS;

            }
        }

        else
        {
            Debug.Log("setdir fal");
            return NodeState.FAILURE;
        }
        Debug.Log("setdir fal");
        return NodeState.FAILURE;
    }

    
}
