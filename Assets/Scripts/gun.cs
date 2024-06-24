using UnityEngine;

public class gun : MonoBehaviour
{
    public float damage = 20f;
    public float range = 15f;
    
    public float gunShotRadius = 5f;
    public LayerMask enemyLayerMask;

    public Camera playerCam;
    void Update()
    {
        if (!PauseMenu.isPaused)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Shoot();
            }
        }
    }

    void Shoot()
    {
        
        //shot radius
        Collider[] enemyColliders;
        enemyColliders = Physics.OverlapSphere(transform.position, gunShotRadius, enemyLayerMask);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        
        //
        foreach (var enemyCollider in enemyColliders)
        {
            enemyCollider.GetComponent<EnemyAwareness>().isAggro = true;
        }
        
        RaycastHit hit;
        if (Physics.Raycast(playerCam.transform.position, playerCam.transform.forward, out hit, range))
        {
           Debug.Log(hit.transform.name); 
           
           imp target = hit.transform.GetComponent<imp>();
           if (target != null)
           {
               target.TakeDamage(damage);
           }
        }
    }
    
    void OnDrawGizmosSelected()
    {
        // Draw a yellow sphere at the transform's position
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(transform.position, 5);
    }
}
