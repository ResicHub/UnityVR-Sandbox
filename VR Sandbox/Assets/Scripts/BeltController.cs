using UnityEngine;

public class BeltController : MonoBehaviour
{
    private Rigidbody myRigidbody;
    private float speed = 0.5f;
    private Vector3 starttPosition;
    private bool isMoving = true;

    private void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        starttPosition = myRigidbody.position;
    }

    private void FixedUpdate()
    {
        if (isMoving)
        {
            myRigidbody.position += Vector3.left * speed * Time.fixedDeltaTime;
            myRigidbody.MovePosition(starttPosition);
        }
    }

    public void SetSpeed(float value)
    {
        speed = value;
    }

    public void SetMovement(bool value)
    {
        isMoving = value;
    }
}