using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyUI : MonoBehaviour
{
    [SerializeField] private RawImage _image;
    [SerializeField] private int _enemyCount;
    private List<RawImage> _rawImages = new List<RawImage>();

    private void UpdateRowImage()
    {
        if (_rawImages.Count > 0)
        {
            Destroy(_rawImages[_rawImages.Count - 1]);
            _rawImages.RemoveAt(_rawImages.Count - 1);
        }
    }

    private void StartInitializingEnemies(int count)
    {
        for (int i = 0; i < count; i++)
        {
            RawImage rawImage = Instantiate(_image, transform);
            _rawImages.Add(rawImage);
        }

        Debug.Log(_rawImages.Count);
    }

    private void OnEnable()
    {
        GameEvents.Instance.OnEnemyInit += StartInitializingEnemies;
        GameEvents.Instance.OnUpdateEnemyUI += UpdateRowImage;
    }

    private void OnDisable()
    {
        GameEvents.Instance.OnEnemyInit -= StartInitializingEnemies;
        GameEvents.Instance.OnUpdateEnemyUI -= UpdateRowImage;
    }
}