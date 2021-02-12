using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class EnergyBar : MonoBehaviour
{
     [SerializeField]
     public TextMesh text;
     [SerializeField]
     private Image foregroundImage;
     [SerializeField]
     private float updateSpeedSeconds = 0.5f;


     private void Awake()
     {
          GetComponentInParent<PlayerStats>().OnEnergyPctChanged += HandleEnergyChanged;
     }

     private void HandleEnergyChanged(int current, int max)
     {
          float pct = (float)current / (float)max;
          text.text = current.ToString() + " / " + max.ToString();
          StartCoroutine(ChangeToPct(pct));
     }

     private IEnumerator ChangeToPct(float pct)
     {
          float preChangePct = foregroundImage.fillAmount;
          float elapsed = 0f;

          while (elapsed < updateSpeedSeconds)
          {
               elapsed += Time.deltaTime;
               foregroundImage.fillAmount = Mathf.Lerp(preChangePct, pct, elapsed / updateSpeedSeconds);
               yield return null;
          }

          foregroundImage.fillAmount = pct;
     }

     // Start is called before the first frame update
     void Start()
     {
          float pct = (float)GetComponentInParent<PlayerStats>().GetCurrentEnergy() / (float)GetComponentInParent<PlayerStats>().GetMaxEnergy();
          foregroundImage.fillAmount = pct;
     }

     // Update is called once per frame
     void Update()
     {

     }
}
