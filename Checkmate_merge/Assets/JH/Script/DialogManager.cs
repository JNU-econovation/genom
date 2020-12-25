using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Dialog
{
    [TextArea]
    public string dialog;//대사
    public string name;//이름
    public Sprite cg; // 스탠딩 이미지
}

public class DialogManager : MonoBehaviour
{
    [SerializeField] private Image standing_cg;
    [SerializeField] private Image dialog_box;
    [SerializeField] private Text dialog_text;
    [SerializeField] private Text name_text;
    
    [SerializeField] private Dialog[] dialog;
    
    private bool isDialog;
    private int count;

    //버튼이 눌러지면 활성화시키는 함수
    public void StartDialog()
    {
        standing_cg.gameObject.SetActive(true);
        dialog_box.gameObject.SetActive(true);
        dialog_text.gameObject.SetActive(true);
        name_text.gameObject.SetActive(true);

        isDialog = true;
        count = 0;

        NextDialog();
    }

    //다음 대화 진행 함수
    public void NextDialog()
    {
        dialog_text.text = dialog[count].dialog;
        name_text.text = dialog[count].name;
        standing_cg.sprite = dialog[count].cg;
        
        count++;
    }

    //대화 끝내기
    public void EndDialog()
    {
        if (Time.timeScale == 0.0f)
            Time.timeScale = 1.0f;
   
        isDialog = false;

        standing_cg.gameObject.SetActive(false);
        dialog_box.gameObject.SetActive(false);
        dialog_text.gameObject.SetActive(false);
        name_text.gameObject.SetActive(false);

    }

    //스페이스바 누르면 다음 대화 실행
    public void Update()
    {
        if(isDialog==true)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                if (count < dialog.Length)
                    NextDialog();
                else
                    EndDialog();
            }
        }
    }

}

// 마지막 대사가 실행 안됨
// 게임매니저에 특정 점수가 되면 실행되도록 했는데 안나옴
// 왜 lastscore은 안되지
// 스페이스바 눌렀는데 왜 안돼
// 왜 대화가 안끝나냐고 하
// 애니메이션 추가?


