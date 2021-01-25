using System.Collections;
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
    float duration = 0.23255813953488372093023255813953f*2;
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
        StartCoroutine(timer());
        
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

    public GameObject QBeatatt;
    IEnumerator QBeatAttak()
    {
        if(transform.gameObject.tag == "QBCanKill")
        {
   
            Instantiate(QBeatatt, player.transform.position + new Vector3(0, 0, 0), Quaternion.identity);
            StartCoroutine(timer());
            yield return null;
        }


    }

    IEnumerator timer()
    {
        if(transform.gameObject.tag != "QBCanKilled")
        {
            yield return new WaitForSeconds(0.93023255813953488372093023255812f);
            StartCoroutine(QBeatAttak());
        }

    }

        IEnumerator Wait(QueenWaitNode waitNode)
    {

        delayTime = 0.93023255813953488372093023255814f * 4;
        while(delayTime > 0)
        {


            if (transform.gameObject.tag != "QBCanKill" && transform.gameObject.tag != "QBCanKilled")
            {
                transform.gameObject.tag = "QueenCanKilled";
            }
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


    public void endQueenBoss()
    {

        pon.gameObject.tag = "QBCanKilled";
        animator2.SetFloat("Mag", 3);
    }



    IEnumerator moveCoroutine(Vector2 endPos)
    {
        float startTime = Time.time;
        Vector2 startPos = transform.localPosition;

        if(Mathf.Abs(pon.transform.localPosition.x - ponPivot.transform.localPosition.x) > 7 || Mathf.Abs(pon.transform.localPosition.y - ponPivot.transform.localPosition.y) > 7)
        {
            duration = 0.23255813953488372093023255813953f * 5;
        }
        else if (Mathf.Abs(pon.transform.localPosition.x - ponPivot.transform.localPosition.x) > 5 || Mathf.Abs(pon.transform.localPosition.y - ponPivot.transform.localPosition.y) > 5)
        {
            duration = 0.23255813953488372093023255813953f * 4;
        }
        else if (Mathf.Abs(pon.transform.localPosition.x - ponPivot.transform.localPosition.x) > 3 || Mathf.Abs(pon.transform.localPosition.y   - ponPivot.transform.localPosition.y) > 3)
        {
            duration = 0.23255813953488372093023255813953f * 3;
        }
        else if (Mathf.Abs(pon.transform.localPosition.x - ponPivot.transform.localPosition.x) > 0 || Mathf.Abs(pon.transform.localPosition.y - ponPivot.transform.localPosition.y) > 0)
        {
            duration = 0.23255813953488372093023255813953f * 2;
        }

        while (Time.time - startTime <= duration)
        {
            if (transform.gameObject.tag != "QBCanKill" && transform.gameObject.tag != "QBCanKilled")
            {
                transform.gameObject.tag = "QueenCanKill";
            }
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

    public Animator animator2;
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
        if (pon.transform.tag == "QBKilled")
        {
            animator2.SetFloat("Mag", 0);
        }
    }


}
