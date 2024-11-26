using UnityEngine;

public class MovimentacaoPlayer : Personagem
{
    Vector3 m;
    float percurso;

    // Start is called before the first frame update
    void Start()
    {
        m.Set(18.258f, 7.408821f, 27.592f);
        transform.position = m;
        distancia /= 5;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("mesa"))
        {
            NoChao = true;
        }
        else
        {
            NoChao = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        percurso = distancia;

        if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) && Input.GetKey(KeyCode.Space))
        {
            percurso = distancia / 2;
        }

        else if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) && (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)))
        {
            percurso = distancia / 2;
        }

        else if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) && (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)))
        {
            percurso = distancia / 2;
        }

        else if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) && (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)))
        {
            percurso = distancia / 2;
        }

        else if ((Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) && Input.GetKey(KeyCode.Space))
        {
            percurso = distancia / 2;
        }

        else if ((Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) && (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)))
        {
            percurso = distancia / 2;
        }

        else if ((Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) && (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)))
        {
            percurso = distancia / 2;
        }

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            m.z = percurso;
            transform.Translate(m);
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            m.z = -percurso;
            transform.Translate(m);
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            m.x = percurso;
            transform.Translate(m);
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            m.x = -percurso;
            transform.Translate(m);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            if (NoChao == true)
            {
                m.y = percurso;
                transform.Translate(m);
            }
        }

        if (transform.position.y <= 0)
        {
            //Se Ofélia cair da mesa, destrua a Ofélia e reinicie o jogo
            Apagar();
        }

        m.Set(0, 0, 0);
    }
}
