﻿using SS14.Server.Interfaces.GameObjects;
using SS14.Shared.Interfaces.GameObjects.Components;
using SS14.Shared.Interfaces.Map;
using SS14.Shared.IoC;
using SS14.Shared.Map;
using SS14.Shared.Maths;

namespace Content.Server.Placement
{
    /// <summary>
    ///     Helper function for spawning more complex multi-entity structures
    /// </summary>
    public static class SpawnHelpers
    {
        /// <summary>
        ///     Spawns a spotlight ground turret that will track any living entities in range.
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="localPosition"></param>
        public static void SpawnLightTurret(IMapGrid grid, Vector2 localPosition)
        {
            var entMan = IoCManager.Resolve<IServerEntityManager>();
            var tBase = entMan.SpawnEntity("TurretBase");
            tBase.GetComponent<ITransformComponent>().LocalPosition = new GridLocalCoordinates(localPosition, grid);

            var tTop = entMan.SpawnEntity("TurretTopLight");
            var topTransform = tTop.GetComponent<ITransformComponent>();
            topTransform.LocalPosition = new GridLocalCoordinates(localPosition, grid);
            topTransform.AttachParent(tBase);
        }
    }
}
