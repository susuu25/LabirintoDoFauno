using UnityEngine;
using UnityEngine.SceneManagement; //Necessário para reiniciar o jogo

//Classe base para personagem no jogo (Ofelia)
public class Personagem : MonoBehaviour
{
    public float distancia = 5f; //Velocidade padrão da Ofelia
    public bool NoChao = false;


    // Método para reiniciar o jogo
    protected void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    protected void Apagar()
    {
        Destroy(gameObject); //Destroi a Ofélia
        RestartGame(); //Reinicia o jogo
    }

}
