using UnityEngine;
using System.Collections;


public class Respawn : MonoBehaviour 
{

 void OnTriggerEnter(Collider other)
 {
     Application.LoadLevel("Cave");
 }
}
