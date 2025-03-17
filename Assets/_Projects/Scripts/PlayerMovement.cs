using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField]
    private float sideSpeed;
    [SerializeField]
    private float forwardSpeed;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        Debug.DrawRay(transform.position, rb.linearVelocity, Color.red);
    }

    void FixedUpdate()
    {
        MovePlayer();
    }

    public void MovePlayer()
    {
        MovePlayerForward();
        MovePlayerSide();
    }
    public void MovePlayerForward()
    {
        rb.AddForce(0,0,forwardSpeed * Time.deltaTime);
    }

    public void MovePlayerSide()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(sideSpeed * Time.deltaTime, 0, 0, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-sideSpeed * Time.deltaTime, 0, 0, ForceMode.Force);
        }
    }

}
