using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RockTreeAi : MonoBehaviour
{
    GameObject player;
    [SerializeField] GameObject rock;
    [SerializeField] GameObject rockPivot;

    public Animator animator;


    float duration = 0.23255813953488372093023255813953f /2;
    public float step = 1f;
    public float delayTime = 10f;

    public float dirCheckNum;

    public Sequence topNode;

    public bool isWait = false;
    public bool isTimerOn = false;
    public Coroutine evaluateCoroutine;
    void Start()
    {
        animator = rock.GetComponent<Animator>();
        player = GameObject.FindWithTag("Player");
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


        RockSetDirNode ponSetDirNode = new RockSetDirNode(rock, player, rockPivot);
        RockWaitNode waitNode = new RockWaitNode(delayTime, this);
        RockMoveNode moveNode = new RockMoveNode(rock, rockPivot, duration, this);

        topNode = new Sequence(new List<Node> {  ponSetDirNode, waitNode, moveNode });

    }

 
    public void StartWaitCoroutine(RockWaitNode waitNode)
    {
        StartCoroutine(Wait( waitNode));
    }




    IEnumerator Wait(RockWaitNode waitNode)
    {

        delayTime = 0.93023255813953488372093023255814f* 2f;
        while(delayTime > 0)
        {
            transform.gameObject.tag = "RockCanKilled";
            //Debug.Log("기다리는중");

            delayTime -= Time.deltaTime;
            yield return null;
        }
        isWait = true;

        StartEvaluateCoroutine();
    }

    public void StartLerpCoroutine(RockMoveNode moveNode)
    {
        //StartCoroutine(Lerp(moveNode));
        StartCoroutine(moveCoroutine(rockPivot.transform.position));
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
            rock.gameObject.tag = "RockCanKill";
            transform.localPosition = Vector2.Lerp(startPos, endPos, (Time.time - startTime) / duration);
            yield return null;
        }

        transform.localPosition = endPos;


    }

    void Update()
    {

        moveDir();
    }
    public void moveDir()
    {
        if (rockPivot.transform.localPosition.x > 0.5f && rock.transform.tag == "RockCanKilled")
        {
            animator.SetFloat("Ver", -0.5f);
            animator.SetFloat("Hor", 2);
            animator.SetFloat("Mag", 0.01f);
        }
        if (rockPivot.transform.localPosition.x > 0.5f && rock.transform.tag == "RockCanKill")
        {
            animator.SetFloat("Ver", -0.5f);
            animator.SetFloat("Hor", -2);
            animator.SetFloat("Mag", 0.01f);
        }


        if (rockPivot.transform.localPosition.x < -0.5f && rock.transform.tag == "RockCanKilled")
        {
            animator.SetFloat("Ver", 1);
            animator.SetFloat("Hor", 2);
            animator.SetFloat("Mag", 0.01f);
        }
        if (rockPivot.transform.localPosition.x < -0.5f && rock.transform.tag == "RockCanKill")
        {
            animator.SetFloat("Ver", 1);
            animator.SetFloat("Hor", -2);
            animator.SetFloat("Mag", 0.01f);
        }




        if (rockPivot.transform.localPosition.y > 0.5f && rock.transform.tag == "RockCanKilled")
        {
            animator.SetFloat("Ver", -1);
            animator.SetFloat("Hor", 2);
            animator.SetFloat("Mag", 0.01f);
        }
        if (rockPivot.transform.localPosition.y > 0.5f && rock.transform.tag == "RockCanKill")
        {
            animator.SetFloat("Ver", -1);
            animator.SetFloat("Hor", -2);
            animator.SetFloat("Mag", 0.01f);
        }

        if (rockPivot.transform.localPosition.y < -0.5f && rock.transform.tag == "RockCanKilled")
        {
            animator.SetFloat("Ver", 0.5f);
            animator.SetFloat("Hor", 2);
            animator.SetFloat("Mag", 0.01f);
        }
        if (rockPivot.transform.localPosition.y < -0.5f && rock.transform.tag == "RockCanKill")
        {
            animator.SetFloat("Ver", 0.5f);
            animator.SetFloat("Hor", -2);
            animator.SetFloat("Mag", 0.01f);
        }


    }




}
