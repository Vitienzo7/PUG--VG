using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalController : MonoBehaviour {
    [SerializeField] private string proximaFase;
     private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(proximaFase);
        }
    }
}
