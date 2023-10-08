using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Stone : MonoBehaviour
{
    public Route currentRoute;

    int routePosition = 0;

    public int steps;

    bool isMoving;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isMoving)
        {
            steps = Random.Range(1, 11);
            Debug.Log("Number Spun: " + steps);

            if (routePosition + steps < currentRoute.childNodeList.Count)
            {
                StartCoroutine(Move());
            }
            else
            {
                Debug.Log("Congratulations! You are retired.");
            }
        }
    }

    IEnumerator Move()
    {
        if (isMoving)
        {
            yield break;
        }
        isMoving = true;

        while (steps > 0)
        {
            Vector3 nextPos = currentRoute.childNodeList[routePosition + 1].position;
            while (MoveToNextNode(nextPos)) { yield return null; }

            yield return new WaitForSeconds(0.1f);
            steps--;
            routePosition++;
        }

        isMoving = false;
    }

    bool MoveToNextNode(Vector3 goal)
    {
        return goal != (transform.position = Vector3.MoveTowards(transform.position, goal, 2f * Time.deltaTime));
    }
}