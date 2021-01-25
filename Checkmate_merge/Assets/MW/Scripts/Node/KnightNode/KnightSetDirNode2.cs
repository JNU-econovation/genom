using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightSetDirNode2 : Node
{
    private GameObject knight;
    private GameObject player;
    private GameObject knightPivot1;
    private GameObject knightPivot2;



    public KnightSetDirNode2(GameObject knight, GameObject player, GameObject knightPivot1, GameObject knightPivot2)
    {
        this.knight = knight;
        this.player = player;
        this.knightPivot1 = knightPivot1;
        this.knightPivot2 = knightPivot2;

    }

    public override NodeState Evaluate()
    {

        // 01에 위치했을시 추적
        if ((player.transform.position.x - knight.transform.position.x ) > -3.4f && (player.transform.position.x - knight.transform.position.x) < -3.2f 
            && (player.transform.position.y - knight.transform.position.y) > 0.9f &&(player.transform.position.y - knight.transform.position.y) < 1.2f)
        {

            knightPivot1.transform.position = new Vector2(knight.transform.position.x - 1.1f, knight.transform.position.y + 2.2f);

            if(knightPivot1.transform.position.x <-4 || knightPivot1.transform.position.x > 5.5 || knightPivot1.transform.position.y > 4.5 || knightPivot1.transform.position.y < -4)
            {
                return NodeState.FAILURE;
            }
            else 
                return NodeState.SUCCESS;

        }

        if ((player.transform.position.x - knight.transform.position.x) > -3.4f && (player.transform.position.x - knight.transform.position.x) < -3.2f
    && (player.transform.position.y - knight.transform.position.y) > 3.2f && (player.transform.position.y - knight.transform.position.y) < 3.4f)
        {
            knightPivot1.transform.position = new Vector2(knight.transform.position.x - 1.1f, knight.transform.position.y + 2.2f);

            if (knightPivot1.transform.position.x < -4 || knightPivot1.transform.position.x > 5.5 || knightPivot1.transform.position.y > 4.5 || knightPivot1.transform.position.y < -4)
            {
                return NodeState.FAILURE;
            }
            else
                return NodeState.SUCCESS;

        }

        if ((player.transform.position.x - knight.transform.position.x) > -2.3f && (player.transform.position.x - knight.transform.position.x) < -2.1f
&& (player.transform.position.y - knight.transform.position.y) > 4.3f && (player.transform.position.y - knight.transform.position.y) < 4.5f)
        {
            knightPivot1.transform.position = new Vector2(knight.transform.position.x - 1.1f, knight.transform.position.y + 2.2f);

            if (knightPivot1.transform.position.x < -4 || knightPivot1.transform.position.x > 5.5 || knightPivot1.transform.position.y > 4.5 || knightPivot1.transform.position.y < -4)
            {
                return NodeState.FAILURE;
            }
            else
                return NodeState.SUCCESS;

        }
        if ((player.transform.position.x - knight.transform.position.x) > -0.1f && (player.transform.position.x - knight.transform.position.x) < 0.1
&& (player.transform.position.y - knight.transform.position.y) > 4.3f && (player.transform.position.y - knight.transform.position.y) < 4.5f)
        {
            knightPivot1.transform.position = new Vector2(knight.transform.position.x - 1.1f, knight.transform.position.y + 2.2f);

            if (knightPivot1.transform.position.x < -4 || knightPivot1.transform.position.x > 5.5 || knightPivot1.transform.position.y > 4.5 || knightPivot1.transform.position.y < -4)
            {
                return NodeState.FAILURE;
            }
            else
                return NodeState.SUCCESS;

        }

        if ((player.transform.position.x - knight.transform.position.x) > 0.9f && (player.transform.position.x - knight.transform.position.x) < 1.1f
    && (player.transform.position.y - knight.transform.position.y) > 3.2f && (player.transform.position.y - knight.transform.position.y) < 3.4f)
        {
            knightPivot1.transform.position = new Vector2(knight.transform.position.x - 1.1f, knight.transform.position.y + 2.2f);

            if (knightPivot1.transform.position.x < -4 || knightPivot1.transform.position.x > 5.5 || knightPivot1.transform.position.y > 4.5 || knightPivot1.transform.position.y < -4)
            {
                return NodeState.FAILURE;
            }
            else
                return NodeState.SUCCESS;

        }
        if ((player.transform.position.x - knight.transform.position.x) > 0.9f && (player.transform.position.x - knight.transform.position.x) < 1.1f
            && (player.transform.position.y - knight.transform.position.y) > 0.9f && (player.transform.position.y - knight.transform.position.y) < 1.2f)
        {
            knightPivot1.transform.position = new Vector2(knight.transform.position.x - 1.1f, knight.transform.position.y + 2.2f);

            if (knightPivot1.transform.position.x < -4 || knightPivot1.transform.position.x > 5.5 || knightPivot1.transform.position.y > 4.5 || knightPivot1.transform.position.y < -4)
            {
                return NodeState.FAILURE;
            }
            else
                return NodeState.SUCCESS;

        }



        //02 위치시 추적



        if ((player.transform.position.x - knight.transform.position.x) > -0.1f && (player.transform.position.x - knight.transform.position.x) < 0.1
     && (player.transform.position.y - knight.transform.position.y) > 1.9f && (player.transform.position.y - knight.transform.position.y) < 2.3f)
        {
            knightPivot1.transform.position = new Vector2(knight.transform.position.x - 2.2f, knight.transform.position.y + 1.1f);
            if (knightPivot1.transform.position.x < -4 || knightPivot1.transform.position.x > 5.5 || knightPivot1.transform.position.y > 4.5 || knightPivot1.transform.position.y < -4)
            {
                return NodeState.FAILURE;
            }
            else
                return NodeState.SUCCESS;

        }

        if ((player.transform.position.x - knight.transform.position.x) > -1.2f && (player.transform.position.x - knight.transform.position.x) < -0.9f
    && (player.transform.position.y - knight.transform.position.y) > 3.2f && (player.transform.position.y - knight.transform.position.y) < 3.4f)
        {
            knightPivot1.transform.position = new Vector2(knight.transform.position.x - 2.2f, knight.transform.position.y + 1.1f);
            if (knightPivot1.transform.position.x < -4 || knightPivot1.transform.position.x > 5.5 || knightPivot1.transform.position.y > 4.5 || knightPivot1.transform.position.y < -4)
            {
                return NodeState.FAILURE;
            }
            else
                return NodeState.SUCCESS;

        }


        if ((player.transform.position.x - knight.transform.position.x) > -4.5f && (player.transform.position.x - knight.transform.position.x) < -4.2f
     && (player.transform.position.y - knight.transform.position.y) > 1.9f && (player.transform.position.y - knight.transform.position.y) < 2.3f)
        {
            knightPivot1.transform.position = new Vector2(knight.transform.position.x - 2.2f, knight.transform.position.y + 1.1f);
            if (knightPivot1.transform.position.x < -4 || knightPivot1.transform.position.x > 5.5 || knightPivot1.transform.position.y > 4.5 || knightPivot1.transform.position.y < -4)
            {
                return NodeState.FAILURE;
            }
            else
                return NodeState.SUCCESS;

        }
        if ((player.transform.position.x - knight.transform.position.x) > -4.5f && (player.transform.position.x - knight.transform.position.x) < -4.2f
&& (player.transform.position.y - knight.transform.position.y) > -0.1f && (player.transform.position.y - knight.transform.position.y) < 0.1f)
        {
            knightPivot1.transform.position = new Vector2(knight.transform.position.x - 2.2f, knight.transform.position.y + 1.1f);
            if (knightPivot1.transform.position.x < -4 || knightPivot1.transform.position.x > 5.5 || knightPivot1.transform.position.y > 4.5 || knightPivot1.transform.position.y < -4)
            {
                return NodeState.FAILURE;
            }
            else
                return NodeState.SUCCESS;

        }

        if ((player.transform.position.x - knight.transform.position.x) > -3.4f && (player.transform.position.x - knight.transform.position.x) < -3.2f
&& (player.transform.position.y - knight.transform.position.y) > -1.3f && (player.transform.position.y - knight.transform.position.y) < -0.8f)
        {
            knightPivot1.transform.position = new Vector2(knight.transform.position.x - 2.2f, knight.transform.position.y + 1.1f);
            if (knightPivot1.transform.position.x < -4 || knightPivot1.transform.position.x > 5.5 || knightPivot1.transform.position.y > 4.5 || knightPivot1.transform.position.y < -4)
            {
                return NodeState.FAILURE;
            }
            else
                return NodeState.SUCCESS;

        }

        if ((player.transform.position.x - knight.transform.position.x) > -1.3f && (player.transform.position.x - knight.transform.position.x) < -0.8f
&& (player.transform.position.y - knight.transform.position.y) > -1.3f && (player.transform.position.y - knight.transform.position.y) < -0.8f)
        {
            knightPivot1.transform.position = new Vector2(knight.transform.position.x - 2.2f, knight.transform.position.y + 1.1f);
            if (knightPivot1.transform.position.x < -4 || knightPivot1.transform.position.x > 5.5 || knightPivot1.transform.position.y > 4.5 || knightPivot1.transform.position.y < -4)
            {
                return NodeState.FAILURE;
            }
            else
                return NodeState.SUCCESS;

        }


        //03 추적

        if ((player.transform.position.x - knight.transform.position.x) > -4.5f && (player.transform.position.x - knight.transform.position.x) < -4.2f
&& (player.transform.position.y - knight.transform.position.y) > -2.4f && (player.transform.position.y - knight.transform.position.y) < -2.0f)
        {
            knightPivot1.transform.position = new Vector2(knight.transform.position.x - 2.2f, knight.transform.position.y - 1.1f);
            if (knightPivot1.transform.position.x < -4 || knightPivot1.transform.position.x > 5.5 || knightPivot1.transform.position.y > 4.5 || knightPivot1.transform.position.y < -4)
            {
                return NodeState.FAILURE;
            }
            else
                return NodeState.SUCCESS;

        }


        if ((player.transform.position.x - knight.transform.position.x) > -3.4f && (player.transform.position.x - knight.transform.position.x) < -3.1f
&& (player.transform.position.y - knight.transform.position.y) > -3.4f && (player.transform.position.y - knight.transform.position.y) < -3.1f)
        {
            knightPivot1.transform.position = new Vector2(knight.transform.position.x - 2.2f, knight.transform.position.y - 1.1f);
            if (knightPivot1.transform.position.x < -4 || knightPivot1.transform.position.x > 5.5 || knightPivot1.transform.position.y > 4.5 || knightPivot1.transform.position.y < -4)
            {
                return NodeState.FAILURE;
            }
            else
                return NodeState.SUCCESS;

        }

        if ((player.transform.position.x - knight.transform.position.x) > -1.2f && (player.transform.position.x - knight.transform.position.x) < -1.0f
&& (player.transform.position.y - knight.transform.position.y) > -3.4f && (player.transform.position.y - knight.transform.position.y) < -3.1f)
        {
            knightPivot1.transform.position = new Vector2(knight.transform.position.x - 2.2f, knight.transform.position.y - 1.1f);
            if (knightPivot1.transform.position.x < -4 || knightPivot1.transform.position.x > 5.5 || knightPivot1.transform.position.y > 4.5 || knightPivot1.transform.position.y < -4)
            {
                return NodeState.FAILURE;
            }
            else
                return NodeState.SUCCESS;

        }

        if ((player.transform.position.x - knight.transform.position.x) > -0.1f && (player.transform.position.x - knight.transform.position.x) < 0.1f
&& (player.transform.position.y - knight.transform.position.y) > -2.3f && (player.transform.position.y - knight.transform.position.y) < -2.1f)
        {
            knightPivot1.transform.position = new Vector2(knight.transform.position.x - 2.2f, knight.transform.position.y - 1.1f);
            if (knightPivot1.transform.position.x < -4 || knightPivot1.transform.position.x > 5.5 || knightPivot1.transform.position.y > 4.5 || knightPivot1.transform.position.y < -4)
            {
                return NodeState.FAILURE;
            }
            else
                return NodeState.SUCCESS;

        }



        // 04 추적


        if ((player.transform.position.x - knight.transform.position.x) > -2.3f && (player.transform.position.x - knight.transform.position.x) < -2.0f
&& (player.transform.position.y - knight.transform.position.y) > -4.5f && (player.transform.position.y - knight.transform.position.y) < -4.3f)
        {
            knightPivot1.transform.position = new Vector2(knight.transform.position.x - 1.1f, knight.transform.position.y - 2.2f);
            if (knightPivot1.transform.position.x < -4 || knightPivot1.transform.position.x > 5.5 || knightPivot1.transform.position.y > 4.5 || knightPivot1.transform.position.y < -4)
            {
                return NodeState.FAILURE;
            }
            else
                return NodeState.SUCCESS;

        }



        if ((player.transform.position.x - knight.transform.position.x) > -0.1f && (player.transform.position.x - knight.transform.position.x) < 0.1f
&& (player.transform.position.y - knight.transform.position.y) > -4.5f && (player.transform.position.y - knight.transform.position.y) < -4.3f)
        {
            knightPivot1.transform.position = new Vector2(knight.transform.position.x - 1.1f, knight.transform.position.y - 2.2f);
            if (knightPivot1.transform.position.x < -4 || knightPivot1.transform.position.x > 5.5 || knightPivot1.transform.position.y > 4.5 || knightPivot1.transform.position.y < -4)
            {
                return NodeState.FAILURE;
            }
            else
                return NodeState.SUCCESS;

        }


        if ((player.transform.position.x - knight.transform.position.x) > 1.0f && (player.transform.position.x - knight.transform.position.x) < 1.2f
&& (player.transform.position.y - knight.transform.position.y) > -3.4f && (player.transform.position.y - knight.transform.position.y) < -3.2f)
        {
            knightPivot1.transform.position = new Vector2(knight.transform.position.x - 1.1f, knight.transform.position.y - 2.2f);
            if (knightPivot1.transform.position.x < -4 || knightPivot1.transform.position.x > 5.5 || knightPivot1.transform.position.y > 4.5 || knightPivot1.transform.position.y < -4)
            {
                return NodeState.FAILURE;
            }
            else
                return NodeState.SUCCESS;

        }


        if ((player.transform.position.x - knight.transform.position.x) > 1.0f && (player.transform.position.x - knight.transform.position.x) < 1.2f
&& (player.transform.position.y - knight.transform.position.y) > -1.2f && (player.transform.position.y - knight.transform.position.y) < -1.0f)
        {
            knightPivot1.transform.position = new Vector2(knight.transform.position.x - 1.1f, knight.transform.position.y - 2.2f);
            if (knightPivot1.transform.position.x < -4 || knightPivot1.transform.position.x > 5.5 || knightPivot1.transform.position.y > 4.5 || knightPivot1.transform.position.y < -4)
            {
                return NodeState.FAILURE;
            }
            else
                return NodeState.SUCCESS;

        }
        //05 추적



        if ((player.transform.position.x - knight.transform.position.x) > 2.1f && (player.transform.position.x - knight.transform.position.x) < 2.3f
&& (player.transform.position.y - knight.transform.position.y) > -4.5f && (player.transform.position.y - knight.transform.position.y) < -4.3f)
        {
            knightPivot1.transform.position = new Vector2(knight.transform.position.x +1.1f, knight.transform.position.y - 2.2f);
            if (knightPivot1.transform.position.x < -4 || knightPivot1.transform.position.x > 5.5 || knightPivot1.transform.position.y > 4.5 || knightPivot1.transform.position.y < -4)
            {
                return NodeState.FAILURE;
            }
            else
                return NodeState.SUCCESS;

        }


        if ((player.transform.position.x - knight.transform.position.x) > 3.2f && (player.transform.position.x - knight.transform.position.x) < 3.4f
&& (player.transform.position.y - knight.transform.position.y) > -3.4f && (player.transform.position.y - knight.transform.position.y) < -3.2f)
        {
            knightPivot1.transform.position = new Vector2(knight.transform.position.x + 1.1f, knight.transform.position.y - 2.2f);
            if (knightPivot1.transform.position.x < -4 || knightPivot1.transform.position.x > 5.5 || knightPivot1.transform.position.y > 4.5 || knightPivot1.transform.position.y < -4)
            {
                return NodeState.FAILURE;
            }
            else
                return NodeState.SUCCESS;

        }

        if ((player.transform.position.x - knight.transform.position.x) > 2.1f && (player.transform.position.x - knight.transform.position.x) < 2.3f
&& (player.transform.position.y - knight.transform.position.y) > -0.1f && (player.transform.position.y - knight.transform.position.y) < 0.1f)
        {
            knightPivot1.transform.position = new Vector2(knight.transform.position.x + 1.1f, knight.transform.position.y - 2.2f);
            if (knightPivot1.transform.position.x < -4 || knightPivot1.transform.position.x > 5.5 || knightPivot1.transform.position.y > 4.5 || knightPivot1.transform.position.y < -4)
            {
                return NodeState.FAILURE;
            }
            else
                return NodeState.SUCCESS;

        }
        if ((player.transform.position.x - knight.transform.position.x) > 3.2f && (player.transform.position.x - knight.transform.position.x) < 3.4f
&& (player.transform.position.y - knight.transform.position.y) > -1.2f && (player.transform.position.y - knight.transform.position.y) < -1.0f)
        {
            knightPivot1.transform.position = new Vector2(knight.transform.position.x + 1.1f, knight.transform.position.y - 2.2f);
            if (knightPivot1.transform.position.x < -4 || knightPivot1.transform.position.x > 5.5 || knightPivot1.transform.position.y > 4.5 || knightPivot1.transform.position.y < -4)
            {
                return NodeState.FAILURE;
            }
            else
                return NodeState.SUCCESS;

        }

        //06 추적

        if ((player.transform.position.x - knight.transform.position.x) > 4.3f && (player.transform.position.x - knight.transform.position.x) < 4.5f
&& (player.transform.position.y - knight.transform.position.y) > -2.3f && (player.transform.position.y - knight.transform.position.y) < -2.1f)
        {
            knightPivot1.transform.position = new Vector2(knight.transform.position.x + 2.2f, knight.transform.position.y - 1.1f);
            if (knightPivot1.transform.position.x < -4 || knightPivot1.transform.position.x > 5.5 || knightPivot1.transform.position.y > 4.5 || knightPivot1.transform.position.y < -4)
            {
                return NodeState.FAILURE;
            }
            else
                return NodeState.SUCCESS;

        }
        if ((player.transform.position.x - knight.transform.position.x) > 4.3f && (player.transform.position.x - knight.transform.position.x) < 4.5f
&& (player.transform.position.y - knight.transform.position.y) > -0.1f && (player.transform.position.y - knight.transform.position.y) < 0.1f)
        {
            knightPivot1.transform.position = new Vector2(knight.transform.position.x + 2.2f, knight.transform.position.y - 1.1f);
            if (knightPivot1.transform.position.x < -4 || knightPivot1.transform.position.x > 5.5 || knightPivot1.transform.position.y > 4.5 || knightPivot1.transform.position.y < -4)
            {
                return NodeState.FAILURE;
            }
            else
                return NodeState.SUCCESS;

        }


        if ((player.transform.position.x - knight.transform.position.x) > 3.2f && (player.transform.position.x - knight.transform.position.x) < 3.4f
&& (player.transform.position.y - knight.transform.position.y) > 1.0f && (player.transform.position.y - knight.transform.position.y) < 1.2f)
        {
            knightPivot1.transform.position = new Vector2(knight.transform.position.x + 2.2f, knight.transform.position.y - 1.1f);
            if (knightPivot1.transform.position.x < -4 || knightPivot1.transform.position.x > 5.5 || knightPivot1.transform.position.y > 4.5 || knightPivot1.transform.position.y < -4)
            {
                return NodeState.FAILURE;
            }
            else
                return NodeState.SUCCESS;

        }


        //07 추적
        if ((player.transform.position.x - knight.transform.position.x) > 3.2f && (player.transform.position.x - knight.transform.position.x) < 3.4f
&& (player.transform.position.y - knight.transform.position.y) > 3.2f && (player.transform.position.y - knight.transform.position.y) < 3.4f)
        {
            knightPivot1.transform.position = new Vector2(knight.transform.position.x + 2.2f, knight.transform.position.y + 1.1f);
            if (knightPivot1.transform.position.x < -4 || knightPivot1.transform.position.x > 5.5 || knightPivot1.transform.position.y > 4.5 || knightPivot1.transform.position.y < -4)
            {
                return NodeState.FAILURE;
            }
            else
                return NodeState.SUCCESS;

        }
        if ((player.transform.position.x - knight.transform.position.x) > 4.3f && (player.transform.position.x - knight.transform.position.x) < 4.5f
&& (player.transform.position.y - knight.transform.position.y) > 2.1f && (player.transform.position.y - knight.transform.position.y) < 2.3f)
        {
            knightPivot1.transform.position = new Vector2(knight.transform.position.x + 2.2f, knight.transform.position.y + 1.1f);
            if (knightPivot1.transform.position.x < -4 || knightPivot1.transform.position.x > 5.5 || knightPivot1.transform.position.y > 4.5 || knightPivot1.transform.position.y < -4)
            {
                return NodeState.FAILURE;
            }
            else
                return NodeState.SUCCESS;

        }



        //8 추적
        if ((player.transform.position.x - knight.transform.position.x) > 2.1f && (player.transform.position.x - knight.transform.position.x) < 2.3f
&& (player.transform.position.y - knight.transform.position.y) > 4.3f && (player.transform.position.y - knight.transform.position.y) < 4.5f)
        {
            knightPivot1.transform.position = new Vector2(knight.transform.position.x + 1.1f, knight.transform.position.y + 2.2f);
            if (knightPivot1.transform.position.x < -4 || knightPivot1.transform.position.x > 5.5 || knightPivot1.transform.position.y > 4.5 || knightPivot1.transform.position.y < -4)
            {
                return NodeState.FAILURE;
            }
            else
                return NodeState.SUCCESS;

        }

        return NodeState.FAILURE;


    }

    
 













}

   
