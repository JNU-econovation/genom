using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BishopTreeAi : MonoBehaviour
{
    GameObject player;
    [SerializeField] GameObject bishop;
    [SerializeField] GameObject bishopPivot;

    public Animator animator;


    float duration = 0.23255813953488372093023255813953f * 2;
    public float step = 1f;
    public float delayTime = 10f;


    public Sequence topNode;

    public bool isWait = false;
    public bool isTimerOn = false;
    public Coroutine evaluateCoroutine;
    void Start()
    {
        animator = bishop.GetComponent<Animator>();
        player = GameObject.FindWithTag("Player");
        ConstructBehaviourTree();
        evaluateCoroutine = StartCoroutine(StartEvaluate());
    }

    void Update()
    {
        moveDir();

    }
    public void StartEvaluateCoroutine()
    {
        evaluateCoroutine = StartCoroutine(StartEvaluate());
    }

    public void StopEvaluateCoroutine()
    {
        StopCoroutine(evaluateCoroutine);
    }
    IEnumerator StartEvaluate()
    {
        while (!isTimerOn)
        {
            yield return null;
            topNode.Evaluate();
        }
    }

    private void ConstructBehaviourTree()
    {


        BishopSetDirNode ponSetDirNode = new BishopSetDirNode(bishop, player, bishopPivot);
        BishopWaitNode waitNode = new BishopWaitNode(delayTime, this);
        BishopMoveNode moveNode = new BishopMoveNode(bishop, bishopPivot, duration, this);

        topNode = new Sequence(new List<Node> {  ponSetDirNode, waitNode, moveNode });

    }

 
    public void StartWaitCoroutine(BishopWaitNode waitNode)
    {
        StartCoroutine(Wait( waitNode));
    }




    IEnumerator Wait(BishopWaitNode waitNode)
    {

        delayTime = 0.93023255813953488372093023255814f* 4f;
        while(delayTime > 0)
        {
            transform.gameObject.tag = "BishopCanKilled";
            //Debug.Log("기다리는중");

            delayTime -= Time.deltaTime;
            yield return null;
        }
        isWait = true;

        StartEvaluateCoroutine();
    }

    public void StartLerpCoroutine(BishopMoveNode moveNode)
    {
        //StartCoroutine(Lerp(moveNode));
        StartCoroutine(moveCoroutine(bishopPivot.transform.position));
    }

    /*
    IEnumerator Lerp(MoveNode moveNode)
    {
        float dist = Vector2.Distance(moveNode.GetPos(), moveNode.GetEndPos());
        while (dist > 0.01f)
        {
            Debug.Log(dist);
            moveNode.SetPos(Vector3.Lerp(moveNode.GetPos(), moveNode.GetEndPos(), Time.deltaTime / 2f));
            dist = Vector2.Distance(moveNode.GetPos(), moveNode.GetEndPos());
            yield return null;
        }

    }
    */






    IEnumerator moveCoroutine(Vector2 endPos)
    {
        float startTime = Time.time;
        Vector2 startPos = transform.localPosition;


        while (Time.time - startTime <= duration)
        {
            gameObject.tag = "BishopCanKill";
            transform.localPosition = Vector2.Lerp(startPos, endPos, (Time.time - startTime) / duration);
            yield return null;
        }

        transform.localPosition = endPos;


    }

    public void moveDir()
    {
        if (bishopPivot.transform.localPosition.x > 0.5f && bishopPivot.transform.localPosition.y > 0.5f && bishop.tag == "BishopCanKilled")
        {

            animator.SetFloat("Hor", 2);
            animator.SetFloat("Ver", -2);
            animator.SetFloat("Magnitude", 0.01f);
        }
        if (bishopPivot.transform.localPosition.x > 0.5f && bishopPivot.transform.localPosition.y > 0.5f && bishop.tag == "BishopCanKill")
        {

            animator.SetFloat("Hor", 2);
            animator.SetFloat("Ver", 2);
            animator.SetFloat("Magnitude", 0.01f);
        }


        if (bishopPivot.transform.localPosition.x < -0.5f && bishopPivot.transform.localPosition.y > 0.5f && bishop.tag == "BishopCanKilled")
        {

            animator.SetFloat("Hor", -1);
            animator.SetFloat("Ver", -2);
            animator.SetFloat("Magnitude", 0.01f);
        }
        if (bishopPivot.transform.localPosition.x < -0.5f && bishopPivot.transform.localPosition.y > 0.5f && bishop.tag == "BishopCanKill")
        {

            animator.SetFloat("Hor", -1);
            animator.SetFloat("Ver", 2);
            animator.SetFloat("Magnitude", 0.01f);
        }


        if (bishopPivot.transform.localPosition.x > 0.5f && bishopPivot.transform.localPosition.y < -0.5f && bishop.tag == "BishopCanKilled")
        {

            animator.SetFloat("Hor", 1);
            animator.SetFloat("Ver", -2);
            animator.SetFloat("Magnitude", 0.01f);
        }
        if (bishopPivot.transform.localPosition.x > 0.5f && bishopPivot.transform.localPosition.y < -0.5f && bishop.tag == "BishopCanKill")
        {

            animator.SetFloat("Hor", 1);
            animator.SetFloat("Ver", 2);
            animator.SetFloat("Magnitude", 0.01f);
        }


        if (bishopPivot.transform.localPosition.x < -0.5f && bishopPivot.transform.localPosition.y < -0.5f && bishop.tag == "BishopCanKilled")
        {

            animator.SetFloat("Hor", -2);
            animator.SetFloat("Ver", -2);
            animator.SetFloat("Magnitude", 0.01f);
        }
        if (bishopPivot.transform.localPosition.x < -0.5f && bishopPivot.transform.localPosition.y < -0.5f && bishop.tag == "BishopCanKill")
        {

            animator.SetFloat("Hor", -2);
            animator.SetFloat("Ver", 2);
            animator.SetFloat("Magnitude", 0.01f);
        }




    }

}
