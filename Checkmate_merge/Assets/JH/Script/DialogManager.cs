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

    public bool canRoundStart = false;

    //싱글톤
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

    private void Start()
    {
        count = 0;
        name_text.text = "";
        sentence_text.text = "";

        list_name = new List<string>();
        list_sentence = new List<string>();
        list_cg = new List<Sprite>();
    }

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

        if(EnemySpawner.instance.isPonDialog==true)
        {
            EnemySpawner.instance.isPonDialog = false;
            Debug.Log("iscanDialog: " + EnemySpawner.instance.isPonDialog);
        }

        //Time.timeScale = 1.0f;
        //canRoundStart = true;

        if (Time.timeScale == 0.0f)
        {
            yield return new WaitForSeconds(2f);
            Time.timeScale = 1.0f;
            Debug.Log("재시작");
        }

        yield return new WaitForSeconds(0.5f);
        GameManager.instance.state = GameManager.State.offDialog;

        
    }


    //첫대화 시작
    public void FirstDialog()
    {
        Time.timeScale = 0.0f;//기물, 점수 정지
        isFirst = true;
        canKeyControl = true;
        startUI.SetActive(true);
        

    }
    public IEnumerator EndFirstDialog()
    {
        startUI.SetActive(false);
        isFirst = false;

        yield return new WaitForSeconds(2f);
        Time.timeScale = 1.0f;//점수,기물 다시 시작

        yield return new WaitForSeconds(0.5f);
        GameManager.instance.state = GameManager.State.offDialog;
    }
    

    //스페이스바 누르면 다음 문장 실행
    private void Update()
    {


        if (isFirst&&canKeyControl)
        {
            if (Input.GetKeyDown(KeyCode.Space)|| Input.GetMouseButton(0))
            {
              
                StartCoroutine(EndFirstDialog());
           
            }
        }
        if (isDialog&&canKeyControl)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButton(0))
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

                if (list_cg[count].name == "down 1")//리스트에 할당된 이미지가 down 1이면
                {
                    standing_cg.rectTransform.anchoredPosition = new Vector2(39,67);//이미지 위치를 (650,40)으로 변경
                }
                else
                    standing_cg.rectTransform.anchoredPosition = new Vector2(629,67);

               
            }

        }
        else//count==0 (첫 이미지)
        {
            standing_cg.sprite = list_cg[count];

            if (list_cg[count].name == "down 1")//리스트에 할당된 이미지가 down 1이면
            {
                standing_cg.rectTransform.anchoredPosition = new Vector2(39,67);//이미지 위치를 (650,40)으로 변경
            }
            else
                standing_cg.rectTransform.anchoredPosition = new Vector2(629,67);
            
        }

        //대사 1글자씩 출력 
        for (int i = 0; i < list_sentence[count].Length; i++)
        {

            sentence_text.text += list_sentence[count][i];

            yield return null;

        }

    }



}
