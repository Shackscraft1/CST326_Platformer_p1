using System;
using UnityEngine;

public class CoinBlock : MonoBehaviour
{
    
    
    public static event EventHandler CoinCollected;

    private void OnTriggerEnter(Collider other)
    {
        
       
        if (other.TryGetComponent<RayCast>(out var coinBox))
        {
            CoinCollected?.Invoke(this, EventArgs.Empty);
            
            
        }
    }
}
