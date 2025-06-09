using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum ButtonType
{

    
    Status = 0,
    Inventory = 1,
    
    Back = 100

    //추가 하면 넣어주기 


}

public class ButtonHandler : MonoBehaviour
{
    private event Action ExtraEvent;

    [SerializeField] private ButtonType buttonType;
    [SerializeField] private GameObject UIObject;

    int index;


    public void SetButtonIndex(int _index)
    {
        index = _index;
    }

    private void Awake()
    {

        GetComponent<Button>().onClick.AddListener(() => MainUIManager.Instance.OnclickButton(index));
        GetComponent<Button>().onClick.AddListener(() => MainUIManager.Instance.DeActiveAllButton());

        if (buttonType == ButtonType.Back)
        {
            GetComponent<Button>().onClick.AddListener(() => ClickBackButton());
        }
        else if (buttonType == ButtonType.Inventory)
        {

            GetComponent<Button>().onClick.AddListener(() => ExtraEvent?.Invoke());//호출하기
         }
    }

    public ButtonType GetButtonType()
    {
        return buttonType;

    }
public void SetExtraAction(Action action)
{
    ExtraEvent = action;
}

public void InvokeExtraEvent()
{
    ExtraEvent?.Invoke(); // ✅ 외부에서 호출 가능
}

    public void ActiveUIObject()
    {

        UIObject.SetActive(true);

    }
    public void DeactiveUIObject()
    {

        UIObject.SetActive(false);

    }

    public void ClickBackButton()
    {
        if (buttonType == ButtonType.Back)
        {
            //모든 버튼 켜기 
            MainUIManager.Instance.ResetAll();
            
        }

     }




}
