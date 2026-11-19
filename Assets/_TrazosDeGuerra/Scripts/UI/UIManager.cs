using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{

    [Header("Referencias del Modal")] //Crea separadores visuales en el inspector de Unity
    public GameObject panelModal;
    public TextMeshProUGUI textoTitulo;
    public TextMeshProUGUI textoMensaje;

    private void Start() {
        CerrarModal();
    }

    public void MostrarModal(string titulo, string mensaje) {
        textoTitulo.text = titulo;
        textoMensaje.text = mensaje;
        panelModal.SetActive(true);
    }

    public void CerrarModal() {
        panelModal.SetActive(false);
    }
}
