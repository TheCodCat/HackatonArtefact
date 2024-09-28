using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Torch : Interactable
{
    float time = 0;
    [SerializeField] protected bool _isPlay;
    [SerializeField] protected ParticleSystem _particleSystem;
    [SerializeField] private float _intensivityLight;
    [SerializeField] protected Light _light;
    [SerializeField] private AnimationCurve _animationFire;
    [SerializeField] private AudioClip[] _audioClips;
    [SerializeField] private AudioSource _audioSource;
    public bool IsPlay => _isPlay;

    public override void Interaction()
    {
        _isPlay = !_isPlay;
		_audioSource.clip = _audioClips[Random.Range(0,_audioClips.Length)];
        _audioSource.pitch = Random.Range(0.95f,1); ;
        if (_isPlay)
        {
            _particleSystem.Play();
            StartCoroutine(LightNoise());
        }
        else
        {
            _particleSystem.Stop();
        }
        _light.gameObject.SetActive(_isPlay);
        _audioSource.Play();
    }

    IEnumerator LightNoise()
    {

        while (_isPlay)
        {
            _light.intensity = _animationFire.Evaluate(time) * _intensivityLight;

            time = (time + Time.deltaTime) % _animationFire.keys[_animationFire.keys.Length - 1].time;
            yield return null;
        }
    }
	private void OnDisable()
	{
        StopCoroutine(LightNoise());
	}
}
