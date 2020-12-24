﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class QueenTreeAi : MonoBehaviour
{
    GameObject player;
    [SerializeField] GameObject pon;
    [SerializeField] GameObject ponPivot;
    [SerializeField] GameObject FindPivot1;
    [SerializeField] GameObject FindPivot2;
    [SerializeField] LayerMask PlayerMask;
    public Animator animator;
    float duration = 0.23255813953488372093023255813953f;
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


        QueenSetDirNode queenSetDirNode = new QueenSetDirNode(pon, player, ponPivot, PlayerMask);
        QueenSetDirNode2 queenSetDirNode2 = new QueenSetDirNode2(pon, player, ponPivot, PlayerMask);
        QueenWaitNode waitNode = new QueenWaitNode(delayTime, this);
        QueenMoveNode moveNode = new QueenMoveNode(pon, ponPivot, duration, this);

        Selector setDirSelector = new Selector(new List<Node> { queenSetDirNode, queenSetDirNode2 });

        topNode = new Sequence(new List<Node> { setDirSelector, waitNode, moveNode });

    }

 
    public void StartWaitCoroutine(QueenWaitNode waitNode)
    {
        StartCoroutine(Wait( waitNode));
    }




    IEnumerator Wait(QueenWaitNode waitNode)
    {

        delayTime = 0.93023255813953488372093023255814f * 2;
        while(delayTime > 0)
        {


            transform.gameObject.tag = "QueenCanKilled";
            delayTime -= Time.deltaTime;
            yield return null;
        }

        StartEvaluateCoroutine();
    }

    public void StartLerpCoroutine(QueenMoveNode moveNode)
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






    IEnumerator moveCoroutine(Vector2 endPos)
    {
        float startTime = Time.time;
        Vector2 startPos = transform.localPosition;


        while (Time.time - startTime <= duration)
        {
            pon.gameObject.tag = "QueenCanKill";
            transform.localPosition = Vector2.Lerp(startPos, endPos, (Time.time - startTime) / duration);
            yield return null;
        }

        transform.localPosition = endPos;


    }






        public void SetDir(GameObject pon, GameObject player)
    {
        if (Mathf.Abs(player.transform.position.x - pon.transform.position.x) > Mathf.Abs(player.transform.position.y - pon.transform.position.y))
        {
            if ((player.transform.position.x - pon.transform.position.x) > 0)
            {
                ponPivot.transform.localPosition = new Vector3(1.1f, 0, 0);
                FindPivot1.transform.localPosition = new Vector3(1.1f, 1.1f, 0);
                FindPivot2.transform.localPosition = new Vector3(1.1f, -1.1f, 0);
                dirCheckNum = 0;

            }
            if ((player.transform.position.x - pon.transform.position.x) <= 0)
            {
                ponPivot.transform.localPosition = new Vector3(-1.1f, 0, 0);
                FindPivot1.transform.localPosition = new Vector3(-1.1f, 1.1f, 0);
                FindPivot2.transform.localPosition = new Vector3(-1.1f, -1.1f, 0);
                dirCheckNum = 0;

            }
        }
        if (Mathf.Abs(player.transform.position.x - pon.transform.position.x) <= Mathf.Abs(player.transform.position.y - pon.transform.position.y))
        {
            if ((player.transform.position.y - pon.transform.position.y) > 0)
            {
                ponPivot.transform.localPosition = new Vector3(0, 1.1f, 0);
                FindPivot1.transform.localPosition = new Vector3(1.1f, 1.1f, 0);
                FindPivot2.transform.localPosition = new Vector3(-1.1f, 1.1f, 0);
                dirCheckNum = 0;

            }
            if ((player.transform.position.y - pon.transform.position.y) <= 0)
            {
                ponPivot.transform.localPosition = new Vector3(0, -1.1f, 0);
                FindPivot1.transform.localPosition = new Vector3(1.1f, -1.1f, 0);
                FindPivot2.transform.localPosition = new Vector3(-1.1f, -1.1f, 0);
                dirCheckNum = 0;

            }
        }


    }

    void Update()
    {

        moveDir();
    }
    public void moveDir()
    {
        if (pon.transform.tag == "QueenCanKilled")
        {
            animator.SetFloat("attck", 0);
        }
        else if (pon.transform.tag == "QueenCanKill")
        {
            animator.SetFloat("attck", 1);
        }
    }

}
