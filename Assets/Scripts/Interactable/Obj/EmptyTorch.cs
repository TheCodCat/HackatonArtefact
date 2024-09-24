using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmtyTorch : Interactable
{
    float time = 0;
    [SerializeField] private ParticleSystem _particleSystem;
    [SerializeField] private float _intensivityLight;
    [SerializeField] private Light _light;
    [SerializeField] private bool _isPlay;
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
        Altar.OnActive?.Invoke();
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
}
