using UnityEngine;

public class Colisao : Obstaculos
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("comi"))
        {
            //Se Ofélia tocar uma comida, destrua a Ofélia e reinicie o jogo
            Apagar();
        }
        else if (collision.gameObject.CompareTag("homi"))
        {
            //Se Ofélia tocar o Homem Pálido, destrua a Ofélia e reinicie o jogo
            Apagar();
        }
    }
}
