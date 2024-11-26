using UnityEngine;
using UnityEngine.SceneManagement; //Necessário para reiniciar o jogo

//Classe base para personagem no jogo (Ofelia)
public class Obstaculos : MonoBehaviour
{
    //Método para reiniciar o jogo
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
