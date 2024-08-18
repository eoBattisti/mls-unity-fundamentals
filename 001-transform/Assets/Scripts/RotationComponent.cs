using UnityEngine;

public class RotationComponent : MonoBehaviour
{

    [SerializeField]
    private float speed = 0;

    // Update is called once per frame
    void Update()
    {
        // Create a empty Vector3 object
        Vector3 vec = Vector3.zero;

        // Set the Z axis based on the speed and delta time
        vec.z = speed * Time.deltaTime;

        // If the player press the Q, we will rotate the player anticlockwise
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(vec);
        }

        // If the player press the E, we will rotate the player clockwise
        if (Input.GetKey(KeyCode.E))
        {
            // Set the Z index to be negative
            vec.z *= -1;
            transform.Rotate(vec);
        }
    }
}
