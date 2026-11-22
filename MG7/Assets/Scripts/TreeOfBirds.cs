using UnityEngine;

// Step 1: write the TreeOfBirds class in this file!
public class TreeOfBirds : MonoBehaviour
{
    [SerializeField] private GameObject[] sparrows;
    [SerializeField] private float interactionDistance;
    [SerializeField] private Transform player;
    
    private void Update()
    {
        for(int i = 0; i < sparrows.Length; i++)
        {
            float distance = Vector3.Distance(player.position, transform.position);
            if(distance < interactionDistance)
            {
                sparrows[i].SetActive(true);
            }
        }
    }
}