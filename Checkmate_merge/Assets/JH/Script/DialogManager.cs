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
    public GameObject startUI;
    public GameObject dialogUI;
    
    public Text name_text;
    public Text sentence_text;
    public Image standing_cg;
    private string write_text;//시범 텍스트

    private List<string> list_name;
    private List<string> list_sentence;
    private List<Sprite> list_cg;

    private int count;// 대화 순서
    private bool isDialog = false;
    private bool isStart = false;

    private void Start()
    {
        count = 0;
        name_text.text = "";
        sentence_text.text = "";

        list_name = new List<string>();
        list_sentence = new List<string>();
        list_cg = new List<Sprite>();
    }
    //대화UI 시작
    public void DialogUIstart()
    {
        isStart = true;
        startUI.SetActive(true);
        
    }

    //리스트에 지정값만큼 넣기
    public void ShowDialog(Dialog dialog)
    {
        isDialog = true;

        for (int i = 0; i < dialog.sentence.Length;i++)
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
            }

        }
        else//count==0 (첫 이미지)
        {
            standing_cg.sprite = list_cg[count];
        }

        //대사 1글자씩 출력 
        for (int i = 0; i < list_sentence[count].Length; i++)
        {

            sentence_text.text += list_sentence[count][i];

            yield return null;

        }
       
    }

    //스페이스바 누르면 다음 문장 실행
    private void Update()
    {
        if(isStart)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                startUI.SetActive(false);
                isStart = false;
                Time.timeScale = 1.0f;
            }
        }
        if(isDialog)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                count++;
                sentence_text.text = "";

                if (count == list_sentence.Count)//count가 list의 지정된 count와 같다면 대화 종료
                {
                    StopAllCoroutines();
                    EndDialog();
                }
                else//그렇지 않다면 계속 대화
                {
                    StopAllCoroutines();
                    StartCoroutine(StartDialog());
                }
                Debug.Log("count:" + count);
            }
        }
        
        
    }


    // 대화 종료
    public void EndDialog()
    {
        name_text.text = "";
        sentence_text.text = "";
        count = 0;

        list_name.Clear();
        list_sentence.Clear();
        list_cg.Clear();

        dialogUI.SetActive(false);
        isDialog = false;

        Time.timeScale = 1.0f;
    }
}

