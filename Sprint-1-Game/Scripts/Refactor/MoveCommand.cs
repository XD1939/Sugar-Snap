using Microsoft.Xna.Framework;

public class MoveCommand(Player player, Point directionVec, Grid grid):ICommand
{
    public void Execute()
    {
        // player.Movable.DirectionVec = directionVec;
        // Point destination = player.Movable.Destination();
        // if (grid.GetGridCell(destination).CanMoveTo)
        // {
        //     player.Movable.Move();
        // }
    }
}