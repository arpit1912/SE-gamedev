using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Shaker : MonoBehaviour
{
    public static Shaker instance;
     Transform _target;

     Vector3 _initialpos;

     public float Intensity;
    // Start is called before the first frame update

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        //Intensity = 0.05f;
        _target = GetComponent<Transform>();
        _initialpos = _target.localPosition;
        
    }

    float _pendingDuration = 0f;

    public void Shake(float duration)
    {
        Debug.Log("The shaking should start");

        if (duration > 0)
        {
            _pendingDuration += duration;
            //_isShaking = true;
        }
    }

    bool _isShaking = false;
    // Update is called once per frame
    
    void Update()
    {
        
        if (_pendingDuration > 0 && !_isShaking)
        {
            StartCoroutine(DoShake());
        }
    }

    IEnumerator DoShake()
    {
       Debug.Log("thus is called");
        _isShaking = true;
        var startTime = Time.realtimeSinceStartup;
        while (Time.realtimeSinceStartup < startTime + _pendingDuration)
        {
            var randomPoint = new Vector3(Random.Range(-1f, 1f)*Intensity, Random.Range(-1f, 1f)*Intensity,0);
            _target.localPosition = randomPoint + _initialpos;
            yield return null;
        }
        _pendingDuration = 0f;
        _target.localPosition = _initialpos;
        _isShaking = false;
    }
}
