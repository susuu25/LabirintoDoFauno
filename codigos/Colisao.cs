using UnityEngine;

public class Colisao : Obstaculos
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("comi"))
        {
            //Se Of�lia tocar uma comida, destrua a Of�lia e reinicie o jogo
            Apagar();
        }
        else if (collision.gameObject.CompareTag("homi"))
        {
            //Se Of�lia tocar o Homem P�lido, destrua a Of�lia e reinicie o jogo
            Apagar();
        }
    }
}
