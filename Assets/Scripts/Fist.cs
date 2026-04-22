using UnityEngine;

public class Fist : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("enemy"))
        {
            collider.GetComponent<Enemy>().isHit();
        }
    }
}
