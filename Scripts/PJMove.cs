using UnityEngine;

public class PJMove : MonoBehaviour {
    private float velocidade = 5.0f;
    public Rigidbody2D rb;
    Vector2 forçaPulo;
    bool podePular = true;
    private int quantidadePulos = 2;
    public int quantidadeItens = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        forçaPulo = new Vector2(0.0f, 5.0f);
    }

    // Update is called once per frame
    void Update() {
        float mX = Input.GetAxisRaw("Horizontal");
        rb.linearVelocityX = mX * velocidade;
        if (Input.GetKeyDown(KeyCode.Space) && podePular && quantidadePulos > 0) {
            quantidadePulos--;
            rb.AddForce(forçaPulo, ForceMode2D.Impulse);
            if (quantidadePulos < 2)
            {
                forçaPulo.y = 5.0f;
                if (quantidadePulos == 0)
                {
                    podePular = false;
                }
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Ground")) {
            podePular = true;
            quantidadePulos = 2;
        }
    }

    public void AdicionarItem(int quantidade)
    {
        quantidadeItens += quantidade;

        Debug.Log("Itens coletados: " + quantidadeItens);
    }
}