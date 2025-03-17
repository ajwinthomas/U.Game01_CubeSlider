using TMPro;
using UnityEngine;


public class ScoreUpdater : MonoBehaviour
{
     public GameManager gameManager;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI GscoreUI;
    public TextMeshProUGUI WscoreUI;
    void Update()
    {
        gameManager.score = transform.position.z;
        UpdateScoreOnUI();
    }

    public void UpdateScoreOnUI ()
    {
       scoreText.text = "Score : " + Mathf.Floor(gameManager.score);
       GscoreUI.text = " " +Mathf.Floor(gameManager.score);
       WscoreUI.text = " " + Mathf.Floor(gameManager.score);
    }
}
