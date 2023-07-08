using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Operation") && this.gameObject.CompareTag("Enemy"))
        {
            Operations operations = new Operations();
            operations = other.GetComponent<Operations>();

            switch (operations.SelectOperation)
            {
                case Operations.Operation.Addition:
                    operations.AddPlayer(this.gameObject, operations.value);
                    break;

                case Operations.Operation.Multiplication:
                    operations.MultiplePlayer(this.gameObject, operations.value);
                    break;

                case Operations.Operation.Division:
                    Debug.Log("Bölme");
                    break;

                case Operations.Operation.Subtraction:
                    Debug.Log("Çıkarma");
                    break;

            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerTower"))
        {
            GameManager.instance.GetDamage("Player");
            Destroy(this.gameObject);
        }
    }
}
