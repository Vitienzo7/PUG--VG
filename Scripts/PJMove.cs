using UnityEngine;

public class PJMove : MonoBehaviour {
    private float velocidade = 5.0f;
    public Rigidbody2D rb;
    Vector2 forçaPulo;
    bool podePular = true;
    public int quantidadeItens = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        forçaPulo = new Vector2(0.0f, 5.0f);
    }

    // Update is called once per frame
    void Update() {
        float mX = Input.GetAxisRaw("Horizontal");
        rb.linearVelocityX = mX * velocidade;
        if (Input.GetKeyDown(KeyCode.Space) && podePular) {
            podePular = false;
            rb.AddForce(forçaPulo, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Ground")) {
            podePular = true;
        }
    }

    public void AdicionarItem(int quantidade)
    {
        quantidadeItens += quantidade;

        Debug.Log("Itens coletados: " + quantidadeItens);
    }
}