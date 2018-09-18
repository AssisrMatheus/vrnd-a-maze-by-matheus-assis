using System.Collections;
using UnityEngine;

public class Coin : SpinningObject
{
    public GameObject coinPoofPrefab;
    
    public void OnCoinClicked()
    {
        if (coinPoofPrefab != null)
        {
            Instantiate(coinPoofPrefab, this.transform.position, coinPoofPrefab.transform.rotation);
        }

        DestroyAfterSeconds(0.02f, this.gameObject);
    }
}
