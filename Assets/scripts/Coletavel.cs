using UnityEngine;

public class Coletavel : MonoBehaviour
{
    public bool hasJumpUpgrade;
    public bool hasInvincibility;
    private MOVIMENTO movimento;

    private void Start()
    {
        movimento = GetComponent<MOVIMENTO>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Crystal"))
        {

            Destroy(other.gameObject);
        }


        else if (other.CompareTag("Jump"))
        {
            hasJumpUpgrade = true;
            Destroy(other.gameObject);
        }

        else if (other.CompareTag("Invincibility"))
        {
            hasInvincibility = true;
        }
    }
}
