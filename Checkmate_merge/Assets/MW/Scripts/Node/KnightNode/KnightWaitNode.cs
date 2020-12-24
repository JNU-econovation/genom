using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightWaitNode : Node
{
    public float delayTime = 0.93023255813953488372093023255814f * 2;
    private float count;
    private KnightTreeAi ai;
    
    // Start is called before the first frame update

    public KnightWaitNode(float delayTime, KnightTreeAi ai)
    {
        this.delayTime = delayTime;
        this.ai = ai;
    }



    public override NodeState Evaluate()
    {
        delayTime = 0.93023255813953488372093023255814f * 2; 
        count += Time.deltaTime;

  
        if (count > delayTime)
        {
            
            Debug.Log("3초 기다림이 완료되었습니다");
            count = 0;
            return NodeState.SUCCESS;
        }
        Debug.Log("3초를 기다리는 중입니다.");

        return NodeState.FAILURE;
 


    }
}


    