using UnityEngine;

[RequireComponent(typeof(Collider))]
public class ClockPassbyAudioTrigger : MonoBehaviour
{
    public Transform player;
    public AudioSource clockAudio;
    public ShowerLookAudioTrigger prerequisiteShowerTrigger;

    [Tooltip("If true, this trigger only works after shower has been triggered once.")]
    public bool requireShowerFirst = true;

    [Tooltip("If true, sound only plays once for the whole run.")]
    public bool playOnlyOnce = true;

    bool m_HasPlayed;

    void Reset()
    {
        clockAudio = GetComponent<AudioSource>();

        Collider triggerCollider = GetComponent<Collider>();
        if (triggerCollider != null)
        {
            triggerCollider.isTrigger = true;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (player == null || clockAudio == null)
            return;

        if (other.transform != player)
            return;

        if (requireShowerFirst)
        {
            if (prerequisiteShowerTrigger == null || !prerequisiteShowerTrigger.HasTriggeredOnce)
                return;
        }

        if (playOnlyOnce && m_HasPlayed)
            return;

        clockAudio.Play();
        m_HasPlayed = true;
    }
}
