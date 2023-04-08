using MelonLoader;
using Il2Cpp;
using uncapped_magic_06;

[assembly: MelonInfo(typeof(UncappedMagic06), "Uncapped magic (ver. 0.6)", "1.0.0", "Matthiew Purple")]
[assembly: MelonGame("アトラス", "smt3hd")]

namespace uncapped_magic_06;
public class UncappedMagic06 : MelonMod
{
    // When booting up the game
    public override void OnInitializeMelon()
    {
        // For each skill in the game
        for (int i = 0; i < datNormalSkill.tbl.Length; i++)
        {
            // If the skill is a magic skill, then uncap its limit
            if (datNormalSkill.tbl[i].magiclimit != 0) datNormalSkill.tbl[i].magiclimit = short.MaxValue;
        }
    }
}
