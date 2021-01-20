using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class KnightTreeAi : MonoBehaviour
{
    GameObject player;
    [SerializeField] GameObject pon;
    [SerializeField] GameObject ponPivot;
    [SerializeField] GameObject knightPivot2;
    [SerializeField] LayerMask PlayerMask;
    public Animator animator;
    float duration = 0.23255813953488372093023255813953f*2f;
    public float step = 1f;
    public float delayTime = 10f;

    public float dirCheckNum;

    public Sequence topNode;

    public bool isWaitEnd = false;
    public bool isTimerOn = false;
    public Coroutine evaluateCoroutine;
    void Start()
    {
        animator = pon.GetComponent<Animator>();
        player = GameObject.FindWithTag("PlayerPos");
        ConstructBehaviourTree();
        evaluateCoroutine = StartCoroutine(StartEvaluate());
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


        KnightSetDirNode queenSetDirNode = new KnightSetDirNode(pon, player, ponPivot, knightPivot2);
        KnightSetDirNode2 queenSetDirNode2 = new KnightSetDirNode2(pon, player, ponPivot, knightPivot2);
        KnightSetDirNode3 knightSetDirNode3 = new KnightSetDirNode3(pon, player, ponPivot, knightPivot2);
        KnightSetDirNode4 knightSetDirNode4 = new KnightSetDirNode4(pon, player, ponPivot, knightPivot2);
        KnightWaitNode waitNode = new KnightWaitNode(delayTime, this);
        KnightMoveNode moveNode = new KnightMoveNode(pon, ponPivot, duration, this);
        KnightMoveNode2 moveNode2 = new KnightMoveNode2(pon, knightPivot2, duration, this);


        KnightEndMove endMove = new KnightEndMove(pon, knightPivot2, duration, this);
        Selector setDirSelector = new Selector(new List<Node> { queenSetDirNode, queenSetDirNode2, knightSetDirNode3, knightSetDirNode4 });

        topNode = new Sequence(new List<Node> { setDirSelector, waitNode, moveNode , endMove });

    }

 
    public void StartWaitCoroutine(KnightWaitNode waitNode)
    {
        StartCoroutine(Wait( waitNode));
    }




    IEnumerator Wait(KnightWaitNode waitNode)
    {

        delayTime = 0.93023255813953488372093023255814f * 4;
        while(delayTime > 0)
        {


            transform.gameObject.tag = "KnightCanKilled";
            delayTime -= Time.deltaTime;
            yield return null;
        }

        StartEvaluateCoroutine();
    }

    public void StartLerpCoroutine(KnightMoveNode moveNode)
    {
        //StartCoroutine(Lerp(moveNode));
        StartCoroutine(moveCoroutine(ponPivot.transform.position));
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




    public void StartLerpCoroutine2(KnightMoveNode2 moveNode2)
    {
        //StartCoroutine(Lerp(moveNode));
        StartCoroutine(moveCoroutine2(knightPivot2.transform.position));
    }
    IEnumerator moveCoroutine2(Vector2 endPos)
    {
        float startTime = Time.time;
        Vector2 startPos = transform.localPosition;


        while (Time.time - startTime <= duration)
        {
            pon.gameObject.tag = "KnightCanKill";
            transform.localPosition = Vector2.Lerp(startPos, endPos, (Time.time - startTime) / duration);
            yield return null;
        }

        transform.localPosition = endPos;


    }


    IEnumerator moveCoroutine(Vector2 endPos)
    {
        float startTime = Time.time;
        Vector2 startPos = transform.localPosition;


        while (Time.time - startTime <= duration)
        {
            pon.gameObject.tag = "KnightCanKill";
            transform.localPosition = Vector2.Lerp(startPos, endPos, (Time.time - startTime) / duration);
            yield return null;
        }
        pon.gameObject.tag = "KnightCanKilled";
        transform.localPosition = endPos;


    }
    void Update()
    {
        moveDir();
        if(pon.gameObject.tag != "KnightCanKill")
        {
            pon.gameObject.tag = "KnightCanKilled";
        }

    }
    public void moveDir()
    {
        if( ponPivot.transform.localPosition.x > 4f && pon.transform.tag == "KnightCanKilled")
        {
            animator.SetFloat("Ver", -0.5f);
            animator.SetFloat("Hor", 2);
            animator.SetFloat("right", 0);
        }
        if ( ponPivot.transform.localPosition.x > 4f && pon.transform.tag == "KnightCanKill")
        {
            animator.SetFloat("Ver", -0.5f);
            animator.SetFloat("Hor", -2);
            animator.SetFloat("right", 1);
        }


        if ( ponPivot.transform.localPosition.x < -4f && pon.transform.tag == "KnightCanKilled")
        {
            animator.SetFloat("Ver", 1);
            animator.SetFloat("Hor", 2);
            animator.SetFloat("left", 0);
        }
        if ( ponPivot.transform.localPosition.x < -4f && pon.transform.tag == "KnightCanKill")
        {
            animator.SetFloat("Ver", 1);
            animator.SetFloat("Hor", -2);
            animator.SetFloat("left", 1);
        }




        if ( ponPivot.transform.localPosition.y > 4f && pon.transform.tag == "KnightCanKilled")
        {
            animator.SetFloat("Ver", -1);
            animator.SetFloat("Hor", 2);
            animator.SetFloat("up", 0);
        }
        if ( ponPivot.transform.localPosition.y > 4f && pon.transform.tag == "KnightCanKill")
        {
            animator.SetFloat("Ver", -1);
            animator.SetFloat("Hor", -2);
            animator.SetFloat("up", 1);
        }


        if (ponPivot.transform.localPosition.y < -4f && pon.transform.tag == "KnightCanKilled")
        {
            animator.SetFloat("Ver", 0.5f);
            animator.SetFloat("Hor", 2);
            animator.SetFloat("down", 0);
        }
        if (ponPivot.transform.localPosition.y < -4f && pon.transform.tag == "KnightCanKill")
        {
            animator.SetFloat("Ver", 0.5f);
            animator.SetFloat("Hor", -2);
            animator.SetFloat("down", 1);
        }


    }





}
