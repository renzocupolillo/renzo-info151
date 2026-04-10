using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroilixo : MonoBehaviour
{
private void OnCollisionEnter (Collision collision) {
// Optional: Check if the entering object is the Player
if (collision.gameObject.CompareTag("lixo")) {
Destroy(collision.gameObject);
}
}
}
