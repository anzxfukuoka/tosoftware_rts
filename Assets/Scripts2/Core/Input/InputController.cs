using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Юнити предоставляет интерфейс к своей системе ввода.
 * Класс InputController адаптирует ее для этой игры
 * 
 * Всего в игре доступны 2 вида ввода - кнопками (мышь, клавятура, кнопки на гемпаде) и осями (движение мыши, джойстик на геймпада)
 * Типы ввода кнопками перечисленны в InputButtonType.
 * 
 * На классы, которые зависят от ввода нужно повесить IInputListener
 * и вызвать метод InputControllerAddInputListener(this)
 * Сам InputController должен висеть на сцене
 */

/*
 * Также в этом файле находится IMovable.
 * Может его переместить?
 */

public enum InputButtonType
{
    UNK, // непредусмотренная клафиша
    
    ButtonA, // ЛКМ или F
    ButtonB, // ПКМ или R

    // WASD или стрелками
    Up, 
    Down,
    Left,
    Right,
}

public class InputController : MonoBehaviour
{

    private static InputController _instance;

    public class InputButtonEventArgs 
    {
        public InputButtonType type;
        
        public InputButtonEventArgs(InputButtonType type)
        {
            this.type = type;
        }
    }

    public class InputAxisEventArgs 
    {
        private static float _lastX, _lastY;

        public float x, y;
        public float dx, dy;

        public InputAxisEventArgs(float x, float y)
        {
            dx = _lastX - x;
            dy = _lastY - y;

            this.x = x;
            this.y = y;

            _lastX = this.x;
            _lastY = this.y;
        }
    }

    delegate void InputButton(InputButtonEventArgs args);
    static event InputButton InputButtonEvent;

    delegate void InputAxis(InputAxisEventArgs args);
    static event InputAxis InputAxisEvent;

    public static void AddInputListener(IInputListener listener)
    {
        InputButtonEvent += listener.OnInputButton;
        InputAxisEvent += listener.OnInputAxis;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //клавишы

        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.F))
        {
            InputButtonEvent?.Invoke(new InputButtonEventArgs(InputButtonType.ButtonA));
        }
        else if (Input.GetMouseButtonDown(1) || Input.GetKeyDown(KeyCode.R))
        {
            InputButtonEvent?.Invoke(new InputButtonEventArgs(InputButtonType.ButtonB));
        }

        else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            InputButtonEvent?.Invoke(new InputButtonEventArgs(InputButtonType.Up));
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) 
        {
            InputButtonEvent?.Invoke(new InputButtonEventArgs(InputButtonType.Left));
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            InputButtonEvent?.Invoke(new InputButtonEventArgs(InputButtonType.Right));
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            InputButtonEvent?.Invoke(new InputButtonEventArgs(InputButtonType.Right));
        }

        //мыш (кродеться)

        float h = Input.GetAxis("Mouse X");
        float v = Input.GetAxis("Mouse Y");

        InputAxisEvent?.Invoke(new InputAxisEventArgs(h, v));
    }
}

public interface IInputListener
{
    void OnInputButton(InputController.InputButtonEventArgs args);
    void OnInputAxis(InputController.InputAxisEventArgs args);
}

public interface IMovable 
{
    void Move(Vector3 direction);
    void Rotate(Vector3 angle);
}


