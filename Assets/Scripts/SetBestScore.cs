using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SetBestScore : MonoBehaviour
{
    private void Start()
    {
        var highScore = PlayerPrefs.GetInt("HighScore", 0);
        var highScorePlayerName = PlayerPrefs.GetString("HighScorePlayerName", "Anonymous");
        string scoreText = $"Best Score : {highScorePlayerName} : {highScore}";
        GetComponent<Text>().text = scoreText;
    }
}
