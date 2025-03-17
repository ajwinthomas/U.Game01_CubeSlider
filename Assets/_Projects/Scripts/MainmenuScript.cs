using UnityEngine;
using UnityEngine.UI;

public class MainmenuScript : MonoBehaviour
{
    public Button playButton;
    private void Start()
    {
        playButton.onClick.AddListener(StartGame);
    }

    public void StartGame()
    {
        GameManager.instance.LoadLevelOne();
    }
}
