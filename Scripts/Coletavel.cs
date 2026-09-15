using UnityEngine;

public class Coletavel : MonoBehaviour {
    public int valor = 1;

    private void OnTriggerEnter2D(Collider2D other) {

        if (other.CompareTag("Player")) {
            PJMove inventario = other.GetComponent<PJMove>();

            if (inventario != null) {
                inventario.AdicionarItem(valor);
            }
             Destroy(gameObject);
        }
    }
}
