using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    [SerializeField] private int borderDelta = 200;
    [SerializeField] private float speed = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.mousePosition.x >= Screen.width - borderDelta && transform.position.x <= 5)
        {
            transform.position += Vector3.right * Time.deltaTime * speed;
        }

        if (Input.mousePosition.x <= 0 + borderDelta && transform.position.x >= -5)
        {
            transform.position += Vector3.left * Time.deltaTime * speed;
        }

        if (Input.mousePosition.y >= Screen.height - borderDelta && transform.position.y <= 2)
        {
            transform.position += Vector3.up * Time.deltaTime * speed;
        }

        if (Input.mousePosition.y <= 0 + borderDelta && transform.position.y >= -2)
        {
            transform.position += Vector3.down * Time.deltaTime * speed;
        }
    }
}
