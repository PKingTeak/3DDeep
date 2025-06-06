using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{

    [SerializeField] private int index;
    [SerializeField] private ItemData itemData;

    public void InitSlot(int _index)
    {
        index = _index;


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
