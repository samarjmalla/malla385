using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 10f;
    public float rotationSpeed = 70f; // Add a variable for rotation speed

    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey("w"))
        {
            pos.y += speed * Time.deltaTime;
        }

        if (Input.GetKey("s"))
        {
            pos.y -= speed * Time.deltaTime;
        }

        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;
           transform.Rotate(Vector3.back * rotationSpeed * Time.deltaTime);

        }

        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
            // Rotate the object constantly to the left when "a" key is pressed
            transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
        }

        transform.position = pos;
    }
}
