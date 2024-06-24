using System;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class uiManager : MonoBehaviour
{
    private int health;
    //public int maxHealth;
    public Image healthBar;
    public Sprite[] healthLevels;
    public TextMeshProUGUI healthText;
    public HealthManager healthManager;

    private void Start()
    {
        /*Array.Reverse(healthLevels);
        healthManager = GetComponent<HealthManager>();

        if (healthManager == null)
        {
            Debug.Log("FUUUUCK");
        }*/
    }

    public void UpdateHealthIndicator(int health)
    {
        /*float normalizedHealth = (float)health / maxHealth;
        int spriteIndex = Mathf.FloorToInt(normalizedHealth * (healthLevels.Length - 1));

        healthBar.sprite = healthLevels[spriteIndex];
        */
        if (healthManager != null)
        {
            healthText.text = healthManager.CurrentHealth.ToString();
        }
        else
        {
            //Debug.LogWarning("healthManager is not assigned!");
        }
    }

    private void Update()
    {
        UpdateHealthIndicator(health);
    }
}
