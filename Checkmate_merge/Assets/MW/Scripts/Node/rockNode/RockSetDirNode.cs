using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSetDirNode : Node
{
    private GameObject rock;
    private GameObject player;
    private GameObject rockPivot;




    public RockSetDirNode(GameObject rock, GameObject player, GameObject rockPivot)
    {
        this.rock = rock;
        this.player = player;
        this.rockPivot = rockPivot;

    }

    public override NodeState Evaluate()
    {
        if (Mathf.Abs(rockPivot.transform.localPosition.x) > 1)
        {
            return NodeState.SUCCESS;
        }
        if (Mathf.Abs(rockPivot.transform.localPosition.y) > 1)
        {
            return NodeState.SUCCESS;
        }
        if (Mathf.Abs(player.transform.position.x - rock.transform.position.x) > Mathf.Abs(player.transform.position.y - rock.transform.position.y))
        {
            if ((player.transform.position.x - rock.transform.position.x) > 0)
            {
                rockPivot.transform.localPosition = new Vector3(1.1f, 0, 0);

                Debug.Log("좌표를 설정합니다");
                return NodeState.SUCCESS;

            }
            if ((player.transform.position.x - rock.transform.position.x) <= 0)
            {
                rockPivot.transform.localPosition = new Vector3(-1.1f, 0, 0);

                Debug.Log("좌표를 설정합니다");
                return NodeState.SUCCESS;

            }
        }
        else if (Mathf.Abs(player.transform.position.x - rock.transform.position.x) <= Mathf.Abs(player.transform.position.y - rock.transform.position.y))
        {
            if ((player.transform.position.y - rock.transform.position.y) > 0)
            {
                rockPivot.transform.localPosition = new Vector3(0, 1.1f, 0);

                //Debug.Log("좌표를 설정합니다");
                return NodeState.SUCCESS;

            }
            if ((player.transform.position.y - rock.transform.position.y) <= 0)
            {
                rockPivot.transform.localPosition = new Vector3(0, -1.1f, 0);

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
