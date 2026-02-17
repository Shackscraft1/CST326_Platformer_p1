using UnityEngine;
public class BreakBrick : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        
        
        if (other.TryGetComponent<RayCast>(out var brick))
        {
            //play animation
           Destroy(gameObject);
           
        }
    }
}
