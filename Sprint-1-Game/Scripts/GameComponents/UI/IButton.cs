using Microsoft.Xna.Framework.Graphics;
using MonoGameLibrary;

namespace Scripts.GameComponents;

public interface IButton
{
    void Init(int x, int y, IInputManager input, bool canHot);
    void Update(int dtMs);
    void Draw(SpriteBatch sb);
}