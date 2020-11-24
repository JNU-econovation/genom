using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightSetDirNode4 : Node
{
    private GameObject knight;
    private GameObject player;
    private GameObject knightPivot;
    private GameObject knightPivot2;


    public KnightSetDirNode4(GameObject knight, GameObject player, GameObject knightPivot, GameObject knightPivot2)
    {
        this.knight = knight;
        this.player = player;
        this.knightPivot = knightPivot;
        this.knightPivot2 = knightPivot2;

    }

    public override NodeState Evaluate()
    {
        if(knightPivot.transform.position.x < -4 && knightPivot.transform.position.y > 0)
        {
            knightPivot.transform.position = new Vector2(knight.transform.position.x + 1.1f  , knight.transform.position.y - 2.2f);
            return NodeState.SUCCESS;
        }

        if (knightPivot.transform.position.x > -4 && knightPivot.transform.position.y > 0)
        {
            knightPivot.transform.position = new Vector2(knight.transform.position.x + 1.1f, knight.transform.position.y - 2.2f);
            return NodeState.SUCCESS;
        }





        if (knightPivot.transform.position.x < -4 && knightPivot.transform.position.y <= 0)
        {
            knightPivot.transform.position = new Vector2(knight.transform.position.x + 1.1f, knight.transform.position.y + 2.2f);
            return NodeState.SUCCESS;
        }
        if (knightPivot.transform.position.x > -4 && knightPivot.transform.position.y <= 0)
        {
            knightPivot.transform.position = new Vector2(knight.transform.position.x + 1.1f, knight.transform.position.y + 2.2f);
            return NodeState.SUCCESS;
        }





        if (knightPivot.transform.position.x > 5.5 && knightPivot.transform.position.y > 0)
        {
            knightPivot.transform.position = new Vector2(knight.transform.position.x - 1.1f, knight.transform.position.y - 2.2f);
            return NodeState.SUCCESS;
        }

        if (knightPivot.transform.position.x < 5.5 && knightPivot.transform.position.y > 0)
        {
            knightPivot.transform.position = new Vector2(knight.transform.position.x - 1.1f, knight.transform.position.y - 2.2f);
            return NodeState.SUCCESS;
        }




        if (knightPivot.transform.position.x > 5.5 && knightPivot.transform.position.y <= 0)
        {
            knightPivot.transform.position = new Vector2(knight.transform.position.x + -.1f, knight.transform.position.y + 2.2f);
            return NodeState.SUCCESS;
        }
        if (knightPivot.transform.position.x < 5.5 && knightPivot.transform.position.y <= 0)
        {
            knightPivot.transform.position = new Vector2(knight.transform.position.x + -.1f, knight.transform.position.y + 2.2f);
            return NodeState.SUCCESS;
        }


        if (knightPivot.transform.position.y >4.5 && knightPivot.transform.position.x > 1)
        {
            knightPivot.transform.position = new Vector2(knight.transform.position.x - 2.2f, knight.transform.position.y - 1.1f);
            return NodeState.SUCCESS;
        }
        if (knightPivot.transform.position.y < 4.5 && knightPivot.transform.position.x > 1)
        {
            knightPivot.transform.position = new Vector2(knight.transform.position.x - 2.2f, knight.transform.position.y - 1.1f);
            return NodeState.SUCCESS;
        }



        if (knightPivot.transform.position.y >4.5 && knightPivot.transform.position.x <= 1)
        {
            knightPivot.transform.position = new Vector2(knight.transform.position.x + 2.2f, knight.transform.position.y - 1.1f);
            return NodeState.SUCCESS;
        }
        if (knightPivot.transform.position.y < 4.5 && knightPivot.transform.position.x <= 1)
        {
            knightPivot.transform.position = new Vector2(knight.transform.position.x + 2.2f, knight.transform.position.y - 1.1f);
            return NodeState.SUCCESS;
        }


        if (knightPivot.transform.position.y < -5 && knightPivot.transform.position.x > 1)
        {
            knightPivot.transform.position = new Vector2(knight.transform.position.x - 2.2f, knight.transform.position.y + 1.1f);
            return NodeState.SUCCESS;
        }

        if (knightPivot.transform.position.y > -5 && knightPivot.transform.position.x > 1)
        {
            knightPivot.transform.position = new Vector2(knight.transform.position.x - 2.2f, knight.transform.position.y + 1.1f);
            return NodeState.SUCCESS;
        }


        if (knightPivot.transform.position.y < -5 && knightPivot.transform.position.x <= 1)
        {
            knightPivot.transform.position = new Vector2(knight.transform.position.x + 2.2f, knight.transform.position.y + 1.1f);
            return NodeState.SUCCESS;
        }
        if (knightPivot.transform.position.y > -5 && knightPivot.transform.position.x <= 1)
        {
            knightPivot.transform.position = new Vector2(knight.transform.position.x + 2.2f, knight.transform.position.y + 1.1f);
            return NodeState.SUCCESS;
        }


        Debug.Log("setdir fal123");
            return NodeState.FAILURE;
   
    }

    
}
