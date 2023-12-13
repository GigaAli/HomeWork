
using State.States.Classes;

using State.States.Interfaces;

Character character = new Character();

        
character.ChangeState(new RunningState());

        
character.Move();

        
character.ChangeState(new JumpingState());

        
character.Move();

        
character.ChangeState(new RestingState());

        
character.Move();
