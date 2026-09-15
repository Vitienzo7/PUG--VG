using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalController : MonoBehaviour {
    [SerializeField] private string Fase2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }

    private void OnTriggerEnter2D(BoxCollider2D other) {
        if (other.CompareTag("Player")) {
            int proximaCena = SceneManager.GetActiveScene().buildIndex + 1;
            SceneManager.LoadScene(Fase2);
        }
    }
}
