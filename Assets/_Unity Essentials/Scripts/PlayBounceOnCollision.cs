using NUnit.Framework.Constraints;
using UnityEngine;

public class PlayBounceOnCollision : MonoBehaviour
{
    private AudioSource bounceSfx;
    public float impactThreshold = 1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bounceSfx = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (!bounceSfx.isPlaying && collision.relativeVelocity.magnitude > impactThreshold)
        {
            bounceSfx.Play();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
