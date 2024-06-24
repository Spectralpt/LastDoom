using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    // Define the health changed event and handler delegate.
    public delegate void HealthChangedHandler(object source, float newHealth);
    public static event HealthChangedHandler OnHealthChanged;
    public GameObject gameOver;
         
    // Show in inspector
    [SerializeField]
    float currentHealth;
    // Allow other scripts a readonly property to access current health
    public float CurrentHealth => currentHealth;

    [SerializeField] 
    private float maxHealth;

    [SerializeField]
    private float startingHealth;
    
    // test values
    [SerializeField]
    float testHealAmount = 5f;
    [SerializeField]
    float testDamageAmount = -5f;
    
    
    private void Start()
    {
        currentHealth = startingHealth;
    }

    public void ChangeHealth(float amount) {
        currentHealth += amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
         
        // Fire off health change event.
        //OnHealthChanged?.Invoke(this, currentHealth);
    }
         
    // Test code
   void Update() {
        if (Input.GetKeyDown(KeyCode.Q)) {
            ChangeHealth(testHealAmount);
        }
        if (Input.GetKeyDown(KeyCode.E)) {
            ChangeHealth(testDamageAmount);
        }
        ShouldPLayerDie();
   }

   public void ShouldPLayerDie()
   {
       if (currentHealth <= 0)
       {
           gameOver.SetActive(true);
           Cursor.lockState = CursorLockMode.None;
           Cursor.visible = true;
       }
   }
}
