using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointMover : MonoBehaviour
{
    // Start is called before the first frame update

    float posX;
    float posY;
    float posZ;

    void Start()
    {
        StartCoroutine(movePointsX());

        posX = transform.position.x;
        posY = transform.position.y;
        posZ = transform.position.z;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator movePointsX()
    {
        while (true)
        {

        yield return new WaitForSeconds(3f);

            transform.DOMove(new Vector3(posX + 30, posY, posZ),2);

            yield return new WaitForSeconds(3f);

            transform.DOMove(new Vector3(posX-30, posY, posZ), 2);

        }

    }

}
