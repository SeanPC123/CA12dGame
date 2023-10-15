using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Health playerHealth;
    [SerializeField] private Image HBTotal;
    [SerializeField] private Image HBCurrent;

    private void start()
    {
        HBTotal.fillAmount = playerHealth.currentHealth / 10;
    }

    private void update()
    {
        HBCurrent.fillAmount = playerHealth.currentHealth /10;
    }

}
