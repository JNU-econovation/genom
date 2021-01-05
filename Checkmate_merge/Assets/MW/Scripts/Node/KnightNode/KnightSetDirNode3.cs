using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightSetDirNode3 : Node
{
    private GameObject knight;
    private GameObject player;
    private GameObject knightPivot;
    private GameObject knightPivot2;



    public KnightSetDirNode3(GameObject knight, GameObject player, GameObject knightPivot, GameObject knightPivot2)
    {
        this.knight = knight;
        this.player = player;
        this.knightPivot = knightPivot;
        this.knightPivot2 = knightPivot2;

    }

    public override NodeState Evaluate()
    {

        if ((Mathf.Abs(player.transform.position.y - knight.transform.position.y) < Mathf.Abs(player.transform.position.x - knight.transform.position.x)))
        {
            if ((player.transform.position.x - knight.transform.position.x) >= 0)
            {

                if ((player.transform.position.y - knight.transform.position.y) > 0)
                {

                    knightPivot.transform.position = new Vector3(knight.transform.position.x + 2.2f, knight.transform.position.y + 1.1f);
                    if (knightPivot.transform.position.x < -4 || knightPivot.transform.position.x > 5.5 || knightPivot.transform.position.y > 4.5 || knightPivot.transform.position.y < -4)
                    {
                        knightPivot.transform.position = new Vector3(knight.transform.position.x + 2.2f, knight.transform.position.y - 1.1f);
                        return NodeState.FAILURE;
                    }
                    return NodeState.SUCCESS;
                }


                if ((player.transform.position.y - knight.transform.position.y) <= 0)
                {

                    knightPivot.transform.position = new Vector3(knight.transform.position.x + 2.2f, knight.transform.position.y - 1.1f);
                    if (knightPivot.transform.position.x < -4 || knightPivot.transform.position.x > 5.5 || knightPivot.transform.position.y > 4.5 || knightPivot.transform.position.y < -4)
                    {
                        knightPivot.transform.position = new Vector3(knight.transform.position.x + 2.2f, knight.transform.position.y + 1.1f);
                        return NodeState.FAILURE;
                    }
                    return NodeState.SUCCESS;
                }




            }

            if ((player.transform.position.x - knight.transform.position.x) < 0)
            {
                if ((player.transform.position.y - knight.transform.position.y) > 0)
                {

                    knightPivot.transform.position = new Vector3(knight.transform.position.x - 2.2f, knight.transform.position.y + 1.1f);
                    if (knightPivot.transform.position.x < -4 || knightPivot.transform.position.x > 5.5 || knightPivot.transform.position.y > 4.5 || knightPivot.transform.position.y < -4)
                    {
                        knightPivot.transform.position = new Vector3(knight.transform.position.x - 2.2f, knight.transform.position.y - 1.1f);
                        return NodeState.FAILURE;
                    }
                    return NodeState.SUCCESS;
                }


                if ((player.transform.position.y - knight.transform.position.y) <= 0)
                {

                    knightPivot.transform.position = new Vector3(knight.transform.position.x - 2.2f, knight.transform.position.y - 1.1f);
                    if (knightPivot.transform.position.x < -4 || knightPivot.transform.position.x > 5.5 || knightPivot.transform.position.y > 4.5 || knightPivot.transform.position.y < -4)
                    {
                        knightPivot.transform.position = new Vector3(knight.transform.position.x - 2.2f, knight.transform.position.y + 1.1f);
                        return NodeState.FAILURE;
                    }
                    return NodeState.SUCCESS;
                }
            }


        }
        else if ((Mathf.Abs(player.transform.position.y - knight.transform.position.y) > Mathf.Abs(player.transform.position.x - knight.transform.position.x)))
        {
            if ((player.transform.position.y - knight.transform.position.y) >= 0)
            {
                if ((player.transform.position.x - knight.transform.position.x) > 0)
                {

                    knightPivot.transform.position = new Vector3(knight.transform.position.x + 1.1f, knight.transform.position.y + 2.2f);
                    if (knightPivot.transform.position.x < -4 || knightPivot.transform.position.x > 5.5 || knightPivot.transform.position.y > 4.5 || knightPivot.transform.position.y < -4)
                    {
                        knightPivot.transform.position = new Vector3(knight.transform.position.x - 1.1f, knight.transform.position.y + 2.2f);
                        return NodeState.FAILURE;
                    }
                    return NodeState.SUCCESS;
                }


                if ((player.transform.position.x - knight.transform.position.x) <= 0)
                {

                    knightPivot.transform.position = new Vector3(knight.transform.position.x - 1.1f, knight.transform.position.y + 2.2f);
                    if (knightPivot.transform.position.x < -4 || knightPivot.transform.position.x > 5.5 || knightPivot.transform.position.y > 4.5 || knightPivot.transform.position.y < -4)
                    {
                        knightPivot.transform.position = new Vector3(knight.transform.position.x + 1.1f, knight.transform.position.y + 2.2f);
                        return NodeState.FAILURE;
                    }
                    return NodeState.SUCCESS;
                }
            }

            if ((player.transform.position.y - knight.transform.position.y) < 0)
            {

                if ((player.transform.position.x - knight.transform.position.x) > 0)
                {

                    knightPivot.transform.position = new Vector3(knight.transform.position.x + 1.1f, knight.transform.position.y - 2.2f);
                    if (knightPivot.transform.position.x < -4 || knightPivot.transform.position.x > 5.5 || knightPivot.transform.position.y > 4.5 || knightPivot.transform.position.y < -4)
                    {
                        knightPivot.transform.position = new Vector3(knight.transform.position.x - 1.1f, knight.transform.position.y - 2.2f);
                        return NodeState.FAILURE;
                    }
                    return NodeState.SUCCESS;
                }


                if ((player.transform.position.x - knight.transform.position.x) <= 0)
                {

                    knightPivot.transform.position = new Vector3(knight.transform.position.x - 1.1f, knight.transform.position.y - 2.2f);
                    if (knightPivot.transform.position.x < -4 || knightPivot.transform.position.x > 5.5 || knightPivot.transform.position.y > 4.5 || knightPivot.transform.position.y < -4)
                    {
                        knightPivot.transform.position = new Vector3(knight.transform.position.x + 1.1f, knight.transform.position.y - 2.2f);
                        return NodeState.FAILURE;
                    }
                    return NodeState.SUCCESS;
                }


            }



        }

            return NodeState.FAILURE;
   
    }

    
}
