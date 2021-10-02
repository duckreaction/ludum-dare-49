using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSound : MonoBehaviour
{
    [SerializeField]
    float _velocityMaxVolume = 5f;

    Rigidbody _rigidbody;
    public new Rigidbody rigidbody
    {
        get
        {
            if (_rigidbody == null)
            {
                _rigidbody = GetComponent<Rigidbody>();
            }
            return _rigidbody;
        }
    }

    AudioSource _audioSource;
    public AudioSource audioSource
    {
        get
        {
            if (_audioSource == null)
            {
                _audioSource = GetComponent<AudioSource>();
            }
            return _audioSource;
        }
    }

    public void Update()
    {
        audioSource.volume = Mathf.Lerp(0, 1, rigidbody.velocity.magnitude / _velocityMaxVolume);
    }
}