using System;
using System.Collections.Generic;
using System.Text;

namespace Monsters
{
    public interface IBattle
    {
        Monster.MonsterAction MonsterBattleResponse();
    }
}
