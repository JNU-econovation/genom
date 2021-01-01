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
    public GameObject dialogUI;
    [SerializeField] private Image standing_cg;
    [SerializeField] private Text dialog_text;
    [SerializeField] private Text name_text;
    public Dialog[] dialog;
   
    private bool isDialog;
    private int count;


    //대화 UI 활성화시키는 함수
    public void StartDialog()
    {

        dialogUI.SetActive(true);

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


    //스페이스바 누르면 다음 대화 실행
    public void Update()
    {
        if (isDialog == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (count < dialog.Length)
                    NextDialog();
                else
                    EndDialog();

            }
        }
    }

    //대화 끝내기
    private void EndDialog()
    {
        isDialog = false;

        Time.timeScale = 1.0f;

        dialogUI.SetActive(false);
    }

}
