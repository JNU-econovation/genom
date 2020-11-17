﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PonTreeAi : MonoBehaviour
{
    GameObject player;
    [SerializeField] GameObject pon;
    [SerializeField] GameObject ponPivot;
    [SerializeField] GameObject FindPivot1;
    [SerializeField] GameObject FindPivot2;
    


    float duration = 0.5f;
    public float step = 1f;
    public float delayTime = 10f;

    public float dirCheckNum;

    public Sequence topNode;

    public bool isWaitEnd = false;
    public bool isTimerOn = false;
    public Coroutine evaluateCoroutine;
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        ConstructBehaviourTree();
        evaluateCoroutine = StartCoroutine(StartEvaluate());
    }

    void Update()
    {


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
        FindMoveNode findMoveNode = new FindMoveNode(pon, player, FindPivot1, this);
        FindMoveNode2 findMoveNode2 = new FindMoveNode2(pon, player, FindPivot2, this);


        PonSetDirNode ponSetDirNode = new PonSetDirNode(pon, player, ponPivot, FindPivot1, FindPivot2);
        WaitNode waitNode = new WaitNode(delayTime, this);
        MoveNode moveNode = new MoveNode(pon, ponPivot, duration, this);


        Selector findPlayerSelector = new Selector(new List<Node> { findMoveNode, findMoveNode2 });
        Selector moveSelector = new Selector(new List<Node> { findPlayerSelector, moveNode });

        topNode = new Sequence(new List<Node> {  ponSetDirNode, waitNode, moveSelector });

    }

 
    public void StartWaitCoroutine(WaitNode waitNode)
    {
        StartCoroutine(Wait( waitNode));
    }




    IEnumerator Wait(WaitNode waitNode)
    {

        delayTime = 3f;
        while(delayTime > 0)
        {
            transform.gameObject.tag = "PonCanKilled";
            //Debug.Log("기다리는중");

            delayTime -= Time.deltaTime;
            yield return null;
        }

        StartEvaluateCoroutine();
    }

    public void StartLerpCoroutine(MoveNode moveNode)
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

    public void StartLerpCoroutine2(FindMoveNode findMoveNode)
    {
        //StartCoroutine(Lerp(moveNode));
        StartCoroutine(moveCoroutine(FindPivot1.transform.position));
    }

    public void StartLerpCoroutine3(FindMoveNode2 findMoveNode2)
    {
        //StartCoroutine(Lerp(moveNode));
        StartCoroutine(moveCoroutine(FindPivot2.transform.position));
    }




    IEnumerator moveCoroutine(Vector2 endPos)
    {
        float startTime = Time.time;
        Vector2 startPos = transform.localPosition;


        while (Time.time - startTime <= duration)
        {
            pon.gameObject.tag = "PonCanKill";
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



}
