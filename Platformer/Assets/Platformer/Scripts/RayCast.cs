using System;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class RayCast : MonoBehaviour
{
    [SerializeField] private Camera rayCamera;
    [SerializeField] private TextMeshProUGUI coinText;
    
    [SerializeField] private Transform pointerSphere;
    
    private static int _totalCoins = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CoinBlock.CoinCollected += CoinBlockOnCoinCollected;
    }

    private void CoinBlockOnCoinCollected(object sender, EventArgs e)
    {
        _totalCoins++;
        coinText.text = "X"+ _totalCoins.ToString("D2");
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 mousePosition = Mouse.current.position.value;
        Ray screenRay = rayCamera.ScreenPointToRay(mousePosition);
        if (Physics.Raycast(screenRay, out RaycastHit screenHitInfo))
        {
            if (Mouse.current.leftButton.wasPressedThisFrame)
            {
                pointerSphere.position = screenHitInfo.point;
            }
        }
    
    
    }
}
