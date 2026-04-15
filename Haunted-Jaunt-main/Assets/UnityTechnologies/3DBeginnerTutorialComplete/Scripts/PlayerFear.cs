using UnityEngine;

public class PlayerFear : MonoBehaviour
{
    public Transform[] enemies;
    public ParticleSystem sweatParticles;

    public float maxDistance = 10f;
    public float minDistance = 2f;

    private ParticleSystem.EmissionModule emission;

    void Start()
    {
        emission = sweatParticles.emission;
    }

    void Update()
    {
        float closestDistance = Mathf.Infinity;

        foreach (Transform enemy in enemies)
        {
            float dist = Vector3.Distance(transform.position, enemy.position);
            if(dist < closestDistance)
            {
                closestDistance = dist;
            }
        }

        float t = Mathf.InverseLerp(maxDistance, minDistance, closestDistance);

        float emissionRate = Mathf.Lerp(0f, 200f, t);
        emission.rateOverTime = emissionRate;

        if(t > 0.1f && !sweatParticles.isPlaying)
        {
            sweatParticles.Play();
        }
        else if(t <= 0.1f && sweatParticles.isPlaying)
        {
            sweatParticles.Stop();
        }
    }
}
