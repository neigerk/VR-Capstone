using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyStats : MonoBehaviour
{
     [SerializeField]
     private int maxHp;
     private int currentHp;

     public event Action<int, int> OnHpPctChanged = delegate { };

     private void Awake()
     {
          currentHp = maxHp;
     }

     private void Start()
     {
          ChangeCurrentHp(0);
     }

     // Update is called once per frame
     void Update()
     {
          
     }

     public void ChangeCurrentHp(int value)
     {
          currentHp += value;
          if (currentHp < 0)
          {
               currentHp = 0;
          }
          if (currentHp > maxHp)
          {
               currentHp = maxHp;
          }
          OnHpPctChanged(currentHp, maxHp);
     }
}
