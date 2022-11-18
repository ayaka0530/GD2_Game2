using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject gameoverText;    // �ǋL�B���x���N���A�ƕ\������e�L�X�g���i�[
    public GameObject titleButton;   // �ǋL�B���̃��x���֑J�ڂ���{�^�����i�[
    public AudioSource gameoverAudio;   // ���y���Đ�����R���|�[�l���g
    public GameObject[] heartArray = new GameObject[3]; //�n�[�g�̕\��
    public GameObject lvUpImage;//�G�l���M�[�����������̉摜������
    public Sprite normalPlayerImage;//�`���[�W�������̉摜������
    public Sprite chargingPlayerImage;//�`���[�W�������̉摜������

    private float speed = 0.2f;
    private int playerHp;
    private int energyAmount;
    private int power = 1;
    private int playerLv;
    private GameObject shots;
    private int lvUpCount = 0;
    bool lv2Fin = false;
    bool lv3Fin = false;
    bool lv4Fin = false;


    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        shots = GameObject.FindGameObjectWithTag("Shot");

        playerHp = 3;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;

        if (Input.GetKey("left") || (Input.GetKey(KeyCode.A)))
        {
            position.x -= speed;

        }
        else if (Input.GetKey("right") || (Input.GetKey(KeyCode.D)))
        {
            position.x += speed;
        }
        else if (Input.GetKey("up") || (Input.GetKey(KeyCode.W)))
        {
            position.y += speed;
        }
        else if (Input.GetKey("down") || (Input.GetKey(KeyCode.S)))
        {
            position.y -= speed;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = chargingPlayerImage;
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = normalPlayerImage;
        }

        var pos = transform.position;
        //�G���A�w�肵�Ĉړ�����
        position.x = Mathf.Clamp(position.x, -7.33f, 6.5f);
        position.y = Mathf.Clamp(position.y, -3.63f, 3.63f);

        transform.position = position;

        //�擾�����G�i�W�[���Ƀ��x���A�b�v
        //�G�i�W�[�̐����擾
        energyAmount = gameManager.TeachEnergyAmount();

        if (energyAmount <= 0)
        {
            power = 1;

            shots.GetComponent<Shot>().mode = 0;
        }
        else if (energyAmount >= 50)
        {
            if (lv2Fin == false)
            {
                lvUpImage.SetActive(true);
                lv2Fin = true;
            }

            shots.GetComponent<Shot>().mode = 1;
        }
        else if (energyAmount >= 100)
        {
            power = 2;
        }

        else if (energyAmount >= 300)
        {
            power = 3;
        }

        //if (Input.GetKeyDown(KeyCode.Alpha2))
        //{
        //    for (int i = 0; i <= 1; i++)
        //    {
        //        shots[i].GetComponent<Shot>().mode = 1;
        //    }
        //}


        if (playerHp <= 0)
        {
            Destroy(this.gameObject);
            gameoverText.SetActive(true);  // �ǋL�B�����ɂȂ��Ĕ�\���ɂȂ����Q�[���I�u�W�F�N�g��
            titleButton.SetActive(true); // ���̃^�C�~���O�ŗL���ɂ���B
            gameoverAudio.Play();          // Play���\�b�h�����s���邱�Ƃ��o����
        }

        if (playerHp == 3)
        {
            heartArray[2].gameObject.SetActive(true);
            heartArray[1].gameObject.SetActive(true);
            heartArray[0].gameObject.SetActive(true);
        }

        if (playerHp == 2)
        {
            heartArray[2].gameObject.SetActive(false);
            heartArray[1].gameObject.SetActive(true);
            heartArray[0].gameObject.SetActive(true);
        }
        if (playerHp == 1)
        {
            heartArray[2].gameObject.SetActive(false);
            heartArray[1].gameObject.SetActive(false);
            heartArray[0].gameObject.SetActive(true);
        }

        if (playerHp == 0)
        {
            heartArray[2].gameObject.SetActive(false);
            heartArray[1].gameObject.SetActive(false);
            heartArray[0].gameObject.SetActive(false);
        }
    }

    //�v���C���[�ƓG������������G�Ƀ_���[�W
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            other.GetComponent<Enemy>().EnemyDamage();
        }
    }

    //�v���C���[�̌��݂̃p���[��`����
    public int TeachPlayerPower()
    {
        return power;
    }

    //�v���C���[�ɓ���_���[�W�̌v�Z
    public void PlayerDamage()
    {
        playerHp = playerHp - 1;
        Debug.Log("playerHp" + playerHp);
    }

}
