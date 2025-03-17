using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverPanel;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            if(gameOverPanel != null)
            {
                gameOverPanel.SetActive(true);
            }
            else
            {
                Debug.Log("Put the  gameover panel for reference ");
            }
        }
    }
}
