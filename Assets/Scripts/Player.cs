
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField]
    private float _velocidadePlayer = 3.0f;

    [SerializeField]
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float entradaHorizontal = Input.GetAxis("Horizontal");


        float entradaleft = Input.GetAxis("Left");


        animator.SetFloat("Horizontal", entradaHorizontal);
        animator.SetFloat("Vertical", entradaleft);

        transform.Translate(Vector3.right * Time.deltaTime * _velocidadePlayer * entradaHorizontal);


        transform.Translate(Vector3.left * Time.deltaTime * _velocidadePlayer * entradaleft);



    }
}