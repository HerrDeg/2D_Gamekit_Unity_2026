using System;
using UnityEngine;

public class AudioWaterDropCollision : MonoBehaviour
{
    
    public ParticleSystem waterParticle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnParticleCollision(GameObject other)
    {
        Debug.Log("Water Collision");
    }
}
