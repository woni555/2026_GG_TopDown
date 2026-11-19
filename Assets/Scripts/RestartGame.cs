
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public void Restart()
    {
        Inventory.ResetKeys();
        SceneManager.LoadScene("Stage1");
    }
}
