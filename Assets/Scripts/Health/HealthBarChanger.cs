using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarChanger : MonoBehaviour
{
    public Sprite[] sprites; // Array of sprites to cycle through
    public Sprite test;
    public Image healthbar;
    private int currentSpriteIndex = 0;
    private Image currentHealthBar;

    void Start()
    {
        healthbar.sprite = test;
    }
}
