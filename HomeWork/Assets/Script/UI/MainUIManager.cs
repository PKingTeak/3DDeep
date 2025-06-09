using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MainUIManager : MonoBehaviour
{
    //모든 UI 매니저를 관리하는 클래스

    public static MainUIManager Instance { get; set; }

    [Header("UI List")]
    [SerializeField]
    List<ButtonHandler> uiList = new List<ButtonHandler>();
    [SerializeField] private GameObject backButton;




    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        if (uiList.Count > 0)
        {

            for (int i = 0; i < uiList.Count; i++)
            {
                uiList[i].SetButtonIndex(i);
                uiList[i].DeactiveUIObject();
               

            }
        }
    }

    public void OnclickButton(int index)
    {
        //해당 인덱스의 UI를 활성화하고 나머지는 비활성화
        ClickButton(index);
    }
    public void ClickButton(int index)
    {
        for (int i = 0; i < uiList.Count; i++)
        {

            if (i == index)
            {
                uiList[i].ActiveUIObject();
                uiList[i].InvokeExtraEvent(); //여기서 등록된 이벤트 실행
            }
            else
            {
                uiList[i].DeactiveUIObject();
            }
            //해당 인덱스 말고 모든 UI를 비활성화

            

        }


    }

    public void DeActiveAllButton()
    {
        for (int i = 0; i < uiList.Count; i++)
        {
            uiList[i].gameObject.SetActive(false);

        }
            backButton.SetActive(true);

    }

    public void ActiveAllButton()
    {
        for (int i = 0; i < uiList.Count; i++)
        {
            uiList[i].gameObject.SetActive(true);

        }
        backButton.SetActive(false);

    }

    public void ResetAll()
    {
        ActiveAllButton();
        for (int i = 0; i < uiList.Count; i++)
        {
            uiList[i].DeactiveUIObject();
        }
        backButton.SetActive(false);
     }



}
