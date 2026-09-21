using UnityEngine;

public class Toggle : MonoBehaviour // T는 대문자로 유지하는 것이 좋습니다!
{
    [Header("UI 창들 (0: 인벤토리, 1: 스킬, 2: 랭크 순서)")]
    public GameObject[] uiPanels;

    public void ToggleInventory()
    {
        TogglePanel(0);
    }

    public void ToggleSkill()
    {
        TogglePanel(1);
    }

    public void ToggleRank()
    {
        TogglePanel(2);
    }

    private void TogglePanel(int index)
    {
        if (index >= 0 && index < uiPanels.Length)
        {
            if (uiPanels[index] != null)
            {
                bool isActive = uiPanels[index].activeSelf;
                uiPanels[index].SetActive(!isActive);
            }
        }
    }
}