//using TMPro;
//using UnityEngine;

//public class Coletavel : MonoBehaviour
//{
//    public TextMeshProUGUI Cristal;
//    public int Count;
//    private PlayerPrefs playerObject;

//    private void Start()
//    {
//        playerObject = GetComponent<Player>();
//    }
//    private void OnCollisionEnter(Collision collision)
//    {
//        if (collision.gameObject.CompareTag("Crystal"))
//        {
//            Debug.Log("Cristal!");
//            Destroy(collision.gameObject);
//            Count++;
//            Cristal.text = Count.ToString();
//        }
//    }
//}
