using UnityEngine;

public class PlayKnockOnCollapse : MonoBehaviour
{
    private AudioSource knockSfx;
    public float impactThreshold = 1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        knockSfx = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.relativeVelocity.magnitude > impactThreshold)
        {
            knockSfx.Play();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
