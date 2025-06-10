using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//인벤토리 정보가 넘어오면 해당 인벤토리를 진짜 화면에 표시만 해주는 느낌으로 사용
//OnEnable될때마다 아이템 정보를 갱신해야하는건가?
public class InventoryUI : MonoBehaviour
{

    [SerializeField]
    private List<Slot> slots = new List<Slot>();

    [SerializeField] private ButtonHandler buttonHandler;
    [SerializeField] private ScrollRect scrollRect;
    [SerializeField] private Player player;

   

    public void DisPlayItem(Dictionary<int, Item> itemDic)
    {



        for (int i = 0; i < slots.Count; i++)
        {
            if (itemDic.TryGetValue(i, out Item item))
            {

                if (item.GetItemData() == null)
                {

                    return;
                }
                slots[i].SetItemData(item); //아이템 데이터 넣어주기

            }
            else
            {
                slots[i].ClearSlot();
            }

         }
       
    }

    private void InitSlotList()
    {
        for (int i = 0; i < slots.Count; i++)
        {
            slots[i].InitSlot(i);

        }

    }


    public void OnUpdateInventoryUI()
    {
        UpdateInventroyUI();
    }


    private void UpdateInventroyUI()
    {
        Debug.Log("인벤토리 업데이트 시작");
        DisPlayItem(player.Inventory.GetAllItems());
    }


    //인벤토리의 기능 
    //인덱스를 사용해서 해당 슬롯에 접근할 것이다.
    void Awake()
    {
        scrollRect.verticalNormalizedPosition = 1f; // 스크롤 위치를 맨 위로 초기화 
        buttonHandler.SetExtraAction(() => OnUpdateInventoryUI()); //업데이트 인벤토리 UI갱신 
        
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
