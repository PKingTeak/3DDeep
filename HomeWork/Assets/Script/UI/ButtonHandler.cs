using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum ButtonType
{
    Status = 0,
    Inventory =1

    //추가 하면 넣어주기 


}

public class ButtonHandler : MonoBehaviour
{
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
    }

    public void ActiveUIObject()
    {

        UIObject.SetActive(true);

    }
    public void DeactiveUIObject()
    {

        UIObject.SetActive(false);

    }




}
