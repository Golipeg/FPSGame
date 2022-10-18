using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoving : MonoBehaviour
{
   private Transform _heroTransform;

   private void Start()
   {
      _heroTransform = FindObjectOfType<PlayerMain>().transform;// ищем нашего героя, обращая к его трансформу 
   }
/// <summary>
/// Данный метод задаёт ротацию по отношению к нашему герою. Т.е. наш враг всегда будет двигаться лицом к нашему герою. 
/// </summary>
   private void EnemyRotation()
   {
       Quaternion targetRotation;
       var direction = _heroTransform.position - transform.position;
       direction.y = 0;
       targetRotation=Quaternion.LookRotation(direction);//задаем ротацию по направлению к герою( идём лицом к герою). 
       transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 3 * Time.deltaTime);
   }

   private void Update()
   {
       EnemyRotation();
       transform.position = Vector3.MoveTowards(transform.position, _heroTransform.position, 2 * Time.deltaTime);//двигаемся к нашему герою
   }
}
