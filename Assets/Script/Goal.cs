using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject clearText;    // �ǋL�B���x���N���A�ƕ\������e�L�X�g���i�[
    public GameObject nextButton;   // �ǋL�B���̃��x���֑J�ڂ���{�^�����i�[
    public AudioSource audioSorce;   // ���y���Đ�����R���|�[�l���g

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //��������
        Vector2 pos = transform.position;

        pos.x -= 0.05f;

        transform.position = new Vector2(pos.x, pos.y);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("�S�[���I");

            clearText.SetActive(true);  // �ǋL�B�����ɂȂ��Ĕ�\���ɂȂ����Q�[���I�u�W�F�N�g��
            nextButton.SetActive(true); // ���̃^�C�~���O�ŗL���ɂ���B
            audioSorce.Play();          // Play���\�b�h�����s���邱�Ƃ��o����
        }
    }
}
