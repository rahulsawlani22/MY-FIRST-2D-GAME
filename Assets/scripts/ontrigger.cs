using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ontrigger : MonoBehaviour
{
    public gamemanager gameManager;
   void OnTriggerEnter ()
   {
       gameManager.CompleteLevel();
   }
   

}
