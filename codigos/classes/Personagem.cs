using UnityEngine;
using UnityEngine.SceneManagement; //Necess�rio para reiniciar o jogo

//Classe base para personagem no jogo (Ofelia)
public class Personagem : MonoBehaviour
{
    public float distancia = 5f; //Velocidade padr�o da Ofelia
    public bool NoChao = false;


    // M�todo para reiniciar o jogo
    protected void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    protected void Apagar()
    {
        Destroy(gameObject); //Destroi a Of�lia
        RestartGame(); //Reinicia o jogo
    }

}
