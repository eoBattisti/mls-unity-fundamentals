using UnityEngine;

public class MovementComponent : MonoBehaviour
{
    // Update is called once per frame
    [SerializeField]
    private float speed = 0;

    void Update()
    {
        // Get both the default movement for the X/Y axis speed based on the set speed and delta time
        float direction = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        // Move the player to the given X/Y direction
        transform.Translate(new Vector3(direction, vertical, 0f));
    }
}
