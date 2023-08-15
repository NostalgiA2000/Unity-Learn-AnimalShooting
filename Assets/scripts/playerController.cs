using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    public float horizontalInput;
    public float speed = 10.0f;
    public float leftBoundary = -20.0f;
    public float rightBoundary = 20.0f;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (transform.position.x < leftBoundary) {

            transform.position = new Vector3(leftBoundary , transform.position.y , transform.position.z);
        
        }

        if (transform.position.x > rightBoundary)
        {

            transform.position = new Vector3(rightBoundary, transform.position.y, transform.position.z);

        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

    }
}
