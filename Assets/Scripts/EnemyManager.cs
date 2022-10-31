using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] private int _enemyCount;// кол-во врагов
    [SerializeField] private EnemyBehaviour _enemyPrefab;// наш враг 
    private Vector3 _currentPosition;// позиция , в которой появляться наш враг
    void Start()
    {
        for (int i = 0; i < _enemyCount; i++)
        {
            var enemy = Instantiate(_enemyPrefab);
            RandomPosition(enemy.transform);
            enemy.transform.rotation=Quaternion.identity;//ротация в нулях  т.е. обьект появляется
            
        }
        GameEvents.Instance.OnEnemyInit?.Invoke(_enemyCount);
    }
    
    private void RandomPosition(Transform enemyTransform)
    {
        _currentPosition = new Vector3(Random.Range(-19f, 19f), 1.69f, Random.Range(-19f, 19f));
        enemyTransform.position = _currentPosition;
    }
    
}
