using UnityEngine;

public class Chair : MonoBehaviour
{
    public GameObject E;
    public bool inRange;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inRange = false;
        E.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            E.SetActive(true);
            inRange = true;
        }
    }    
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            E.SetActive(false);
            inRange = false;
        }
    }
}
