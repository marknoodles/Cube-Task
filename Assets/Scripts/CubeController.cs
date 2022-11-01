using UnityEngine;

public class CubeController : MonoBehaviour
{
    public static int movingSpeed;

    public static float cubeDestination;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (rb.position.x >= -cubeDestination)
        {
            rb.velocity =
                new Vector3(-movingSpeed, rb.velocity.y, rb.velocity.z);
        }
        else
        {
            Destroy (gameObject);
        }
    }
}
