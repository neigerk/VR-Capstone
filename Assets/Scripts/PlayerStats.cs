using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerStats : MonoBehaviour
{
     public TextMesh textHp;
     public TextMesh textEnergy;

     [SerializeField]
     private int maxHp;
     public int currentHp;

     [SerializeField]
     private int maxEnergy;
     private int currentEnergy;

     public event Action<int, int> OnHpPctChanged = delegate { };
     public event Action<int, int> OnEnergyPctChanged = delegate { };

    [SerializeField]
    FlashImage _flashImage = null;

    private void Awake()
     {
          currentHp = maxHp;
          currentEnergy = maxEnergy / 2;
     }

     // Start is called before the first frame update
     void Start()
    {
          ChangeCurrentEnergy(0);
          ChangeCurrentHP(0);
    }

    // Update is called once per frame
    void Update()
    {
          //SetHPText();
          //SetEnergyText();
          if (Input.GetKeyDown(KeyCode.LeftControl))
               ChangeCurrentHP(-10);
          if (Input.GetKeyDown(KeyCode.LeftAlt))
               ChangeCurrentEnergy(-10);
     }

     //TEXT FUNCTIONS
     void SetHPText()
     {
          textHp.text = currentHp.ToString() + " / " + maxHp.ToString();
     }

     void SetEnergyText()
     {
          textEnergy.text = currentEnergy.ToString() + " / " + maxEnergy.ToString();
     }

     //PUBLIC GETTERS AND SETTERS
     public int GetCurrentHP()
     {
          return currentHp;
     }
     public int GetMaxHP()
     {
          return maxHp;
     }
     public int GetCurrentEnergy()
     {
          return currentEnergy;
     }
     public int GetMaxEnergy()
     {
          return maxEnergy;
     }
     public void SetCurrentHP(int value)
     {
          currentHp = value;
     }
     public void SetCurrentEnergy(int value)
     {
          currentEnergy = value;
     }
     public void ChangeCurrentHP(int value)
     {
          if (value < 0)
          {
               _flashImage.StartFlash(.25f, .5f, Color.red);
          }
          currentHp = currentHp + value;
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
     public void ChangeCurrentEnergy(int value)
     {
          currentEnergy = currentEnergy + value;
          if(currentEnergy < 0)
          {
               currentEnergy = 0;
          }
          if(currentEnergy > maxEnergy)
          {
               currentEnergy = maxEnergy;
          }

          OnEnergyPctChanged(currentEnergy, maxEnergy);
     }

}
