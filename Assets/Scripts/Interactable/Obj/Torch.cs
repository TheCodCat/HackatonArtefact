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
    public bool IsPlay => _isPlay;

    public override void Interaction()
    {
        _isPlay = !_isPlay;
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
