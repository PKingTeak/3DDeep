using System.Collections;
using System.Collections.Generic;

using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class Slot : MonoBehaviour
{

    [SerializeField] private int index;
    [SerializeField] private ItemData itemData; //슬롯에 저장할 아이템 정보


    private Item item;
    [SerializeField]
    private Image itemIconImage;
    [SerializeField]
    private TextMeshProUGUI Equimenttext;


  


    public void InitSlot(int _index)
    {
        index = _index;


    }

    public void SetItemData(Item _item)
    {
        item = _item;
        itemData = _item.GetItemData();
        itemIconImage.sprite = _item.GetItemData().itemIcon;
        IsEquiment();
    }

    public void ClearSlot()

    {
        itemData = null;

    }
    // Start is called before the first frame update
    void Start()
    {

        if (item == null)
        {
            return;
        }

        //슬롯이 생성되면 따로 해줄께 있나?
    }

    public void ShowSlotInfo()
    {
        itemIconImage.sprite = item.GetItemData().itemIcon;

    }
    // Update is called once per frame
    void Update()
    {

    }

    public void IsEquiment()
    {
        if (item.IsEquiment)
        {
            GameManager.instance.Player.ApplyItem(item);
            GameManager.instance.player.ApplyItem(item);
            Equimenttext.gameObject.SetActive(true);
        }
        else if (!item.IsEquiment && Equimenttext.IsActive() == true)
        {
            GameManager.instance.player.RemoveItem(item);
            Equimenttext.gameObject.SetActive(false);
        }

    }

    public void ClickSlot()
    {
        if (item == null) return;

        item.ToggleEquip();
        IsEquiment();



    }
}
