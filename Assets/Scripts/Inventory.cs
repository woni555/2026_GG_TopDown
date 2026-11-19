
using UnityEngine;
using TMPro;

public class Inventory : MonoBehaviour
{
    public static int keys = 0;

    public TMP_Text keyText;

    // 게임을 새로 실행할 때 열쇠 초기화
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
    private static void ResetKeysOnPlay()
    {
        keys = 0;
    }

    // 화면에 열쇠 개수 표시
    private void Start()
    {
        UpdateKeyText();
    }

    // 열쇠 획득
    public void AddKey()
    {
        keys++;
        UpdateKeyText();
    }

    // 열쇠 개수 표시 갱신
    private void UpdateKeyText()
    {
        if (keyText != null)
        {
            keyText.text = "열쇠 " + keys;
        }
    }

    // 필요할 때 열쇠 초기화
    public static void ResetKeys()
    {
        keys = 0;
    }
}
