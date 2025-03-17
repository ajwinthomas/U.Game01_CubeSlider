using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Victory : MonoBehaviour
{
    public GameObject winningPanel;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Victory"))
        {

            if(winningPanel != null)
            {
                winningPanel.SetActive(true);
            }
            else
            {
                Debug.Log("Put the reference of winningPanel");
            }
        }
    }
}
