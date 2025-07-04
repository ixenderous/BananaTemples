using MelonLoader;
using BTD_Mod_Helper;
using BananaTemples;
using Il2CppAssets.Scripts.Models;
using Il2CppAssets.Scripts.Models.Map;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors;
using Il2CppAssets.Scripts.Unity.UI_New.InGame;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

[assembly: MelonInfo(typeof(BananaTemples.BananaTemples), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace BananaTemples;

public class BananaTemples : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<BananaTemples>("BananaTemples loaded!");
    }

    public override void OnNewGameModel(GameModel result)
    {
        base.OnNewGameModel(result);
        
        if (!Settings.ModEnabled || !InGameData.CurrentGame.IsSandbox) return;

        var baseSuper = result.GetTower("BananaFarm", 0, 0, 0);
        baseSuper.footprint = new CircleFootprintModel("CircleFootprintModel_Circle Footprint", 11, false, false, false);
        baseSuper.radius = 11;
        
        var temple = result.GetTower("BananaFarm", 0, 1, 0);
        temple.footprint = new RectangleFootprintModel("RectangleFootprintModel_", 37, 40, false, true, false);
        temple.radius = 20;
        temple.areaTypes = new[] {
            AreaType.water,
            AreaType.land
        };
        
        var tsg = result.GetTower("BananaFarm", 0, 2, 0);
        tsg.footprint = new RectangleFootprintModel("RectangleFootprintModel_", 37, 40, false, true, false);
        tsg.radius = 25;
        tsg.areaTypes = new[] {
            AreaType.water,
            AreaType.land
        };
    }
}