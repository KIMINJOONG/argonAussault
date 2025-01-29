using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        // float horizontalThrow = movement.ReadValue<Vector2>().x;
        // float verticalThrow = movement.ReadValue<Vector2>().y;
        // Debug.Log(horizontalThrow);
        // Debug.Log(verticalThrow);

        float xThrow = Input.GetAxis("Horizontal");
        float yThrow = Input.GetAxis("Vertical");

        float xOffset = .1f;
        float newXPos = transform.localPosition.x + xOffset;
        transform.localPosition = new Vector3(newXPos, transform.localPosition.y, transform.localPosition.z);
    }
}
