using Unity.VisualScripting;
using UnityEngine;

public class debrisFloat : MonoBehaviour
{
    public float minSpeed = 0.5f;
    public float maxSpeed = 2f;
    public float rotationSpeed = 40;

    private Vector2 direction;
    private float speed;
    private Camera cam;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cam = Camera.main;
        direction = Random.insideUnitCircle.normalized;
        speed = Random.Range(minSpeed, maxSpeed);
        if (Random.value < 0.5f)
            rotationSpeed = -rotationSpeed;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime, Space.World);
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);

        WrapAroundScreen();
    }

    void WrapAroundScreen()
    {
        Vector3 pos = transform.position;
        Vector3 viewportPos = cam.WorldToViewportPoint(pos);
        if (viewportPos.x < 0) viewportPos.x = 1;
        if (viewportPos.y > 1) viewportPos.y = 0;

        if (viewportPos.y < 0) viewportPos.y = 1;
        if (viewportPos.y > 1) viewportPos.y = 0;

        transform.position = cam.ViewportToWorldPoint(viewportPos);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            DebrisCounter.instance.AddDebris();
            Destroy(gameObject);    
        }
        
    }
}
