using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectable"))
        {

            Collect(other.GetComponent<Collectible>());

        }
    }

    private void Collect(Collectible collectible)
    {
      if(collectible.Collect()){
            if (collectible is WineGumCollectible)
            {
                Debug.Log("Wine Gum collect");




            }
        }


    }
}
