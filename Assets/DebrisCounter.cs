using UnityEngine;

public class DebrisCounter : MonoBehaviour
{
    public static DebrisCounter instance;
    public int collected = 0;
    public int required = 5;

    public GameObject portal;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Awake()
    {

        instance = this;
        portal.SetActive(false);

        
    }
    public void AddDebris()
    {
        collected++;
        if (collected >= required)
        {
            portal.SetActive(true);
        }
    }
}
