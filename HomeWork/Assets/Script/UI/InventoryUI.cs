using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    private List<Slot> slot = new List<Slot>();

    [SerializeField] private ScrollRect scrollRect;


    

    private void InitSlotList()
    {
        for (int i = 0; i < slot.Count; i++)
        {
            slot[i].InitSlot(i);

        }

    }
    


    public void EqumentItem()
    {



    }

    //인벤토리의 기능 
    //인덱스를 사용해서 해당 슬롯에 접근할 것이다.
    void Awake()
    {
      scrollRect.verticalNormalizedPosition = 1f; // 스크롤 위치를 맨 위로 초기화  
    }

    void Start()
    {
        InitSlotList();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
