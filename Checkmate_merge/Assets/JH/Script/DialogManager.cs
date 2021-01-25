using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[System.Serializable]
public class Dialog
{
    [TextArea]
    public string[] sentence;//대사
    public string[] name;//이름
    public Sprite[] cg;//스탠딩 이미지

}

public class DialogManager : MonoBehaviour
{
    public static DialogManager instance;

    public GameObject startUI;
    public GameObject dialogUI;

    public Text name_text;
    public Text sentence_text;
    public Image standing_cg;


    private List<string> list_name;
    private List<string> list_sentence;
    private List<Sprite> list_cg;

    private int count;// 대화 순서
    public bool isDialog = false;
    public bool isFirst = false;
    public bool canKeyControl = false;//스페이스바 조절
    public bool CanNext = false;

    public Vector2 kingPos = new Vector2(72, 22);
    public Vector2 enemyPos = new Vector2(543, 22);

    public Vector2 kingnamePos = new Vector2(287, 102);
    public Vector2 kingsentencePos = new Vector2(287, -146);

    public Vector2 enemynamePos = new Vector2(89, -102);
    public Vector2 enemysentencePos = new Vector2(89, -146);


    #region 
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogWarning("씬에 두개 이상의 게임 매니저가 존재합니다!");
            Destroy(gameObject);
        }
    }
    #endregion

    private void Start()
    {

        count = 0;
        name_text.text = "";
        sentence_text.text = "";

        list_name = new List<string>();
        list_sentence = new List<string>();
        list_cg = new List<Sprite>();
    }
    //-----------------------------------------------------------------------

    //대화 시작 UI 실행
    public void FirstDialog()
    {
        Time.timeScale = 0.0f;//기물, 점수 정지

        isFirst = true;
        canKeyControl = true;

        startUI.SetActive(true);

        

    }

    //대화 시작 UI 종료
    public IEnumerator EndFirstDialog()
    {
        isFirst = false;
        canKeyControl = false;
        startUI.SetActive(false);

        yield return new WaitForSecondsRealtime(0.5f);
        GameManager.instance.state = GameManager.State.offDialog;//offDialog 상태
        GameManager.instance.isFirstDialog = false;
        GameManager.instance.CanCountdown = true;

        Debug.Log("UI끝/ state: " + GameManager.instance.state + " isFirstDialog: " + GameManager.instance.isFirstDialog + " canCountDown" + GameManager.instance.CanCountdown);

    }
    //----------------------------------------------------------------------

    //리스트에 지정값만큼 넣기
    public void ShowDialog(Dialog dialog)
    {

        isDialog = true;
        canKeyControl = true;

        for (int i = 0; i < dialog.sentence.Length; i++)
        {
            list_name.Add(dialog.name[i]);
            list_sentence.Add(dialog.sentence[i]);
            list_cg.Add(dialog.cg[i]);

        }
        dialogUI.SetActive(true);


        StartCoroutine(StartDialog());
    }

    //대화 뽑아내기
    public IEnumerator StartDialog()
    {
        //이름
        name_text.text = list_name[count];

        //스탠딩 이미지
        if (count > 0)
        {
            if (list_cg[count] != list_cg[count - 1])//두개의 이미지가 다르다면 이미지 교체
            {
                standing_cg.sprite = list_cg[count];

                if (list_cg[count].name == "화이트킹")//리스트에 할당된 이미지가 down 1이면
                {
                    standing_cg.rectTransform.anchoredPosition = kingPos;//이미지 위치를 (650,40)으로 변경
                    name_text.rectTransform.anchoredPosition = kingnamePos;
                    Debug.Log(name_text.rectTransform.anchoredPosition);
                    Debug.Log(kingnamePos);
                    sentence_text.rectTransform.anchoredPosition = kingsentencePos;

                }
                else
                {
                    standing_cg.rectTransform.anchoredPosition = enemyPos;
                    name_text.rectTransform.anchoredPosition = enemynamePos;
                    sentence_text.rectTransform.anchoredPosition = enemysentencePos;
                }
                    

            }

        }
        else//count==0 (첫 이미지)
        {
            standing_cg.sprite = list_cg[count];

            if (list_cg[count].name == "화이트킹")//리스트에 할당된 이미지가 down 1이면
            {
                standing_cg.rectTransform.anchoredPosition = kingPos;//이미지 위치를 (650,40)으로 변경
                name_text.rectTransform.anchoredPosition = kingnamePos;
                sentence_text.rectTransform.anchoredPosition = kingsentencePos;

            }
            else

            {
                standing_cg.rectTransform.anchoredPosition = enemyPos;
                name_text.rectTransform.anchoredPosition = enemynamePos;
                sentence_text.rectTransform.anchoredPosition = enemysentencePos;
            }

        }


        StartCoroutine(Typing());

        yield return null;
    }

    int i = 0;
    public bool isTyping = false;

    IEnumerator Typing()
    {

        for (i = 0; i < list_sentence[count].Length; i++)
        {
            isTyping = true;
            sentence_text.text += list_sentence[count][i];
            yield return new WaitForSecondsRealtime(0.015f);

        }


    }


    private void Update()
    {


        if (isFirst && canKeyControl)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonUp(0))
            {
                if (PauseManager.instance.isContinued == true)//이어하기를 눌렀다면
                {
                    FirstDialog();
                }
                else
                    StartCoroutine(EndFirstDialog());
            }
        }


        if (isDialog && canKeyControl)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonUp(0))
            {

                count++;
                sentence_text.text = "";

                if (count == list_sentence.Count)//count가 list의 지정된 count와 같다면 대화 종료
                {
                    StopAllCoroutines();
                    StartCoroutine(EndDialog());

                }
                else//그렇지 않다면 계속 대화
                {
                    StopAllCoroutines();
                    StartCoroutine(StartDialog());
                }

            }
        }


    }




    // 대화 종료
    public IEnumerator EndDialog()
    {
        name_text.text = "";
        sentence_text.text = "";
        count = 0;

        list_name.Clear();
        list_sentence.Clear();
        list_cg.Clear();

        dialogUI.SetActive(false);
        isDialog = false;

        Debug.Log("대화종료");

        yield return new WaitForSecondsRealtime(2f);
        Debug.Log("2초 기다림");
        Time.timeScale = 1.0f;
        //canRoundStart = true;

        yield return new WaitForSeconds(0.5f);
        GameManager.instance.state = GameManager.State.offDialog;
    }

      

}













