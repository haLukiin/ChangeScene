using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class alienScript : MonoBehaviour
{
    public float alienSpeed = 1.0f;

    public GameObject AdvicePopup;
    
    public TMP_Text adviceText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

            GiveAdvice("Be carefull out there, human!");
            



        }
    }
    void GiveAdvice(string message)
    {
        adviceText.text = message;  
        AdvicePopup.SetActive(true);    
    }

  
}