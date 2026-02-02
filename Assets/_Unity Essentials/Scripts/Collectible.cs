using UnityEngine;

public class Collectible : MonoBehaviour
//MonoBehaviour is a required class for all GameObjects in Unity.
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float rotationSpeed = 0.5f;
    public GameObject onCollectEffect;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationSpeed, 0, Space.World);
    }
    private void OnTriggerEnter(Collider other)
    {

        //Dystroy the collctible

        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            Instantiate(onCollectEffect, transform.position, transform.rotation);
        }

    }
}
