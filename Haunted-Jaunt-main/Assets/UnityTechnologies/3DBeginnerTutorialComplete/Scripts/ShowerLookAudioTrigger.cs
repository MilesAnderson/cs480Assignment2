using UnityEngine;

public class ShowerLookAudioTrigger : MonoBehaviour
{
    public Transform player;
    public Transform lookTarget;
    public AudioSource showerAudio;

    [Header("Activation")]
    public float activateDistance = 6f;
    [Range(-1f, 1f)]
    public float activateFacingDot = 0.75f;

    [Header("Deactivation (Hysteresis)")]
    public float deactivateDistance = 7f;
    [Range(-1f, 1f)]
    public float deactivateFacingDot = 0.6f;

    bool m_IsPlaying;

    public bool HasTriggeredOnce { get; private set; }

    void Reset()
    {
        showerAudio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (player == null || showerAudio == null)
            return;

        Transform target = lookTarget != null ? lookTarget : transform;

        Vector3 toTarget = target.position - player.position;
        float distance = toTarget.magnitude;

        if (distance <= Mathf.Epsilon)
            return;

        Vector3 toTargetDirection = toTarget / distance;
        float facingDot = Vector3.Dot(player.forward, toTargetDirection);

        bool shouldActivate = distance <= activateDistance && facingDot >= activateFacingDot;
        bool shouldDeactivate = distance >= deactivateDistance || facingDot <= deactivateFacingDot;

        if (!m_IsPlaying && shouldActivate)
        {
            showerAudio.Play();
            m_IsPlaying = true;
            HasTriggeredOnce = true;
        }
        else if (m_IsPlaying && shouldDeactivate)
        {
            showerAudio.Stop();
            m_IsPlaying = false;
        }
    }
}
