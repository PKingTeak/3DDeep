using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{

    [SerializeField] private int index;
    [SerializeField] private ItemData itemData; //슬롯에 저장할 아이템 정보



    public void InitSlot(int _index)
    {
        index = _index;


    }

    public void SetItemData(ItemData _itemData)
    {
        itemData = _itemData;
    }

    public void ClearSlot()

    {
        itemData = null;

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
