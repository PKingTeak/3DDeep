using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfoUI : MonoBehaviour
{


    [SerializeField]
    TextMeshProUGUI playerName;
    [SerializeField]
    TextMeshProUGUI playerLevel;
    [SerializeField]
    TextMeshProUGUI expRatioText;
    [SerializeField]
    Image expBar;

    private void Start()
    {
        
      
    }
    

    private void OnDestroy()
    {
        if (GameManager.instance.Player?.GetPlayer() != null)
        {
            GameManager.instance.Player.GetPlayer().ExpUpdate -= OnUpdateInfoUI;
        }
    }

    public void BindPlayer(Character character)
    {
        character.ExpUpdate += OnUpdateInfoUI;
        UpdatePlayerInfo();

    }

    public void OnUpdateInfoUI()
    {
        UpdatePlayerInfo();
    }
 
    public void UpdatePlayerInfo()
    {
     
        Character playerData = GameManager.instance.Player.GetPlayer();
        playerName.text = playerData.Name;
        playerLevel.text = $"Lv : {playerData.Level}";
        expBar.fillAmount = playerData.GetCurLevelRatio();
        expRatioText.text = $"{playerData.CurExp} / {playerData.MaxExp}";



    }


}
