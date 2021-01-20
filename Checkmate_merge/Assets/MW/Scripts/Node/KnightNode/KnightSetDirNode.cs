using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightSetDirNode : Node
{
    private GameObject knight;
    private GameObject player;
    private GameObject knightPivot;
    private GameObject knightPivot2;



    public KnightSetDirNode(GameObject knight, GameObject player, GameObject knightPivot, GameObject knightPivot2)
    {
        this.knight = knight;
        this.player = player;
        this.knightPivot = knightPivot;
        this.knightPivot2 = knightPivot2;

    }

    public override NodeState Evaluate()
    {
    
        if ((Mathf.Abs(player.transform.position.y - knight.transform.position.y) / Mathf.Abs(player.transform.position.x - knight.transform.position.x) ) <
            2.2f && (Mathf.Abs(player.transform.position.y - knight.transform.position.y) / Mathf.Abs(player.transform.position.x - knight.transform.position.x)) > 1.9 && Vector3.Distance(player.transform.position, knight.transform.position) <2.7f && Vector3.Distance(player.transform.position, knight.transform.position) > 2.2f)
        {
            if((player.transform.position.y -knight.transform.position.y) < 0)
            {

                knightPivot.transform.position = player.transform.position;


                if (knightPivot.transform.position.x < -4 || knightPivot.transform.position.x > 5.5 || knightPivot.transform.position.y > 4.5 || knightPivot.transform.position.y < -4)
                {

                    return NodeState.FAILURE;
                }
                return NodeState.SUCCESS;
            }

            if ((player.transform.position.y - knight.transform.position.y) > 0)
            {

                knightPivot.transform.position = player.transform.position;
                if (knightPivot.transform.position.x < -4 || knightPivot.transform.position.x > 5.5 || knightPivot.transform.position.y > 4.5 || knightPivot.transform.position.y < -4)
                {

                    return NodeState.FAILURE;
                }
                return NodeState.SUCCESS;
            }

        }
        else if ((Mathf.Abs(player.transform.position.y - knight.transform.position.y) / Mathf.Abs(player.transform.position.x - knight.transform.position.x)) <
    0.7f && (Mathf.Abs(player.transform.position.y - knight.transform.position.y) / Mathf.Abs(player.transform.position.x - knight.transform.position.x)) > 0.4f && Vector3.Distance(player.transform.position, knight.transform.position) < 2.7f && Vector3.Distance(player.transform.position, knight.transform.position) > 2.2f)
        {
            if ((player.transform.position.x - knight.transform.position.x) < 0)
            {


                knightPivot.transform.position = player.transform.position;
                if (knightPivot.transform.position.x < -4 || knightPivot.transform.position.x > 5.5 || knightPivot.transform.position.y > 4.5 || knightPivot.transform.position.y < -4)
                {

                    return NodeState.FAILURE;
                }
                return NodeState.SUCCESS;
            }

            if ((player.transform.position.x - knight.transform.position.x) > 0)
            {


                knightPivot.transform.position = player.transform.position;
                if (knightPivot.transform.position.x < -4 || knightPivot.transform.position.x > 5.5 || knightPivot.transform.position.y > 4.5 || knightPivot.transform.position.y < -4)
                {

                    return NodeState.FAILURE;
                }
                return NodeState.SUCCESS;
            }
        }



    

            return NodeState.FAILURE;
   
    }

    
}
