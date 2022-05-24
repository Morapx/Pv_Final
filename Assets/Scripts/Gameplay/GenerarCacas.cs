using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerarCacas : MonoBehaviour
{
    public GameObject caCa;
    public int xPos;
    public int zPos;
    public int cantidadCacas;

    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop()
    {
        while (cantidadCacas < 10)
        {
          xPos = Random.Range(633, 661);
          zPos = Random.Range(414, 460);
          Instantiate(caCa, new Vector3(xPos, -4, zPos), Quaternion.identity);
          yield return new WaitForSeconds(0.1f);
          cantidadCacas += 1;
        }
    }

}
