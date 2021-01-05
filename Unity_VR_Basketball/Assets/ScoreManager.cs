
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [Header("分數介面")]
    public Text textScore;
    [Header("分數")]
    public int Score;
    [Header("投進的分數")]
    public int ScoreIn;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "籃球"&& other.transform.position.y > 2.5f)
        {
            AddScore();
        }

        if (other.transform.root.name == "Player") 
        {
            ScoreIn = 3;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.root.name == "Player") 
        {
            ScoreIn = 2;
        }
    }

    private void AddScore()
    {
        Score += ScoreIn;
        textScore.text = "分數"+Score;
    }
}
