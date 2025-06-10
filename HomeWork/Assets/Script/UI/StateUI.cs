using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StateUI : MonoBehaviour
{

    [SerializeField]
    ButtonHandler buttonHandler;

    [SerializeField]
    TextMeshProUGUI AttackText;
    [SerializeField]
    TextMeshProUGUI DefenseText;
    [SerializeField]
    TextMeshProUGUI MaxHpText;


    private void Awake()
    {
        buttonHandler.SetExtraAction(() => OnUpdateStateUI());
    }


    public void OnUpdateStateUI()
    {
        UpdateStateUIInfo();
    }

    private void UpdateStateUIInfo()
    {
        Character player = GameManager.instance.Player.GetPlayer();

        AttackText.text = player.CurAttack.ToString();
        DefenseText.text = player.CurDefense.ToString();
        MaxHpText.text = player.CurMaxHP.ToString();
        
    }


}
