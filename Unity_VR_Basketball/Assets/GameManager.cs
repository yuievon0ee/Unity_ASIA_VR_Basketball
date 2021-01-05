using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    /// <summary>
    /// 重新遊戲
    /// </summary>
   public void RestartGame()
    {
        SceneManager.LoadScene("籃球機");
    }

    /// <summary>
    /// 離開遊戲
    /// </summary>
    public void QuitGame()
    {
        Application.Quit();
    }
}
