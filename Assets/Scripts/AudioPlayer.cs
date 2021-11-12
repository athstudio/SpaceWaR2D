using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    [Header("Shooting")]
    [SerializeField] AudioClip shootingClip;
    [SerializeField] [Range(0f, 1f)] float ShootingValume = 1f;

    [Header("Damage")]
    [SerializeField] AudioClip damageClip;
    [SerializeField] [Range(0f, 1f)] float damageValume = 1f;

    public void PlayShootingClip()
    {
       PlayClip(shootingClip, ShootingValume);
    }

    public void PlayDamageClip()
    {
        PlayClip(damageClip, damageValume);
    }

    void PlayClip(AudioClip clip, float valume)
    {
        if(clip != null)
        {
            Vector3 cameraPos = Camera.main.transform.position;
            AudioSource.PlayClipAtPoint(clip, cameraPos, valume);
        }
    }


}
