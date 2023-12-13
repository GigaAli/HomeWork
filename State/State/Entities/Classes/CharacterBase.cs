using State.States.Classes;
using State.States.Interfaces;

public class Character
{
    private IState _state;

    public Character()
    {

        _state = new WalkingState();
    }

    public void ChangeState(IState state)
    {
        _state = state;
    }

    public void Move()
    {
        _state.Move();
    }
}