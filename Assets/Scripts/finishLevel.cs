using UnityEngine;

public class finishLevel : MonoBehaviour
{
    public GameObject level;
    private void OnTriggerEnter(Collider other)
    {
        level.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
