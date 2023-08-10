﻿using CobaltCoreModding.Definitions.ExternalResourceHelper;

namespace CobaltCoreModding.Definitions.ModContactPoints
{
    public interface IArtRegistry : ICobaltCoreContact
    {
        /// <summary>
        /// Pass any sprite here for registration. it will be assigned an id and return the id.
        /// can also be used to overwrite an existing sprite within the game.
        /// </summary>
        /// <param name="sprite_data">an unregistered sprite</param>
        /// <param name="overwrite_spr">If not null and within the range of ingame sprites, this will be used to overwrite an existing sprite within cobalt core game.</param>
        /// <returns>The id under which the sprite was registered, which will also be included in the sprite object itself</returns>
        public int RegisterArt(ExternalSprite sprite_data, int? overwrite_value = null);
    }
}