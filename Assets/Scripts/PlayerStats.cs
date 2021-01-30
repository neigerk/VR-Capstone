using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
     public TextMesh textHp;
     public TextMesh textEnergy;
     private int maxHp;
     private int currentHp;
     private int maxEnergy;
     private int currentEnergy;

     // Start is called before the first frame update
     void Start()
    {
          maxHp = 100;
          currentHp = maxHp;
          maxEnergy = 100;
          currentEnergy = 50;
          SetHPText();
          SetEnergyText();
    }

    // Update is called once per frame
    void Update()
    {
          SetHPText();
          SetEnergyText();
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
          currentHp = currentHp + value;
     }
     public void ChangeCurrentEnergy(int value)
     {
          currentEnergy = currentEnergy + value;
     }

}
