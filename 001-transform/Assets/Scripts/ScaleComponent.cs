using UnityEngine;

public class ScaleComponent : MonoBehaviour
{
    [SerializeField]
    private float scale_factor = 1.2f;

    // Update is called once per frame
    void Update()
    {
        Vector3 vec = transform.localScale * scale_factor; 

        // If the player presses the LMB we increase the scale
        if (Input.GetMouseButtonDown(0))
        {
            transform.localScale = vec;
        }

        // If the player presses the LMB we decrease the scale
        if (Input.GetMouseButtonDown(1))
        {
            // We check the distance to check if the scale it's not 1 unit away
            // The player does decrease after a certain point
            if (!((transform.localScale - vec).sqrMagnitude <= 1f))
            {
                transform.localScale -= vec;
            }
        }
    }
}
