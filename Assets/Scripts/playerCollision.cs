using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public playerMovement movement;

    void OnCollisionEnter(Collision colInfo) {
        
        if (colInfo.collider.tag == "Obstacle")    {
            GetComponent<playerMovement>().enabled = false;
            FindObjectOfType<gameManager>().EndGame();
        }
        //I should actually go back and make sure the references in the other scripts use this to find
        //Any information related to the player in case of deleting the player
    }
}
