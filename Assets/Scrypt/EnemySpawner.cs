using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Transform _spawnPosition;
    [SerializeField] private GameObject _enemy;
    [SerializeField] private float _spawnTime;
    [SerializeField] private float _nextSpawnTime;
    
    [SerializeField] private int _maxEnemy = 3;
    private int _currentEnemyNum = 0;

    //private void Awake() => Invoke("SpawnEnemy", _spawnTime);

    private void Awake()
    {
        InvokeRepeating("SpawnEnemy", _spawnTime, _nextSpawnTime);
    }

    private void SpawnEnemy()
    {
        Instantiate(_enemy, transform.position, Quaternion.identity);
        _currentEnemyNum++;
        if (_currentEnemyNum >= _maxEnemy)
        {
            CancelInvoke("SpawnEnemy");
        }
    }



    //private void SpawnEnemy()
    //{
    //    //Instantiate(_enemy, transform.position, Quaterion.identity);  // из урока гиков.

    //    _spawnPosition = GameObject.FindGameObjectWithTag("Enemy").transform;
    //}

    //private void Instantiate(GameObject enemy, Vector3 position, object identity)
    //{
    //    throw new NotImplementedException();
    //}

}