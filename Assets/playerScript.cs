using UnityEngine;

public class playerScript : MonoBehaviour
{
    public float playerSpeed = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * playerSpeed * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * playerSpeed * Time.deltaTime);
        }
       
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * playerSpeed * Time.deltaTime);
        }
       
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * playerSpeed * Time.deltaTime);
        }
       
    }

    
    

    
}
